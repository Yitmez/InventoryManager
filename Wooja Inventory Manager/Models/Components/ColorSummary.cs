using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;

namespace Wooja_Inventory_Manager.Models.Components
{
    public class ColorSummary : ViewComponent
    {
        private Color data;

        public ColorSummary(Color cdata)
        {
            data = cdata;
        }

        // IViewComponentResult für... ginge auch.  ?? prüfen
        public string Invoke() //parameter (string themeName) könnte auch gehen 
                              
        {
            ViewBag.Theme = "Extra Info, könnte per Parameter kommen";
            return ("Weitergabe von Informationen");
        }
    }
}
