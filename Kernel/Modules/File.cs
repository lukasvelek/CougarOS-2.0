using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kernel.Modules
{
    public class File
    {

        public bool Exists(string path)
        {
            if (System.IO.File.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string FileType(string suffix)
        {
            string[] lines = ReadAllLines("Definitions/FileTypes");

            foreach (string line in lines)
            {
                string[] half = line.Split('=');

                if (half[0] == suffix)
                {
                    return half[1];
                }
                else
                {
                    return "Unknown";
                }
            }

            return "Unknown";
        }

        public bool CreateFile(string path, string fileType=null)
        {
            try
            {
                if(fileType == null)
                {
                    System.IO.File.Create(path);
                }
                else
                {
                    string suffix = "";

                    switch (fileType)
                    {
                        case "TEXT":
                            suffix = "TEXT";
                            break;
                        case "CONFIG":
                            suffix = "CONFIG";
                            break;
                        case "TEMP":
                            suffix = "TEMP";
                            break;
                        default:
                            suffix = "none";
                            break;
                    }

                    //path += "." + suffix;

                    if(suffix == "none")
                    {
                        System.IO.File.Create(path);
                    }
                    else
                    {
                        path += "." + suffix;
                        System.IO.File.Create(path);
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public string[] ReadAllLines(string path)
        {
            return System.IO.File.ReadAllLines(path);
        }

        public string ReadAllText(string path)
        {
            return System.IO.File.ReadAllText(path);
        }

        public bool WriteAllText(string path, string text)
        {
            if (Exists(path))
            {
                return false;
            }
            else
            {
                System.IO.File.WriteAllText(path, text);
                return true;
            }
        }

        public void AppendText(string path, string text)
        {
            System.IO.File.AppendAllText(path, text);
        }
    }
}
