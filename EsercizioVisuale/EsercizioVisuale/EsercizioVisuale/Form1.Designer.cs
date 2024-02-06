namespace EsercizioVisuale
{
    partial class Visual
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visual));
            this.BtnClose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uccisioni = new System.Windows.Forms.Label();
            this.MoscaButton = new System.Windows.Forms.RadioButton();
            this.FarfallaButton = new System.Windows.Forms.RadioButton();
            this.RagnoButton = new System.Windows.Forms.RadioButton();
            this.ApeButton = new System.Windows.Forms.RadioButton();
            this.BottoneProva = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Location = new System.Drawing.Point(781, 434);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(101, 38);
            this.BtnClose.TabIndex = 0;
            this.BtnClose.Text = "Chiudi";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 430);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(422, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 104);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // uccisioni
            // 
            this.uccisioni.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.uccisioni.AutoSize = true;
            this.uccisioni.Location = new System.Drawing.Point(218, 439);
            this.uccisioni.Name = "uccisioni";
            this.uccisioni.Size = new System.Drawing.Size(50, 13);
            this.uccisioni.TabIndex = 1;
            this.uccisioni.Text = "Uccisioni";
            this.uccisioni.Click += new System.EventHandler(this.uccisioni_Click);
            // 
            // MoscaButton
            // 
            this.MoscaButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MoscaButton.AutoSize = true;
            this.MoscaButton.Location = new System.Drawing.Point(312, 435);
            this.MoscaButton.Name = "MoscaButton";
            this.MoscaButton.Size = new System.Drawing.Size(57, 17);
            this.MoscaButton.TabIndex = 1;
            this.MoscaButton.TabStop = true;
            this.MoscaButton.Text = "Mosca";
            this.MoscaButton.UseVisualStyleBackColor = true;
            this.MoscaButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // FarfallaButton
            // 
            this.FarfallaButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FarfallaButton.AutoSize = true;
            this.FarfallaButton.Location = new System.Drawing.Point(394, 435);
            this.FarfallaButton.Name = "FarfallaButton";
            this.FarfallaButton.Size = new System.Drawing.Size(59, 17);
            this.FarfallaButton.TabIndex = 2;
            this.FarfallaButton.TabStop = true;
            this.FarfallaButton.Text = "Farfalla";
            this.FarfallaButton.UseVisualStyleBackColor = true;
            this.FarfallaButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RagnoButton
            // 
            this.RagnoButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RagnoButton.AutoSize = true;
            this.RagnoButton.Location = new System.Drawing.Point(486, 434);
            this.RagnoButton.Name = "RagnoButton";
            this.RagnoButton.Size = new System.Drawing.Size(57, 17);
            this.RagnoButton.TabIndex = 3;
            this.RagnoButton.TabStop = true;
            this.RagnoButton.Text = "Ragno";
            this.RagnoButton.UseVisualStyleBackColor = true;
            this.RagnoButton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // ApeButton
            // 
            this.ApeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ApeButton.AutoSize = true;
            this.ApeButton.Location = new System.Drawing.Point(578, 435);
            this.ApeButton.Name = "ApeButton";
            this.ApeButton.Size = new System.Drawing.Size(44, 17);
            this.ApeButton.TabIndex = 4;
            this.ApeButton.TabStop = true;
            this.ApeButton.Text = "Ape";
            this.ApeButton.UseVisualStyleBackColor = true;
            this.ApeButton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // BottoneProva
            // 
            this.BottoneProva.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BottoneProva.Location = new System.Drawing.Point(34, 439);
            this.BottoneProva.Name = "BottoneProva";
            this.BottoneProva.Size = new System.Drawing.Size(75, 23);
            this.BottoneProva.TabIndex = 5;
            this.BottoneProva.Text = "Prova";
            this.BottoneProva.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BottoneProva.UseVisualStyleBackColor = true;
            this.BottoneProva.Click += new System.EventHandler(this.BottoneProva_Click);
            // 
            // Visual
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 474);
            this.Controls.Add(this.BottoneProva);
            this.Controls.Add(this.ApeButton);
            this.Controls.Add(this.RagnoButton);
            this.Controls.Add(this.FarfallaButton);
            this.Controls.Add(this.MoscaButton);
            this.Controls.Add(this.uccisioni);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnClose);
            this.Name = "Visual";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Visual_FormClosing);
            this.Load += new System.EventHandler(this.Visual_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label uccisioni;
        private System.Windows.Forms.RadioButton MoscaButton;
        private System.Windows.Forms.RadioButton FarfallaButton;
        private System.Windows.Forms.RadioButton RagnoButton;
        private System.Windows.Forms.RadioButton ApeButton;
        private System.Windows.Forms.Button BottoneProva;
    }
}

