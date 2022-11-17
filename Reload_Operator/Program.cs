using System;

namespace Reload_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string _name1 = Console.ReadLine();
            string _name2 = Console.ReadLine();

            int _points1 = Convert.ToInt32(Console.ReadLine());
            int _points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints _dancer1 = new DancerPoints(_name1, _points1);
            DancerPoints _dancer2 = new DancerPoints(_name2, _points2);
            DancerPoints total = _dancer1 + _dancer2;

            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
        }
    }

    class DancerPoints
    {
        public string name { get; set; }
        public int points { get; set; }

        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public static DancerPoints operator +(DancerPoints x, DancerPoints y)
        {
            string names = x.name + " & " + y.name;
            int allPoints = x.points + y.points;
            DancerPoints res = new DancerPoints(names, allPoints);
            return res;
        }
    }
}
