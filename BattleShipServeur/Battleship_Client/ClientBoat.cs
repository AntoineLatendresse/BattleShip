using System;
using System.Drawing;

namespace Battleship_Client
{
    namespace Bundle
    {
        [Serializable]
        public class ClientBoat
        {
            //Orientation//////////////////////////////////////////////
            public enum Orientation
            {
                Horizontal, Vertical
            }
            //Orientation//////////////////////////////////////////////

            public Point Point_Aircraft_Carrier;
            public Orientation Orien_Aircraft_Carrier;

            public Point Point_Battleship;
            public Orientation Orien_Battleship;

            public Point Point_Destroyer;
            public Orientation Orien_Destroyer;

            public Point Point_Patrol_Boat;
            public Orientation Orien_Patrol_Boat;

            public Point Point_Submarine;
            public Orientation Orien_Submarine;
        }
    }
}
