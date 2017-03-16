/* TigerRoster: Free Open-Source app to help take attendance, record who has completed in-class exercises or homework, or just to help identify students and learn their names and faces
Copyright(C) 2017  Cyprian Tayrien, Interactive Games and Media, Rochester Institute of Technology
GNU General Public License<http://www.gnu.org/licenses/>./**/

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

namespace peeps
{
    public partial class Roster : Form
    {
        Button[] buttons;

        // Display course #
        int c = -1;

        Image[][] images;
        string[][] names;
        
        Button[] portraits = new Button[30];

        void ExportClick(Object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string outstring = "";

            int n = names[c].Length;
            for (int i = 0; i < n; i++) {
                if (names[c][i]!= "" && portraits[i].Text != names[c][i]) {
                    outstring += names[c][i] + "\r\n";
                }
            }

            // save the string into a file
            Stream stream;
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            string datestring = DateTime.Now.ToString("MM-dd-yy");
            sfd.FileName = buttons[c].Text + "_" + datestring + ".txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if ((stream = sfd.OpenFile()) != null)
                {
                    using (StreamWriter writer = new StreamWriter(stream)) {
                        writer.WriteLine(outstring);
                    }

                    stream.Close();
                }
            }
        }

        void CourseClick(Object sender, EventArgs e)
        {
            // search a directory for file list to populate buttons images and text

            Button button = (Button)sender;
            
            if (button.Name == "SectionA") {
                c = 0;
            }
            if (button.Name == "SectionB") {
                c = 1;
            }
            if (button.Name == "SectionC") {
                c = 2;
            }
            if (button.Name == "SectionD") {
                c = 3;
            }
            
            // Give buttons names and pictures
            for (int i = 0; i < 30; i++)
            {
                if (i < names[c].Length) {
                    portraits[i].Text = names[c][i];
                    portraits[i].Image = images[c][i];
                }
                else {
                    portraits[i].Image = null;
                    portraits[i].Text = "";
                }
            }
        }

        void PortraitClick(Object sender, EventArgs e)
        {
            Button button = (Button)sender;
            
            button.Image = null;
            button.Text = "";
        }

        public Roster()
        {
            InitializeComponent();

            Export.Click += new EventHandler(this.ExportClick);

            Button[] buttonnames = { SectionA, SectionB, SectionC, SectionD };
            buttons = buttonnames;
            
            for (int i = 0; i < 4; i++) {
                buttons[i].Click += new EventHandler(this.CourseClick);
            }
            
            this.Width = 1290;
            this.Height = 580;
            
            portraits[0] = button1;
            portraits[0].TextAlign = ContentAlignment.TopCenter;
            portraits[0].Click += new EventHandler(this.PortraitClick);
            portraits[0].Text = "";

            // Spawn buttons for each student and set size
            for (int i = 1; i < 30; i++)
            {
                portraits[i] = new Button();
                portraits[i].Show();
                this.Controls.Add(portraits[i]);

                portraits[i].Size = portraits[0].Size;
                portraits[i].TextAlign = ContentAlignment.TopCenter;
                portraits[i].Click += new EventHandler(this.PortraitClick);                
            }

            // Place button locations (needs to use a buffer btwn buttons)
            int buf = buttons[1].Left - buttons[0].Right;
            for (int i = 1; i < 30; i++)
            {
                if (i == 10 || i == 20)
                {
                    portraits[i].Location = portraits[i - 10].Location;
                    portraits[i].Top += buf + portraits[i].Height;
                }
                else
                {
                    portraits[i].Location = portraits[i - 1].Location;
                    portraits[i].Left += buf + portraits[i].Width;
                }
            }

            // read "projdir/Roster/*/*.png
            // first star is course name
            // second star is student name
            string dbdirbase = Directory.GetCurrentDirectory() + @"\Roster\"; // or /?
            string[] dbdirs = Directory.GetDirectories(dbdirbase);
            int n = dbdirs.Length;
            images = new Image[n][];
            names = new string[n][];

            for (int i = 0; i < dbdirs.Length; i++)
            {
                string[] roster = Directory.GetFiles(dbdirs[i]);
                int m = roster.Length;
                images[i] = new Image[m];
                names[i] = new string[m];

                for (int j = 0; j < roster.Length; j++)
                {
                    // load images
                    images[i][j] = Image.FromFile(roster[j]).GetThumbnailImage(120, 159, null, IntPtr.Zero);

                    char[] delims = { '\\', '.' };
                    string[] parsedname = roster[j].Split(delims); // or /?
                    string newname = parsedname[parsedname.Length - 2];
                    string[] threenames = newname.Split(' ');
                    names[i][j] = threenames[0] + ' ' + threenames[threenames.Length-1];
                }
            }

            // Read class names from directory names in the Roster folder
            for (int i = 0; i < dbdirs.Length; i++)
            {
                string[] parsedir = dbdirs[i].Split('\\'); // or /?
                buttons[i].Text = parsedir[parsedir.Length - 1];
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            // stretch goal: clear portraits
        }

        private void Export_Click(object sender, EventArgs e)
        {
            // stretch goal: export attendance / ICE data to spreadsheets
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // stretch goal: import data from SIS database
        }
    }
}
