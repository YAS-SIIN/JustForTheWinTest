using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustForTheWinTest
{
    public class PlayerData
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<PictureBox>? ListBalls { get; set; }
        public int BallCount { get; set; } = 20;
        public int Credits { get; set; } = 100;
    }
}
