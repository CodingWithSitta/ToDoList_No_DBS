using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Task : ITask
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
        public Task(string name, ICategory category)
        {
            this.categoryName = category;
            this.taskName = name;
        }
    }
}
