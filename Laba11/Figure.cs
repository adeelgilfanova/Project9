using System;
namespace Laba10
{
    public enum Condition { visible, invisible }
    public enum Color { red, green, blue, yellow }
    class Figure : IFigure
    {
        private Color color;
        private Condition condition;
        public Color ChangeColor(string str)
        {
            if (str.Equals("red"))
            {
                color = Color.yellow;
            }
            else if (str.Equals("green"))
            {
                color = Color.blue;
            }
            else if (str.Equals("blue"))
            {
                color = Color.red;
            }
            else
            {
                color = Color.green;
            }
            return color;
        }
        public Condition Status()
        {
            Console.WriteLine("Фигура видна?");
            string answer = Console.ReadLine();
            if (answer.Equals("yes"))
            {
                condition = Condition.visible;
            }
            else
            {
                condition = Condition.invisible;
            }
            return condition;
        }
        public void Movement(int x, int y, int num)
        {
            x += num;
            y += num;
            Console.WriteLine($"Фигура сместилась. Это координаты: ({x}, {y})");
        }
        public void Print()
        {
            Console.WriteLine($"Цвет Фигуры: {color}");
            Console.WriteLine($"Figure condition: {condition}");
        }
    }
}

