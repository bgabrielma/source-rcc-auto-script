using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rcc_aulador_v2_metrodesign_master
{
    public partial class MainOperation : MetroForm
    {
        protected StreamReader readerFiles;
        protected Bitmap habboImager;
        protected MetroStyleManager metroStyleManager;

        // Modal variables
        protected static string FILE_NAME;
        protected static string SENTENCES;
        protected static int NUM_TOPICS;
        protected static int NUM_SENTENCES;
        protected static Dictionary<int, string> dataSourceVelocidade = new Dictionary<int, string>()
                        {
                            { 6, "6 Segundos" },
                            { 7, "7 Segundos" },
                            { 8, "8 Segundos" },
                            { 9, "9 Segundos" },
                            { 10, "10 Segundos" }
                        };

        protected bool isImportProcessComplete = false;

        // Token's definition
        public static Regex SENTENCE_TOKEN = new Regex(@"^>");
        public static Regex TOPIC_TOKEN = new Regex(@"^#");
        public static Regex PAUSE_TOKEN = new Regex(@"^>!!");

        private List<string> titles = new List<string>(); // #!
        private List<Sentence> lines = new List<Sentence>(); // >
        private Militar militar = new Militar();

        //Aulador system
        private List<Sentence> linesSelectedByTitle = new List<Sentence>();
        private int actualLineId = 0;
        private int valuePerTopicConcluded = 0;

        private bool hasTitleSent;
        private bool isScriptStopped;

        public MainOperation(MetroStyleManager metroStyleManager, Bitmap habboImager, Militar militar)
        {
            this.metroStyleManager = metroStyleManager;
            this.habboImager = habboImager;
            this.militar = militar;

            InitializeComponent();
            configureComponents();
        }

        private void configureComponents()
        {
            StyleManager = metroStyleManager;
            mainOperationManager.Theme = btnStartResume.Theme = btnPause.Theme = importScript.Theme = metroStyleManager.Theme;
            mainOperationManager.Style = metroTabControl1.Style = importScript.Style = btnStartResume.Style = btnPause.Style = metroStyleManager.Style;

            // Select first tab
            metroTabControl1.SelectedIndex = 0;

            //Update militar tile
            tileDadosMilitar.TileImage = habboImager;
            tileDadosMilitar.Text = $"Dados do militar: \n\n {militar.Name} - [{militar.Tag}]";

            Refresh();
        }

        private void MainOperation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }

        private async void metroButton1_Click(object sender, EventArgs e)
        {
            importZone.Focus();
            reset();

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try { 
                    readerFiles = new StreamReader(openFileDialog.FileName, Encoding.GetEncoding("iso-8859-1"), true);
                    lblScriptName.Text = FILE_NAME = openFileDialog.SafeFileName;
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);

                    // Release some memory
                    readerFiles.Dispose();
                }

                string contentByLine = string.Empty;

                // Prevent user access other tabs without script load yet
                metroTabControl1.Enabled = false;

                Task readFileTask = Task.Run(() => {

                    while ((contentByLine = readerFiles.ReadLine()) != null)
                    {
                        if(contentByLine != "")
                        {
                            if (TOPIC_TOKEN.IsMatch(contentByLine)) titles.Add(contentByLine.Replace("#", ""));

                            if (SENTENCE_TOKEN.IsMatch(contentByLine) && titles.Count != 0)
                                lines.Add(new Sentence(contentByLine
                                            .Replace(">", "")
                                            .Replace("[Nick]", "")
                                            .Replace("[TAG]", ""), titles.Count));
                        }
                    }

                    // Release some memory
                    readerFiles.Dispose();
                });

                await readFileTask;
                metroTabControl1.Enabled = true;

                // set NUM_SENTENCES and NUM_TOPICS
                lblScriptSentences.Text = Convert.ToString(NUM_SENTENCES = lines.Count);
                lblScriptTopic.Text = Convert.ToString(NUM_TOPICS =  titles.Count);

                // Fill preview textbox
                fillPreview();

                // Confirm Import Process. This is important in order to use aulador
                isImportProcessComplete = true;
            }
        }

        private void reset()
        {
            titles.Clear();
            lines.Clear();
        }

        private void fillPreview()
        {
            previewBox.Text = "";

           for (int i = 0; i < titles.Count; i++)
            {
                previewBox.Text += titles[i] + "\n\n";
                foreach(Sentence _sentence in lines)
                {
                    if(_sentence.getIdTitle() == i + 1)
                    {
                        previewBox.Text += _sentence.getValueLine() + "\n";
                    }
                }

                previewBox.Text += "\n\n";
            }
        }

        private void MetroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(metroTabControl1.SelectedIndex)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        if (!isImportProcessComplete)
                        {
                            MetroMessageBox.Show(this, "Para utilizador o aulador, é necessário importar algum script. Tente novamente após importar!",
                                "RCC - Aulador", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            metroTabControl1.SelectedIndex = 0;
                        }
                        else initAulador();

                        break;
                    }
            }
        }

        private void initAulador()
        {
            MessageBox.Show("Titulos atuais: " + titles.Count);
            fillCombos();
        }
        
        private void fillCombos() {

            // "refresh" the data source and then reassign this as DataSource again
            comboTitles.DataSource = null;
            comboTitles.DataSource = titles;

            // Instance BindingSource class for describe the key and value in comboBox context
            comboBoxVelocidade.DataSource = new BindingSource(dataSourceVelocidade, null);
            comboBoxVelocidade.DisplayMember = "Key";
            comboBoxVelocidade.DisplayMember = "Value";
        }

        private void BtnStartResume_Click(object sender, EventArgs e)
        {
            if (!isScriptStopped)
            {
                if (MetroMessageBox.Show(this, "O Script dará inicio após clicar no botão OK. Certifique-se que está com o seu balão de fala selecionado no jogo.",
                                    "RCC - Inicio do script", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    == DialogResult.OK)
                {
                    timerScript.Enabled = true;
                    WindowState = FormWindowState.Minimized;
                }
            }
            else
            {
                timerScript.Enabled = true;
                WindowState = FormWindowState.Minimized;
            }
        }

        private void ComboTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            // reset
            richTxtAulador.Text = "";
            linesSelectedByTitle.Clear();

            var index = comboTitles.SelectedIndex;

            richTxtAulador.Text += titles[index] + "\n\n";
            foreach (Sentence _sentence in lines)
            {
                if (_sentence.getIdTitle() == index + 1)
                {
                    richTxtAulador.Text += _sentence.getValueLine() + "\n\n";
                    linesSelectedByTitle.Add(new Sentence(_sentence.getValueLine(), index));
                }
            }
            // set value to atribute in progressbar for each topic concluded
            valuePerTopicConcluded = 100 / titles.Count;
        }

        private void ComboBoxVelocidade_SelectedIndexChanged(object sender, EventArgs e )
        {
           var timerVel = int.Parse(((KeyValuePair<int, string>)comboBoxVelocidade.SelectedValue).Key.ToString());
           timerScript.Interval = (int)TimeSpan.FromSeconds(timerVel).TotalMilliseconds;
        }

        /**
         * 
         * BEGIN AULADOR LOGIC + functions
         * 
         * */

        private void TimerScript_Tick(object sender, EventArgs e)
        {
            sendController();
        }

        private void sendController()
        {
            var _sentence = SendPart(actualLineId);

            if(_sentence != null)
            {
                SendKeys.Send(_sentence);
                SendKeys.Send("+{Enter}");
            }
        }

        private string SendPart(int activePart)
        {
            try
            {
                var _line = string.Empty;
                if (!hasTitleSent)
                {
                    _line = titles[linesSelectedByTitle[activePart].getIdTitle()];
                    hasTitleSent = true;
                }
                else
                {
                    _line = linesSelectedByTitle[activePart].getValueLine();
                    actualLineId++;
                }
                return correctLine(_line);
            }
            catch(ArgumentOutOfRangeException)
            {
                // finish topic
                timerScript.Stop();

                hasTitleSent = false;
                actualLineId = 0;

                btnStartResume.Text = "Começar";
                isScriptStopped = false;

                lblProgressScript.Text = $"{ scriptProgressBar.Value += valuePerTopicConcluded } % de finalização da aula";
                showEndTopicNotification();

                return null;
            }

        }

        private string correctLine(string line)
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

        public void showStopNotification()
        {
            rccNotify.BalloonTipTitle = "Atenção, " + militar.Name;
            rccNotify.BalloonTipText = "O script foi pausado com sucesso!";
            rccNotify.ShowBalloonTip(6000);
        }

        public void showEndOfScript()
        {
            rccNotify.BalloonTipTitle = "Parabéns, " + militar.Name;
            rccNotify.BalloonTipText = "Terminou a sua aula com sucesso!";
            rccNotify.ShowBalloonTip(6000);
        }

        public void showEndTopicNotification()
        {
            rccNotify.BalloonTipTitle = "Atenção, " + militar.Name;
            rccNotify.BalloonTipText = "Este tópico foi finalizado com sucesso!";
            rccNotify.ShowBalloonTip(6000);
        }

        private void RccNotify_BalloonTipClicked(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            timerScript.Stop();
            timerScript.Enabled = false;
            btnStartResume.Text = "Continuar";
            isScriptStopped = true;
        }
    }
}
