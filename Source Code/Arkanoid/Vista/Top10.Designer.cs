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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labTop10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labPlayers = new System.Windows.Forms.Label();
            this.labScore = new System.Windows.Forms.Label();
            this.lbltop10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltop10
            // 
            this.lbltop10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lbltop10.ColumnCount = 3;
            this.lbltop10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.94674F));
            this.lbltop10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.07101F));
            this.lbltop10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.8639F));
            this.lbltop10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.lbltop10.Controls.Add(this.btnback, 0, 0);
            this.lbltop10.Controls.Add(this.pictureBox1, 2, 0);
            this.lbltop10.Controls.Add(this.labTop10, 1, 0);
            this.lbltop10.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.lbltop10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbltop10.Location = new System.Drawing.Point(0, 0);
            this.lbltop10.Margin = new System.Windows.Forms.Padding(0);
            this.lbltop10.Name = "lbltop10";
            this.lbltop10.RowCount = 2;
            this.lbltop10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.34103F));
            this.lbltop10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.65897F));
            this.lbltop10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.lbltop10.Size = new System.Drawing.Size(753, 632);
            this.lbltop10.TabIndex = 0;
            // 
            // btnback
            // 
            this.btnback.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnback.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnback.Location = new System.Drawing.Point(26, 17);
            this.btnback.Margin = new System.Windows.Forms.Padding(26, 17, 3, 3);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(112, 51);
            this.btnback.TabIndex = 4;
            this.btnback.Text = "GO BACK";
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(552, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labTop10
            // 
            this.labTop10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labTop10.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (7)))), ((int) (((byte) (0)))), ((int) (((byte) (48)))));
            this.labTop10.Font = new System.Drawing.Font("Blader", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labTop10.ForeColor = System.Drawing.Color.White;
            this.labTop10.Location = new System.Drawing.Point(192, 13);
            this.labTop10.Name = "labTop10";
            this.labTop10.Size = new System.Drawing.Size(321, 77);
            this.labTop10.TabIndex = 6;
            this.labTop10.Text = "TOP 10";
            this.labTop10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.lbltop10.SetColumnSpan(this.tableLayoutPanel1, 3);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.81861F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.18139F));
            this.tableLayoutPanel1.Controls.Add(this.labPlayers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labScore, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 111);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 512F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(718, 512);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // labPlayers
            // 
            this.labPlayers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labPlayers.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (7)))), ((int) (((byte) (0)))), ((int) (((byte) (48)))));
            this.labPlayers.Font = new System.Drawing.Font("Blader", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labPlayers.ForeColor = System.Drawing.Color.White;
            this.labPlayers.Location = new System.Drawing.Point(3, 23);
            this.labPlayers.Name = "labPlayers";
            this.labPlayers.Padding = new System.Windows.Forms.Padding(64, 0, 0, 0);
            this.labPlayers.Size = new System.Drawing.Size(380, 466);
            this.labPlayers.TabIndex = 2;
            this.labPlayers.Text = "   Players\r\n1   Henry\r\n2  Oscar\r\n3  Carlos\r\n4  Diana\r\n5  Enrique\r\n6  Chino\r\n7  Ch" + "ule\r\n8  Chobe\r\n9  Alexander\r\n10 Roberto";
            this.labPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labScore
            // 
            this.labScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labScore.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (7)))), ((int) (((byte) (0)))), ((int) (((byte) (48)))));
            this.labScore.Font = new System.Drawing.Font("Blader", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labScore.ForeColor = System.Drawing.Color.White;
            this.labScore.Location = new System.Drawing.Point(461, 27);
            this.labScore.Name = "labScore";
            this.labScore.Size = new System.Drawing.Size(182, 458);
            this.labScore.TabIndex = 3;
            this.labScore.Text = "Score\r\n1000\r\n999\r\n998\r\n997\r\n996\r\n995\r\n994\r\n993\r\n992\r\n991";
            this.labScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Top10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbltop10);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Top10";
            this.Size = new System.Drawing.Size(753, 632);
            this.Load += new System.EventHandler(this.Top10_Load);
            this.lbltop10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label labPlayers;
        private System.Windows.Forms.Label labScore;
        private System.Windows.Forms.Label labTop10;
        private System.Windows.Forms.TableLayoutPanel lbltop10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}