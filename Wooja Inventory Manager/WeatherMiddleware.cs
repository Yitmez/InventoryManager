﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wooja_Inventory_Manager
{
    public class WeatherMiddleware
    {
 
            private RequestDelegate next;
            public WeatherMiddleware(RequestDelegate nextDelegate)
            {
                next = nextDelegate;
            }
            public async Task Invoke(HttpContext context)
            {
                if (context.Request.Path == "/middleware/class")
                {
                    await context.Response
                    .WriteAsync("Middleware Class: It is raining in London");
                }
                else
                {
                    await next(context);
                }
            }
        }
    
}