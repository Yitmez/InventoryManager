using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager
{
    public class WeatherEndpoint
    {
            public static async Task Endpoint(HttpContext context)
            {
                await context.Response
                .WriteAsync("Endpoint Class: It is cloudy in Milan");
            }
        
    }
}
