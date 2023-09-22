/*
 * A feladat a github-on olvasható!
 */

using System;

namespace WarriorProject
{
    public class Position
    {
        private int x; 
        private int y;

        public int X {get { return x;} set { } }
        public int Y { get { return y;} set { } }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void ToConsole()
        {
            Console.WriteLine("(" + x + ", " + y + ")");
        }
    }

    public class  Warrior
    {
        private string name;
        private Position position;

        public Position Position { get { return position; } set { } }

        public Warrior(string name, Position position)
        {
            this.name = name;
            this.position = position;
        }

        public void MoveHorizontal(int hossz)
        {
            this.position.X += hossz;
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
