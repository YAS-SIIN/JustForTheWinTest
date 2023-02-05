namespace JustForTheWinTest
{
    public partial class frmMain : Form
    {
        private PlayerData _playerData;


        /// <summary>
        /// form constructor
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            _playerData = new();
        }
              
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                makeButtonBallsShape();
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// This method is for manual playing
        /// </summary>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                _playerData = new();
                makeChanceBalls();

                _playerData.Name = txtPlayerName.Text;
                lblPlayerName.Text = $"Player Name : {_playerData.Name}";
                lblCredits.Text = $"Credits : {_playerData.Credits}";
                lblWin.Text = $"Win : {_playerData.WinCount}";
                lblPlayedRound.Text = $"Played Round : {_playerData.PlayedRound}";
                lblRTP.Text = $"RTP : {_playerData.RTP}";
                pnlEnterGame.Enabled = false;
                pnlSimulate.Enabled = false;
                pnlGameMain.Visible = true;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Shall player name be over 3 character
        /// </summary>
        private void txtPlayerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (txtPlayerName.Text.Length >= 2)
                    btnPlay.Enabled = true;
                else
                    btnPlay.Enabled = false;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// back to main and play again
        /// </summary>
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                pnlEnterGame.Enabled = true;
                pnlSimulate.Enabled = true;
                pnlBasket.Enabled = true;

                pnlGameMain.Visible = false;
                btnPlay.Enabled = false;
                txtPlayerName.Text = "";
                txtPlayerName.PlaceholderText = "Enter your name : ";
                txtPlayerName.Focus();
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// this method manage every ball click event 
        /// </summary> 
        private void btnBall_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox thisBall = (PictureBox)sender;
                BallData ballData = new();
                ballData = calculateScore(thisBall.Name);
                _playerData.PlayedRound += 1;
                showGameResult();
                makeChanceBalls();
                MessageBox.Show(ballData.BallStatus.ToString());
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// Simulating automatic play by the system  
        /// </summary>  
        private void btnSimulate_Click(object sender, EventArgs e)
        {
            try
            {
                _playerData = new();
                makeChanceBalls();
                _playerData.Name = "Simulate";
                _playerData.Credits = numCredits.Value;
                _playerData.PlayedRound = numRound.Value;

                lblPlayerName.Text = $"Player Name : {_playerData.Name}";

                simulate();
                pnlEnterGame.Enabled = false;
                pnlSimulate.Enabled = false;
                pnlGameMain.Visible = true;
                pnlBasket.Enabled = false;
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// this will return list of twenty random chance
        /// <returns>list of chance</returns>
        /// </summary>  
        private int[] GenerateStatus()
        {
            Random rnd = new Random();

            int[] BallRandomStatus = new int[19];
            BallRandomStatus[0] = 2;
            for (int i = 1; i < 19; i++)
            {
                if (i <= 5)
                    BallRandomStatus[i] = 1;
                else
                    BallRandomStatus[i] = 0;
            }

            return BallRandomStatus.OrderBy(x => rnd.Next()).ToArray();
        }

        /// <summary>
        /// this will design 20 ball button shape inside basket panel
        /// </summary>                                                    
        private void makeButtonBallsShape()
        {
            int startPosition = 5;
            _playerData.ListBallShape = new();
            for (int i = 0; i <= 19; i++)
            {
                PictureBox newBall = new()
                {
                    Image = JustForTheWinTest.Properties.Resources.icons8_ball_60,
                    Name = $"btnBall{i}",
                    Size = new System.Drawing.Size(30, 30),
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                    Location = new System.Drawing.Point(startPosition, 8),
                    Cursor = System.Windows.Forms.Cursors.Hand,
                };
                newBall.Click += new System.EventHandler(btnBall_Click);

                _playerData.ListBallShape.Add(newBall);
                this.pnlBasket.Controls.Add(newBall);
                startPosition += 43;
            }
        }

        /// <summary>
        /// this will create list of twenty array with chances
        /// </summary>                                                    
        private void makeChanceBalls()
        {
            int[] ballStatus = GenerateStatus();
            _playerData.ListBallData = new();

            for (int i = 0; i <= ballStatus.Count() - 1; i++)
            {
                BallData newBallData = new() { Name = $"btnBall{i}", BallStatus = (EnumBallStatus)ballStatus[i] };
                _playerData.ListBallData.Add(newBallData);
            }
        }


        /// <summary>
        /// this method will simulate the game
        /// </summary> 
        private void simulate()
        {
            try
            {
                Random rnd = new Random();
                BallData ballData = new();
                decimal playRound = _playerData.PlayedRound;
                for (int i = 0; i < playRound; i++)
                {
                    int chosenBall = rnd.Next(0, 19);
                    ballData = calculateScore($"btnBall{chosenBall}");
                    playRound += ballData.BallStatus == EnumBallStatus.Extra ? 1 : 0;
                    makeChanceBalls();
                }
                showGameResult();
            }
            catch (Exception) { throw; }
        }

        /// <summary>
        /// this method will calculate score of every chance ball   
        /// <returns>list of chance</returns>
        /// </summary>
        private BallData calculateScore(string ballIndexName)
        {
            BallData ballData = new();
            if (!(_playerData.ListBallData is null))
            {
                ballData = _playerData.ListBallData.Where(x => x.Name == ballIndexName).FirstOrDefault();
   
                _playerData.Credits -= ballData.BallStatus != EnumBallStatus.Extra ? 10 : 0;

                if (ballData.BallStatus == EnumBallStatus.Win)
                {
                    _playerData.WinCount += 1;
                    _playerData.Credits += 20;
                }
            }
            return ballData;
        }

        /// <summary>
        /// this method will show result of game
        /// </summary> 
        private void showGameResult()
        {
            try
            {
                lblWin.Text = $"Win : {_playerData.WinCount}";
                lblCredits.Text = $"Credits : {_playerData.Credits}";
                lblPlayedRound.Text = $"Played Round : {_playerData.PlayedRound}";
                _playerData.RTP = ((_playerData.WinCount * 20) / (_playerData.PlayedRound * 10)) * 100;
                lblRTP.Text = $"RTP : {_playerData.RTP.ToString("00.00")}";
            }
            catch (Exception) { throw; }
        }
    }
}