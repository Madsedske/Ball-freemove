
namespace Ball_freemove
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
            this.pictureBoxBall = new System.Windows.Forms.PictureBox();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxYdre3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxYdre1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxYdre4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxYdre2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlåFirkant = new System.Windows.Forms.PictureBox();
            this.pictureBoxGulFirkant = new System.Windows.Forms.PictureBox();
            this.pictureBoxGrønFirkant = new System.Windows.Forms.PictureBox();
            this.pictureBoxRødFirkant = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tæller = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxXLocation = new System.Windows.Forms.TextBox();
            this.textBoxYLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.buttonBegin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYdre3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYdre1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYdre4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYdre2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlåFirkant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGulFirkant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrønFirkant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRødFirkant)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxBall
            // 
            this.pictureBoxBall.BackColor = System.Drawing.Color.White;
            this.pictureBoxBall.Location = new System.Drawing.Point(232, 66);
            this.pictureBoxBall.Name = "pictureBoxBall";
            this.pictureBoxBall.Size = new System.Drawing.Size(10, 10);
            this.pictureBoxBall.TabIndex = 0;
            this.pictureBoxBall.TabStop = false;
            // 
            // gametimer
            // 
            this.gametimer.Interval = 10;
            this.gametimer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // pictureBoxYdre3
            // 
            this.pictureBoxYdre3.BackColor = System.Drawing.Color.Red;
            this.pictureBoxYdre3.Location = new System.Drawing.Point(50, 450);
            this.pictureBoxYdre3.Name = "pictureBoxYdre3";
            this.pictureBoxYdre3.Size = new System.Drawing.Size(400, 10);
            this.pictureBoxYdre3.TabIndex = 1;
            this.pictureBoxYdre3.TabStop = false;
            // 
            // pictureBoxYdre1
            // 
            this.pictureBoxYdre1.BackColor = System.Drawing.Color.Green;
            this.pictureBoxYdre1.Location = new System.Drawing.Point(50, 50);
            this.pictureBoxYdre1.Name = "pictureBoxYdre1";
            this.pictureBoxYdre1.Size = new System.Drawing.Size(400, 10);
            this.pictureBoxYdre1.TabIndex = 2;
            this.pictureBoxYdre1.TabStop = false;
            // 
            // pictureBoxYdre4
            // 
            this.pictureBoxYdre4.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxYdre4.Location = new System.Drawing.Point(50, 60);
            this.pictureBoxYdre4.Name = "pictureBoxYdre4";
            this.pictureBoxYdre4.Size = new System.Drawing.Size(10, 390);
            this.pictureBoxYdre4.TabIndex = 3;
            this.pictureBoxYdre4.TabStop = false;
            // 
            // pictureBoxYdre2
            // 
            this.pictureBoxYdre2.BackColor = System.Drawing.Color.Yellow;
            this.pictureBoxYdre2.Location = new System.Drawing.Point(440, 60);
            this.pictureBoxYdre2.Name = "pictureBoxYdre2";
            this.pictureBoxYdre2.Size = new System.Drawing.Size(10, 390);
            this.pictureBoxYdre2.TabIndex = 4;
            this.pictureBoxYdre2.TabStop = false;
            // 
            // pictureBoxBlåFirkant
            // 
            this.pictureBoxBlåFirkant.BackColor = System.Drawing.Color.Blue;
            this.pictureBoxBlåFirkant.Location = new System.Drawing.Point(314, 119);
            this.pictureBoxBlåFirkant.Name = "pictureBoxBlåFirkant";
            this.pictureBoxBlåFirkant.Size = new System.Drawing.Size(82, 50);
            this.pictureBoxBlåFirkant.TabIndex = 5;
            this.pictureBoxBlåFirkant.TabStop = false;
            // 
            // pictureBoxGulFirkant
            // 
            this.pictureBoxGulFirkant.BackColor = System.Drawing.Color.Yellow;
            this.pictureBoxGulFirkant.Location = new System.Drawing.Point(130, 279);
            this.pictureBoxGulFirkant.Name = "pictureBoxGulFirkant";
            this.pictureBoxGulFirkant.Size = new System.Drawing.Size(50, 126);
            this.pictureBoxGulFirkant.TabIndex = 6;
            this.pictureBoxGulFirkant.TabStop = false;
            // 
            // pictureBoxGrønFirkant
            // 
            this.pictureBoxGrønFirkant.BackColor = System.Drawing.Color.Green;
            this.pictureBoxGrønFirkant.Location = new System.Drawing.Point(283, 255);
            this.pictureBoxGrønFirkant.Name = "pictureBoxGrønFirkant";
            this.pictureBoxGrønFirkant.Size = new System.Drawing.Size(90, 90);
            this.pictureBoxGrønFirkant.TabIndex = 7;
            this.pictureBoxGrønFirkant.TabStop = false;
            // 
            // pictureBoxRødFirkant
            // 
            this.pictureBoxRødFirkant.BackColor = System.Drawing.Color.Red;
            this.pictureBoxRødFirkant.Location = new System.Drawing.Point(114, 136);
            this.pictureBoxRødFirkant.Name = "pictureBoxRødFirkant";
            this.pictureBoxRødFirkant.Size = new System.Drawing.Size(128, 55);
            this.pictureBoxRødFirkant.TabIndex = 8;
            this.pictureBoxRødFirkant.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(410, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // Tæller
            // 
            this.Tæller.Interval = 1000;
            this.Tæller.Tick += new System.EventHandler(this.Tæller_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // textBoxXLocation
            // 
            this.textBoxXLocation.Location = new System.Drawing.Point(15, 479);
            this.textBoxXLocation.Name = "textBoxXLocation";
            this.textBoxXLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxXLocation.TabIndex = 11;
            // 
            // textBoxYLocation
            // 
            this.textBoxYLocation.Location = new System.Drawing.Point(121, 479);
            this.textBoxYLocation.Name = "textBoxYLocation";
            this.textBoxYLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxYLocation.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(227, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Angiv startposition";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.ForeColor = System.Drawing.Color.White;
            this.labelX.Location = new System.Drawing.Point(56, 463);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(14, 13);
            this.labelX.TabIndex = 14;
            this.labelX.Text = "X";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.ForeColor = System.Drawing.Color.White;
            this.labelY.Location = new System.Drawing.Point(166, 463);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(14, 13);
            this.labelY.TabIndex = 15;
            this.labelY.Text = "Y";
            // 
            // buttonBegin
            // 
            this.buttonBegin.Location = new System.Drawing.Point(367, 477);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(61, 22);
            this.buttonBegin.TabIndex = 16;
            this.buttonBegin.Text = "Begin";
            this.buttonBegin.UseVisualStyleBackColor = true;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(502, 511);
            this.Controls.Add(this.buttonBegin);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxYLocation);
            this.Controls.Add(this.textBoxXLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxRødFirkant);
            this.Controls.Add(this.pictureBoxGrønFirkant);
            this.Controls.Add(this.pictureBoxGulFirkant);
            this.Controls.Add(this.pictureBoxBlåFirkant);
            this.Controls.Add(this.pictureBoxYdre2);
            this.Controls.Add(this.pictureBoxYdre4);
            this.Controls.Add(this.pictureBoxYdre1);
            this.Controls.Add(this.pictureBoxYdre3);
            this.Controls.Add(this.pictureBoxBall);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYdre3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYdre1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYdre4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYdre2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlåFirkant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGulFirkant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGrønFirkant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRødFirkant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBall;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox pictureBoxYdre3;
        private System.Windows.Forms.PictureBox pictureBoxYdre1;
        private System.Windows.Forms.PictureBox pictureBoxYdre4;
        private System.Windows.Forms.PictureBox pictureBoxYdre2;
        private System.Windows.Forms.PictureBox pictureBoxBlåFirkant;
        private System.Windows.Forms.PictureBox pictureBoxGulFirkant;
        private System.Windows.Forms.PictureBox pictureBoxGrønFirkant;
        private System.Windows.Forms.PictureBox pictureBoxRødFirkant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Tæller;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxXLocation;
        private System.Windows.Forms.TextBox textBoxYLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button buttonBegin;
    }
}

