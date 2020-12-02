using System;
using fightgrid.Models;

namespace fightgrid{
    public class Enemy{
        private Fighter cpu = Instance.X;
        private Fighter player = Instance.O;
        public static int playerX = Instance.O.Position[1];
        public static int playerY = Instance.O.Position[0];

        public static  bool isOccupied(int x, int y){
            if(x == playerX && y == playerY){
                return true;
            }else{
                return false;
            }
        }
        public static void Move(){
            Random rng = new Random();
            int action = rng.Next(0,4);
            int cpuX = Instance.X.Position[1];
            int cpuY = Instance.X.Position[0];

            switch(action){
                //0 = up
                case(0):
                    if(cpuY >0 && isOccupied(cpuY-1,cpuX)== false){
                        Instance.X.Position[0] -=1;
                    }else{
                        Move();
                    }
                    break;
                //1 = down
                case(1):
                    if(cpuY < 2 && isOccupied(cpuY+1,cpuX)== false){
                        Instance.X.Position[0] +=1;
                    }else{
                        Move();
                    }
                    break;
                //2 = left
                case(2):
                    if(cpuX > 0 && isOccupied(cpuY,cpuX-1)== false){
                        Instance.X.Position[1] -=1;
                    }else{
                        Move();
                    }
                    break;
                //3 = right
                case(3):
                    if(cpuX < 2 && isOccupied(cpuY,cpuX+1)== false){
                        Instance.X.Position[1] +=1;
                    }else{
                        Move();
                    }
                    break;
            }
            Arena.DrawArena();
        }
    }

}