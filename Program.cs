using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using fightgrid.Models;

namespace fightgrid
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // CreateWebHostBuilder(args).Build().Run();
            Start();
        }

        // public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //     WebHost.CreateDefaultBuilder(args)
        //         .UseStartup<Startup>();

        static void Start()
        {
            Fighter Oguy = new Fighter(0);
            Fighter Xguy = new Fighter(1);
            // Console.WriteLine(Oguy.Icon);
            // Console.WriteLine(Oguy.Focus);
            // Console.WriteLine(Oguy.Position[0]);
           

            // Console.WriteLine(Xguy.Icon);
            // Console.WriteLine(Xguy.Focus);
            // Console.WriteLine(Xguy.Position[0]);

            DrawArena(Oguy,Xguy);

        }
        static void DrawArena(Fighter Oguy,Fighter Xguy)
        {

            //draw 2D arr
            string[,] arenaGrid = new string[,] {{"*","*","*"},{"*","*","*"},{"*","*","*"}};
            int[,] arenaInt = new int[,] {{2,2,2},{2,2,2},{2,2,2}}; //0 is O, 1 is X, 2 is empty

            Console.WriteLine($"Oposition: {Oguy.Position[0]} {Oguy.Position[1]}");
            Console.WriteLine($"Xposition: {Xguy.Position[0]} {Xguy.Position[1]}");
            Console.WriteLine($"{arenaGrid[Oguy.Position[0],Oguy.Position[1]]}");

            //placement
            arenaGrid[Oguy.Position[0],Oguy.Position[1]]= Oguy.Icon;
            arenaGrid[Xguy.Position[0],Xguy.Position[1]]= Xguy.Icon;

            Console.WriteLine($"| {arenaGrid[0,0]} {arenaGrid[0,1]} {arenaGrid[0,2]} | O:{Oguy.Focus}");
            Console.WriteLine($"| {arenaGrid[1,0]} {arenaGrid[1,1]} {arenaGrid[1,2]} | X:{Xguy.Focus}");
            Console.WriteLine($"| {arenaGrid[2,0]} {arenaGrid[2,1]} {arenaGrid[2,2]} |");
            
        }
    }
}
