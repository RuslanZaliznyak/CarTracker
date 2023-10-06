using System;
using Microsoft.AspNetCore.Builder;

namespace CarTracker
{
    public static class AuthRoutes
    {
        public static void ConfigureRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/auth", () =>
            {

            });

            endpoints.MapGet("/api/login", () =>
            {

            });

            endpoints.MapGet("/api/register", () =>
            {

            });

            endpoints.MapGet("/api/logout", () =>
            {

            });

        }
    }
}

