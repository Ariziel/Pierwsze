using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverBot.Structure.User.Market
{
    class MarketStructure
    {

        public class Stock
        {
            public int wood { get; set; }
            public int stone { get; set; }
            public int iron { get; set; }
        }

        public class Capacity
        {
            public int wood { get; set; }
            public int stone { get; set; }
            public int iron { get; set; }
        }

        public class Rates
        {
            public double wood { get; set; }
            public double stone { get; set; }
            public double iron { get; set; }
        }

        public class Tax
        {
            public double buy { get; set; }
            public int sell { get; set; }
        }

        public class Constants
        {
            public double resource_base_price { get; set; }
            public double resource_price_elasticity { get; set; }
            public int stock_size_modifier { get; set; }
        }

        public class RootObject
        {
            public Stock stock { get; set; }
            public Capacity capacity { get; set; }
            public Rates rates { get; set; }
            public Tax tax { get; set; }
            public Constants constants { get; set; }
            public double duration { get; set; }
            public int credit { get; set; }
            public int merchants { get; set; }
            public string status_bar { get; set; }
        }

    }
}
