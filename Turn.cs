using System;
using fightgrid.Models;

namespace fightgrid
{
    public class Turn {
        public static int CurrentPhase = 1;

        public static void PhaseShift(){
            CurrentPhase +=1;
            if(CurrentPhase > 2){
                CurrentPhase = 0;
            }
        }

         public static void PhaseShift(Fighter player, Fighter enemy){
            
            CurrentPhase +=1;
            if(CurrentPhase > 2){
                CurrentPhase = 0;
            }
            Phaser(player, enemy);
        }

        public static void Phaser(Fighter player, Fighter enemy)
        {
            if(CurrentPhase == 0) //starting phase
            {
                Console.WriteLine("Start Turn");
                player.Focus +=1;
                enemy.Focus +=1;
                PhaseShift(player, enemy);
            }else if(CurrentPhase == 1){
                Console.WriteLine("Player's Turn");
            }else if(CurrentPhase ==2){
                Console.WriteLine("Enemy's Turn");
                PhaseShift(player, enemy);
            }
        }
    }
}