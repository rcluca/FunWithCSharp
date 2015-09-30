using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Algorithms
{
    //
    // Summary:
    //     Determines how many nuts Robo will pick up on his journey to meet Robitta.
    //     Can be played by replacing contents of Main with below and modifying line variable.
    //     Full challenge description at https://www.codeeval.com/open_challenges/212/
    //
    // Returns:
    //     Print to the Console the number of nuts Robo picks up.
    //

    //static void Main(string[] args)
    //{

    //    // Size of the field that Robo will go through,
    //    // and X and Y coordinates of a place where Robitta waits for him.
    //    string line = "4x4 | 2 2";

    //    int nuts = 0;

    //    string[] strArr = line.Split('|');
    //    string[] coor = strArr[0].TrimEnd(' ').Split('x');
    //    string[] loveCoor = strArr[1].TrimStart(' ').Split(' ');

    //    Point map = new Point() { x = int.Parse(coor[0]), y = int.Parse(coor[1]) };
    //    Point loverLocation = new Point() { x = int.Parse(loveCoor[0]), y = int.Parse(loveCoor[1]) };
    //    RoboLovers roboLovers = new RoboLovers(map, loverLocation);
    //    nuts = roboLovers.PlayGame();

    //    Console.WriteLine(nuts);
    //    Console.ReadLine();
    //}

    public class RoboLovers
    {
        Point _map;
        Point _location;
        Point _loverLocation;
        Direction _direction;
        bool[,] _visited;
        int _nuts;

        public RoboLovers(Point map, Point loverLocation)
        {
            _map = map;
            _location = new Point() { x = 1, y = map.y };
            _loverLocation = loverLocation;
            _direction = Direction.Right;
            _visited = new bool[map.x + 1, map.y + 1];
            _nuts = 1;
        }

        public int PlayGame()
        {
            if (_location.x == _loverLocation.x && _location.y == _loverLocation.y)
                return _nuts;
            else
            {
                Move();
                _nuts++;
                return PlayGame();
            }
        }

        private void Move()
        {
            _visited[_location.x, _location.y] = true;
            Point proposedLocation = new Point() { x = _location.x, y = _location.y };

            if (_direction == Direction.Right)
            {
                proposedLocation.x++;
                if (proposedLocation.x > _map.x || _visited[proposedLocation.x, proposedLocation.y])
                {
                    _direction = Direction.Down;
                    _location.y--;
                }
                else
                {
                    _location.x++;
                }
            }
            else if (_direction == Direction.Down)
            {
                proposedLocation.y--;
                if (proposedLocation.y < 1 || _visited[proposedLocation.x, proposedLocation.y])
                {
                    _direction = Direction.Left;
                    _location.x--;
                }
                else
                {
                    _location.y--;
                }
            }
            else if (_direction == Direction.Left)
            {
                proposedLocation.x--;
                if (proposedLocation.x < 1 || _visited[proposedLocation.x, proposedLocation.y])
                {
                    _direction = Direction.Up;
                    _location.y++;
                }
                else
                {
                    _location.x--;
                }
            }
            else if (_direction == Direction.Up)
            {
                proposedLocation.y++;
                if (proposedLocation.y > _map.y || _visited[proposedLocation.x, proposedLocation.y])
                {
                    _direction = Direction.Right;
                    _location.x++;
                }
                else
                {
                    _location.y++;
                }
            }
        }
    }

    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public enum Direction
    {
        Right,
        Down,
        Left,
        Up
    }
}
