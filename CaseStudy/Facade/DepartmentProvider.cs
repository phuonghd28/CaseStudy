using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy
{
    class DepartmentProvider : IDepartment
    {
        public void CreateMember()
        {
            Console.WriteLine("Create member doing");
        }
    }
}
