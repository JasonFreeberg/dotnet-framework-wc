using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotnetwindowsapp.Models
{
    public class TaskItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}