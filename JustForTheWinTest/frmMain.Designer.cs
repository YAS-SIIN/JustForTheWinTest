namespace JustForTheWinTest
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.pnlEnterGame = new System.Windows.Forms.Panel();
            this.pnlBasket = new System.Windows.Forms.Panel();
            this.lblBasket = new System.Windows.Forms.Label();
            this.btnChooseBall = new System.Windows.Forms.Button();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlGameMain = new System.Windows.Forms.Panel();
            this.pnlEnterGame.SuspendLayout();
            this.pnlBasket.SuspendLayout();
            this.pnlGameMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Location = new System.Drawing.Point(327, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(310, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Just For The Win Game";
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.Location = new System.Drawing.Point(79, 55);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(96, 40);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(4, 18);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPlayerName.MaxLength = 15;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.PlaceholderText = "Enter your name : ";
            this.txtPlayerName.Size = new System.Drawing.Size(249, 29);
            this.txtPlayerName.TabIndex = 2;
            this.txtPlayerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerName_KeyPress);
            // 
            // pnlEnterGame
            // 
            this.pnlEnterGame.Controls.Add(this.txtPlayerName);
            this.pnlEnterGame.Controls.Add(this.btnPlay);
            this.pnlEnterGame.Location = new System.Drawing.Point(365, 414);
            this.pnlEnterGame.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEnterGame.Name = "pnlEnterGame";
            this.pnlEnterGame.Size = new System.Drawing.Size(257, 107);
            this.pnlEnterGame.TabIndex = 3;
            // 
            // pnlBasket
            // 
            this.pnlBasket.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlBasket.Controls.Add(this.lblBasket);
            this.pnlBasket.Location = new System.Drawing.Point(4, 256);
            this.pnlBasket.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBasket.Name = "pnlBasket";
            this.pnlBasket.Size = new System.Drawing.Size(919, 98);
            this.pnlBasket.TabIndex = 5;
            this.pnlBasket.Tag = "Basket";
            // 
            // lblBasket
            // 
            this.lblBasket.AutoSize = true;
            this.lblBasket.Location = new System.Drawing.Point(455, 68);
            this.lblBasket.Name = "lblBasket";
            this.lblBasket.Size = new System.Drawing.Size(55, 21);
            this.lblBasket.TabIndex = 6;
            this.lblBasket.Text = "Basket";
            // 
            // btnChooseBall
            // 
            this.btnChooseBall.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChooseBall.Location = new System.Drawing.Point(443, 208);
            this.btnChooseBall.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseBall.Name = "btnChooseBall";
            this.btnChooseBall.Size = new System.Drawing.Size(167, 40);
            this.btnChooseBall.TabIndex = 3;
            this.btnChooseBall.Text = "Choose a Ball";
            this.btnChooseBall.UseVisualStyleBackColor = true;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(488, 17);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(79, 21);
            this.lblCredits.TabIndex = 7;
            this.lblCredits.Text = "Credits : 0";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(139, 17);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(110, 21);
            this.lblPlayerName.TabIndex = 8;
            this.lblPlayerName.Text = "Player Name : ";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(339, 208);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 40);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlGameMain
            // 
            this.pnlGameMain.Controls.Add(this.lblPlayerName);
            this.pnlGameMain.Controls.Add(this.pnlBasket);
            this.pnlGameMain.Controls.Add(this.lblCredits);
            this.pnlGameMain.Controls.Add(this.btnBack);
            this.pnlGameMain.Controls.Add(this.btnChooseBall);
            this.pnlGameMain.Location = new System.Drawing.Point(12, 49);
            this.pnlGameMain.Name = "pnlGameMain";
            this.pnlGameMain.Size = new System.Drawing.Size(927, 358);
            this.pnlGameMain.TabIndex = 10;
            this.pnlGameMain.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(951, 526);
            this.Controls.Add(this.pnlGameMain);
            this.Controls.Add(this.pnlEnterGame);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Just For The Win";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlEnterGame.ResumeLayout(false);
            this.pnlEnterGame.PerformLayout();
            this.pnlBasket.ResumeLayout(false);
            this.pnlBasket.PerformLayout();
            this.pnlGameMain.ResumeLayout(false);
            this.pnlGameMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnPlay;
        private TextBox txtPlayerName;
        private Panel pnlEnterGame;
        private Panel pnlBasket;
        private Label lblBasket;
        private Button btnChooseBall;
        private Label lblCredits;
        private Label lblPlayerName;
        private Button btnBack;
        private Panel pnlGameMain;
    }
}