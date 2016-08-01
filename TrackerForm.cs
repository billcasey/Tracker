using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Tracker
{
    public partial class TrackerForm : Form
    {
        RecentFiles rf = new RecentFiles();

        public TrackerForm()
        {
            InitializeComponent();
            checkDirectory(null, null);
        }

        //Invoked when the application is executed with a command line argument. 
        //If a .track file is opened, it's path will be the arg
        public TrackerForm(String arg)
        {
            InitializeComponent();
            openFile(arg, null);
            checkDirectory(null, null);
        }

        /*Custom Methods*/
        private void openFile(object sender, EventArgs e)
        {
            if(File.Exists(sender.ToString()))
            {
                checkedListBox1.Items.Clear();
                rf.setLoadedFilePath(sender.ToString());
                StreamReader sr = new StreamReader(sender.ToString());
                List<String> linesRead = new List<String>();

                while(sr.Peek() >= 0)
                {
                    linesRead.Add(sr.ReadLine());
                }

                for(int i=0; i < linesRead.Count; i++)
                {
                    //Each line read will be in the following format: File|[Full Path|Folder Path] OR [URL]|Watched
                    String[] parsedLine = linesRead[i].Split('|');

                    //Check if the line is referencing a File.
                    if(parsedLine[0] == "File")
                    {
                        String tempTitle = parsedLine[1];
                        String tempPath = parsedLine[2];
                        String tempFolderPath = parsedLine[3];
                        Boolean tempWatched = Boolean.Parse(parsedLine[4]);

                        checkedListBox1.Items.Add(new TrackedFile(tempTitle, tempPath, tempFolderPath, tempWatched));

                        if(tempWatched == true)
                        {
                            checkedListBox1.SetItemChecked(i, true);
                        }
                    }
                    //Check if the line is referencing a Link
                    else if(parsedLine[0] == "Link")
                    {
                        String tempTitle = parsedLine[1];
                        String tempURL = parsedLine[2];
                        Boolean tempWatched = Boolean.Parse(parsedLine[3]);

                        checkedListBox1.Items.Add(new TrackedLink(tempTitle,tempURL,tempWatched));

                        if(tempWatched == true)
                        {
                            checkedListBox1.SetItemChecked(i, true);
                        }
                    }
                    //Otherwise, go here.
                    else
                    {
                        //This block is never entered. If extra types are added, handling them will go here.
                    }
                }
                sr.Close();
                rf.setLoadedFilePath(sender.ToString());
            }
        }

        private void saveFile(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(sender.ToString());
            for(int i=0; i < checkedListBox1.Items.Count; i++)
            {
                if(checkedListBox1.Items[i].GetType().Equals(typeof(TrackedFile)))
                {
                    TrackedFile tf = (TrackedFile)checkedListBox1.Items[i];
                    sw.WriteLine("File|" + tf.getTitle() + "|" + tf.getPath() + "|" + tf.getFolderPath() + "|" + checkedListBox1.GetItemChecked(i));
                }
                else if(checkedListBox1.Items[i].GetType().Equals(typeof(TrackedLink)))
                {
                    TrackedLink lk = (TrackedLink)checkedListBox1.Items[i];
                    sw.WriteLine("Link|" + lk.getPageTitle() + "|" + lk.getURL() + "|" + checkedListBox1.GetItemChecked(i));
                }
                else
                {
                    //Does nothing. If you add extra types, how to save them will go here
                }
            }
            sw.Close();
            rf.addRecentFile(sender.ToString());
        }

        /*Menu Bar Tool Strip Items*/
        /*File - And Sub Items */
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Tracker Files (*.track)|*.track|All files (*.*)|*.*"; // The dialog filter means that it will only look for .track files. All Files is included so users have the option of seeing every file in the directory.
            openFileDialog1.FileName = "Tracked.track"; //The default name for saved files is "Tracked.track".
            DialogResult openFileResult = openFileDialog1.ShowDialog(); //Using Dialog Result means that if a user clicks cancel instead of selecting something, it will not crash

            //If the user selects a valid file using the dialog, then pass the path to the openFile method.
            if(openFileResult == DialogResult.OK)
            {
                openFile(openFileDialog1.FileName, null);
            }
        }
        
        private void checkDirectory(object sender, EventArgs e)
        {
           //Clear the recents each time this is called, so the list does not go on forever.
            recentFilesToolStripMenuItem.DropDownItems.Clear();
            List<String> passedPaths = rf.getRecentFilePaths();

            foreach (var entry in passedPaths)
            {
                recentFilesToolStripMenuItem.DropDownItems.Add(entry, null, openFile); //Adds the Path, null value for the icon, and the menthod called when it is clicked.
            }
            //Add the separator bar and the clear recent files button.
            recentFilesToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
            recentFilesToolStripMenuItem.DropDownItems.Add("Clear Recent Files", null, clearRecentFilesDropdown);
        }

        private void clearRecentFilesDropdown(object sender, EventArgs e)
        {
            recentFilesToolStripMenuItem.DropDownItems.Clear();
            rf.deleteRecentFilesTxtFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(File.Exists(rf.getLoadedFilePath()))
            {
                saveFile(rf.getLoadedFilePath(), null);
            }
            else
            {
                //If this is a new list, then prompt the user for a name and directory to save the new file in.
                saveAsToolStripMenuItem_Click(null, null);
            }
        }
        
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This block sets default names for the save file dialog. It makes it easier for the user.
            saveFileDialog1.FileName = "Tracked"; //This will ignore whatever extension you give it.
            saveFileDialog1.Filter = "Tracker Files (*.track)|*.track|All files (*.*)|*.*"; //Shows possible extensions
            DialogResult saveFileDialogResult = saveFileDialog1.ShowDialog();

            //Checks to see if the user actually picked a path, and that the path is valid.
            if(saveFileDialogResult == DialogResult.OK)
            {
                saveFile(saveFileDialog1.FileName, null);
            }
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*About*/
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        /*Top Tool Strip Bar*/
        private void tsbAddFolder_Click(object sender, EventArgs e)
        {        
            //Using Dialog Result means that an exception will not occur if the user clicks cancel.
            folderBrowserDialog1.ShowNewFolderButton = true;
            folderBrowserDialog1.Description = "Select a folder to add its files to the tracker. Selecting a parent folder also includes all files in all subfolders.";
            DialogResult openFolderResult = folderBrowserDialog1.ShowDialog();

            if (openFolderResult == DialogResult.OK)
            {
                //The Directory Class outputs files as full paths in a string array. 
                //This will give all files in all sub-directories.
                String[] fileNames = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.*", SearchOption.AllDirectories); 

                foreach (var newFileFound in fileNames)
                {
                    String[] parsedPath = newFileFound.Split('\\');
                    String tempTitle = parsedPath[parsedPath.Length - 1]; //The very last part of any path is the name of the file
                    String tempPath = newFileFound;
                    String tempFolderPath = tempPath.Substring(0, tempPath.Length - tempTitle.Length); //A substring of the whole path minus the length of the title gives the path to the folder.

                    checkedListBox1.Items.Add(new TrackedFile(tempTitle, tempPath, tempFolderPath, false));
                }
            }
        }

        private void tsbAddFile_Click(object sender, EventArgs e)
        {
            //Using Dialog Result means that an exception will not occur if the user clicks cancel.
            openFileDialog1.FileName = null;
            DialogResult openFileResult = openFileDialog1.ShowDialog();
            
            if(openFileResult == DialogResult.OK)
            {
                String[] parsedPath = openFileDialog1.FileName.Split('\\');
                String tempTitle = parsedPath[parsedPath.Length - 1]; //The very last part of any path is the filename
                String tempPath = openFileDialog1.FileName;
                String tempFolderPath = tempPath.Substring(0, tempPath.Length - tempTitle.Length); //A substring of the whole path minus the length of the title gives the path to the folder.

                checkedListBox1.Items.Add(new TrackedFile(tempTitle, tempPath, tempFolderPath, false));
            }
        }
        
        private void tsbAddLink_Click(object sender, EventArgs e)
        {
            AddLink newAddLinkForm = new AddLink();
            if(newAddLinkForm.ShowDialog() == DialogResult.OK)
            {
                String tempTitle = newAddLinkForm.getPageTitle();
                String tempURL = newAddLinkForm.getURL();
                checkedListBox1.Items.Add(new TrackedLink(tempTitle, tempURL, false));
                newAddLinkForm.Dispose();
            }
        }

        private void tsbRemoveSelected_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.SelectedIndex >= 0)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
            }
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            rf.setLoadedFilePath(null);
        }
        
        /*File Access Strip Items*/
        //TODO: Add "if(File.Exists()) for each to check for typos.
        private void atsPlayNext_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.Items.Count > 0) //Check to see that the checked list box is populated
            {
                //This loop goes through every item in the checked list box.
                //It will 'open' the path of the first item that is not checked.
                for(int i=0; i < checkedListBox1.Items.Count; i++)
                {
                    if(checkedListBox1.GetItemChecked(i) == false)
                    {
                        /* Stack Overflow said this is the best way to 'open' any file when you pass it a path.
                         * Windows will open what ever program is associated with the extension of the file.
                         * If Process.Start() is passed a web URL, it will open it in your default internet browser */

                        //TODO: Add exception handling to see what happens if you give it a bad path. I have not encountered such an error yet.
                        if(checkedListBox1.Items[i].GetType().Equals(typeof(TrackedFile)))
                        {
                            System.Diagnostics.Process.Start(((TrackedFile)checkedListBox1.Items[i]).getPath());
                            checkedListBox1.SetItemChecked(i, true);
                            break;
                        }
                        else if(checkedListBox1.Items[i].GetType().Equals(typeof(TrackedLink)))
                        {
                            System.Diagnostics.Process.Start(((TrackedLink)checkedListBox1.Items[i]).getURL());
                            checkedListBox1.SetItemChecked(i, true);
                            break;
                        }
                        break;
                    }
                }
            }
        }

        private void atsPlaySelected_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.SelectedIndex >= 0)
            {
                /* Stack Overflow said this is the best way to 'open' any file when you pass it a path.
                 * Windows will open what ever program is associated with the extension of the file.
                 * If Process.Start() is passed a web URL, it will open it in your default internet browser */

                //TODO: Add exception handling to see what happens if you give it a bad path. I have not encountered such an error yet.
                if (checkedListBox1.SelectedItem.GetType().Equals(typeof(TrackedFile)))
                {
                    System.Diagnostics.Process.Start(((TrackedFile)checkedListBox1.SelectedItem).getPath());
                    checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, true);
                }
                else if(checkedListBox1.SelectedItem.GetType().Equals(typeof(TrackedLink)))
                {
                    System.Diagnostics.Process.Start(((TrackedLink)checkedListBox1.SelectedItem).getURL());
                    checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, true);
                }
            }
        }

        private void atsOpenDirectory_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.SelectedIndex >= 0)
            {
                /*Taken from StackOverflow: "Implement “Open Containing Folder” and highlight file"
                 * http://stackoverflow.com/questions/2829501/implement-open-containing-folder-and-highlight-file
                 */
                if(checkedListBox1.SelectedItem.GetType().Equals(typeof(TrackedFile)))
                {
                    String filePath = ((TrackedFile)checkedListBox1.SelectedItem).getPath();
                    if(File.Exists(filePath))
                    {
                        System.Diagnostics.Process.Start("explorer.exe", "/select," + filePath);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Filename/path", "Invalid path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(checkedListBox1.SelectedItem.GetType().Equals(typeof(TrackedLink)))
                {
                    /* Links do not have behavior for "Open Directory".
                     * Nothing needs to be done here. 
                     * Place an error messagebox here if users need an explanation.*/ 
                }
            }
        }

        private void atsRename_Click(object sender, EventArgs e)
        {
            //TODO: CRITICAL. This will cause an unhandled exception if rename is called on a link.
            if(checkedListBox1.SelectedIndex >= 0)
            {
                if(File.Exists(((TrackedFile) checkedListBox1.SelectedItem).getPath()))
                {
                    String oldPath = ((TrackedFile)checkedListBox1.SelectedItem).getPath();
                    String oldTitle = ((TrackedFile)checkedListBox1.SelectedItem).getTitle();

                    RenameFile rnf = new RenameFile(oldPath, oldTitle);
                    rnf.ShowDialog();

                    if(rnf.DialogResult == DialogResult.OK && rnf.newName != "")
                    {
                        String newNameWithPath = ((TrackedFile)checkedListBox1.SelectedItem).getFolderPath() + rnf.newName;
                        File.Move(oldPath, newNameWithPath);

                        ((TrackedFile)checkedListBox1.SelectedItem).setPath(newNameWithPath);
                        ((TrackedFile)checkedListBox1.SelectedItem).setTitle(rnf.newName);
                    }
                }
            }
        }

        private void addMultipleLinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMultipleLinks aml = new AddMultipleLinks();
            aml.ShowDialog();

            if(aml.getLinesCount() > 0)
            {
                for (int i = 0; i < aml.getLinesCount(); i++)
                {
                    checkedListBox1.Items.Add(new TrackedLink(aml.getTitleAt(i), aml.getURLAt(i), false));
                }       
            }
            aml.Close();
        }
    }
}