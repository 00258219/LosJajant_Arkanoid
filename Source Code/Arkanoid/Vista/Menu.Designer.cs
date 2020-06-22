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
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.tlpBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBase
            // 
            this.tlpBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpBase.ColumnCount = 1;
            this.tlpBase.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBase.Controls.Add(this.pbLogo, 0, 0);
            this.tlpBase.Controls.Add(this.lblExit, 0, 4);
            this.tlpBase.Controls.Add(this.lblTop, 0, 3);
            this.tlpBase.Controls.Add(this.lblPlay, 0, 2);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(0, 0);
            this.tlpBase.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 6;
            this.tlpBase.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.99999F));
            this.tlpBase.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.000008F));
            this.tlpBase.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.38981F));
            this.tlpBase.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.38981F));
            this.tlpBase.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.39038F));
            this.tlpBase.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.829998F));
            this.tlpBase.Size = new System.Drawing.Size(873, 593);
            this.tlpBase.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Bottom)));
            this.pbLogo.Location = new System.Drawing.Point(51, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(770, 171);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lblExit
            // 
            this.lblExit.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Blader", 75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(155, 434);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(563, 114);
            this.lblExit.TabIndex = 3;
            this.lblExit.Text = "exit";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.LblExit_Click);
            this.lblExit.MouseLeave += new System.EventHandler(this.LblExit_MouseLeave);
            this.lblExit.MouseHover += new System.EventHandler(this.LblExit_MouseHover);
            // 
            // lblTop
            // 
            this.lblTop.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTop.BackColor = System.Drawing.Color.Transparent;
            this.lblTop.Font = new System.Drawing.Font("Blader", 75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTop.ForeColor = System.Drawing.Color.White;
            this.lblTop.Location = new System.Drawing.Point(70, 320);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(733, 114);
            this.lblTop.TabIndex = 2;
            this.lblTop.Text = "Top 10";
            this.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTop.Click += new System.EventHandler(this.LblTop_Click);
            this.lblTop.MouseLeave += new System.EventHandler(this.LblTop_MouseLeave);
            this.lblTop.MouseHover += new System.EventHandler(this.LblTop_MouseHover);
            // 
            // lblPlay
            // 
            this.lblPlay.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblPlay.BackColor = System.Drawing.Color.Transparent;
            this.lblPlay.Font = new System.Drawing.Font("Blader", 75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPlay.ForeColor = System.Drawing.Color.White;
            this.lblPlay.Location = new System.Drawing.Point(229, 206);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(414, 114);
            this.lblPlay.TabIndex = 1;
            this.lblPlay.Text = "Play";
            this.lblPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlay.Click += new System.EventHandler(this.LblPlay_Click);
            this.lblPlay.MouseLeave += new System.EventHandler(this.LblPlay_MouseLeave);
            this.lblPlay.MouseHover += new System.EventHandler(this.LblPlay_MouseHover);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpBase);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(873, 593);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tlpBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pbLogo)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TableLayoutPanel tlpBase;

        #endregion
    }
}