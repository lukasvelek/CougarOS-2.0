using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kernel
{
    public class MasterConfiguration
    {
        Modules.File File = new Modules.File();

        string systemVersion;
        string systemVersionName;
        string systemBuild;
        string systemName;
        string systemCopyright;
        string systemAuthor;

        string systemLanguage;

        public string SystemVersion { get => systemVersion; }
        public string SystemVersionName { get => systemVersionName; }
        public string SystemBuild { get => systemBuild; }
        public string SystemName { get => systemName; }
        public string SystemCopyright { get => systemCopyright; }
        public string SystemAuthor { get => systemAuthor; }
        public string SystemLanguage { get => systemLanguage; set => systemLanguage = value; }

        public MasterConfiguration()
        {
            // ALL CONFIGURATION LOCATED IN A MASTER CONFIG FILE

            if (File.Exists("cfg/MASTER.CONFIG"))
            {
                string[] lines = File.ReadAllLines("cfg/MASTER.CONFIG");

                foreach (string line in lines)
                {
                    string[] halves = line.Split('=');

                    if (halves[0].ToLower().Contains("systemversion"))
                    {
                        systemVersion = halves[1].Replace("\"", "");
                    }
                    else
                    {
                    }

                    if (halves[0].ToLower().Contains("systemversionname"))
                    {
                        systemVersionName = halves[1].Replace("\"", "");
                    }

                    if (halves[0].ToLower().Contains("systembuild"))
                    {
                        systemBuild = halves[1].Replace("\"", "");
                    }

                    if (halves[0].ToLower().Contains("systemname"))
                    {
                        systemName = halves[1].Replace("\"", "");
                    }
                }
            }
            else
            {

            }

            /*systemVersion = "2.0";
            systemVersionName = "Cadillac";
            systemBuild = "1000";
            systemName = "CougarOS " + SystemVersion + SystemVersionName;
            systemCopyright = "Copyright (c) 2020 Lukas Velek";
            systemAuthor = "Lukas Velek";

            if (File.Exists("cfg/INSTALLED.CONFIG"))
            {
                // System has been installed

                string[] lines = File.ReadAllLines("cfg/INSTALLED.CONFIG");

                foreach(string line in lines)
                {
                    string[] halves = line.Split('=');

                    if (halves[0].Contains("language"))
                    {
                        system
                    }
                }
            }
            else
            {
                // System hasn't been installed and so has to be installed
            }*/
        }
    }
}
