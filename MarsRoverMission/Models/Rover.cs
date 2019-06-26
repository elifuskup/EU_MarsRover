using System;
using System.Collections.Generic;
using System.Reflection;

namespace MarsRoverMission.Models
{
    public class Rover
    {
        /// <summary>
        /// Assume that the square directly North from (x, y) is (x, y 1) ==> 
        /// North will be equal to 1 and compass will be used as clockwise.
        /// </summary>
        private const int N = 1;
        private const int E = 2;
        private const int S = 3;
        private const int W = 4;

        public int positionX { get; set; }
        public int positionY { get; set; }
        public int direction { get; set; }
        public Directions directionName { get; set; }

        public int MaxCoordinateX { get; set; }
        public int MaxCoordinateY { get; set; }

        public List<string> Moves;
        public enum Directions
        {
            N = 1,
            E = 2,
            S = 3,
            W = 4
        }

        public Rover(int x, int y)
        {
            MaxCoordinateX = x;
            MaxCoordinateY = y;

            positionX = 0;
            positionY = 0;
            direction = N;
        }

        /// <summary>
        /// Function to set coordinates for landing
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="direction"></param>
        public void LandRover(int x, int y, Directions direction)
        {
            this.positionX = x;
            this.positionY = y;
            this.direction = (int)direction;
            this.Moves = new List<string>();
            Moves.Add(positionX + "," + positionY);
        }

        /// <summary>
        /// Function to move rover
        /// Paint result list + Landing Coordinates
        /// </summary>
        /// <param name="movements"></param>
        /// <returns></returns>
        public string OperateRover(string movements)
        {
            bool paintIt = true;

            foreach (var letter in movements.ToCharArray())
            {
                paintIt = true;
                switch (letter)
                {
                    case 'L':
                        GoTo_L();
                        break;
                    case 'R':
                        GoTo_R();
                        break;
                    case 'M':
                        GoTo_M();
                        break;
                    default:
                        paintIt = false;
                        break;
                }
                if (paintIt)
                    Moves.Add(positionX + "," + positionY);
            }

            this.directionName = (Directions)direction;
            return "All moved!";

            // with Reflection
            //var xMethod = this.GetType().GetMethod("GoTo_" + letter);
            //if (xMethod != null)
            //    xMethod.Invoke(this, new object[] { });
            //else
            //    throw new Exception("Wrong direction!");
        }

        /// <summary>
        /// Function to MOVE FORWARD
        /// </summary>
        public void GoTo_M()
        {
            if (direction == (int)Directions.N)
            {
                this.positionY++;
            }
            else if (direction == (int)Directions.E)
            {
                this.positionX++;
            }
            else if (direction == (int)Directions.S)
            {
                this.positionY--;
            }
            else if (direction == (int)Directions.W)
            {
                this.positionX--;
            }
        }

        /// <summary>
        /// Function to TURN LEFT
        /// </summary>
        public void GoTo_L()
        {
            direction = (direction - 1) < N ? W : direction - 1;
        }

        /// <summary>
        /// Function to TURN RIGHT
        /// </summary>
        public void GoTo_R()
        {
            direction = (direction + 1) > W ? N : direction + 1;
        }
    }
}
