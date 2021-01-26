using ClassLibrary.Classes.Entities;
using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Services
{
    public class TaskServices
    {
        public List<Task> tasks;
        public List<Category> categories;
        public Category category;

        public TaskServices()
        {
            tasks = new List<Task>();
            categories = new List<Category>();
        }
        public void CreateCategorie()
        {
            categories.Add(Test1)
        }
         
        {
            
        }
    }
}
