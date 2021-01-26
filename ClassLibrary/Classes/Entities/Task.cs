using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Task : ITask
    {
        private string taskName;
        private string categoryName;

        public string TaskName
        {
            get { return taskName; }
            set { taskName = value; }
        }
        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }
        public Task()
        { }
        public Task(string name, string category)
        {
            taskName = name;
            categoryName = category;
        }

        public override string ToString()
        {
            return $"{TaskName} - {CategoryName}";
        }
    }
}
