using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static rcc_script_system.Speed;

namespace rcc_script_system
{
    public partial class controlPanel : Form
    {
        private OpenFileDialog openFile;

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

        // List's definition
        private List<string> titles = new List<string>(); // #!
        private List<string> comments = new List<string>(); // //
        private List<Line> lines = new List<Line>(); // >
        private StreamReader readerFiles;

        // current List for auto-script
        private List<string> actualLinesByTopic = new List<string>();

        //Name of script
        private string nameScript;
        private string nameRCC;
        private string tagRCC;

        //counters
        private int activePart;
        private bool isTopicSend;

        public controlPanel(OpenFileDialog openFile, List<string> titles, List<string> comments, List<Line> lines, string nameScript, string nameRCC, string tagRCC)
        {
            // define class's variables with recieved data
            this.titles = titles;
            this.comments = comments;
            this.lines = lines;
            this.nameScript = nameScript;
            this.openFile = openFile;
            this.nameRCC = nameRCC;
            this.tagRCC = tagRCC;
            activePart = 1;
            isTopicSend = false;

            readerFiles = new StreamReader(this.openFile.FileName, Encoding.GetEncoding("iso-8859-1"));
            MouseDown += new MouseEventHandler(Move_window); // binding the method to the event
            InitializeComponent();

            //disable buttons
            btnPause.Enabled = false;
            btnReset.Enabled = false;
            btnContinue.Enabled = false;


        }

        private void Move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void loadHabboUser()
        {
            // fill habbo's data
            rcc_user_name.Text = nameRCC;
            rcc_user_tag.Text = tagRCC;

            WebClient client = new WebClient();

            // Add a user agent header in case the 
            // requested URI contains a query.

            var url = string.Format(
                "https://www.habbo.com.br/habbo-imaging/avatarimage?img_format=gif&user={0}&action=crr=6&direction=2&head_direction=2&gesture=std&size=l&headonly=1",
                nameRCC);

            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            try
            {
                Stream stream = client.OpenRead(url);
                Bitmap bitmap = new Bitmap(stream);

                rcc_user.Image = bitmap;

                stream.Flush();
                stream.Close();
                client.Dispose();

                //fill topic and speed box
                fillComboBox();
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    if (((HttpWebResponse)e.Response).StatusCode == HttpStatusCode.NotFound)
                    {
                        MessageBox.Show("Lamentamos mas não existe nenhum habbo com referencia ao nick inserido.",
                            "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ActiveForm.Close();
                    }
                }
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Create a blue-cyan border arround the panel component
            e.Graphics.DrawRectangle(
                new Pen(new SolidBrush(Color.FromArgb(48, 141, 252)), 4), e.ClipRectangle);
            Invalidate();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Create a blue-cyan border arround the panel component
            e.Graphics.DrawRectangle(
               new Pen(new SolidBrush(Color.FromArgb(48, 141, 252)), 4), e.ClipRectangle);
            Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja realmente sair do painel de controle?",
                    "RCC - Painel de controle", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) == DialogResult.OK)
            {
                Dispose();
            }
        }

