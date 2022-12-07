namespace FinalExam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblStoryText = new System.Windows.Forms.Label();
            this.picBigImage = new System.Windows.Forms.PictureBox();
            this.lblAuto = new System.Windows.Forms.Label();
            this.btnNextScene = new System.Windows.Forms.Button();
            this.tmrAutoScene = new System.Windows.Forms.Timer(this.components);
            this.lblDialogue = new System.Windows.Forms.Label();
            this.chkAssault = new System.Windows.Forms.CheckBox();
            this.chkSubstancePoss = new System.Windows.Forms.CheckBox();
            this.chkTheft = new System.Windows.Forms.CheckBox();
            this.chkFirearmPoss = new System.Windows.Forms.CheckBox();
            this.chkInfluencedDriving = new System.Windows.Forms.CheckBox();
            this.chkCriminalMischief = new System.Windows.Forms.CheckBox();
            this.chkRecklessEndanger = new System.Windows.Forms.CheckBox();
            this.chkManslaughter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBigImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStoryText
            // 
            this.lblStoryText.AutoSize = true;
            this.lblStoryText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStoryText.Location = new System.Drawing.Point(12, 9);
            this.lblStoryText.Name = "lblStoryText";
            this.lblStoryText.Size = new System.Drawing.Size(198, 21);
            this.lblStoryText.TabIndex = 0;
            this.lblStoryText.Text = "Welcome to Saul Simulator";
            // 
            // picBigImage
            // 
            this.picBigImage.Image = global::FinalExam.Properties.Resources.saul;
            this.picBigImage.Location = new System.Drawing.Point(12, 12);
            this.picBigImage.Name = "picBigImage";
            this.picBigImage.Size = new System.Drawing.Size(776, 426);
            this.picBigImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBigImage.TabIndex = 1;
            this.picBigImage.TabStop = false;
            // 
            // lblAuto
            // 
            this.lblAuto.AutoSize = true;
            this.lblAuto.Location = new System.Drawing.Point(662, 408);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(126, 30);
            this.lblAuto.TabIndex = 2;
            this.lblAuto.Text = "Auto False\r\nPress Spacebar to auto";
            // 
            // btnNextScene
            // 
            this.btnNextScene.Location = new System.Drawing.Point(12, 415);
            this.btnNextScene.Name = "btnNextScene";
            this.btnNextScene.Size = new System.Drawing.Size(75, 23);
            this.btnNextScene.TabIndex = 3;
            this.btnNextScene.Text = "Start Scene";
            this.btnNextScene.UseVisualStyleBackColor = true;
            this.btnNextScene.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_Keypress);
            this.btnNextScene.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnNextScene_Click);
            // 
            // tmrAutoScene
            // 
            this.tmrAutoScene.Interval = 150;
            this.tmrAutoScene.Tick += new System.EventHandler(this.tmrAutoScene_Tick);
            // 
            // lblDialogue
            // 
            this.lblDialogue.AutoSize = true;
            this.lblDialogue.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDialogue.Location = new System.Drawing.Point(539, 95);
            this.lblDialogue.Name = "lblDialogue";
            this.lblDialogue.Size = new System.Drawing.Size(38, 15);
            this.lblDialogue.TabIndex = 4;
            this.lblDialogue.Text = "label1";
            // 
            // chkAssault
            // 
            this.chkAssault.AutoSize = true;
            this.chkAssault.Location = new System.Drawing.Point(200, 113);
            this.chkAssault.Name = "chkAssault";
            this.chkAssault.Size = new System.Drawing.Size(64, 19);
            this.chkAssault.TabIndex = 5;
            this.chkAssault.Text = "Assault";
            this.chkAssault.UseVisualStyleBackColor = true;
            this.chkAssault.Click += new System.EventHandler(this.checkboxClick);
            this.chkAssault.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_Keypress);
            // 
            // chkSubstancePoss
            // 
            this.chkSubstancePoss.AutoSize = true;
            this.chkSubstancePoss.Location = new System.Drawing.Point(376, 113);
            this.chkSubstancePoss.Name = "chkSubstancePoss";
            this.chkSubstancePoss.Size = new System.Drawing.Size(158, 19);
            this.chkSubstancePoss.TabIndex = 6;
            this.chkSubstancePoss.Text = "Possession of substances";
            this.chkSubstancePoss.UseVisualStyleBackColor = true;
            this.chkSubstancePoss.Click += new System.EventHandler(this.checkboxClick);
            this.chkSubstancePoss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_Keypress);
            // 
            // chkTheft
            // 
            this.chkTheft.AutoSize = true;
            this.chkTheft.Location = new System.Drawing.Point(200, 146);
            this.chkTheft.Name = "chkTheft";
            this.chkTheft.Size = new System.Drawing.Size(120, 19);
            this.chkTheft.TabIndex = 7;
            this.chkTheft.Text = "Theft under $5000";
            this.chkTheft.UseVisualStyleBackColor = true;
            this.chkTheft.Click += new System.EventHandler(this.checkboxClick);
            this.chkTheft.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_Keypress);
            // 
            // chkFirearmPoss
            // 
            this.chkFirearmPoss.AutoSize = true;
            this.chkFirearmPoss.Location = new System.Drawing.Point(376, 146);
            this.chkFirearmPoss.Name = "chkFirearmPoss";
            this.chkFirearmPoss.Size = new System.Drawing.Size(145, 19);
            this.chkFirearmPoss.TabIndex = 8;
            this.chkFirearmPoss.Text = "Possession of Firearms";
            this.chkFirearmPoss.UseVisualStyleBackColor = true;
            this.chkFirearmPoss.Click += new System.EventHandler(this.checkboxClick);
            this.chkFirearmPoss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_Keypress);
            // 
            // chkInfluencedDriving
            // 
            this.chkInfluencedDriving.AutoSize = true;
            this.chkInfluencedDriving.Location = new System.Drawing.Point(200, 186);
            this.chkInfluencedDriving.Name = "chkInfluencedDriving";
            this.chkInfluencedDriving.Size = new System.Drawing.Size(170, 19);
            this.chkInfluencedDriving.TabIndex = 9;
            this.chkInfluencedDriving.Text = "Driving under the influence";
            this.chkInfluencedDriving.UseVisualStyleBackColor = true;
            this.chkInfluencedDriving.Click += new System.EventHandler(this.checkboxClick);
            this.chkInfluencedDriving.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_Keypress);
            // 
            // chkCriminalMischief
            // 
            this.chkCriminalMischief.AutoSize = true;
            this.chkCriminalMischief.Location = new System.Drawing.Point(376, 186);
            this.chkCriminalMischief.Name = "chkCriminalMischief";
            this.chkCriminalMischief.Size = new System.Drawing.Size(119, 19);
            this.chkCriminalMischief.TabIndex = 10;
            this.chkCriminalMischief.Text = "Criminal Mischief";
            this.chkCriminalMischief.UseVisualStyleBackColor = true;
            this.chkCriminalMischief.Click += new System.EventHandler(this.checkboxClick);
            this.chkCriminalMischief.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_Keypress);
            // 
            // chkRecklessEndanger
            // 
            this.chkRecklessEndanger.AutoSize = true;
            this.chkRecklessEndanger.Location = new System.Drawing.Point(200, 230);
            this.chkRecklessEndanger.Name = "chkRecklessEndanger";
            this.chkRecklessEndanger.Size = new System.Drawing.Size(151, 19);
            this.chkRecklessEndanger.TabIndex = 11;
            this.chkRecklessEndanger.Text = "Reckless Endangerment";
            this.chkRecklessEndanger.UseVisualStyleBackColor = true;
            this.chkRecklessEndanger.Click += new System.EventHandler(this.checkboxClick);
            this.chkRecklessEndanger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_Keypress);
            // 
            // chkManslaughter
            // 
            this.chkManslaughter.AutoSize = true;
            this.chkManslaughter.Location = new System.Drawing.Point(376, 230);
            this.chkManslaughter.Name = "chkManslaughter";
            this.chkManslaughter.Size = new System.Drawing.Size(99, 19);
            this.chkManslaughter.TabIndex = 12;
            this.chkManslaughter.Text = "Manslaughter";
            this.chkManslaughter.UseVisualStyleBackColor = true;
            this.chkManslaughter.Click += new System.EventHandler(this.checkboxClick);
            this.chkManslaughter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_Keypress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkManslaughter);
            this.Controls.Add(this.chkRecklessEndanger);
            this.Controls.Add(this.chkCriminalMischief);
            this.Controls.Add(this.chkInfluencedDriving);
            this.Controls.Add(this.chkFirearmPoss);
            this.Controls.Add(this.chkTheft);
            this.Controls.Add(this.chkSubstancePoss);
            this.Controls.Add(this.chkAssault);
            this.Controls.Add(this.lblDialogue);
            this.Controls.Add(this.btnNextScene);
            this.Controls.Add(this.lblAuto);
            this.Controls.Add(this.lblStoryText);
            this.Controls.Add(this.picBigImage);
            this.Name = "Form1";
            this.Text = "Saul Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            ((System.ComponentModel.ISupportInitialize)(this.picBigImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStoryText;
        private PictureBox picBigImage;
        private Label lblAuto;
        private Button btnNextScene;
        private System.Windows.Forms.Timer tmrAutoScene;
        private Label lblDialogue;
        private CheckBox chkAssault;
        private CheckBox chkSubstancePoss;
        private CheckBox chkTheft;
        private CheckBox chkFirearmPoss;
        private CheckBox chkInfluencedDriving;
        private CheckBox chkCriminalMischief;
        private CheckBox chkRecklessEndanger;
        private CheckBox chkManslaughter;
    }
}