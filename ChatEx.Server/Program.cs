using System;
using Microsoft.Owin.Hosting;

namespace ChatEx.Server
{
    public class Program
    {
        public static string HostUrl = "http://localhost:5000/";

        public static void Main(string[] args)
        {
            using (WebApp.Start<Startup>(HostUrl))
            {
                Console.WriteLine($"Server running at {HostUrl}");
                Console.ReadLine();
            }
        }
    }
}