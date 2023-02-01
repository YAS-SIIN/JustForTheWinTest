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

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            makeBaketBalls();
            _playerData.Name = txtPlayerName.Text;
            lblPlayerName.Text = $"Player Name : {_playerData.Name}";

            lblCredits.Text = $"Credits : {_playerData.Credits}";
            pnlEnterGame.Visible = false;
            pnlGameMain.Visible = true;      
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
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// this will return list of twenty ball
        /// </summary>                                                    
        void makeBaketBalls()
        {
            _playerData.ListBalls = new();
            int startPosition = 5;
            int endPosition = 5;
            for (int i = 1; i <= 20; i++)
            {
                PictureBox newBall = new();
                newBall.Image = global::JustForTheWinTest.Properties.Resources.icons8_ball_60;
                newBall.Name = $"imgBall1{i}";
                newBall.Size = new System.Drawing.Size(30, 30);
                newBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

                newBall.Location = new System.Drawing.Point(startPosition, 5);

                //if (i % 5 == 0)
                //{
                //    endPosition += 35;
                //    startPosition = 5;
                //}
                //else
                //{
                //    startPosition += 35;
                //}
                endPosition += 35;
                startPosition += 35;
                _playerData.ListBalls.Add(newBall);
                this.pnlBasket.Controls.Add(newBall);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlEnterGame.Visible = true;  
            pnlGameMain.Visible = false;
            txtPlayerName.Text = "";
            txtPlayerName.Focus();
        }
    }
}