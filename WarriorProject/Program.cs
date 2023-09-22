/*
 * A feladat a github-on olvasható!
 */

using System;

namespace WarriorProject
{
    public class Position
    {
        private int _x;
        private int _y;

        public int X { get {return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }

        public Position(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public void ToConsole()
        {
            Console.WriteLine("(" + _x + ", " + _y + ")");
        }
    }

    public class  Warrior
    {
        private string name;
        private Position position;

        public Position Position { get => position; }

        public Warrior(string name, Position position)
        {
            this.name = name;
            this.position = position;
        }

        public void MoveHorizontal(int hossz)
        {
            position.X += hossz;
        }
        public void MoveVertical(int hossz)
        {
            this.position.Y += hossz;
        }

        public void ToConsole()
        {
            Console.WriteLine(name + ", position " + "(" + this.position.X + ", " + this.position.Y + ")") ;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Position position = new Position(2, -1);
            position.ToConsole();
            Warrior warrior = new Warrior("Peter the Iron Man", position);
            warrior.ToConsole();
            warrior.MoveHorizontal(3);
            warrior.MoveVertical(-2);
            warrior.ToConsole();
        }
    }
}
