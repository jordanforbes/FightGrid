using System;
using fightgrid.Models;

namespace fightgrid
{
    public class Turn {
        public static int CurrentPhase = 1;
        //0 = start turn 
        //1 = player phase
        //2 = enemy phase
        public static void IncreFocus(Fighter o, Fighter x){
            if(o.Focus <10){
                    o.Focus +=1;
                }
            if(x.Focus <10){
                    x.Focus +=1;
                }
        }

        public static void PhaseShift(){
            if(CurrentPhase >=2){
                CurrentPhase = 0;
            }else{
                CurrentPhase +=1;
            }
            Arena.DrawArena();
            // Phaser(Fighter Oguy, enemy);
        }

        //  public static void PhaseShift(Fighter player, Fighter enemy){
            
        //     if(CurrentPhase >=2){
        //         CurrentPhase = 0;
        //     }else{
        //         CurrentPhase +=1;
        //     }
        //     Phaser(player, enemy);
        // }

        // public static void Phaser(Fighter player, Fighter enemy)
        // {
        //     if(CurrentPhase == 0) //starting phase
        //     {
        //         Arena.Debug("Start Turn");
        //         // Console.WriteLine("Start Turn");
        //         if(player.Focus <10){
        //             player.Focus +=1;
        //         }
        //         if(enemy.Focus <10){
        //             enemy.Focus +=1;
        //         }
                
        //         // PhaseShift(player, enemy);
        //         // PhaseShift();
        //     }else if(CurrentPhase == 1){
        //         Arena.Debug("Player's Turn");
        //     }else if(CurrentPhase ==2){
        //         Arena.Debug("Enemy's Turn");
        //         // PhaseShift(player, enemy);
        //     }
        // }
    }
}