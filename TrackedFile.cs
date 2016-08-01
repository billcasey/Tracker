using System;
using System.Text;

namespace Tracker
{
    class TrackedFile 
    {
        private String title;
        private String path;
        private String folderPath;
        private Boolean watched;

        public TrackedFile()
        {
            title = "NO TITLE";
            path = "NO PATH";
            folderPath = "NO FOLDER PATH";
            watched = false;
        }

        public TrackedFile(String title, String path, String folderPath, Boolean watched)
        {
            this.title = title;
            this.path = path;
            this.folderPath = folderPath;
            this.watched = watched;
        }

        /* Default Get and Set Methods */
        public String getTitle()
        {
            return title;
        }

        public void setTitle(String title)
        {
            this.title = title;
        }

        public String getPath()
        {
            return path;
        }

        public void setPath(String path)
        {
            this.path = path;
        }

        public String getFolderPath()
        {
            return folderPath;
        }

        public void setFolderPath(String folderPath)
        {
            this.folderPath = folderPath;
        }

        public Boolean getWatched()
        {
            return watched;
        }

        public void setWatched(Boolean watched)
        {
            this.watched = watched;
        }

        public void setWathced(String watched)
        {
            this.watched = Boolean.Parse(watched);
        }

        public String getExtension()
        {
            StringBuilder extension = new StringBuilder(".");
            String[] split = this.title.Split('.');
            extension.Append(split[split.Length - 1]);

            return extension.ToString();
        }

        public override string ToString()
        {
            return title;
        }
    }
}
