using System;
using Microsoft.AspNetCore.Builder;

namespace CarTracker
{
    public static class CarRoutes
    {
        public static void ConfigureRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/car", () =>
            {

            });

            endpoints.MapGet("/api/car-location", () =>
            {

            });

            endpoints.MapGet("/api/car-status", () =>
            {

            });

            endpoints.MapGet("/api/car-alerts", () =>
            {

            });




        }
    }
}

