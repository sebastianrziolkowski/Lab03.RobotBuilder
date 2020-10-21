using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBuilder.Urzadzenia
{
    class Urzadzenie
    {

        private string _name;
        private bool _wlaczony;

        public Urzadzenie()
        {
            _name = "device#001";
        }
        public Urzadzenie(string name)
        {
            this._name = name;
            _wlaczony = false;
        }

        public void Uruchom()
        {
            if (_wlaczony)
                Console.WriteLine(_name + " already running!");
            else
            {
                _wlaczony = true;
                Console.WriteLine("Turning on");
            }

        }

        public void Wylacz()
        {
            if (!_wlaczony)
                Console.WriteLine("Already off!");
            else
            {
                _wlaczony = false;
                Console.WriteLine("Turning off");
            }

        }

    }
}
