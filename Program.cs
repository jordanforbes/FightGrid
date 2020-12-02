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
            // Instance.instantiateChars();
            // Turn.Phaser(Oguy, Instance.X);

            while (Instance.O.Focus >=0 && Instance.X.Focus >=0) {
                    ConsoleKey input = Console.ReadKey (true).Key;
                    Arena.DrawArena();
                    Controls.Movement (input);
                    Enemy.Move();
                    // Controls.Movement(Instance.O, Instance.X, input);
                // while(Turn.CurrentPhase==1){

                // }
                // //start
                // if(Turn.CurrentPhase==0){
                //     Arena.Debug("Start Turn");
                //     Arena.DebugL($"OX:{Instance.O.Position[1]}");
                //     Arena.DebugL($"OY{Instance.O.Position[0]}");
                //     Turn.IncreFocus(Instance.O,Instance.X);
                //     Arena.DrawArena();
                // //player
                // }else if(Turn.CurrentPhase==1){
                //     Arena.Debug("Player's Turn");
                //     Arena.DrawArena();
                // }
                // //enemy
                // else if(Turn.CurrentPhase==2){
                //     Arena.Debug("Enemy Turn");
                //     Arena.DrawArena();
                // }
                
            }

        }

         //Starting, Player, Enemy
    

    }
}