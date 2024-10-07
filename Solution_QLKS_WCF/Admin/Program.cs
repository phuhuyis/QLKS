using Admin.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    static class Program
    {
        public static String url = "http://" + config.ipwcf + ":" + config.portwcf + "/QLKS";
        public static IQLKS qlks;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BasicHttpBinding binding = new BasicHttpBinding(BasicHttpSecurityMode.None);
            //Proxy
            /*binding.ProxyAddress = new Uri(config.addressProxy);
            binding.BypassProxyOnLocal = false;
            binding.UseDefaultWebProxy = false;*/
            //deploy phai xoa
            var channel = new ChannelFactory<IQLKS>(binding);
            var endpoint = new EndpointAddress(url);
            qlks = channel?.CreateChannel(endpoint);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
