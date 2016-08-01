using System;

namespace Tracker
{
    class TrackedLink
    {
        private String pageTitle;
        private String URL;
        private Boolean watched;

        public TrackedLink()
        {
            pageTitle = "NO TITLE";
            URL = "NO URL";
            watched = false;
        }

        public TrackedLink(String pageTitle, String URL, Boolean watched)
        {
            this.pageTitle = pageTitle;
            this.URL = URL;
            this.watched = watched;
        }

        public String getURL()
        {
            return URL;
        }

        public void setURL(String URL)
        {
            this.URL = URL;
        }

        public String getPageTitle()
        {
            return pageTitle;
        }

        public void setPageName(String pageName)
        {
            this.pageTitle = pageName;
        }

        public Boolean getWatched()
        {
            return watched;
        }

        public void setWatched(Boolean watched)
        {
            this.watched = watched;
        }

        public void setWatched(String watched)
        {
            this.watched = Boolean.Parse(watched);
        }

        public override string ToString()
        {
            return pageTitle;
        }
    }
}
