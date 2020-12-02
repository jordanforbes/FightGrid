using System.Net.Mime;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using fightgrid.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace fightgrid {
    public class Program {
        public static void Main (string[] args) {
            // CreateWebHostBuilder(args).Build().Run();
            Start ();
        }

        // public static int CurrentPhase = 0;

        static void Start () {
            Fighter Oguy = new Fighter (0);
            Fighter Xguy = new Fighter (1);
            Arena.DrawArena (Oguy, Xguy);

            while (Oguy.Focus >=0 && Xguy.Focus >=0) {
                Turn.Phaser(Oguy, Xguy);
                ConsoleKey input = Console.ReadKey (true).Key;
                
                Controls.Movement (Oguy, Xguy, input);
                Arena.DrawArena(Oguy,Xguy);
            }

        }

         //Starting, Player, Enemy
    

    }
}