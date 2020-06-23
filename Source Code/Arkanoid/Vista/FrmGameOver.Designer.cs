using System.ComponentModel;

namespace Arkanoid
{
    partial class FrmGameOver
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tpl2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.tlp3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPlayAgain = new System.Windows.Forms.Label();
            this.tlp4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.tlp5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblExit = new System.Windows.Forms.Label();
            this.tpl6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tmrPoints = new System.Windows.Forms.Timer(this.components);
            this.tlp1.SuspendLayout();
            this.tpl2.SuspendLayout();
            this.tlp3.SuspendLayout();
            this.tlp4.SuspendLayout();
            this.tlp5.SuspendLayout();
            this.tpl6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp1.BackColor = System.Drawing.Color.Transparent;
            this.tlp1.ColumnCount = 3;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlp1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96F));
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlp1.Controls.Add(this.lblMessage, 1, 1);
            this.tlp1.Controls.Add(this.tpl2, 1, 3);
            this.tlp1.Controls.Add(this.tlp3, 1, 7);
            this.tlp1.Controls.Add(this.tlp4, 1, 9);
            this.tlp1.Controls.Add(this.tlp5, 1, 11);
            this.tlp1.Controls.Add(this.tpl6, 1, 5);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 13;
            this.tlp1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.385373F));
            this.tlp1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.10497F));
            this.tlp1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.385373F));
            this.tlp1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.446383F));
            this.tlp1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.385373F));
            this.tlp1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.62941F));
            this.tlp1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.385373F));
            this.tlp1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.831756F));
            this.tlp1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.385373F));
            this.tlp1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.351271F));
            this.tlp1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.385373F));
            this.tlp1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.623949F));
            this.tlp1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.70002F));
            this.tlp1.Size = new System.Drawing.Size(545, 670);
            this.tlp1.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("Blader", 54.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(13, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(517, 107);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Bien Hecho!";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpl2
            // 
            this.tpl2.ColumnCount = 3;
            this.tpl2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpl2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tpl2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tpl2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpl2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tpl2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tpl2.Controls.Add(this.lblGameOver, 1, 0);
            this.tpl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpl2.Location = new System.Drawing.Point(13, 128);
            this.tpl2.Name = "tpl2";
            this.tpl2.RowCount = 1;
            this.tpl2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpl2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpl2.Size = new System.Drawing.Size(517, 43);
            this.tpl2.TabIndex = 1;
            // 
            // lblGameOver
            // 
            this.lblGameOver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGameOver.Font = new System.Drawing.Font("Blader", 28F);
            this.lblGameOver.ForeColor = System.Drawing.Color.White;
            this.lblGameOver.Location = new System.Drawing.Point(108, 0);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(295, 43);
            this.lblGameOver.TabIndex = 0;
            this.lblGameOver.Text = "- Game Over -";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp3
            // 
            this.tlp3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp3.ColumnCount = 3;
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlp3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlp3.Controls.Add(this.lblPlayAgain, 1, 0);
            this.tlp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp3.Location = new System.Drawing.Point(13, 366);
            this.tlp3.Name = "tlp3";
            this.tlp3.RowCount = 1;
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp3.Size = new System.Drawing.Size(517, 53);
            this.tlp3.TabIndex = 3;
            // 
            // lblPlayAgain
            // 
            this.lblPlayAgain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlayAgain.Font = new System.Drawing.Font("Blader", 30F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblPlayAgain.ForeColor = System.Drawing.Color.White;
            this.lblPlayAgain.Location = new System.Drawing.Point(34, 0);
            this.lblPlayAgain.Name = "lblPlayAgain";
            this.lblPlayAgain.Size = new System.Drawing.Size(448, 53);
            this.lblPlayAgain.TabIndex = 0;
            this.lblPlayAgain.Text = "Volver a jugar";
            this.lblPlayAgain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayAgain.Click += new System.EventHandler(this.LblPlayAgain_Click);
            this.lblPlayAgain.MouseEnter += new System.EventHandler(this.LblPlayAgain_MouseEnter);
            this.lblPlayAgain.MouseLeave += new System.EventHandler(this.LblPlayAgain_MouseLeave);
            // 
            // tlp4
            // 
            this.tlp4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp4.ColumnCount = 3;
            this.tlp4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlp4.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tlp4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlp4.Controls.Add(this.lblMenu, 1, 0);
            this.tlp4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp4.Location = new System.Drawing.Point(13, 434);
            this.tlp4.Name = "tlp4";
            this.tlp4.RowCount = 1;
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp4.Size = new System.Drawing.Size(517, 56);
            this.tlp4.TabIndex = 4;
            // 
            // lblMenu
            // 
            this.lblMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMenu.Font = new System.Drawing.Font("Blader", 30F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(34, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(448, 56);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menu Principal";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenu.Click += new System.EventHandler(this.LblMenu_Click);
            this.lblMenu.MouseEnter += new System.EventHandler(this.LblMenu_MouseEnter);
            this.lblMenu.MouseLeave += new System.EventHandler(this.LblMenu_MouseLeave);
            // 
            // tlp5
            // 
            this.tlp5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp5.ColumnCount = 3;
            this.tlp5.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlp5.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tlp5.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlp5.Controls.Add(this.lblExit, 1, 0);
            this.tlp5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp5.Location = new System.Drawing.Point(13, 505);
            this.tlp5.Name = "tlp5";
            this.tlp5.RowCount = 1;
            this.tlp5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp5.Size = new System.Drawing.Size(517, 51);
            this.tlp5.TabIndex = 5;
            // 
            // lblExit
            // 
            this.lblExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExit.Font = new System.Drawing.Font("Blader", 30F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Location = new System.Drawing.Point(85, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(345, 51);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "Salir";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.LblExit_Click);
            this.lblExit.MouseEnter += new System.EventHandler(this.LblExit_MouseEnter);
            this.lblExit.MouseLeave += new System.EventHandler(this.LblExit_MouseLeave);
            // 
            // tpl6
            // 
            this.tpl6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tpl6.ColumnCount = 1;
            this.tpl6.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpl6.Controls.Add(this.lblScore, 0, 0);
            this.tpl6.Controls.Add(this.lblBonus, 0, 1);
            this.tpl6.Controls.Add(this.lblTotal, 0, 2);
            this.tpl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpl6.Location = new System.Drawing.Point(13, 186);
            this.tpl6.Name = "tpl6";
            this.tpl6.RowCount = 3;
            this.tpl6.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.98592F));
            this.tpl6.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.69014F));
            this.tpl6.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.32394F));
            this.tpl6.Size = new System.Drawing.Size(517, 165);
            this.tpl6.TabIndex = 6;
            // 
            // lblScore
            // 
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScore.Font = new System.Drawing.Font("Blader", 25F);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(3, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(511, 51);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score:";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBonus
            // 
            this.lblBonus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBonus.Font = new System.Drawing.Font("Blader", 25F);
            this.lblBonus.ForeColor = System.Drawing.Color.White;
            this.lblBonus.Location = new System.Drawing.Point(3, 51);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(511, 52);
            this.lblBonus.TabIndex = 1;
            this.lblBonus.Text = "Bonus: ";
            this.lblBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Blader", 39.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(3, 103);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(511, 62);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total: ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrPoints
            // 
            this.tmrPoints.Tick += new System.EventHandler(this.TmrPoints_Tick);
            // 
            // FrmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(545, 563);
            this.Controls.Add(this.tlp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "FrmGameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GameOver_Load);
            this.tlp1.ResumeLayout(false);
            this.tpl2.ResumeLayout(false);
            this.tlp3.ResumeLayout(false);
            this.tlp4.ResumeLayout(false);
            this.tlp5.ResumeLayout(false);
            this.tpl6.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblPlayAgain;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TableLayoutPanel tlp1;
        private System.Windows.Forms.TableLayoutPanel tlp3;
        private System.Windows.Forms.TableLayoutPanel tlp4;
        private System.Windows.Forms.TableLayoutPanel tlp5;
        private System.Windows.Forms.Timer tmrPoints;
        private System.Windows.Forms.TableLayoutPanel tpl2;
        private System.Windows.Forms.TableLayoutPanel tpl6;
        

        #endregion
    }
}