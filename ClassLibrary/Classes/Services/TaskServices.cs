using ClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Services
{
    public class TaskServices
    {
        public List<Task> tasks;
        public List<string> categories;

        public TaskServices()
        {
            tasks = new List<Task>();
            categories = new List<string>();
            CreateCategory();
            CreateTask();
        }
        public void CreateCategory()
        {
            categories.Add("School");
            categories.Add("Work");
            categories.Add("Home");
            categories.Add("Family");
            categories.Add("Friends");
            categories.Add("Others");
        }

        public void CreateTask()
        {
            tasks.Add(new Task("Take the dog out", categories[3].ToString()));
            tasks.Add(new Task("Do home work", categories[0].ToString()));
            tasks.Add(new Task("Take the dog out", categories[3].ToString()));
        }

        public List<Task> GetTasks()
        {
            return tasks;
        }
    }
}
