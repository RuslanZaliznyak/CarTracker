using System;
namespace CarTracker
{
	public static class Routes
	{
        public static void ConfigureRoutes(IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/api/car", () =>
            {
                Console.WriteLine("api car test");
            });

            
        }
    }
}

