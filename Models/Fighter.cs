using System;
using System.Collections.Generic;

namespace fightgrid.Models
{
    //needs focus 
    //you lose when you get negative focus
    //each turn you gain one focus point
    //you use focus with each attack

    public class Fighter
    {
        public int Focus=0;
        public int Role{get;set;}
        public string Icon{get;set;}
        public char Mode='M';

        public List<sbyte> Position{get;set;} 

        public Fighter(int role)
        {
            if( role == 0 ){
                Role= role;
                Icon = "O";
                Position = new List<sbyte>(){0,0}; //y and x not x and y

            }else if( role==1 ){
                Role= role;
                Icon = "X";
                Position = new List<sbyte>(){2,2};

                // Position[0]=2;
                // Position[1]=2;
            }
        }
         //KICK LOGIC
            public void Kick (int x, int y, Fighter l, Fighter r, Fighter enemy) 
            {
                if (l.Position[x] > r.Position[x] && l.Position[y] == r.Position[y]) 
                {
                    Console.WriteLine ("Kick Connected!");
                    enemy.Focus -=2;
                    Focus -=1;
                } else {
                    Console.WriteLine ("Missed Kick!");
                    enemy.Focus +=1;
                    Focus -=1;
                }
            }

            //PUNCH LOGIC
            public void Punch (int x, int y, Fighter l, Fighter r, Fighter enemy)
            {
                if(l.Position[x] == r.Position[x]+1)
                {
                    if(l.Position[y]-1 <= r.Position[y] && l.Position[y]+1 >=r.Position[y] )
                    {
                        Console.WriteLine("Punch Connected!");
                        enemy.Focus -=2;
                        Focus -=1;
                    }
                    else{
                        Console.WriteLine("Missed Punch!");
                        enemy.Focus +=1;
                        Focus -=1;
                    }
                }else{
                    Console.WriteLine("Missed Punch!");
                    enemy.Focus +=1;
                    Focus -=1;
                }
                
            }


    }

}
