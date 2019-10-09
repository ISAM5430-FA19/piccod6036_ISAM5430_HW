using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5C2
{
    class Motorway
    {

        private string _name;
        private string _type;
        private string _direction;
        private string _surface;
        private int _numberlanes;
        private bool _toll;
        private string _party;
        
        public string Name { get; set; }
        public string Type { get; set; }
        public string Direction { get; set; }
        public string Surface { get; set; }
        public int NumberLanes { get; set; }
        public bool Toll { get; set; }
        public string Party { get; set; }

        public Motorway(string name, string type, string direction, string surface, int numberlanes, bool toll, string party)
        {
            Name = name;
            Type = type;
            Direction = direction;
            Surface = surface;
            NumberLanes = numberlanes;
            Toll = toll;
            Party = party;
        }

        public override string ToString()
        {
            return @"Name: " + Name
                +   "\nType: " + Type
                + "\nDirection: " + Direction
                + "\nSurface: " + Surface
                + "\nNumber of Lanes: " + NumberLanes.ToString()
                + "\nToll: " + Toll.ToString()
                + "\nParty: " + Party;
        }











    }
}
