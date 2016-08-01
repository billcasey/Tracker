using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tracker
{
    public partial class About : Form
    {
        private int cumulativeFilesChecked = 0;
        private int cumulativeFilesTracked = 0;

        public About()
        {
            InitializeComponent();
            generateStatistics(AppDomain.CurrentDomain.BaseDirectory + "RecentFiles.txt");
            //loadStatisticsFile();
        }

        //Note: I was going to make a statistics text file. I decided instead to analyze the data in the recent files list instead.
        //Remove this at will. It is called by nothing, and will never be called again.
        public void loadStatisticsFile()
        {
            //System.Diagnostics.Process.Start("explorer.exe", "/select," + AppDomain.CurrentDomain.BaseDirectory);
            if(File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Stats.txt"))
            {
                StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Stats.txt");
                cumulativeFilesChecked = int.Parse(sr.ReadLine());
                cumulativeFilesTracked = int.Parse(sr.ReadLine());
                sr.Close();

                labelCheckedResult.Text = cumulativeFilesChecked.ToString();
                labelUncheckedResult.Text = (cumulativeFilesTracked - cumulativeFilesChecked).ToString();
                labelTotalResult.Text = cumulativeFilesTracked.ToString();

                progressBar1.Maximum = cumulativeFilesTracked;
                progressBar1.Value = cumulativeFilesChecked;
            }
            else
            {
                generateStatistics(AppDomain.CurrentDomain.BaseDirectory + "RecentFiles.txt");

                StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Stats.txt");
                sw.WriteLine(cumulativeFilesChecked);
                sw.WriteLine(cumulativeFilesTracked);
                sw.Close();

                labelCheckedResult.Text = cumulativeFilesChecked.ToString();
                labelUncheckedResult.Text = (cumulativeFilesTracked - cumulativeFilesChecked).ToString();
                labelTotalResult.Text = cumulativeFilesTracked.ToString();

                progressBar1.Maximum = cumulativeFilesTracked;
                progressBar1.Value = cumulativeFilesChecked;
            }
        }

        //Will load each line from RecentFiles.txt and pass them to the analyzeFile method
        public void generateStatistics(String Path)
        {
            if(File.Exists(Path))
            {
                StreamReader sr = new StreamReader(Path);

                while(sr.Peek() >= 0)
                {
                    analyzeFile(sr.ReadLine());
                }
                sr.Close();
            }

            labelCheckedResult.Text = cumulativeFilesChecked.ToString();
            labelUncheckedResult.Text = (cumulativeFilesTracked - cumulativeFilesChecked).ToString();
            labelTotalResult.Text = cumulativeFilesTracked.ToString();

            progressBar1.Maximum = cumulativeFilesTracked;
            progressBar1.Value = cumulativeFilesChecked;
        }

        //Examine each file stored in the RecentFiles.txt file. 
        public void analyzeFile(String Path)
        {
            if(File.Exists(Path))
            {
                StreamReader sr = new StreamReader(Path);

                while(sr.Peek() >=0)
                {
                    String lineRead = sr.ReadLine();
                    if (lineRead.Contains("|True"))
                    {
                        cumulativeFilesChecked++;
                        cumulativeFilesTracked++;
                    }
                    else //if (lineRead.Contains("|False"))
                    {
                        cumulativeFilesTracked++;
                    }
                }
                sr.Close();
            }
        }

        //Remove this at will. It is called by nothing, and will never be called again.
        public void clearStats()
        {
            generateStatistics(AppDomain.CurrentDomain.BaseDirectory + "RecentFiles.txt");

            cumulativeFilesTracked = 0;
            cumulativeFilesChecked = 0;

            StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Stats.txt");
            sw.WriteLine(cumulativeFilesChecked);
            sw.WriteLine(cumulativeFilesTracked);
            sw.Close();

            labelCheckedResult.Text = cumulativeFilesChecked.ToString();
            labelUncheckedResult.Text = (cumulativeFilesTracked - cumulativeFilesChecked).ToString();
            labelTotalResult.Text = cumulativeFilesTracked.ToString();

            progressBar1.Maximum = cumulativeFilesTracked;
            progressBar1.Value = cumulativeFilesChecked;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
