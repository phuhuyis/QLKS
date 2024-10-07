using Employee.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public static class Program
    {
        public static String url = "http://" + config.ipwcf + ":" + config.portwcf + "/QLKS";
        public static IQLKS qlks;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BasicHttpBinding binding = new BasicHttpBinding(BasicHttpSecurityMode.None);
            //Proxy
            /*binding.ProxyAddress = new Uri(config.addressProxy);
            binding.BypassProxyOnLocal = false;
            binding.UseDefaultWebProxy = false;*/
            //deploy phai xoa
            var channel = new ChannelFactory<IQLKS>(binding);
            var endpoint = new EndpointAddress(url);
            qlks = channel?.CreateChannel(endpoint);
            Application.Run(new frmLogin());
        }
    }
}
