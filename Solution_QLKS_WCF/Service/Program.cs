using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Program
    {
        public static String url = "http://" + config.ipwcf + ":" + config.portwcf + "/QLKS";
        public static void Main(string[] args)
        {
            BasicHttpBinding binding = new BasicHttpBinding(BasicHttpSecurityMode.None);
            //Proxy
            /*binding.ProxyAddress = new Uri(config.addressProxy);
            binding.BypassProxyOnLocal = false;
            binding.UseDefaultWebProxy = false;*/
            //deploy phai xoa
            ServiceHost host = new ServiceHost(typeof(QLKS));
            host.AddServiceEndpoint(typeof(IQLKS), binding, url);
            host.Open();
            Console.WriteLine("Service is start");
            Console.ReadKey();
            dataprovider.Dataprovider.Close();
        }
    }
}
