using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Class
{
    internal class WebSite
    {
        private string Name { get; set; }
        private string Url { get; set; }
        private string Description { get; set; }

        static string IpPattern = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
        private string IpAdress;

        private string IpAdressProp
        {
            get { return IpAdress; }
            set { 
                if (Regex.IsMatch(value, IpPattern)) {
                    IpAdress = value;
                }
                else
                {
                    throw new Exception("Incorrect ip!");
                }
            }
        }


        public WebSite(string Name, string Url, string Description, string IpAdress) { 
            this.Name = Name;
            this.Url = Url;
            this.Description = Description;
            IpAdressProp = IpAdress;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Site name: {Name}");
            Console.WriteLine($"Url: {Url}, Ip: {IpAdress}");
            Console.WriteLine($"Description:\n{Description}");
        }
    }
}
