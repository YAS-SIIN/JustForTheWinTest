namespace JustForTheWinTest
{
    public partial class frmMain : Form
    {
        private PlayerData _playerData;
        public frmMain()
        {
            InitializeComponent();
            _playerData = new();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception) { throw; }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                _playerData = new();
                makeButtonBalls();
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

        private void btnBall_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox thisBall = (PictureBox)sender;
                BallData ballData;
                string gameResult = "";
                if (!(_playerData.BallData is null))
                {
                    ballData = _playerData.BallData.Where(x => x.Name == thisBall.Name).FirstOrDefault();
                    gameResult = ballData.BallStatus.ToString();

                    _playerData.Credits -= ballData.BallStatus != EnumBallStatus.Extra ? 10 : 0;
                    _playerData.PlayedRound += ballData.BallStatus != EnumBallStatus.Extra ? 1 : 0;
                    if (ballData.BallStatus == EnumBallStatus.Win)
                    {
                        _playerData.WinCount += 1;
                        _playerData.Credits += 20;
                    }
                }

                lblWin.Text = $"Win : {_playerData.WinCount}";
                lblCredits.Text = $"Credits : {_playerData.Credits}";
                lblPlayedRound.Text = $"Played Round : {_playerData.PlayedRound}";
                _playerData.RTP = ((_playerData.WinCount * 20) / (_playerData.PlayedRound * 10)) * 100;
                lblRTP.Text = $"RTP : {_playerData.RTP.ToString("00.00")}";

                makeButtonBalls();
                MessageBox.Show(gameResult);
            }
            catch (Exception) { throw; }
        }

        private void btnSimulate_Click(object sender, EventArgs e)
        {
            try
            {
                _playerData = new();
                makeButtonBalls();
                _playerData.Name = "Simulate";
                _playerData.Credits = numCredits.Value;
                _playerData.PlayedRound = numRound.Value;

                simulate();

                lblPlayerName.Text = $"Player Name : {_playerData.Name}";
                lblWin.Text = $"Win : {_playerData.WinCount}";
                lblCredits.Text = $"Credits : {_playerData.Credits}";
                lblPlayedRound.Text = $"Played Round : {_playerData.PlayedRound}";
                _playerData.RTP = ((_playerData.WinCount * 20) / (_playerData.PlayedRound * 10)) * 100;
                lblRTP.Text = $"RTP : {_playerData.RTP.ToString("00.00")}";

                pnlEnterGame.Enabled = false;
                pnlSimulate.Enabled = false;
                pnlGameMain.Visible = true;
                pnlBasket.Enabled=false;
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
        /// this will create list of twenty array with chances
        /// </summary>                                                    
        private void makeButtonBalls()
        {
            int[] ballStatus = GenerateStatus();
            int startPosition = 5;
            _playerData.ListBalls = new();
            _playerData.BallData = new();

            for (int i = 0; i <= ballStatus.Count() - 1; i++)
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

                _playerData.ListBalls.Add(newBall);
                this.pnlBasket.Controls.Add(newBall);
                startPosition += 43;

                BallData newBallData = new() { Name = newBall.Name, BallStatus = (EnumBallStatus)ballStatus[i] };
                _playerData.BallData.Add(newBallData);
            }
        }


        /// <summary>
        /// this method simulate the game
        /// </summary> 
        private void simulate()
        {
            try
            {
                Random rnd = new Random();
                decimal playRound = _playerData.PlayedRound;
                for (int i = 0; i < playRound; i++)
                {
                    BallData ballData;
                    if (!(_playerData.BallData is null))
                    {
                        int chosenBall = rnd.Next(0, 19);
                        ballData = _playerData.BallData.Where(x => x.Name == $"btnBall{chosenBall}").FirstOrDefault();

                        _playerData.Credits -= ballData.BallStatus != EnumBallStatus.Extra ? 10 : 0;
                        playRound += ballData.BallStatus == EnumBallStatus.Extra ? 1 : 0;

                        if (ballData.BallStatus == EnumBallStatus.Win)
                        {
                            _playerData.WinCount += 1;
                            _playerData.Credits += 20;
                        }
                    }

                    makeButtonBalls();
                }
            }
            catch (Exception) { throw; }
        }

    }
}