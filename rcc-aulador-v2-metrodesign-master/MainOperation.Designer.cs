namespace rcc_aulador_v2_metrodesign_master
{
    partial class MainOperation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainOperation));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainOperationManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mainOperationTabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.importZone = new MetroFramework.Controls.MetroTabPage();
            this.importScript = new MetroFramework.Controls.MetroTile();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lblScriptSentences = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblScriptTopic = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblScriptName = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.preVisualizacao = new MetroFramework.Controls.MetroLabel();
            this.previewBox = new System.Windows.Forms.RichTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnPause = new MetroFramework.Controls.MetroButton();
            this.btnStartResume = new MetroFramework.Controls.MetroButton();
            this.tileDadosMilitar = new MetroFramework.Controls.MetroTile();
            this.lblProgressScript = new MetroFramework.Controls.MetroLabel();
            this.scriptProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.comboBoxVelocidade = new MetroFramework.Controls.MetroComboBox();
            this.comboTitles = new MetroFramework.Controls.MetroComboBox();
            this.richTxtAulador = new System.Windows.Forms.RichTextBox();
            this.timerScript = new System.Windows.Forms.Timer(this.components);
            this.rccNotify = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainOperationManager)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.importZone.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text|*.txt|All|*.*";
            // 
            // mainOperationManager
            // 
            this.mainOperationManager.Owner = this;
            this.mainOperationManager.Style = MetroFramework.MetroColorStyle.Yellow;
            // 
            // mainOperationTabControl
            // 
            this.mainOperationTabControl.Location = new System.Drawing.Point(169, 114);
            this.mainOperationTabControl.Name = "mainOperationTabControl";
            this.mainOperationTabControl.Size = new System.Drawing.Size(200, 100);
            this.mainOperationTabControl.TabIndex = 25;
            this.mainOperationTabControl.UseSelectable = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.importZone);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(942, 516);
            this.metroTabControl1.TabIndex = 26;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.MetroTabControl1_SelectedIndexChanged);
            // 
            // importZone
            // 
            this.importZone.Controls.Add(this.importScript);
            this.importZone.Controls.Add(this.metroLabel9);
            this.importZone.Controls.Add(this.metroLabel8);
            this.importZone.Controls.Add(this.lblScriptSentences);
            this.importZone.Controls.Add(this.metroLabel7);
            this.importZone.Controls.Add(this.lblScriptTopic);
            this.importZone.Controls.Add(this.metroLabel5);
            this.importZone.Controls.Add(this.lblScriptName);
            this.importZone.Controls.Add(this.metroLabel2);
            this.importZone.Controls.Add(this.preVisualizacao);
            this.importZone.Controls.Add(this.previewBox);
            this.importZone.HorizontalScrollbarBarColor = true;
            this.importZone.HorizontalScrollbarHighlightOnWheel = false;
            this.importZone.HorizontalScrollbarSize = 10;
            this.importZone.Location = new System.Drawing.Point(4, 38);
            this.importZone.Name = "importZone";
            this.importZone.Size = new System.Drawing.Size(934, 474);
            this.importZone.TabIndex = 0;
            this.importZone.Text = "Importar Script";
            this.importZone.VerticalScrollbarBarColor = true;
            this.importZone.VerticalScrollbarHighlightOnWheel = false;
            this.importZone.VerticalScrollbarSize = 10;
            // 
            // importScript
            // 
            this.importScript.ActiveControl = null;
            this.importScript.BackColor = System.Drawing.Color.Transparent;
            this.importScript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importScript.Location = new System.Drawing.Point(638, 352);
            this.importScript.Name = "importScript";
            this.importScript.Size = new System.Drawing.Size(244, 89);
            this.importScript.TabIndex = 36;
            this.importScript.Text = "Importar script";
            this.importScript.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.importScript.TileImage = global::rcc_aulador_v2_metrodesign_master.Properties.Resources.import__3_;
            this.importScript.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importScript.UseSelectable = true;
            this.importScript.UseTileImage = true;
            this.importScript.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.Location = new System.Drawing.Point(679, 258);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(203, 30);
            this.metroLabel9.TabIndex = 35;
            this.metroLabel9.Text = "edições no ficheiro devem ser feitos no \r\npróprio ficheiro.";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(585, 258);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(95, 15);
            this.metroLabel8.TabIndex = 34;
            this.metroLabel8.Text = "Atenção militar:";
            // 
            // lblScriptSentences
            // 
            this.lblScriptSentences.AutoSize = true;
            this.lblScriptSentences.Location = new System.Drawing.Point(728, 186);
            this.lblScriptSentences.Name = "lblScriptSentences";
            this.lblScriptSentences.Size = new System.Drawing.Size(27, 19);
            this.lblScriptSentences.TabIndex = 32;
            this.lblScriptSentences.Text = "---";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(675, 186);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(44, 15);
            this.metroLabel7.TabIndex = 31;
            this.metroLabel7.Text = "Frases:";
            // 
            // lblScriptTopic
            // 
            this.lblScriptTopic.AutoSize = true;
            this.lblScriptTopic.Location = new System.Drawing.Point(728, 156);
            this.lblScriptTopic.Name = "lblScriptTopic";
            this.lblScriptTopic.Size = new System.Drawing.Size(27, 19);
            this.lblScriptTopic.TabIndex = 30;
            this.lblScriptTopic.Text = "---";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(669, 156);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 15);
            this.metroLabel5.TabIndex = 29;
            this.metroLabel5.Text = "Tópicos:";
            // 
            // lblScriptName
            // 
            this.lblScriptName.AutoSize = true;
            this.lblScriptName.Location = new System.Drawing.Point(728, 125);
            this.lblScriptName.Name = "lblScriptName";
            this.lblScriptName.Size = new System.Drawing.Size(27, 19);
            this.lblScriptName.TabIndex = 28;
            this.lblScriptName.Text = "---";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(677, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 15);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Script:";
            // 
            // preVisualizacao
            // 
            this.preVisualizacao.AutoSize = true;
            this.preVisualizacao.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.preVisualizacao.Location = new System.Drawing.Point(658, 47);
            this.preVisualizacao.Name = "preVisualizacao";
            this.preVisualizacao.Size = new System.Drawing.Size(134, 25);
            this.preVisualizacao.TabIndex = 26;
            this.preVisualizacao.Text = "Pré-visualização";
            // 
            // previewBox
            // 
            this.previewBox.BackColor = System.Drawing.Color.White;
            this.previewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewBox.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewBox.Location = new System.Drawing.Point(1, 11);
            this.previewBox.Margin = new System.Windows.Forms.Padding(10);
            this.previewBox.Name = "previewBox";
            this.previewBox.ReadOnly = true;
            this.previewBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.previewBox.Size = new System.Drawing.Size(535, 460);
            this.previewBox.TabIndex = 25;
            this.previewBox.Text = "";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnPause);
            this.metroTabPage2.Controls.Add(this.btnStartResume);
            this.metroTabPage2.Controls.Add(this.tileDadosMilitar);
            this.metroTabPage2.Controls.Add(this.lblProgressScript);
            this.metroTabPage2.Controls.Add(this.scriptProgressBar);
            this.metroTabPage2.Controls.Add(this.metroLabel3);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.comboBoxVelocidade);
            this.metroTabPage2.Controls.Add(this.comboTitles);
            this.metroTabPage2.Controls.Add(this.richTxtAulador);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(934, 474);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Aulador";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btnPause
            // 
            this.btnPause.Highlight = true;
            this.btnPause.Location = new System.Drawing.Point(762, 400);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(134, 47);
            this.btnPause.TabIndex = 50;
            this.btnPause.Text = "Pausar";
            this.btnPause.UseSelectable = true;
            this.btnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // btnStartResume
            // 
            this.btnStartResume.Highlight = true;
            this.btnStartResume.Location = new System.Drawing.Point(588, 400);
            this.btnStartResume.Name = "btnStartResume";
            this.btnStartResume.Size = new System.Drawing.Size(134, 47);
            this.btnStartResume.TabIndex = 49;
            this.btnStartResume.Text = "Começar";
            this.btnStartResume.UseSelectable = true;
            this.btnStartResume.Click += new System.EventHandler(this.BtnStartResume_Click);
            // 
            // tileDadosMilitar
            // 
            this.tileDadosMilitar.ActiveControl = null;
            this.tileDadosMilitar.Location = new System.Drawing.Point(552, 31);
            this.tileDadosMilitar.Name = "tileDadosMilitar";
            this.tileDadosMilitar.Size = new System.Drawing.Size(382, 99);
            this.tileDadosMilitar.TabIndex = 48;
            this.tileDadosMilitar.Text = ",SrGabriel - [SrG]";
            this.tileDadosMilitar.TileImage = global::rcc_aulador_v2_metrodesign_master.Properties.Resources.logoRCC_strog;
            this.tileDadosMilitar.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tileDadosMilitar.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileDadosMilitar.UseSelectable = true;
            this.tileDadosMilitar.UseTileImage = true;
            // 
            // lblProgressScript
            // 
            this.lblProgressScript.AutoSize = true;
            this.lblProgressScript.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblProgressScript.Location = new System.Drawing.Point(552, 151);
            this.lblProgressScript.Name = "lblProgressScript";
            this.lblProgressScript.Size = new System.Drawing.Size(125, 15);
            this.lblProgressScript.TabIndex = 43;
            this.lblProgressScript.Text = "% de finalização da aula";
            // 
            // scriptProgressBar
            // 
            this.scriptProgressBar.Location = new System.Drawing.Point(552, 172);
            this.scriptProgressBar.Name = "scriptProgressBar";
            this.scriptProgressBar.Size = new System.Drawing.Size(379, 16);
            this.scriptProgressBar.TabIndex = 42;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(552, 226);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(111, 19);
            this.metroLabel3.TabIndex = 41;
            this.metroLabel3.Text = "Selecionar Tópico";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(552, 298);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 40;
            this.metroLabel1.Text = "Velocidade:";
            // 
            // comboBoxVelocidade
            // 
            this.comboBoxVelocidade.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboBoxVelocidade.FormattingEnabled = true;
            this.comboBoxVelocidade.ItemHeight = 19;
            this.comboBoxVelocidade.Location = new System.Drawing.Point(552, 320);
            this.comboBoxVelocidade.Name = "comboBoxVelocidade";
            this.comboBoxVelocidade.Size = new System.Drawing.Size(184, 25);
            this.comboBoxVelocidade.TabIndex = 39;
            this.comboBoxVelocidade.UseSelectable = true;
            this.comboBoxVelocidade.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVelocidade_SelectedIndexChanged);
            // 
            // comboTitles
            // 
            this.comboTitles.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.comboTitles.FormattingEnabled = true;
            this.comboTitles.ItemHeight = 19;
            this.comboTitles.Location = new System.Drawing.Point(552, 248);
            this.comboTitles.Name = "comboTitles";
            this.comboTitles.Size = new System.Drawing.Size(382, 25);
            this.comboTitles.TabIndex = 38;
            this.comboTitles.UseSelectable = true;
            this.comboTitles.SelectedIndexChanged += new System.EventHandler(this.ComboTitles_SelectedIndexChanged);
            // 
            // richTxtAulador
            // 
            this.richTxtAulador.BackColor = System.Drawing.Color.White;
            this.richTxtAulador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTxtAulador.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtAulador.Location = new System.Drawing.Point(1, 11);
            this.richTxtAulador.Margin = new System.Windows.Forms.Padding(10);
            this.richTxtAulador.Name = "richTxtAulador";
            this.richTxtAulador.ReadOnly = true;
            this.richTxtAulador.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTxtAulador.Size = new System.Drawing.Size(535, 460);
            this.richTxtAulador.TabIndex = 37;
            this.richTxtAulador.Text = "";
            // 
            // timerScript
            // 
            this.timerScript.Interval = 6000;
            this.timerScript.Tick += new System.EventHandler(this.TimerScript_Tick);
            // 
            // rccNotify
            // 
            this.rccNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.rccNotify.BalloonTipText = "RCC";
            this.rccNotify.BalloonTipTitle = "RCC";
            this.rccNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("rccNotify.Icon")));
            this.rccNotify.Text = "Clique para expandir o programa!";
            this.rccNotify.Visible = true;
            this.rccNotify.BalloonTipClicked += new System.EventHandler(this.RccNotify_BalloonTipClicked);
            // 
            // MainOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 596);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.mainOperationTabControl);
            this.Name = "MainOperation";
            this.Resizable = false;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "[RCC] - Main Operation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainOperation_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.mainOperationManager)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.importZone.ResumeLayout(false);
            this.importZone.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MetroFramework.Components.MetroStyleManager mainOperationManager;
        private MetroFramework.Controls.MetroTabControl mainOperationTabControl;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage importZone;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblScriptSentences;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblScriptTopic;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblScriptName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel preVisualizacao;
        private System.Windows.Forms.RichTextBox previewBox;
        private MetroFramework.Controls.MetroTile importScript;
        private MetroFramework.Controls.MetroComboBox comboBoxVelocidade;
        private MetroFramework.Controls.MetroComboBox comboTitles;
        private System.Windows.Forms.RichTextBox richTxtAulador;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblProgressScript;
        private MetroFramework.Controls.MetroProgressBar scriptProgressBar;
        private MetroFramework.Controls.MetroTile tileDadosMilitar;
        private MetroFramework.Controls.MetroButton btnPause;
        private MetroFramework.Controls.MetroButton btnStartResume;
        private System.Windows.Forms.Timer timerScript;
        private System.Windows.Forms.NotifyIcon rccNotify;
    }
}