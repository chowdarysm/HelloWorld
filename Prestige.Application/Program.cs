using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prestige.Core.Authorization;

namespace Prestige.Application
{
    class Program
    {
       

        static void Main(string[] args)
        {           

            if (Environment.UserInteractive)
            {
                // running as console app
                Start(args);
               
                Stop();
            }
            else
            {
                // running as service
                //using (var service = new Service())
                //{
                //    ServiceBase.Run(service);
                //}
            }
        }

        public static void Start(string[] args)
        {
            
            try
            {
                //GetInfo();
                Console.ReadKey();
            }
            catch (Exception e)
            {
                //Handle exception or write "throw new InvalidOperationException"..
            }
        }

        public static  void GetInfo()
        {
            AuthManager _authManager = new AuthManager();
            Console.WriteLine(_authManager.GetInfo());
        }

        public static void Stop()
        {
            Environment.Exit(0);
        }
    }
}
