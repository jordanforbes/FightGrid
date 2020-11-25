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
        public int Focus=1;
        public int Role{get;set;}
        public string Icon{get;set;}

        public List<sbyte> Position{get;set;} 

        public Fighter(int role)
        {
            if( role == 0 ){
                Role= role;
                Icon = "O";
                Position = new List<sbyte>(){0,0};

            }else if( role==1 ){
                Role= role;
                Icon = "X";
                Position = new List<sbyte>(){2,2};

                // Position[0]=2;
                // Position[1]=2;
            }
        }

    }

}
