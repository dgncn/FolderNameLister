using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderNameLister
{
    public class DirSortProcess
    {
        public string GetDirections(string fullPath)
        {
            string dirpathText = "";
            DirectoryInfo d = new DirectoryInfo(fullPath);
            while (d.EnumerateDirectories().Count() > 0)
            {
                IEnumerable<DirectoryInfo> fi = d.EnumerateDirectories();

                foreach (var directory in fi)
                {
                    dirpathText += "\t" + directory.Name + "\r\n";

                    IEnumerable<DirectoryInfo> fi1 = directory.EnumerateDirectories();

                    foreach (var directory2 in fi1)
                    {
                        dirpathText += "\t  --" + directory2.Name + "\r\n";

                        IEnumerable<DirectoryInfo> fi2 = directory2.EnumerateDirectories();

                        foreach (var directory3 in fi2)
                        {
                            dirpathText += "\t    ----" + directory3.Name + "\r\n";

                            IEnumerable<DirectoryInfo> fi3 = directory3.EnumerateDirectories();

                            foreach (var directory4 in fi3)
                            {
                                dirpathText += "\t      ------" + directory4.Name + "\r\n";

                                IEnumerable<DirectoryInfo> fi4 = directory4.EnumerateDirectories();
                                foreach (var directory5 in fi4)
                                {
                                    dirpathText += "\t        --------" + directory5.Name + "\r\n";

                                    IEnumerable<DirectoryInfo> fi5 = directory5.EnumerateDirectories();

                                }
                            }
                        }
                    }

                }
                return dirpathText;
            }
            return dirpathText;
        }
    }
}
