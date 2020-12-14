
namespace FlappyBird
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.boru2 = new System.Windows.Forms.PictureBox();
            this.boru1 = new System.Windows.Forms.PictureBox();
            this.kus = new System.Windows.Forms.PictureBox();
            this.zemin = new System.Windows.Forms.Panel();
            this.boru4 = new System.Windows.Forms.PictureBox();
            this.boru3 = new System.Windows.Forms.PictureBox();
            this.lblSkor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boru2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // boru2
            // 
            this.boru2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boru2.Image = global::FlappyBird.Properties.Resources.pipe;
            this.boru2.Location = new System.Drawing.Point(318, 300);
            this.boru2.Name = "boru2";
            this.boru2.Size = new System.Drawing.Size(100, 165);
            this.boru2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boru2.TabIndex = 2;
            this.boru2.TabStop = false;
            // 
            // boru1
            // 
            this.boru1.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.boru1.Location = new System.Drawing.Point(318, 0);
            this.boru1.Name = "boru1";
            this.boru1.Size = new System.Drawing.Size(100, 135);
            this.boru1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boru1.TabIndex = 1;
            this.boru1.TabStop = false;
            // 
            // kus
            // 
            this.kus.Image = global::FlappyBird.Properties.Resources.bird;
            this.kus.Location = new System.Drawing.Point(73, 131);
            this.kus.Name = "kus";
            this.kus.Size = new System.Drawing.Size(66, 50);
            this.kus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kus.TabIndex = 0;
            this.kus.TabStop = false;
            // 
            // zemin
            // 
            this.zemin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zemin.BackgroundImage = global::FlappyBird.Properties.Resources.ground;
            this.zemin.Location = new System.Drawing.Point(0, 465);
            this.zemin.Name = "zemin";
            this.zemin.Size = new System.Drawing.Size(10000, 129);
            this.zemin.TabIndex = 3;
            // 
            // boru4
            // 
            this.boru4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.boru4.Image = global::FlappyBird.Properties.Resources.pipe;
            this.boru4.Location = new System.Drawing.Point(717, 346);
            this.boru4.Name = "boru4";
            this.boru4.Size = new System.Drawing.Size(100, 119);
            this.boru4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boru4.TabIndex = 6;
            this.boru4.TabStop = false;
            // 
            // boru3
            // 
            this.boru3.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.boru3.Location = new System.Drawing.Point(690, 0);
            this.boru3.Name = "boru3";
            this.boru3.Size = new System.Drawing.Size(100, 193);
            this.boru3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boru3.TabIndex = 5;
            this.boru3.TabStop = false;
            // 
            // lblSkor
            // 
            this.lblSkor.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblSkor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblSkor.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.ForeColor = System.Drawing.Color.Black;
            this.lblSkor.Location = new System.Drawing.Point(0, 485);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(687, 34);
            this.lblSkor.TabIndex = 0;
            this.lblSkor.Text = "Skor: 0";
            this.lblSkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(687, 519);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.boru4);
            this.Controls.Add(this.boru3);
            this.Controls.Add(this.zemin);
            this.Controls.Add(this.boru2);
            this.Controls.Add(this.boru1);
            this.Controls.Add(this.kus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.boru2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boru3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox kus;
        private System.Windows.Forms.PictureBox boru1;
        private System.Windows.Forms.PictureBox boru2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel zemin;
        private System.Windows.Forms.PictureBox boru4;
        private System.Windows.Forms.PictureBox boru3;
        private System.Windows.Forms.Label lblSkor;
    }
}

