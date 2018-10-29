/******************************************************/
/************* Arkadiusz Kowalczyk © 2018 *************/
/******************************************************/

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileCopy
{
    public partial class FileCopyApp : Form
    {
        //Synchronization timer
        private static System.Timers.Timer aTimer;

        //Directory to copy FROM
        private String sourceDir;
        //Directory to copy TO
        private String destinationDir;
        //List of file extensions to copy
        private String[] extension;

        //If TRUE all files will be copied once again even if they allready exist
        //If FALSE only new files will be copied
        private bool syncAllFiles = false;

        public FileCopyApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initial setup-> START and FORCE SYNCHRONIZATION buttons are active, STOP button is disabled
            stopButton.Enabled = false;
            startButton.Enabled = true;
            forceButton.Enabled = true;

            //If config file exists
            if (Utilities.readTxt("config.cfg") != "")
            {
                //Each config option is splited by ";", parse the data into array
                string[] config = Utilities.readTxt("config.cfg").Split(';');

                //Set textboxes
                sourceTextBox.Text = config[0];
                destinationTextBox.Text = config[1];
                extensionTextBox.Text = config[2];
                timerNumericBox.Value = Convert.ToInt32(config[3]);
                if (config[4] == "true" || config[4] == "True")
                    allFilesCheckBox.Checked = true;
                else
                    allFilesCheckBox.Checked = false;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //If all textboxes have a content and directories exists
            if(Directory.Exists(sourceTextBox.Text) && Directory.Exists(destinationTextBox.Text)
                && extensionTextBox.Text != "" && timerNumericBox.Value != 0)
            {
                //Disable text fields and check box
                sourceTextBox.Enabled = false;
                destinationTextBox.Enabled = false;
                extensionTextBox.Enabled = false;
                timerNumericBox.Enabled = false;
                allFilesCheckBox.Enabled = false;
                
                //Grab the source and destination directories from text boxes
                sourceDir = sourceTextBox.Text;
                destinationDir = destinationTextBox.Text;

                //Grab extenstions list
                String extensionsTemp = extensionTextBox.Text;
                //Remove white spaces
                extensionsTemp = extensionsTemp.Replace(" ", "");
                //Split extensions by ","
                extension = extensionsTemp.Split(',');

                //Parse time to next sync from text box
                int timeToNextSync = Convert.ToInt32(timerNumericBox.Value);
                
                //Clear the error label
                errorLabel.Text = "";
                startButton.Enabled = false;
                stopButton.Enabled = true;

                String tempString = "";
                //jeśli użytkownik podał rozszerzenie bez kropki
                for(int i = 0; i < extension.Length; i++)
                {
                    if (extension[i][0] != '.')
                    {
                        //dodawanie kropki
                        extension[i] = "." + extension[i];
                    }
                    //Prepare good looking extensions list meanwhile
                    if (i != 0)
                        tempString += ", " + extension[i];
                    else
                        tempString += extension[i];
                }
                extensionTextBox.Text = tempString;

                //First sync
                Sync();
                //Start the timer for all the next syncs
                SetTimer(timeToNextSync);
            }
            else
            {
                errorLabel.Text = "Niepoprawne dane wejściowe lub podane katalogi nie istnieją.";
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            aTimer.Stop();

            startButton.Enabled = true;
            stopButton.Enabled = false;
            sourceTextBox.Enabled = true;
            destinationTextBox.Enabled = true;
            extensionTextBox.Enabled = true;
            timerNumericBox.Enabled = true;
            allFilesCheckBox.Enabled = true;
        }

        private void forceButton_Click(object sender, EventArgs e)
        {
            //jeśli został już wciśnięty przycisk start
            if(startButton.Enabled == false)
            {
                errorLabel.Text = "";
                //synchronizacja jest możliwa
                Sync();
            } else
            {
                errorLabel.Text = "Najpierw naciśnij START!";
            }
        }

        private void SetTimer(int time)
        {
            int time_milis = time * 1000;
            aTimer = new System.Timers.Timer(time_milis);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Sync();
        }

        private void Sync()
        {
            for(int i = 0; i < extension.Length; i++)
            {
                try
                {
                    string[] sourceFilesList = Directory.GetFiles(sourceDir, "*" + extension[i]);
                    string[] destinationFilesList = Directory.GetFiles(destinationDir, "*" + extension[i]);
                    
                    foreach (string file in sourceFilesList)
                    {
                        //Variable file contains the path with a file name, so we need to cut it
                        string fileName = file.Substring(sourceDir.Length + 1);

                        //Sync all files
                        if (syncAllFiles)
                        {
                            File.Copy(Path.Combine(sourceDir, fileName), Path.Combine(destinationDir, fileName), true);
                        }
                        else
                        {
                            //If the file already exists in destination directory don't copy it
                            if (!destinationFilesList.Contains(file))
                            {
                                File.Copy(Path.Combine(sourceDir, fileName), Path.Combine(destinationDir, fileName), true);
                            }
                        }
                    }
                }
                catch (DirectoryNotFoundException dirNotFound)
                {
                    Console.WriteLine(dirNotFound.Message);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Utilities.clearTxtFile("config.cfg");

            //save into config.cfg
            Utilities.writeTxt(sourceTextBox.Text, "config.cfg", true);
            Utilities.writeTxt(destinationTextBox.Text, "config.cfg", true);
            Utilities.writeTxt(extensionTextBox.Text, "config.cfg", true);
            Utilities.writeTxt(Convert.ToString(timerNumericBox.Value), "config.cfg", true);
            Utilities.writeTxt(allFilesCheckBox.Checked.ToString(), "config.cfg", false);
        }

        private void allFilesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            syncAllFiles = allFilesCheckBox.Checked;
            Console.WriteLine("BOX: " + syncAllFiles);
        }
    }
}
