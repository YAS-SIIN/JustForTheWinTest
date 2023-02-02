﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustForTheWinTest
{
    public class PlayerData
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public List<PictureBox> ListBalls { get; set; } = new List<PictureBox>();
        public List<BallData> BallData { get; set; } = new List<BallData>();                
        public float Credits { get; set; } = 100;
        public float WinCount { get; set; } = 0;
        public float PlayedRound { get; set; } = 0;   
        public float RTP { get; set; } = 0;
    }

    public class BallData
    {
        public string? Name { get; set; }

        public EnumBallStatus BallStatus { get; set; }
    }

    public enum EnumBallStatus
    {
        [Display(Name = "NoWin")]
        NoWin,
        [Display(Name = "Win")]
        Win,
        [Display(Name = "Extra")]
        Extra
    }
}
