using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsAgencies = new NewsAgency[]
            {
                new NewsAgency("BBC"),
                new NewsAgency("CNN"),
                new NewsAgency("RT"),
                new NewsAgency("DW")
            };

            foreach (var item in newsAgencies)
            {
                item.BreakingNews += ShowBreakingNews;
            }

            foreach (var item in newsAgencies)
            {
                item.BroadcastBreakingNews();
            }
        }

        private static void ShowBreakingNews(object sender, EventArgs e)
        {
            var agency = sender as NewsAgency;

            if (agency != null)
            {
                Console.WriteLine($"{agency.Name}:\t{e.ToString()}");
            }
        }
    }
}
