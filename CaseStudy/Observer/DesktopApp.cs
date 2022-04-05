using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy.Observer
{
    class DesktopApp : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine(message + " in desktop app");
        }
    }
}
