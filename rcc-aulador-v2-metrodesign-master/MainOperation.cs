using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        protected bool isImportProcessComplete = false;

        // Token's definition
        public static Regex SENTENCE_TOKEN = new Regex(@"^>");
        public static Regex TOPIC_TOKEN = new Regex(@"^#");
        public static Regex PAUSE_TOKEN = new Regex(@"^>!!");

        private List<string> titles = new List<string>(); // #!
        private List<Sentence> lines = new List<Sentence>(); // >
        private Militar militar = new Militar();

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

                Task readFileTask = Task.Run(() => {

                    while ((contentByLine = readerFiles.ReadLine()) != null)
                    {
                        if (TOPIC_TOKEN.IsMatch(contentByLine)) titles.Add(contentByLine.Replace("#", ""));

                        if (SENTENCE_TOKEN.IsMatch(contentByLine) && titles.Count != 0) lines.Add(
                            new Sentence(contentByLine
                                .Replace(">", "")
                                .Replace("[Nick]", "")
                                .Replace("[TAG]", ""), titles.Count));
                    }

                    // Release some memory
                    readerFiles.Dispose();
                });

                await readFileTask;

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
                        if(!isImportProcessComplete)
                        {
                            MetroMessageBox.Show(this, "Para utilizador o aulador, é necessário importar algum script. Tente novamente após importar!",
                                "RCC - Aulador", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            metroTabControl1.SelectedIndex = 0;
                        }
                        break;
                    }
            }
        }
    }
}
