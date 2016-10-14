using System;
using System.Reflection;
using System.Windows.Forms;
using System.IO;

namespace playlists16
{
    public partial class baseForm : Form
    {
        public baseForm()
        {
            InitializeComponent();
           
        }
        //this is here to let all the children (specificly Form1) know there is a form2
       public Form form2;

//(UPDATABLE/YOUTUBE DEPENSENT)this is how all play lists start  in youtube if  this changes it will need an update
        string list = "http://www.youtube.com/watch_videos?video_ids=";
        // this will be the place of the equal sign so i can copy only after that 
        int indexOfEqual = 0;
        // this will be the place of the last \ so i can replace after that
        int indexOfSlash = 0;
        // this will be how many videos the user have added
        int addTimes = 0;
        // this will be the name of the file the user loads it is initiated as the bufferlist withing our file
        string fileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+"\\playlists\\bufferlist1.txt";
        
        // this will be the name of the file the user loads
        string bufferPathName = null;


        //this makes sure to create the path and the file if it did not exist
        public void fileExistance(string a)
        {
            int indx= a.LastIndexOf('\\');
            string b =   a.Substring(0, indexOfSlash + 1);
            FileInfo fileInfo = new FileInfo(b);
            if (!fileInfo.Exists)
            {
                Directory.CreateDirectory(fileInfo.Directory.FullName);
            }

        }

    //when you click the load button you open a file and choose a txt document (that should contain a link in text form
    private void load_Click(object sender, EventArgs e)
        {
            
            // Show the Open File dialog. If the user clicks OK, load the
            // picture that the user chose.
            if (loadfileDialog.ShowDialog() == DialogResult.OK)
            {
               fileName = loadfileDialog.FileName;
                list = File.ReadAllText(@fileName);
            }

            
            
        }

        // when you click the save button you save your list in a temporary file as a text 
        private void save_Click(object sender, EventArgs e)
        {
            fileExistance(fileName);
            File.WriteAllText(@fileName, list);
        
        }

        // this is the add button it adds what ever comes after the = in the textbox to our list
        private void add_Click(object sender, EventArgs e)
        {
            //if the textbox is empty it does nothing
            if (textBox1.Text.Length == 0)
            {
                return;
            }
            else
                indexOfEqual = textBox1.Text.IndexOf("=");
            //if there is no = sign in your textbox it asks the user to privide a proper part of the url
            if (indexOfEqual==-1)
               
                {
                    MessageBox.Show("I need a youtube link. So make sure you have the part after and including the = sign of the url!");
                    return;
                }
            //if there is more than 1 = sign in your textbox it asks the user to privide a proper  url
            if (textBox1.Text.IndexOf("=",indexOfEqual+1) !=-1)
            {
                MessageBox.Show("I need a youtube link. The text you you have does not look like one. So make sure you have a proper chunk, including the = sign till the end of the url!");
                return;
            }
//(UPDATABLE/YOUTUBE DEPENSENT)it pastes together the parts of the url needed in order to create a youtube list
            string adding = textBox1.Text.Substring(indexOfEqual + 1);
            list = list + "," + adding;
            textBox1.Text = null;
            addTimes = addTimes + 1;
            //saves your list after the add to a bufferlist.txt
            indexOfSlash = fileName.LastIndexOf('\\');
//(multiple OS) here i check for the path beeing seperated by front Slash / and not back slash \ like in unix  useless here ...         
            if (indexOfSlash == -1) {
                indexOfSlash = fileName.LastIndexOf("/");
            }
            bufferPathName = fileName.Substring(0, indexOfSlash+1)+"bufferlist1.txt";

            fileExistance(bufferPathName);
            //this writes every add we maketo a buffer file
            File.WriteAllText(@bufferPathName, list);



            //if u adding more than 20 songs warning comes out since youtube will only have 20 songs either way 
            if (addTimes == 20)
            {
                MessageBox.Show("youtube has a max of 20 in a list so you will not have more!");
            }
        }

        //this the play button
        private void playButton_Click(object sender, EventArgs e)
        {
            //this opens a web page with the url from your default browser that is stored in the string list
            System.Diagnostics.Process.Start(list);
        }

    }
}
