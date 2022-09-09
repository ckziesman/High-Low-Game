
namespace Final_CZiesman_HighLowGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.userCard = new System.Windows.Forms.PictureBox();
            this.dealerCard = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.dealerLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.highButton = new System.Windows.Forms.Button();
            this.lowButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "High or Low Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guess if your card is higher or lower than the Dealer\'s card!";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dealerCard);
            this.groupBox1.Location = new System.Drawing.Point(13, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 327);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dealer\'s Card";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userCard);
            this.groupBox2.Location = new System.Drawing.Point(252, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 327);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your Card: ";
            // 
            // userCard
            // 
            this.userCard.Image = global::Final_CZiesman_HighLowGame.Properties.Resources.cardBack;
            this.userCard.Location = new System.Drawing.Point(6, 19);
            this.userCard.Name = "userCard";
            this.userCard.Size = new System.Drawing.Size(203, 303);
            this.userCard.TabIndex = 0;
            this.userCard.TabStop = false;
            // 
            // dealerCard
            // 
            this.dealerCard.Image = global::Final_CZiesman_HighLowGame.Properties.Resources.cardBack;
            this.dealerCard.Location = new System.Drawing.Point(6, 19);
            this.dealerCard.Name = "dealerCard";
            this.dealerCard.Size = new System.Drawing.Size(203, 303);
            this.dealerCard.TabIndex = 0;
            this.dealerCard.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dealer\'s Card: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Your Card: ";
            // 
            // userLabel
            // 
            this.userLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userLabel.Location = new System.Drawing.Point(383, 394);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(25, 23);
            this.userLabel.TabIndex = 5;
            // 
            // dealerLabel
            // 
            this.dealerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dealerLabel.Location = new System.Drawing.Point(138, 394);
            this.dealerLabel.Name = "dealerLabel";
            this.dealerLabel.Size = new System.Drawing.Size(25, 23);
            this.dealerLabel.TabIndex = 5;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(88, 442);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Play!";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(320, 442);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // highButton
            // 
            this.highButton.Enabled = false;
            this.highButton.Location = new System.Drawing.Point(499, 126);
            this.highButton.Name = "highButton";
            this.highButton.Size = new System.Drawing.Size(75, 23);
            this.highButton.TabIndex = 8;
            this.highButton.Text = "High";
            this.highButton.UseVisualStyleBackColor = true;
            this.highButton.Click += new System.EventHandler(this.highButton_Click);
            // 
            // lowButton
            // 
            this.lowButton.Enabled = false;
            this.lowButton.Location = new System.Drawing.Point(499, 278);
            this.lowButton.Name = "lowButton";
            this.lowButton.Size = new System.Drawing.Size(75, 23);
            this.lowButton.TabIndex = 9;
            this.lowButton.Text = "Low";
            this.lowButton.UseVisualStyleBackColor = true;
            this.lowButton.Click += new System.EventHandler(this.lowButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 511);
            this.Controls.Add(this.lowButton);
            this.Controls.Add(this.highButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.dealerLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "High or Low Game";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dealerCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox dealerCard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox userCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label dealerLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button highButton;
        private System.Windows.Forms.Button lowButton;
    }
}

