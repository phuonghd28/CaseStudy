using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudy
{
    class FacadeModel
    {
        private IProduct _product;
        private IDepartment _department;

        public FacadeModel()
        {
            _product = new ProductProvider();
            _department = new DepartmentProvider();
        }

        public string CreateProduct()
        {
            _product.CreateProduct();
            return "Create product";
        }

        public string CreateMember()
        {
            _department.CreateMember();
            return "Create member";
        }
    }
}