        private void topicCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillPreview();
        }

        public void fillComboBox()
        {
            topicCombo.DataSource = titles;

            // Instance new dictionary in order to get an overwrite index value
            Dictionary<string, string> speed = new Dictionary<string, string>();

            //each element add to dictionary
            foreach (speedType x in (speedType[])Enum.GetValues(typeof(speedType)))
            {
                var number = ((int)x).ToString();
                speed.Add(number, number + " segundos");
            }

            //overwrite default configs into speedCombo
            speedCombo.DataSource = new BindingSource(speed, null);
            speedCombo.DisplayMember = "Value";
            speedCombo.ValueMember = "Key";

            fillPreview();

        }

        public void fillPreview()
        {
            // "String: " + titles[topicCombo.SelectedIndex] + " e valor: " + topicCombo.SelectedIndex

            // reset list and line pointer
            actualLinesByTopic.Clear();
            activePart = 1;

            // title
            preview.Text = titles[topicCombo.SelectedIndex] + "\n\n";
            actualLinesByTopic.Add(topicCombo.SelectedValue.ToString());

            foreach (Line x in lines)
            {
                // define temp pointer index
                var temp_index = topicCombo.SelectedIndex + 1;

                if (x.getIdTitle() == temp_index)
                {
                    actualLinesByTopic.Add(x.getValueLine()) ;
                    preview.Text += x.getValueLine() + '\n';
                }
            }
        }

        private void speedCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get speed number
            var seconds = double.Parse(((KeyValuePair<string, string>)speedCombo.SelectedItem).Key);

            // declare seconds and convert to milliseconds
            timerScript.Interval = (int)TimeSpan.FromSeconds(seconds).TotalMilliseconds;
        }

        private void controlPanel_Shown(object sender, EventArgs e)
        {
            // Load habbo's image
            loadHabboUser();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Após clicar em OK, vá até ao seu jogo e coloque o cursor do seu mouse na barra de fala. Seja rápido! Para cancelar, basta clicar no botão.",
                  "Informação", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                == DialogResult.OK)
            {
                timerScript.Enabled = true;
                isTopicSend = false;
                WindowState = FormWindowState.Minimized;
                timerScript.Start();
                btnStart.Enabled = false;
                btnReset.Enabled = true;
                btnPause.Enabled = true;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timerScript.Stop();
            timerScript.Enabled = false;
            btnContinue.Enabled = true;
            btnPause.Enabled = false;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            timerScript.Enabled = true;
            timerScript.Start();
            btnContinue.Enabled = true;
            btnPause.Enabled = false;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timerScript.Stop();
            timerScript.Enabled = false;
            btnContinue.Enabled = false;
            btnPause.Enabled = false;
            btnStart.Enabled = true;
            btnReset.Enabled = false;


            actualLinesByTopic.Clear();
            activePart = 1;
           
        }

        private void timerScript_Tick(object sender, EventArgs e)
        {
            sendController();

        }

        private void sendController()
        {
            var stringRemoveCaracter = string.Empty;
            SendKeys.Send((stringRemoveCaracter = SendPart(activePart)).Replace(";;", ""));
            SendKeys.Send("+{Enter}");

            if (SendPart(activePart).Contains(";;"))
            {
                // This method allow you to "force" click and use many times
                Button btn = new Button();
                btn.Click += btnPause_Click;
                btn.PerformClick();
                showStopNotification();
            }

            activePart++;
        }
        private string SendPart(int part)
        {
            if (!isTopicSend)
            {
                isTopicSend = true;
                return correctLine(topicCombo.SelectedValue.ToString());
            }

            // actualLinesByTopic -> index 0 
            var tmpActivePart = activePart;

            //Increments ajust
            tmpActivePart--; // 1 --> 0

            try
            {
                return correctLine(actualLinesByTopic[tmpActivePart]);
            }

            catch(ArgumentOutOfRangeException)
            {
                timerScript.Stop();
                btnContinue.Enabled = false;
                btnPause.Enabled = false;
                btnStart.Enabled = true;
                btnReset.Enabled = false;
                activePart = 1;
                MessageBox.Show("Este tópico foi finalizado com sucesso!",
                   "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return "";
            }
        }

        public string correctLine(string line)
        {

            return line.Replace("+", "{+}")
                .Replace("^", "{^}")
                .Replace("%", "{%}")
                .Replace("~", "{~}")
                .Replace("(", "{(}")
                .Replace(")", "{)}")
                .Replace("[", "{[}")
                .Replace("]", "{]}");
        }

        private void preview_TextChanged(object sender, EventArgs e)
        {

        }

        private void min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void controlPanel_Leave(object sender, EventArgs e)
        {

        }

        public void showStopNotification()
        {
            rccNotify.BalloonTipTitle = "Atenção, " + this.nameRCC;
            rccNotify.BalloonTipText = "O script foi pausado com sucesso!";
            rccNotify.ShowBalloonTip(6000);
        }

        private void controlPanel_Load(object sender, EventArgs e)
        {
            rccNotify.BalloonTipTitle = "Bem vindo, " + this.nameRCC;
            rccNotify.BalloonTipText = "Desfrute do programa e seja feliz";
            rccNotify.ShowBalloonTip(6000);
        }
    }
}
