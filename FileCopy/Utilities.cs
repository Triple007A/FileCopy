/******************************************************/
/************* Arkadiusz Kowalczyk © 2018 *************/
/******************************************************/

using System;
using System.IO;

//Txt files minimal manager needed to save config files

namespace FileCopy
{
    class Utilities
    {
        public static string txt = "";

        public static void writeTxt(string text, string fileName, bool withSemicolon)
        {
            using (StreamWriter writeText = new StreamWriter(fileName, true))
            {
                writeText.Write(text);
                if (withSemicolon)
                    writeText.Write(';');
            }
        }

        public static void clearTxtFile(string fileName)
        {
            using (StreamWriter writeText = new StreamWriter(fileName, false))
            {
                writeText.Write("");
            }
        }

        public static string readTxt(string fileName)
        {
            try
            {
                using (StreamReader readText = new StreamReader(fileName))
                {
                    txt = readText.ReadToEnd();
                    return txt;
                }
            }
            catch (Exception ex)
            {
                return "";
            }

        }

    }
}
