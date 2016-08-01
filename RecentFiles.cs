using System;
using System.Collections.Generic;
using System.IO;

namespace Tracker
{
    class RecentFiles
    {
        private String loadedFilePath;
        private List<String> recentPaths = new List<String>();

        public RecentFiles()
        {
            //If the "RecentFiles.txt" exists, load all the entries into recentPaths
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + "RecentFiles.txt"))
            {
                StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "RecentFiles.txt");

                while (sr.Peek() >= 0)
                {
                    recentPaths.Add(sr.ReadLine());
                }

                sr.Close();
            }
            //Otherwise, create a blank file called "RecentFiles.txt"
            else
            {
                StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "RecentFiles.txt");
                sw.Close();
            }
        }

        public String getLoadedFilePath()
        {
            return loadedFilePath;
        }

        public void setLoadedFilePath(String value)
        {
            if (value != null)
            {
                loadedFilePath = value;
                addRecentFile(value);
            }
        }

        public List<String> getRecentFilePaths()
        {
            return recentPaths;
        }

        public void addRecentFile(String Path)
        {
            //If the path already exists in recentPaths, delete it, then insert it in the front of the list.
            if (recentPaths.Contains(Path))
            {
                recentPaths.Remove(Path);
                recentPaths.Insert(0, Path);
            }
            //If the path is not already in the list, then add the path to the front of the list.
            else
            {
                recentPaths.Insert(0, Path);
            }

            //Save the list to disk.
            StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "RecentFiles.txt");
            for (int i = 0; i < recentPaths.Count; i++)
            {
                sw.WriteLine(recentPaths[i]);
            }
            sw.Close();
        }

        public void deleteRecentFilesTxtFile()
        {
            recentPaths.Clear();
            StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "RecentFiles.txt");
            sw.Close();
        }
    }
}