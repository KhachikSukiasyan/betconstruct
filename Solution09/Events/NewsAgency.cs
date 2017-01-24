using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class NewsAgency
    {
        public NewsAgency(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public event EventHandler<BreakingNewsEventArgs> BreakingNews;

        public void BroadcastBreakingNews()
        {
            // checking
            var args = new BreakingNewsEventArgs
            {
                Title = "Donald Trum canceled \"Obama Care\"",
                When = DateTime.Now,
                News = new object()
            };

            BreakingNews?.Invoke(this, args);
        }
    }
}
