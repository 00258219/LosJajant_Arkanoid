using System.ComponentModel;

namespace Arkanoid
{
    partial class Top10
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
            this.lbltop10 = new System.Windows.Forms.TableLayoutPanel();
            this.btnback = new System.Windows.Forms.Button();
            this.labPlayers = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labTop10 = new System.Windows.Forms.Label();
            this.lbltop10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltop10
            // 
            this.lbltop10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lbltop10.ColumnCount = 6;
            this.lbltop10.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.08428F));
            this.lbltop10.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.35763F));
            this.lbltop10.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.542141F));
            this.lbltop10.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.89522F));
            this.lbltop10.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.150342F));
            this.lbltop10.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.74641F));
            this.lbltop10.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.lbltop10.Controls.Add(this.btnback, 0, 0);
            this.lbltop10.Controls.Add(this.labPlayers, 1, 2);
            this.lbltop10.Controls.Add(this.labScore, 3, 2);
            this.lbltop10.Controls.Add(this.pictureBox1, 4, 0);
            this.lbltop10.Controls.Add(this.labTop10, 1, 0);
            this.lbltop10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltop10.Location = new System.Drawing.Point(0, 0);
            this.lbltop10.Margin = new System.Windows.Forms.Padding(0);
            this.lbltop10.Name = "lbltop10";
            this.lbltop10.RowCount = 4;
            this.lbltop10.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.81481F));
            this.lbltop10.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.053498F));
            this.lbltop10.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.19728F));
            this.lbltop10.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.835909F));
            this.lbltop10.Size = new System.Drawing.Size(878, 729);
            this.lbltop10.TabIndex = 0;
            // 
            // btnback
            // 
            this.btnback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnback.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnback.Location = new System.Drawing.Point(27, 27);
            this.btnback.Margin = new System.Windows.Forms.Padding(0);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(96, 53);
            this.btnback.TabIndex = 4;
            this.btnback.Text = "GO BACK";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // labPlayers
            // 
            this.labPlayers.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (7)))), ((int) (((byte) (0)))),
                ((int) (((byte) (48)))));
            this.labPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labPlayers.Font = new System.Drawing.Font("Blader", 36F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labPlayers.ForeColor = System.Drawing.Color.White;
            this.labPlayers.Location = new System.Drawing.Point(153, 174);
            this.labPlayers.Name = "labPlayers";
            this.labPlayers.Padding = new System.Windows.Forms.Padding(75, 0, 0, 0);
            this.labPlayers.Size = new System.Drawing.Size(322, 526);
            this.labPlayers.TabIndex = 2;
            this.labPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labScore
            // 
            this.labScore.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (7)))), ((int) (((byte) (0)))),
                ((int) (((byte) (48)))));
            this.lbltop10.SetColumnSpan(this.labScore, 2);
            this.labScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labScore.Font = new System.Drawing.Font("Blader", 36F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labScore.ForeColor = System.Drawing.Color.White;
            this.labScore.Location = new System.Drawing.Point(556, 174);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(170, 526);
            this.labScore.TabIndex = 3;
            this.labScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.lbltop10.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(675, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0, 6, 6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labTop10
            // 
            this.labTop10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labTop10.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (7)))), ((int) (((byte) (0)))),
                ((int) (((byte) (48)))));
            this.lbltop10.SetColumnSpan(this.labTop10, 3);
            this.labTop10.Font = new System.Drawing.Font("Blader", 48F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labTop10.ForeColor = System.Drawing.Color.White;
            this.labTop10.Location = new System.Drawing.Point(176, 32);
            this.labTop10.Margin = new System.Windows.Forms.Padding(0);
            this.labTop10.Name = "labTop10";
            this.lbltop10.SetRowSpan(this.labTop10, 2);
            this.labTop10.Size = new System.Drawing.Size(472, 110);
            this.labTop10.TabIndex = 6;
            this.labTop10.Text = "TOP 10";
            this.labTop10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Top10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbltop10);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Top10";
            this.Size = new System.Drawing.Size(878, 729);
            this.Load += new System.EventHandler(this.Top10_Load);
            this.lbltop10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label labPlayers;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Label labTop10;
        private System.Windows.Forms.TableLayoutPanel lbltop10;
        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}