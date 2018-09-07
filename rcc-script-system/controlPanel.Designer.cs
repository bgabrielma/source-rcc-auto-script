namespace rcc_script_system
{
    partial class controlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlPanel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.min = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rcc_user = new System.Windows.Forms.PictureBox();
            this.rcc_user_tag = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rcc_user_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.preview = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.topicCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.speedCombo = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timerScript = new System.Windows.Forms.Timer(this.components);
            this.btnContinue = new System.Windows.Forms.Button();
            this.rccNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rcc_user)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.min);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 49);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Light", 13F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "RCC - Painel de controle";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(18, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.WaitOnLoad = true;
            // 
            // min
            // 
            this.min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min.Image = ((System.Drawing.Image)(resources.GetObject("min.Image")));
            this.min.InitialImage = ((System.Drawing.Image)(resources.GetObject("min.InitialImage")));
            this.min.Location = new System.Drawing.Point(966, 10);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(28, 32);
            this.min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.min.TabIndex = 1;
            this.min.TabStop = false;
            this.min.WaitOnLoad = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // close
            // 
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.InitialImage = ((System.Drawing.Image)(resources.GetObject("close.InitialImage")));
            this.close.Location = new System.Drawing.Point(1006, 10);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(28, 32);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 0;
            this.close.TabStop = false;
            this.close.WaitOnLoad = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(70)))), ((int)(((byte)(91)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 640);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1048, 5);
            this.panel4.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.rcc_user);
            this.panel2.Controls.Add(this.rcc_user_tag);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.rcc_user_name);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(757, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 109);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // rcc_user
            // 
            this.rcc_user.Location = new System.Drawing.Point(10, 9);
            this.rcc_user.Name = "rcc_user";
            this.rcc_user.Size = new System.Drawing.Size(95, 89);
            this.rcc_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.rcc_user.TabIndex = 15;
            this.rcc_user.TabStop = false;
            // 
            // rcc_user_tag
            // 
            this.rcc_user_tag.AutoSize = true;
            this.rcc_user_tag.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcc_user_tag.ForeColor = System.Drawing.Color.White;
            this.rcc_user_tag.Location = new System.Drawing.Point(166, 69);
            this.rcc_user_tag.Name = "rcc_user_tag";
            this.rcc_user_tag.Size = new System.Drawing.Size(39, 18);
            this.rcc_user_tag.TabIndex = 14;
            this.rcc_user_tag.Text = "[SrG]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(121, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "TAG:";
            // 
            // rcc_user_name
            // 
            this.rcc_user_name.AutoSize = true;
            this.rcc_user_name.Font = new System.Drawing.Font("Montserrat Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rcc_user_name.ForeColor = System.Drawing.Color.White;
            this.rcc_user_name.Location = new System.Drawing.Point(166, 41);
            this.rcc_user_name.Name = "rcc_user_name";
            this.rcc_user_name.Size = new System.Drawing.Size(70, 18);
            this.rcc_user_name.TabIndex = 12;
            this.rcc_user_name.Text = ",SrGabriel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(118, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nick:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 13F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(111, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dados do militar:";
            // 
            // preview
            // 
            this.preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview.Font = new System.Drawing.Font("Montserrat Light", 8.75F);
            this.preview.Location = new System.Drawing.Point(27, 137);
            this.preview.Name = "preview";
            this.preview.ReadOnly = true;
            this.preview.Size = new System.Drawing.Size(704, 468);
            this.preview.TabIndex = 6;
            this.preview.Text = "RCC - Painel de controle auto-script";
            this.preview.TextChanged += new System.EventHandler(this.preview_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(27, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 50);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat Medium", 13F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Apresentação parcial:";
            // 
            // topicCombo
            // 
            this.topicCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.topicCombo.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F);
            this.topicCombo.FormattingEnabled = true;
            this.topicCombo.Location = new System.Drawing.Point(758, 294);
            this.topicCombo.Name = "topicCombo";
            this.topicCombo.Size = new System.Drawing.Size(205, 26);
            this.topicCombo.TabIndex = 8;
            this.topicCombo.SelectedIndexChanged += new System.EventHandler(this.topicCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(755, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selecionar tópico:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(141)))), ((int)(((byte)(252)))));
            this.panel8.Location = new System.Drawing.Point(758, 277);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(126, 1);
            this.panel8.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(141)))), ((int)(((byte)(252)))));
            this.panel5.Location = new System.Drawing.Point(758, 368);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(80, 1);
            this.panel5.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(755, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Velocidade:";
            // 
            // speedCombo
            // 
            this.speedCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speedCombo.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F);
            this.speedCombo.FormattingEnabled = true;
            this.speedCombo.Location = new System.Drawing.Point(758, 385);
            this.speedCombo.Name = "speedCombo";
            this.speedCombo.Size = new System.Drawing.Size(126, 26);
            this.speedCombo.TabIndex = 14;
            this.speedCombo.SelectedIndexChanged += new System.EventHandler(this.speedCombo_SelectedIndexChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.CausesValidation = false;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(141)))), ((int)(((byte)(252)))));
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Montserrat Light", 9.25F);
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(757, 462);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(115, 35);
            this.btnStart.TabIndex = 18;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Começar";
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.White;
            this.btnPause.CausesValidation = false;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(141)))), ((int)(((byte)(252)))));
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Montserrat Medium", 9.25F);
            this.btnPause.ForeColor = System.Drawing.Color.Black;
            this.btnPause.Location = new System.Drawing.Point(757, 519);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(235, 35);
            this.btnPause.TabIndex = 19;
            this.btnPause.TabStop = false;
            this.btnPause.Text = "Pausar";
            this.btnPause.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(141)))), ((int)(((byte)(252)))));
            this.panel6.Location = new System.Drawing.Point(758, 446);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(55, 1);
            this.panel6.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(755, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Opções:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(24)))), ((int)(((byte)(37)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(758, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 34);
            this.button2.TabIndex = 23;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.CausesValidation = false;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(141)))), ((int)(((byte)(252)))));
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Montserrat Light", 9.25F);
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(757, 579);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(235, 35);
            this.btnReset.TabIndex = 24;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Resetar";
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timerScript
            // 
            this.timerScript.Interval = 4500;
            this.timerScript.Tick += new System.EventHandler(this.timerScript_Tick);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.White;
            this.btnContinue.CausesValidation = false;
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(141)))), ((int)(((byte)(252)))));
            this.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Montserrat Light", 9.25F);
            this.btnContinue.ForeColor = System.Drawing.Color.Black;
            this.btnContinue.Location = new System.Drawing.Point(881, 462);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(115, 35);
            this.btnContinue.TabIndex = 25;
            this.btnContinue.TabStop = false;
            this.btnContinue.Text = "Retomar";
            this.btnContinue.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // rccNotify
            // 
            this.rccNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.rccNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("rccNotify.Icon")));
            this.rccNotify.Text = "RCC - Ferramenta de Aulas";
            this.rccNotify.Visible = true;
            // 
            // controlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 645);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.speedCombo);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.topicCombo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.preview);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "controlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[RCC] - Painel de controle";
            this.Load += new System.EventHandler(this.controlPanel_Load);
            this.Shown += new System.EventHandler(this.controlPanel_Shown);
            this.Leave += new System.EventHandler(this.controlPanel_Leave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rcc_user)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox min;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rcc_user_tag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label rcc_user_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox rcc_user;
        private System.Windows.Forms.RichTextBox preview;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox topicCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox speedCombo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timerScript;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.NotifyIcon rccNotify;
    }
}