using System.ComponentModel;

namespace Arkanoid
{
    partial class Menu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPlay = new System.Windows.Forms.Label();
            this.labelTop = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.7384F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.26257F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.45251F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.672609F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 298F));
            this.tableLayoutPanel1.Controls.Add(this.labelPlay, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelTop, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelExit, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.44118F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.558824F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(748, 514);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelPlay
            // 
            this.labelPlay.BackColor = System.Drawing.Color.Transparent;
            this.labelPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPlay.Font = new System.Drawing.Font("Blader", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelPlay.ForeColor = System.Drawing.Color.White;
            this.labelPlay.Location = new System.Drawing.Point(150, 83);
            this.labelPlay.Name = "labelPlay";
            this.labelPlay.Size = new System.Drawing.Size(270, 130);
            this.labelPlay.TabIndex = 4;
            this.labelPlay.Text = "Play";
            this.labelPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlay.Click += new System.EventHandler(this.labelPlay_Click);
            this.labelPlay.MouseLeave += new System.EventHandler(this.labelPlay_MouseLeave);
            this.labelPlay.MouseHover += new System.EventHandler(this.labelPlay_MouseHover);
            // 
            // labelTop
            // 
            this.labelTop.BackColor = System.Drawing.Color.Transparent;
            this.labelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTop.Font = new System.Drawing.Font("Blader", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelTop.ForeColor = System.Drawing.Color.White;
            this.labelTop.Location = new System.Drawing.Point(150, 241);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(270, 125);
            this.labelTop.TabIndex = 1;
            this.labelTop.Text = "top 10";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTop.Click += new System.EventHandler(this.labelTop_Click);
            this.labelTop.MouseLeave += new System.EventHandler(this.labelTop_MouseLeave);
            this.labelTop.MouseHover += new System.EventHandler(this.labelTop_MouseHover);
            // 
            // labelExit
            // 
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelExit.Font = new System.Drawing.Font("Blader", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelExit.ForeColor = System.Drawing.Color.White;
            this.labelExit.Location = new System.Drawing.Point(150, 392);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(270, 104);
            this.labelExit.TabIndex = 0;
            this.labelExit.Text = "Exit";
            this.labelExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            this.labelExit.MouseLeave += new System.EventHandler(this.labelExit_MouseLeave);
            this.labelExit.MouseHover += new System.EventHandler(this.labelExit_MouseHover);
            // 
            // pictureBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 3);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(748, 514);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelPlay;
        private System.Windows.Forms.Label labelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}