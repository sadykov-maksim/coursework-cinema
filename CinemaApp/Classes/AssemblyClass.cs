using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Classes
{
    public class AssemblyClass
    {
        public string GetAppName()
        {
            string appName = Assembly.GetEntryAssembly().GetName().Name;
            return appName;
        }
        public Version GetAppVersion()
        {
            try
            {
                return ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }
            catch (Exception)
            {
                return Assembly.GetExecutingAssembly().GetName().Version;
            }
        }
    }
}
