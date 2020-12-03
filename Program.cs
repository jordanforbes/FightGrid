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
        
         public static void Pause()
        {
            
            ConsoleKey key = Console.ReadKey(true).Key;
            while (key != ConsoleKey.Spacebar)
            {
                key = Console.ReadKey(true).Key;
            }
        }

        static void Start () {
            // Instance.instantiateChars();
            // Turn.Phaser(Oguy, Instance.X);

            while (Instance.O.Focus >=0 && Instance.X.Focus >=0) {
                    Arena.DrawArena();
                    ConsoleKey input = Console.ReadKey (true).Key;
                    Controls.Movement (input);
                    Arena.Debug("Press Spacebar");
                    // Pause();
                    Arena.clearDebug();
                    // Arena.DrawArena();
                    Enemy.Move();
           
                
            }

        }

         //Starting, Player, Enemy
    

    }
}