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

        // public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //     WebHost.CreateDefaultBuilder(args)
        //         .UseStartup<Startup>();

        static void Start () {
            Fighter Oguy = new Fighter (0);
            Fighter Xguy = new Fighter (1);
            // Console.WriteLine(Oguy.Icon);
            // Console.WriteLine(Oguy.Focus);
            // Console.WriteLine(Oguy.Position[0]);

            // Console.WriteLine(Xguy.Icon);
            // Console.WriteLine(Xguy.Focus);
            // Console.WriteLine(Xguy.Position[0]);
            // Oguy.Position[1]+=1;//move right
            DrawArena (Oguy, Xguy);

            while (Oguy.Focus >= 0 && Xguy.Focus >= 0) {
                ConsoleKey input = Console.ReadKey (true).Key;
                Controls (Oguy, Xguy, input);
            }

        }
        static void Controls (Fighter Oguy, Fighter Xguy, ConsoleKey key) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //MOVEMENT
            switch (key) {
                //UP
                case (ConsoleKey.UpArrow):
                    Console.WriteLine ("\u2191");
                    if (Oguy.Position[0] != 0) {
                        Oguy.Position[0] -= 1; //move Up
                    } else {
                        Console.WriteLine ("there's a wall there");
                    }
                    break;
                    //DOWN
                case (ConsoleKey.DownArrow):
                    Console.WriteLine ("\u2193");
                    if (Oguy.Position[0] != 2) {
                        Oguy.Position[0] += 1; //move Down
                    } else {
                        Console.WriteLine ("there's a wall there");
                    }
                    break;
                    //LEFT
                case (ConsoleKey.LeftArrow):
                    Console.WriteLine ("\u2190");
                    if (Oguy.Position[1] != 0) {
                        Oguy.Position[1] -= 1; //move Left
                    } else {
                        Console.WriteLine ("there's a wall there");
                    }
                    break;
                    //RIGHT
                case (ConsoleKey.RightArrow):
                    Console.WriteLine ("\u2192");
                    if (Oguy.Position[1] != 2) {
                        Oguy.Position[1] += 1; //move Right
                    } else {
                        Console.WriteLine ("there's a wall there");
                    }
                    break;
            };

            //KICK LOGIC
            void Kick (int x, int y, Fighter l, Fighter r) {
                if (l.Position[x] > r.Position[x] && l.Position[y] == r.Position[y]) {
                    Console.WriteLine ("Kick Connected!");
                    Xguy.Focus -= 1;
                } else {
                    Console.WriteLine ("Miss!");
                }
            }

            //ATTACK
            switch (key) {
                //ATTACK UP
                case (ConsoleKey.W):
                    Kick (0, 1, Oguy, Xguy);
                    break;
                //ATTACK DOWN
                case (ConsoleKey.S):
                    Kick (0, 1, Xguy, Oguy);
                    break;
                //ATTACK LEFT
                case (ConsoleKey.A):
                    Kick (1, 0, Oguy, Xguy);
                    break;
                //ATTACK RIGHT
                case (ConsoleKey.D):
                    Kick (1, 0, Xguy, Oguy);
                    break;
            }

            DrawArena (Oguy, Xguy);
        }

        static void DrawArena (Fighter Oguy, Fighter Xguy) {

            //draw 2D arr
            string[, ] arenaGrid = new string[, ] { { "*", "*", "*" }, { "*", "*", "*" }, { "*", "*", "*" } };
            int[, ] arenaInt = new int[, ] { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } }; //0 is O, 1 is X, 2 is empty

            // Console.WriteLine($"Oposition: {Oguy.Position[0]} {Oguy.Position[1]}");
            // Console.WriteLine($"Xposition: {Xguy.Position[0]} {Xguy.Position[1]}");

            //placement
            // arenaGrid[Oguy.Position[0],Oguy.Position[1]]= Oguy.Icon;
            // arenaGrid[Xguy.Position[0],Xguy.Position[1]]= Xguy.Icon;

            // Console.WriteLine($"| {arenaGrid[0,0]} {arenaGrid[0,1]} {arenaGrid[0,2]} | O:{Oguy.Focus}");
            // Console.WriteLine($"| {arenaGrid[1,0]} {arenaGrid[1,1]} {arenaGrid[1,2]} | X:{Xguy.Focus}");
            // Console.WriteLine($"| {arenaGrid[2,0]} {arenaGrid[2,1]} {arenaGrid[2,2]} |");

            arenaInt[Oguy.Position[0], Oguy.Position[1]] = Oguy.Role;
            arenaInt[Xguy.Position[0], Xguy.Position[1]] = Xguy.Role;

            // Console.WriteLine($"o role: {Oguy.Role}");

            // Console.WriteLine($"x role: {Xguy.Role}");

            Console.WriteLine ($"| {arenaInt[0,0]} {arenaInt[0,1]} {arenaInt[0,2]} | O:{Oguy.Focus}");
            Console.WriteLine ($"| {arenaInt[1,0]} {arenaInt[1,1]} {arenaInt[1,2]} | X:{Xguy.Focus}");
            Console.WriteLine ($"| {arenaInt[2,0]} {arenaInt[2,1]} {arenaInt[2,2]} |");
        }

    }
}