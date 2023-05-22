using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mp3Player
{
    public partial class mp3Player : Form
    {

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer(); //library for using play, stop etc.
        public mp3Player()
        {
            InitializeComponent();
            trackBar1.Value = 10; 

            var pathWithEnv = @"%APPDATA%\AudioPlayer\pathOfMusics.txt"; //creating a path for saving the files into the app. Just a string
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv); //makes the %appdata% environment variable as a path to create the files in there.
            
            if (!File.Exists(filePath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath)); //file doesn't exist, created our file in the path.
            }
            else
            {
                savedPaths = System.IO.File.ReadAllLines(filePath); //file exists, we read them to see the files.
                
            }

            pathWithEnv = @"%APPDATA%\AudioPlayer\namesOfMusic.txt"; 
            filePath = Environment.ExpandEnvironmentVariables(pathWithEnv); 

            if (!File.Exists(filePath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }
            else
            {
                savedFiles = System.IO.File.ReadAllLines(filePath);

                for (int i = 0; i < savedFiles.Length; i++)
                {
                    mplists.Items.Add(savedFiles[i]); //display songs in listbox mp3lists listbox. added songs too.
                }

            }

        }
        //creaing global variables of string type array to save the titles of the audio files and the path of the track
        String[] paths, files; //while choosing a song, it will named as paths and files
        String[] savedPaths;  //after adding one or more song, the list will be named.
        String[] savedFiles;  
        private void mplists_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (mplists.SelectedIndex != -1) //if we selected a song
            {
                player.settings.volume = trackBar1.Value;
                player.URL = savedPaths[mplists.SelectedIndex]; //URL takes songs into the player
                
                label2.Text = savedFiles[mplists.SelectedIndex]; //name of the sound currently playing
                timerLabel1.Text = player.controls.currentPositionString; //current passing time of the song
                
            }
            else
            {
                player.URL = null;
                player.controls.stop();
                label2.Text = null;

                timerLabel1.Text = null;
                timerLabel2.Text = null;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            //code to close the application
            this.Close();
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
           //code to minimize the window
            this.WindowState = FormWindowState.Minimized;
        }

        private void selectSongbtn_Click(object sender, EventArgs e)
        {
            //code for selecting song
            OpenFileDialog ofd = new OpenFileDialog(); //pop up the files

            ofd.Filter = "MP3 Files|*.mp3|WAV Files|*.wav|FLAC files|*.flac"; //filtering for audio files
            
            //code for adding multiple audio files
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                  files = ofd.SafeFileNames; //save the names of the track in files array
                  paths = ofd.FileNames; //save the paths of the tracks in path aray

                if (savedPaths != null)
                {
                    for (int i = paths.Length-1; i >= 0; i--) //we deleted from the end (deleting from the bottom)
                    {
                        if (savedPaths.Contains(paths[i])) //for not adding the same songs twice, we used removing
                        {
                            var newPaths = paths.ToList();
                            newPaths.RemoveAt(i);
                            paths = newPaths.ToArray();

                            var newFiles = files.ToList();
                            newFiles.RemoveAt(i);
                            files = newFiles.ToArray();

                        }
                    }
                }
                  
                for (int i = 0; i<files.Length; i++)
                {
                     mplists.Items.Add(files[i]); //display songs in listbox mp3lsts 
                }

                if (savedPaths != null)
                {
                    savedFiles = savedFiles.Concat(files).ToArray(); //adds to bottom
                    savedPaths = savedPaths.Concat(paths).ToArray();
                }

                else
                {
                    savedFiles = files; savedPaths = paths; //if empty, wont be added
                }
               
                var pathWithEnv = @"%APPDATA%\AudioPlayer\pathOfMusics.txt"; //we declared a path as a string
                var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv); // pathWithEnv became a path to create files and folders 
                System.IO.File.WriteAllLines(filePath, savedPaths);//found the file directory, then writng in the text files
                
                pathWithEnv = @"%APPDATA%\AudioPlayer\namesOfMusic.txt"; 
                filePath = Environment.ExpandEnvironmentVariables(pathWithEnv); 
                System.IO.File.WriteAllLines(filePath, savedFiles); 
            }
        }
        private void playBtn_Click(object sender, EventArgs e)
        {
            if (mplists.SelectedIndex != -1) //if selected a song, terminate here
            {
                player.settings.volume = trackBar1.Value; //set volume to the trackbar value
                player.controls.play();  //play the song
            }
        }
        private void stopBtn_Click(object sender, EventArgs e)
        {
            player.controls.pause(); //pause the song
        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            if (mplists.SelectedIndex != savedFiles.Length-1) 
            {
                mplists.SelectedIndex += 1; //incrementing the index so we can go to the next song
                player.controls.play(); 
            }
        }
        private void btnPanel_Paint(object sender, PaintEventArgs e)
        {
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar1.Value; //volume setted
            volumeVal.Text =  trackBar1.Value.ToString() + "%" ; //writing the volume value in the label
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            if (mplists.SelectedIndex > 0) 
            {
                mplists.SelectedIndex -= 1; //going to the previous song
                player.controls.play();
            }
        }

        private void topPanel_Click(object sender, EventArgs e) 
        { 
        }

        private void shuffleBtn_Click(object sender, EventArgs e) 
        {
            Random rndm = new Random();
            int randNum = rndm.Next(0, savedFiles.Length); //we created a random number

            player.settings.volume = trackBar1.Value; 
            mplists.SelectedIndex = randNum; //we made the number number as the selected index
            player.controls.play(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying) //to see the time of the songs, total time, passed time
            {
                timeBar.Maximum = (int)player.controls.currentItem.duration;
                timeBar.Value = (int)player.controls.currentPosition;
            }

            try
            {
                timerLabel1.Text = player.controls.currentPositionString;

                if (player.controls.currentItem.durationString == "00:00" || mplists.SelectedIndex == -1)
                {
                    timerLabel2.Text = "";
                }

                else
                {
                    timerLabel2.Text = player.controls.currentItem.durationString;
                }
            }
            catch { }
        }

        private void mp3Player_Load(object sender, EventArgs e)
        {
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            timeBar.Value = 0;

            timerLabel1.Text = null;
            timerLabel2.Text = null;

            var newsPaths = savedPaths.ToList();
            newsPaths.RemoveAt(mplists.SelectedIndex);
            savedPaths = newsPaths.ToArray();   //deleting from the string array

            var newsFiles = savedFiles.ToList();
            newsFiles.RemoveAt(mplists.SelectedIndex);
            savedFiles = newsFiles.ToArray();
           
            mplists.Items.RemoveAt(mplists.SelectedIndex);  //deleting from the mplist listbox
            
            //updating the new list into the folder and text files.

            var pathWithEnv = @"%APPDATA%\AudioPlayer\pathOfMusics.txt"; 
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);                                                                      
            System.IO.File.WriteAllLines(filePath, savedPaths);

            pathWithEnv = @"%APPDATA%\AudioPlayer\namesOfMusic.txt"; 
            filePath = Environment.ExpandEnvironmentVariables(pathWithEnv); 
            System.IO.File.WriteAllLines(filePath, savedFiles); 

            mplists.SelectedIndex = -1;
            player.URL = null; //making player's inside empty
        }
        private void topPanel_Paint(object sender, PaintEventArgs e) 
        {
            
        }
    }
}
