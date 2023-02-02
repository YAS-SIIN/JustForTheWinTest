namespace JustForTheWinTest
{
    public partial class frmMain : Form
    {
        private PlayerData _playerData;
        private GameActions _gameActions;
        public frmMain()
        {
            InitializeComponent();
            _playerData = new();
            _gameActions = new();
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
                makeBasketBalls();
                _playerData.Name = txtPlayerName.Text;
                lblPlayerName.Text = $"Player Name : {_playerData.Name}";     
                lblCredits.Text = $"Credits : {_playerData.Credits}";
                lblWin.Text = $"Win : {_playerData.WinCount}";     
                lblPlayedRound.Text = $"Played Round : {_playerData.PlayedRound}";
                lblRTP.Text = $"RTP : {_playerData.RTP}";
                pnlEnterGame.Visible = false;
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


        /// <summary>
        /// this will return list of twenty ball
        /// </summary>                                                    
        void makeBasketBalls()
        {
            int[] ballStatus = _gameActions.GenerateStatus();
            int startPosition = 5;
            _playerData.ListBalls = new();
            _playerData.BallData = new();

            for (int i = 0; i <= ballStatus.Count() - 1; i++)
            {
                PictureBox newBall = new()
                {       
                    Image = global::JustForTheWinTest.Properties.Resources.icons8_ball_60,
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                pnlEnterGame.Visible = true;
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
                    _playerData.PlayedRound += 1;
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

                makeBasketBalls();
                MessageBox.Show(gameResult);
            }
            catch (Exception) { throw; }
        }
    }
}