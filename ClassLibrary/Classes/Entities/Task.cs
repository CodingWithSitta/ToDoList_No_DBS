using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public abstract class Task : ITask
    {
        private string taskName;
        private ICategory categoryName;

        public string TaskName
        {
            get { return taskName; }
            set { taskName = value; }
        }
        public ICategory CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }
    }
}
