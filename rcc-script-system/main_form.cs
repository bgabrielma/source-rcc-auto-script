using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.IO;

namespace rcc_script_system
{
    public partial class main_form : Form
    {
        /* @Note: Algoritm
         *  #! = titulos
            > = frases
            // = comentários
            &: = nome da aula/curso
        */

        // Class's variables
        private bool borderIsLoad;
        public bool BorderIsLoad { get => borderIsLoad; set => borderIsLoad = value; }

        // Token's definition
        public static Regex COMMENT_TOKEN = new Regex(@"^\/\/");
        public static Regex MAIN_TITLE_TOKEN = new Regex(@"^>");
        public static Regex TITLE_TOKEN = new Regex(@"^#!");
        public static Regex COMPANHIA_TOKEN = new Regex(@"^>>>");
        public static Regex NAME_TOKEN = new Regex(@"^&:");
        public static Regex PAUSE_TOKEN = new Regex(@"/\S/"); // ?

        private StreamReader readerFiles;
        private OpenFileDialog openFile;

        // List's definition
        private List<string> titles = new List<string>(); // #!
        private List<string> comments = new List<string>(); // //
        private List<Line> lines = new List<Line>(); // >

        //information data
        private string nameScript;
        private string nameRCC;
        private string tagRCC;
        private string companhiaRCC;

        /**
         * TODO: System to move window 
         * */
        // Prevent the system to re-create the border in determinate components
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;  //this indicates that the action takes place on the title bar


