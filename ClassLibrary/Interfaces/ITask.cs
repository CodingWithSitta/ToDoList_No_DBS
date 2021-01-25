using ClassLibrary.Classes.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Interfaces
{
    public interface ITask
    {
        string TaskName { get; set; }
        ICategory CategoryName { get; set; }

    }
}
