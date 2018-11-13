using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Prestige.Core.Authorization
{
    public class AuthManager
    {

        public String GetInfo()
        {
            string outputValue = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["infovalue"].ToString()))
                    outputValue = ConfigurationManager.AppSettings["infovalue"];  //for test getting value from config file.
                else
                    outputValue = "Configuration value din't set.";
            }
            catch (Exception ex)
            {
                outputValue = "exception message";
                //log exception in error section
            }

            return outputValue;
        }

    }
}
