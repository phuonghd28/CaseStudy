using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy.Observer
{
    class WebApp : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine(message + " in webapp");
        }
    }
}
