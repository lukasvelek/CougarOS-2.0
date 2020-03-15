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
            LoadSystemConfiguration();
        }

        private void LoadSystemConfiguration()
        {
            // ALL CONFIGURATION LOCATED IN A MASTER CONFIG FILE

            if (File.Exists("Configuration/MASTER.CONFIG"))
            {
                string[] lines = File.ReadAllLines("Configuration/MASTER.CONFIG");

                foreach (string line in lines)
                {
                    string[] halves = line.Split('=');

                    if (halves[0].ToLower().Contains("systemversion"))
                    {
                        systemVersion = halves[1].Replace("\"", "");
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

                    if (halves[0].ToLower().Contains("systemcopyright"))
                    {
                        systemCopyright = halves[1].Replace("\"", "");
                    }

                    if (halves[0].ToLower().Contains("systemauthor"))
                    {
                        systemAuthor = halves[1].Replace("\"", "");
                    }
                }
            }
            else
            {
                // PROBABLY AN ERROR HAS OCCURED AND SO THE FILE HAS TO BE GENERATED WITH DEFAULT VALUES

                string configuration =
                    "SystemVersion=2.0" +
                    "SystemVersionName=Cadillac" +
                    "SystemBuild=1000" +
                    "SystemName=CougarOS 2.0 Cadillac" +
                    "SystemCopyright=Copyright (c) 2020 Lukas Velek" +
                    "SystemAuthor=Lukas Velek";

                bool status = File.WriteAllText("Configuration/MASTER.CONFIG", configuration);

                LoadSystemConfiguration();
            }
        }
    }
}
