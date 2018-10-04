using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rcc_script_system
{
    public partial class Generate : Form
    {
        // Prevent the system to re-create the border in determinate components
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;  //this indicates that the action takes place on the title bar

        public Generate()
        {
            MouseDown += new MouseEventHandler(Move_window); // binding the method to the event
            InitializeComponent();
            inicialConfiguration();
        }

        public void inicialConfiguration()
        {
            preview.Text = "";
            bodyOfTopic.Text = "";
            newTopicDesignation.Text = "";
            preview.Text += "// o programa não irá olhar para estas linhas com '//'\n";
            preview.Text += "// Nome: example\n";
            preview.Text += "// Autor: example\n";
            preview.Text += "// Companhia: example" + "\n\n";

            preview.Text += "// Para titulos, segue-se com um '#!'.  Ex: #!tópico 1" + "\n";
            preview.Text += "// Identificação a aula será identificada com '&'. Exemplo em baixo" + "\n";
            preview.Text += "// Para parar em uma determinada linha acrescente ';;' no final da linha" + "\n\n";
            preview.Text += "// Para colocar a sua TAG, Identifique com um [TAG].  Ex: >Minha TAG: [TAG]" + "\n";
            preview.Text += "// Para colocar o seu Nick, Identifique com um [Nick].  Ex: >Meu nick: [Nick]" + "\n\n";
            preview.Text += "// Para frases, segue com um '>'.  Ex: >linha 1" + "\n\n";
            preview.Text += "&: nome do script" + "\n\n";
            preview.Text += "#!TÓPICO NÚMERO UM\n\n";
            preview.Text += ">Frase número um\n";
            preview.Text += ">Frase número dois\n\n";
        }

        private void Move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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

        private void min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Create a blue-cyan border arround the panel component
            e.Graphics.DrawRectangle(
               new Pen(new SolidBrush(Color.FromArgb(48, 141, 252)), 4), e.ClipRectangle);
            Invalidate();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Create a blue-cyan border arround the panel component
            e.Graphics.DrawRectangle(
               new Pen(new SolidBrush(Color.FromArgb(48, 141, 252)), 4), e.ClipRectangle);
            Invalidate();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {

            if(bodyOfTopic.Text == string.Empty || newTopicDesignation.Text == string.Empty)
            {
                MessageBox.Show("Os dois campos são obrigatórios - tente novamente!",
                    "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            preview.Text += "#!" + newTopicDesignation.Text + "\n\n";

            foreach(string x in bodyOfTopic.Lines)
            {
                if(x != string.Empty)
                     preview.Text += ">" + x + "\n";
            }

            //final
            preview.Text += "\n\n";
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.FileName = "newScript.txt";
            save.Filter = "Text File | *.txt";
            try
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(save.OpenFile(), Encoding.GetEncoding("iso-8859-1"));
                    foreach (string x in preview.Lines)
                    {
                        writer.WriteLine(x);
                    }
                    writer.Dispose();
                    writer.Close();

                    MessageBox.Show("O seu auto-script foi salvo com sucesso!",
                       "RCC - Criar script", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    inicialConfiguration();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lamentamos, ocorreu um erro inesperado!",
                   "Ocorreu um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
