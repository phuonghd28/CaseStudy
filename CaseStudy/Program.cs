using CaseStudy.Observer;
using System;

namespace CaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject sub = new Subject();
            WebApp web = new WebApp();
            DesktopApp desktop = new DesktopApp();
            sub.attach(web);
            sub.handleAction(1);
            sub.attach(desktop);
            sub.handleAction(2);
        }
    }
}
