using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotBuilder
{
    class Robot
    {

        private string _kodSerii;
        private int _nrSerii;
        private bool _wlaczony;

        public Robot(string kodSerii, int nrSerii)
        {
            this._kodSerii = kodSerii;
            this._nrSerii = nrSerii;
            this._wlaczony = false;
        }


        public string Seria => _kodSerii + "-" + _nrSerii;

        public void Uruchom()
        {
            if(_wlaczony)
                    Console.WriteLine("Robot already running!");
            else
            {
                _wlaczony = true;
                Console.WriteLine("Robot turning on");
            }

        }

        public void DajSygnal()
        {
            if(_wlaczony)
                Console.WriteLine("Signal: Wrrrp bleep");
            else
                Console.WriteLine("...");
        }

        public override string ToString()
        {
            return "Robot";
        }
    }
}
