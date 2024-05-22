namespace ChatBotProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtTyping = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.InputTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bubble1 = new ChatBotProject.bubble();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleVoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbxBotGif = new System.Windows.Forms.PictureBox();
            this.pbxSmoke = new System.Windows.Forms.PictureBox();
            this.lblListening = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnVoiceRecognition = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.menuButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDisableVoiceRecognition = new Bunifu.Framework.UI.BunifuImageButton();
            this.sqLiteCommandBuilder1 = new System.Data.SQLite.SQLiteCommandBuilder();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSmoke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoiceRecognition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDisableVoiceRecognition)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTyping
            // 
            this.txtTyping.AutoSize = true;
            this.txtTyping.BackColor = System.Drawing.Color.Transparent;
            this.txtTyping.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTyping.ForeColor = System.Drawing.Color.PowderBlue;
            this.txtTyping.Location = new System.Drawing.Point(12, 590);
            this.txtTyping.Name = "txtTyping";
            this.txtTyping.Size = new System.Drawing.Size(96, 13);
            this.txtTyping.TabIndex = 3;
            this.txtTyping.Text = "C.A.I. is thinking...";
            this.txtTyping.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnMinimized);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 34);
            this.panel1.TabIndex = 4;
            // 
            // btnMinimized
            // 
            this.btnMinimized.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimized.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimized.BackgroundImage")));
            this.btnMinimized.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.Location = new System.Drawing.Point(649, 8);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(20, 20);
            this.btnMinimized.TabIndex = 5;
            this.btnMinimized.UseVisualStyleBackColor = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "K.A.I.";
            // 
            // btnClose
            // 
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(673, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 20);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // InputTxt
            // 
            this.InputTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.InputTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InputTxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InputTxt.HintForeColor = System.Drawing.Color.White;
            this.InputTxt.HintText = "Enter Text Here...";
            this.InputTxt.isPassword = false;
            this.InputTxt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InputTxt.LineIdleColor = System.Drawing.Color.SteelBlue;
            this.InputTxt.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.InputTxt.LineThickness = 4;
            this.InputTxt.Location = new System.Drawing.Point(131, 548);
            this.InputTxt.Margin = new System.Windows.Forms.Padding(4);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new System.Drawing.Size(496, 44);
            this.InputTxt.TabIndex = 5;
            this.InputTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InputTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTxt_KeyDown);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bubble1);
            this.panel2.Location = new System.Drawing.Point(5, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 406);
            this.panel2.TabIndex = 7;
            // 
            // bubble1
            // 
            this.bubble1.AutoSize = true;
            this.bubble1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bubble1.BackColor = System.Drawing.Color.LightSlateGray;
            this.bubble1.Location = new System.Drawing.Point(4, 4);
            this.bubble1.Margin = new System.Windows.Forms.Padding(4);
            this.bubble1.Name = "bubble1";
            this.bubble1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.bubble1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bubble1.Size = new System.Drawing.Size(214, 37);
            this.bubble1.TabIndex = 3;
            this.bubble1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearChatToolStripMenuItem,
            this.toggleVoiceToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 56);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // clearChatToolStripMenuItem
            // 
            this.clearChatToolStripMenuItem.Image = global::ChatBotProject.Properties.Resources.Red_Circle;
            this.clearChatToolStripMenuItem.Name = "clearChatToolStripMenuItem";
            this.clearChatToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.clearChatToolStripMenuItem.Text = "Clear Chat";
            this.clearChatToolStripMenuItem.Click += new System.EventHandler(this.clearChatToolStripMenuItem_Click);
            // 
            // toggleVoiceToolStripMenuItem
            // 
            this.toggleVoiceToolStripMenuItem.CheckOnClick = true;
            this.toggleVoiceToolStripMenuItem.Image = global::ChatBotProject.Properties.Resources.Woman_Singer;
            this.toggleVoiceToolStripMenuItem.Name = "toggleVoiceToolStripMenuItem";
            this.toggleVoiceToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.toggleVoiceToolStripMenuItem.Text = "Bot Voice";
            this.toggleVoiceToolStripMenuItem.Click += new System.EventHandler(this.toggleVoiceToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(119, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "K.A.I";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monospac821 BT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(122, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Knowledgeable A.I.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pbxBotGif);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pbxSmoke);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(703, 96);
            this.panel3.TabIndex = 9;
            // 
            // pbxBotGif
            // 
            this.pbxBotGif.BackColor = System.Drawing.Color.Transparent;
            this.pbxBotGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxBotGif.Image = global::ChatBotProject.Properties.Resources.AI_Icon;
            this.pbxBotGif.Location = new System.Drawing.Point(21, 15);
            this.pbxBotGif.Name = "pbxBotGif";
            this.pbxBotGif.Size = new System.Drawing.Size(67, 61);
            this.pbxBotGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBotGif.TabIndex = 0;
            this.pbxBotGif.TabStop = false;
            // 
            // pbxSmoke
            // 
            this.pbxSmoke.BackColor = System.Drawing.Color.Transparent;
            this.pbxSmoke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxSmoke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxSmoke.Image = global::ChatBotProject.Properties.Resources.Smoke;
            this.pbxSmoke.Location = new System.Drawing.Point(0, 0);
            this.pbxSmoke.Name = "pbxSmoke";
            this.pbxSmoke.Size = new System.Drawing.Size(703, 96);
            this.pbxSmoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSmoke.TabIndex = 6;
            this.pbxSmoke.TabStop = false;
            // 
            // lblListening
            // 
            this.lblListening.AutoSize = true;
            this.lblListening.BackColor = System.Drawing.Color.Transparent;
            this.lblListening.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListening.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblListening.Location = new System.Drawing.Point(635, 590);
            this.lblListening.Name = "lblListening";
            this.lblListening.Size = new System.Drawing.Size(60, 13);
            this.lblListening.TabIndex = 10;
            this.lblListening.Text = "Listening...";
            this.lblListening.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 9000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 180;
            // 
            // btnVoiceRecognition
            // 
            this.btnVoiceRecognition.BackColor = System.Drawing.Color.Transparent;
            this.btnVoiceRecognition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoiceRecognition.Image = global::ChatBotProject.Properties.Resources.AddRecord;
            this.btnVoiceRecognition.ImageActive = null;
            this.btnVoiceRecognition.Location = new System.Drawing.Point(58, 547);
            this.btnVoiceRecognition.Name = "btnVoiceRecognition";
            this.btnVoiceRecognition.Size = new System.Drawing.Size(30, 45);
            this.btnVoiceRecognition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVoiceRecognition.TabIndex = 11;
            this.btnVoiceRecognition.TabStop = false;
            this.toolTip1.SetToolTip(this.btnVoiceRecognition, "[BETA] The speech recognizer may struggle to understand poorly pronounced dictati" +
        "on.");
            this.btnVoiceRecognition.Zoom = 10;
            this.btnVoiceRecognition.Click += new System.EventHandler(this.btnVoiceRecognition_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::ChatBotProject.Properties.Resources.Send;
            this.button1.ImageActive = null;
            this.button1.Location = new System.Drawing.Point(637, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 44);
            this.button1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.toolTip2.SetToolTip(this.button1, "Click to send message.");
            this.button1.Zoom = 10;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::ChatBotProject.Properties.Resources.Menu;
            this.menuButton.ImageActive = null;
            this.menuButton.Location = new System.Drawing.Point(11, 548);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(40, 44);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 8;
            this.menuButton.TabStop = false;
            this.toolTip3.SetToolTip(this.menuButton, "Menu Button.");
            this.menuButton.Zoom = 10;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // btnDisableVoiceRecognition
            // 
            this.btnDisableVoiceRecognition.BackColor = System.Drawing.Color.Transparent;
            this.btnDisableVoiceRecognition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisableVoiceRecognition.Image = global::ChatBotProject.Properties.Resources.Mute_Unmute;
            this.btnDisableVoiceRecognition.ImageActive = null;
            this.btnDisableVoiceRecognition.Location = new System.Drawing.Point(94, 547);
            this.btnDisableVoiceRecognition.Name = "btnDisableVoiceRecognition";
            this.btnDisableVoiceRecognition.Size = new System.Drawing.Size(30, 45);
            this.btnDisableVoiceRecognition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDisableVoiceRecognition.TabIndex = 12;
            this.btnDisableVoiceRecognition.TabStop = false;
            this.toolTip4.SetToolTip(this.btnDisableVoiceRecognition, "Disable Speech Recognition.");
            this.btnDisableVoiceRecognition.Zoom = 10;
            this.btnDisableVoiceRecognition.Click += new System.EventHandler(this.btnDisableVoiceRecognition_Click);
            // 
            // sqLiteCommandBuilder1
            // 
            this.sqLiteCommandBuilder1.DataAdapter = null;
            this.sqLiteCommandBuilder1.QuoteSuffix = "]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(157, 593);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(406, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "K.A.I. can make mistakes. Consider checking your input/s.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 608);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDisableVoiceRecognition);
            this.Controls.Add(this.btnVoiceRecognition);
            this.Controls.Add(this.lblListening);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTyping);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatBot";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSmoke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoiceRecognition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDisableVoiceRecognition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtTyping;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox InputTxt;
        private Bunifu.Framework.UI.BunifuImageButton button1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private bubble bubble1;
        private Bunifu.Framework.UI.BunifuImageButton menuButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleVoiceToolStripMenuItem;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxBotGif;
        private System.Windows.Forms.PictureBox pbxSmoke;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblListening;
        private Bunifu.Framework.UI.BunifuImageButton btnVoiceRecognition;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private Bunifu.Framework.UI.BunifuImageButton btnDisableVoiceRecognition;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Data.SQLite.SQLiteCommandBuilder sqLiteCommandBuilder1;
        private System.Windows.Forms.Label label4;
    }
}

