﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Interfaces
{
    public interface ITask
    {
        string TaskName { get; set; }
        string CategoryName { get; set; }
    }
}
