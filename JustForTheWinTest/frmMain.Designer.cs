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
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlGameMain = new System.Windows.Forms.Panel();
            this.lblRTP = new System.Windows.Forms.Label();
            this.lblPlayedRound = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numRound = new System.Windows.Forms.NumericUpDown();
            this.numCredits = new System.Windows.Forms.NumericUpDown();
            this.pnlEnterGame.SuspendLayout();
            this.pnlBasket.SuspendLayout();
            this.pnlGameMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCredits)).BeginInit();
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
            this.btnPlay.Location = new System.Drawing.Point(132, 72);
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
            this.txtPlayerName.Location = new System.Drawing.Point(45, 35);
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
            this.pnlEnterGame.Location = new System.Drawing.Point(489, 396);
            this.pnlEnterGame.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEnterGame.Name = "pnlEnterGame";
            this.pnlEnterGame.Size = new System.Drawing.Size(450, 122);
            this.pnlEnterGame.TabIndex = 3;
            // 
            // pnlBasket
            // 
            this.pnlBasket.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlBasket.Controls.Add(this.lblBasket);
            this.pnlBasket.Location = new System.Drawing.Point(4, 238);
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
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(435, 17);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(79, 21);
            this.lblCredits.TabIndex = 7;
            this.lblCredits.Text = "Credits : 0";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(4, 17);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(110, 21);
            this.lblPlayerName.TabIndex = 8;
            this.lblPlayerName.Text = "Player Name : ";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(432, 193);
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
            this.pnlGameMain.Controls.Add(this.lblRTP);
            this.pnlGameMain.Controls.Add(this.lblPlayedRound);
            this.pnlGameMain.Controls.Add(this.lblWin);
            this.pnlGameMain.Controls.Add(this.lblPlayerName);
            this.pnlGameMain.Controls.Add(this.pnlBasket);
            this.pnlGameMain.Controls.Add(this.lblCredits);
            this.pnlGameMain.Controls.Add(this.btnBack);
            this.pnlGameMain.Location = new System.Drawing.Point(12, 49);
            this.pnlGameMain.Name = "pnlGameMain";
            this.pnlGameMain.Size = new System.Drawing.Size(927, 340);
            this.pnlGameMain.TabIndex = 10;
            this.pnlGameMain.Visible = false;
            // 
            // lblRTP
            // 
            this.lblRTP.AutoSize = true;
            this.lblRTP.Location = new System.Drawing.Point(800, 17);
            this.lblRTP.Name = "lblRTP";
            this.lblRTP.Size = new System.Drawing.Size(56, 21);
            this.lblRTP.TabIndex = 12;
            this.lblRTP.Text = "RTP : 0";
            // 
            // lblPlayedRound
            // 
            this.lblPlayedRound.AutoSize = true;
            this.lblPlayedRound.Location = new System.Drawing.Point(642, 17);
            this.lblPlayedRound.Name = "lblPlayedRound";
            this.lblPlayedRound.Size = new System.Drawing.Size(126, 21);
            this.lblPlayedRound.TabIndex = 11;
            this.lblPlayedRound.Text = "Played Round : 0";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Location = new System.Drawing.Point(548, 17);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(58, 21);
            this.lblWin.TabIndex = 10;
            this.lblWin.Text = "Win : 0";
            // 
            // btnSimulate
            // 
            this.btnSimulate.Enabled = false;
            this.btnSimulate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSimulate.Location = new System.Drawing.Point(195, 72);
            this.btnSimulate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(96, 40);
            this.btnSimulate.TabIndex = 1;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblStart);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numRound);
            this.panel1.Controls.Add(this.numCredits);
            this.panel1.Controls.Add(this.btnSimulate);
            this.panel1.Location = new System.Drawing.Point(12, 396);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 122);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(166, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "*";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.ForeColor = System.Drawing.Color.Red;
            this.lblStart.Location = new System.Drawing.Point(315, 12);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(17, 21);
            this.lblStart.TabIndex = 12;
            this.lblStart.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Round :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Credits (0 = infinite) :";
            // 
            // numRound
            // 
            this.numRound.Location = new System.Drawing.Point(242, 36);
            this.numRound.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numRound.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRound.Name = "numRound";
            this.numRound.Size = new System.Drawing.Size(213, 29);
            this.numRound.TabIndex = 5;
            this.numRound.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCredits
            // 
            this.numCredits.Location = new System.Drawing.Point(4, 35);
            this.numCredits.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numCredits.Name = "numCredits";
            this.numCredits.Size = new System.Drawing.Size(232, 29);
            this.numCredits.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(951, 526);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCredits)).EndInit();
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
        private Label lblCredits;
        private Label lblPlayerName;
        private Button btnBack;
        private Panel pnlGameMain;
        private Label lblWin;
        private Label lblPlayedRound;
        private Label lblRTP;
        private Button btnSimulate;
        private Panel panel1;
        private NumericUpDown numCredits;
        private NumericUpDown numRound;
        private Label label2;
        private Label label3;
        private Label lblStart;
        private Label label1;
    }
}