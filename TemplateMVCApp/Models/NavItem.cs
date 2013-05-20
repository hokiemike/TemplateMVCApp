using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemplateMVCApp.Models
{
    public abstract class NavItem
    {
        public string DisplayText { get; set; }
        
       
    }

    public class NavHeader : NavItem
    {
        
    }

    public class NavLink : NavItem
    {
        public string Url { get; set; }
        public bool IsActive { get; set; }
    }
}