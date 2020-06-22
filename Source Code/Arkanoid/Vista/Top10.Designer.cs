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
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTop10 = new System.Windows.Forms.Label();
            this.tlpBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpBase.ColumnCount = 6;
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.08428F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.35763F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.542141F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.89522F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.150342F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.74641F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlpBase.Controls.Add(this.btnBack, 0, 0);
            this.tlpBase.Controls.Add(this.lblPlayers, 1, 2);
            this.tlpBase.Controls.Add(this.lblScore, 3, 2);
            this.tlpBase.Controls.Add(this.pbLogo, 4, 0);
            this.tlpBase.Controls.Add(this.lblTop10, 1, 0);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 4;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.81481F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.053498F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.19728F));
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.835909F));
            this.tlpBase.Size = new System.Drawing.Size(753, 632);
            this.tlpBase.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnBack.Location = new System.Drawing.Point(23, 23);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 46);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "GO BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblPlayers
            // 
            this.lblPlayers.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (7)))), ((int) (((byte) (0)))), ((int) (((byte) (48)))));
            this.lblPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayers.Font = new System.Drawing.Font("Blader", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPlayers.ForeColor = System.Drawing.Color.White;
            this.lblPlayers.Location = new System.Drawing.Point(131, 150);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Padding = new System.Windows.Forms.Padding(64, 0, 0, 0);
            this.lblPlayers.Size = new System.Drawing.Size(275, 456);
            this.lblPlayers.TabIndex = 2;
            this.lblPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (7)))), ((int) (((byte) (0)))), ((int) (((byte) (48)))));
            this.tlpBase.SetColumnSpan(this.lblScore, 2);
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScore.Font = new System.Drawing.Font("Blader", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(476, 150);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(144, 456);
            this.lblScore.TabIndex = 3;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            this.tlpBase.SetColumnSpan(this.pbLogo, 2);
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Location = new System.Drawing.Point(577, 5);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(171, 88);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // lblTop10
            // 
            this.lblTop10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTop10.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (7)))), ((int) (((byte) (0)))), ((int) (((byte) (48)))));
            this.tlpBase.SetColumnSpan(this.lblTop10, 3);
            this.lblTop10.Font = new System.Drawing.Font("Blader", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTop10.ForeColor = System.Drawing.Color.White;
            this.lblTop10.Location = new System.Drawing.Point(150, 27);
            this.lblTop10.Margin = new System.Windows.Forms.Padding(0);
            this.lblTop10.Name = "lblTop10";
            this.tlpBase.SetRowSpan(this.lblTop10, 2);
            this.lblTop10.Size = new System.Drawing.Size(405, 95);
            this.lblTop10.TabIndex = 6;
            this.lblTop10.Text = "TOP 10";
            this.lblTop10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Top10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tlpBase);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Top10";
            this.Size = new System.Drawing.Size(753, 632);
            this.Load += new System.EventHandler(this.Top10_Load);
            this.tlpBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pbLogo)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTop10;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TableLayoutPanel tlpBase;

        #endregion
    }
}