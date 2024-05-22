namespace ChatBotProject
{
    partial class FirstPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPage));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pbxBotGif = new System.Windows.Forms.PictureBox();
            this.pbxSmoke = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblProgrammer = new System.Windows.Forms.Label();
            this.lblBuildVersion = new System.Windows.Forms.Label();
            this.lblKAI = new System.Windows.Forms.Label();
            this.lblInitializingDatabase = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.progressbar = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSmoke)).BeginInit();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 23;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pbxBotGif
            // 
            this.pbxBotGif.BackColor = System.Drawing.Color.Transparent;
            this.pbxBotGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxBotGif.Image = global::ChatBotProject.Properties.Resources.AI_Icon;
            this.pbxBotGif.Location = new System.Drawing.Point(345, 69);
            this.pbxBotGif.Name = "pbxBotGif";
            this.pbxBotGif.Size = new System.Drawing.Size(110, 92);
            this.pbxBotGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBotGif.TabIndex = 8;
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
            this.pbxSmoke.Size = new System.Drawing.Size(816, 419);
            this.pbxSmoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSmoke.TabIndex = 7;
            this.pbxSmoke.TabStop = false;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.lblSlogan);
            this.panelForm.Controls.Add(this.lblProgrammer);
            this.panelForm.Controls.Add(this.lblBuildVersion);
            this.panelForm.Controls.Add(this.lblKAI);
            this.panelForm.Controls.Add(this.lblInitializingDatabase);
            this.panelForm.Controls.Add(this.lblPercentage);
            this.panelForm.Controls.Add(this.pbxBotGif);
            this.panelForm.Controls.Add(this.progressbar);
            this.panelForm.Controls.Add(this.pbxSmoke);
            this.panelForm.Location = new System.Drawing.Point(0, -11);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(816, 419);
            this.panelForm.TabIndex = 9;
            // 
            // lblSlogan
            // 
            this.lblSlogan.BackColor = System.Drawing.Color.Transparent;
            this.lblSlogan.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.White;
            this.lblSlogan.Location = new System.Drawing.Point(274, 232);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(252, 24);
            this.lblSlogan.TabIndex = 16;
            this.lblSlogan.Text = "Chatbot for CpE Students";
            this.lblSlogan.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProgrammer
            // 
            this.lblProgrammer.BackColor = System.Drawing.Color.Transparent;
            this.lblProgrammer.Font = new System.Drawing.Font("Monospac821 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgrammer.ForeColor = System.Drawing.Color.White;
            this.lblProgrammer.Location = new System.Drawing.Point(708, 11);
            this.lblProgrammer.Name = "lblProgrammer";
            this.lblProgrammer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProgrammer.Size = new System.Drawing.Size(106, 51);
            this.lblProgrammer.TabIndex = 15;
            this.lblProgrammer.Text = "programmed by: Jaier Dojoles BSCPE - 2";
            // 
            // lblBuildVersion
            // 
            this.lblBuildVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblBuildVersion.Font = new System.Drawing.Font("Monospac821 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuildVersion.ForeColor = System.Drawing.Color.White;
            this.lblBuildVersion.Location = new System.Drawing.Point(3, 11);
            this.lblBuildVersion.Name = "lblBuildVersion";
            this.lblBuildVersion.Size = new System.Drawing.Size(139, 21);
            this.lblBuildVersion.TabIndex = 14;
            this.lblBuildVersion.Text = "Beta Build v.1.2";
            // 
            // lblKAI
            // 
            this.lblKAI.BackColor = System.Drawing.Color.Transparent;
            this.lblKAI.Font = new System.Drawing.Font("Monospac821 BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKAI.ForeColor = System.Drawing.Color.White;
            this.lblKAI.Location = new System.Drawing.Point(219, 184);
            this.lblKAI.Name = "lblKAI";
            this.lblKAI.Size = new System.Drawing.Size(361, 38);
            this.lblKAI.TabIndex = 13;
            this.lblKAI.Text = "Knowledgeable A.I.";
            this.lblKAI.Click += new System.EventHandler(this.lblKAI_Click);
            // 
            // lblInitializingDatabase
            // 
            this.lblInitializingDatabase.Font = new System.Drawing.Font("Monospac821 BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitializingDatabase.ForeColor = System.Drawing.Color.White;
            this.lblInitializingDatabase.Location = new System.Drawing.Point(4, 365);
            this.lblInitializingDatabase.Name = "lblInitializingDatabase";
            this.lblInitializingDatabase.Size = new System.Drawing.Size(336, 18);
            this.lblInitializingDatabase.TabIndex = 12;
            // 
            // lblPercentage
            // 
            this.lblPercentage.Font = new System.Drawing.Font("Monospac821 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.ForeColor = System.Drawing.Color.White;
            this.lblPercentage.Location = new System.Drawing.Point(763, 360);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(53, 23);
            this.lblPercentage.TabIndex = 11;
            // 
            // progressbar
            // 
            this.progressbar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.progressbar.Location = new System.Drawing.Point(0, 381);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(10, 20);
            this.progressbar.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 7;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(816, 391);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstPage";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstPage";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBotGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSmoke)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pbxSmoke;
        private System.Windows.Forms.PictureBox pbxBotGif;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel progressbar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblInitializingDatabase;
        private System.Windows.Forms.Label lblProgrammer;
        private System.Windows.Forms.Label lblBuildVersion;
        private System.Windows.Forms.Label lblKAI;
        private System.Windows.Forms.Label lblSlogan;
    }
}