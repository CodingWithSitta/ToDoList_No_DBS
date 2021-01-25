using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classes.Entities
{
    public class Category : ICategory
    {
        private string categoryName;

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }
        public Category(string name)
        {
            this.categoryName = name; 
        }
    }
}