        private void Move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public main_form()
        {
            // add event to enable move system
            MouseDown += new MouseEventHandler(Move_window); // binding the method to the event

            // creating and building components

            InitializeComponent();

            //load properties - nick and tag
            loadProperties();

            //Blocking system to recreate new borders.
            /**
             * TODO: Fixed bug -> add a file and program will create an border into label 
             */
            BorderIsLoad = true;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Main frame
        private void main_content_Paint(object sender, PaintEventArgs e)
        {
            // Create a blue-cyan border arround the panel component
            e.Graphics.DrawRectangle(
                new Pen(new SolidBrush(Color.FromArgb(48, 141, 252)), 4), e.ClipRectangle);
            Invalidate();
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Minimize window when "pictureBox2" component is clicked
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Close the program - terminate it
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Clear memory on close task. Better than close()
            Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (!BorderIsLoad)
            {
                // Create a blue-cyan border arround the panel component
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(48, 141, 252))),
                e.ClipRectangle.Left,
                e.ClipRectangle.Top,
                e.ClipRectangle.Width - 1,
                e.ClipRectangle.Height - 1);
                base.OnPaint(e);
                Invalidate();
            }
        }

        private void data_file_section_Paint(object sender, PaintEventArgs e)
        {
            if (!BorderIsLoad)
            {
                // Create a blue-cyan border arround the panel component
                e.Graphics.DrawRectangle(
                new Pen(new SolidBrush(Color.FromArgb(48, 141, 252)), 2), e.ClipRectangle);
            }
        }

        /*
         * TODO:  Hover effect - add an light slate gray background and remove it on leave event - begin
         * */

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            close.BackColor = Color.LightSlateGray;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.Transparent;
        }

        private void min_MouseHover(object sender, EventArgs e)
        {
            min.BackColor = Color.LightSlateGray;
        }

        private void min_MouseLeave(object sender, EventArgs e)
        {
            min.BackColor = Color.Transparent;
        }

        /*
         * ^^ - end effect methods
         * */

        public void updateInfosAndFillLists(OpenFileDialog file)
        {
            titles.Clear();
            comments.Clear();
            lines.Clear();
            string contentByLine = string.Empty;
            readerFiles = new StreamReader(file.FileName, Encoding.GetEncoding("iso-8859-1"));
            infoFileName.Text = txtFileUpload.SafeFileName;

            //read line by line and separate according to regex's function

            while ((contentByLine = readerFiles.ReadLine()) != null)
            {
                if(COMPANHIA_TOKEN.IsMatch(contentByLine))
                {
                    companhiaRCC = contentByLine.Replace(">>>", "");
                }
                if (TITLE_TOKEN.IsMatch(contentByLine))
                {
                    titles.Add(contentByLine.Replace("#!", "").ToUpper());
                }
                if (MAIN_TITLE_TOKEN.IsMatch(contentByLine))
                {
                    lines.Add(new Line(contentByLine.Replace(">", "").Replace("[Nick]", Properties.SettingsRCC.Default.user.ToString()).Replace("[TAG]", fixTAG(Properties.SettingsRCC.Default.tag.ToString())), titles.Count));
                }
                if (COMMENT_TOKEN.IsMatch(contentByLine))
                {
                    comments.Add(contentByLine);
                }
                if (NAME_TOKEN.IsMatch(contentByLine))
                {
                    if (contentByLine.Length > 29)
                    {
                        scriptName.Text = (contentByLine.Replace("&:", "")).Substring(0, 28) + '\n' + contentByLine.Substring(30);
                    }
                    else
                    {
                        scriptName.Text = contentByLine.Replace("&:", "");
                    }

                    nameScript = contentByLine.Replace("&:", "");
                }
            }

            //Set title's amount display
            for (int i = 1; i <= titles.Count; i++)
            {
                titlesAmount.Text = "" + i;
            }

            //Set Line's amount display
            for (int i = 1; i <= lines.Count; i++)
            {
                linesAmount.Text = "" + i;
            }

            //Enable the button
            btnControlPanel.Enabled = true;
        }

        private void importFile_Click(object sender, EventArgs e)
        {
            reset();

            if (txtFileUpload.ShowDialog() == DialogResult.OK)
            {
                openFile = txtFileUpload;
                updateInfosAndFillLists(txtFileUpload);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // fill variables
            nameRCC = nickRCC.Text;
            tagRCC = tagRCCIdentification.Text;

            var error = 0;

            if (nameRCC == string.Empty)
            {
                nickRCC.ForeColor = Color.Red;
                error = 1;
            }else
            {
                nickRCC.ForeColor = Color.Black;
            }
            
            if(tagRCC == string.Empty || tagRCC.Length < 3)
            {
                tagRCCIdentification.ForeColor = Color.Red;
                error = 1;
            }
            else
            {
                tagRCC = fixTAG(tagRCC);

                tagRCCIdentification.ForeColor = Color.Black;
            }

            // verify if controlPanel's Form is active
            Form controlPanel = Application.OpenForms["controlPanel"];
            if (controlPanel != null)
            {
                MessageBox.Show("Já se encontra uma janela aberta. Fecha a mesma e tente novamente!", 
                    "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (titles.Count == 0 || lines.Count == 0)
            {
                MessageBox.Show("O script inserido no programa é inválido! - Reveja o ficheiro e tente novamente.",
                    "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // open controlPanel's form
            setProperties();

            //update infos
            updateInfosAndFillLists(txtFileUpload);

            controlPanel form = new controlPanel(openFile, titles, comments, lines, nameScript, nameRCC, tagRCC, companhiaRCC);

            if (error == 0)
            {
                form.Show();
            }
        }

        public string fixTAG(string x)
        {
            if (!x.Contains('['))
                x = '[' + x;

            if (!x.Contains(']'))
                x = x + ']';
            return x;
        }

        public void reset()
        {
            if (readerFiles != null)
                readerFiles.Close();

            titles.Clear();
            comments.Clear();
            lines.Clear();
            nameScript = string.Empty;
            nameRCC = string.Empty;
            tagRCC = string.Empty;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form generate = Application.OpenForms["Generate"];
            if (generate != null)
            {
                MessageBox.Show("Já se encontra uma janela aberta. Fecha a mesma e tente novamente!",
                    "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // open controlPanel's form
            Generate generateForm = new Generate();
            generateForm.Show();
        }

        public void loadProperties()
        {
            nickRCC.Text = nameRCC = Properties.SettingsRCC.Default.user;
            tagRCCIdentification.Text = tagRCC = Properties.SettingsRCC.Default.tag;
        }

        public void setProperties()
        {
            Properties.SettingsRCC.Default.user = nickRCC.Text;
            Properties.SettingsRCC.Default.tag = tagRCCIdentification.Text;
            Properties.SettingsRCC.Default.Save();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            close.BackColor = Color.LightSlateGray;
        }


        private void about_Click(object sender, EventArgs e)
        {
            Form about = Application.OpenForms["About"];
            if (about != null)
            {
                MessageBox.Show("Já se encontra uma janela aberta. Fecha a mesma e tente novamente!",
                    "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // open controlPanel's form
            About aboutForm = new About();
            aboutForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            importFile.PerformClick();
        }
    }
}
