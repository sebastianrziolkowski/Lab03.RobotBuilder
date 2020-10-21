using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RobotBuilder.Urzadzenia.Wyjscia;

namespace RobotBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("BB",8);
            robot.DajSygnal();
            Console.WriteLine(robot.Seria);
            robot.Uruchom();
            robot.DajSygnal();

            Lampa lampa = new Lampa();
            lampa.Uruchom();
            lampa.Uruchom();

            Console.ReadLine();
        }
    }
}
