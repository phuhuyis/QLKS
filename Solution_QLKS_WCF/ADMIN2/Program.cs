using ADMIN2.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADMIN2
{
    static class Program
    {
        public static String url = "http://192.168.0.196:8000/QLKS";
        public static IQLKS qlks;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BasicHttpBinding binding = new BasicHttpBinding(BasicHttpSecurityMode.None);
            var channel = new ChannelFactory<IQLKS>(binding);
            var endpoint = new EndpointAddress(url);
            qlks = channel?.CreateChannel(endpoint);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
