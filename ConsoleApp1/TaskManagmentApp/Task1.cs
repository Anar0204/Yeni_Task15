using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManagmentApp.Enums;

namespace TaskManagmentApp
{
    public class Task1
    {
        public Task1(string title,TaskStatus1 ts)
        {
             Title = title;
            Status = ts;
        }
        public string Title;
        TaskStatus1 Status;

        public override string ToString()
        {
            return "Title: "+ Title + " Status: " + Status;
        }
    }

    
}
