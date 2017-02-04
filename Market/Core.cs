using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverBot.Market
{
    class Core
    {
        public static async void CalcRes(UserVillages.VillageStructure.Example Village)
        {
            try
            {
                var Data = StaticVariables.MarketStructures.FirstOrDefault();
                if (Data.merchants > 0)
                {
                    var StockWood = Data.stock.wood;
                    var StockStone = Data.stock.stone;
                    var StockIron = Data.stock.iron;
                    var MaxWood = Data.capacity.wood;
                    var MaxStone = Data.capacity.stone;
                    var MaxIron = Data.capacity.iron;
                    if (StockWood != MaxWood)
                    {
                        var LeftSpace = MaxWood - StockWood;
                        var OnePackage = 1/Data.rates.wood;
                        var MaxPossiblePackages = LeftSpace / Math.Round(OnePackage);
                        var CounttoSend = Math.Floor(MaxPossiblePackages);
                        var FinnalValue = CounttoSend * OnePackage;
                        if (Village.village.wood > Math.Floor(FinnalValue))
                        {
                            if ((Data.merchants*1000) > FinnalValue)
                            {
                                var g = await Market.RequestSell.SellWoodFirst(Math.Floor(FinnalValue).ToString(), Village.village.id.ToString());
                                var ratehash = Market.RegexAndJson.RateFinder(g);
                                StaticVariables.LogsList.Add(DateTime.Now + " Sending request to sell wood " + FinnalValue + " in " + Village.village.id.ToString());
                                var Final = await Market.RequestSell.SellWoodSecond(Math.Floor(FinnalValue).ToString(), Village.village.id.ToString(), ratehash, "1");
                                StaticVariables.MyVillages.Find(z => z.village.id == Village.village.id).village.wood -=
                                    Math.Floor(FinnalValue);
                            }
                        }
                        else
                        {
                            var MyWood = Village.village.wood;
                            var MaxToSend = MyWood / Math.Floor(OnePackage);
                            MaxToSend = Math.Ceiling(MaxToSend);
                            var Final = MaxToSend * OnePackage;
                            if (Village.village.wood > Final)
                            {
                                if ((Data.merchants * 1000) > Final)
                                {
                                    var g = await Market.RequestSell.SellWoodFirst(Math.Floor(Final).ToString(), Village.village.id.ToString());
                                    var ratehash = Market.RegexAndJson.RateFinder(g);
                                    StaticVariables.LogsList.Add(DateTime.Now + " Sending request to sell wood " + FinnalValue + " in " + Village.village.id.ToString());
                                    var Finalreq = await Market.RequestSell.SellWoodSecond(Math.Floor(Final).ToString(), Village.village.id.ToString(), ratehash, "1");
                                    StaticVariables.MyVillages.Find(z => z.village.id == Village.village.id).village.wood -=
                                        Math.Floor(Final);
                                }

                            }
                        }
                    }
                    if (StockStone != MaxStone)
                    {
                        var LeftSpace = MaxStone - StockStone;
                        var OnePackage = 1 / Data.rates.stone;
                        var MaxPossiblePackages = LeftSpace / Math.Round(OnePackage);
                        var CounttoSend = Math.Floor(MaxPossiblePackages);
                        var FinnalValue = CounttoSend * OnePackage;
                        if (Village.village.stone > Math.Floor(FinnalValue))
                        {
                            if ((Data.merchants * 1000) > FinnalValue)
                            {
                                var g = await Market.RequestSell.SellStoneFirst(Math.Floor(FinnalValue).ToString(), Village.village.id.ToString());
                                var ratehash = Market.RegexAndJson.RateFinder(g);
                                StaticVariables.LogsList.Add(DateTime.Now + " Sending request to sell stone " + FinnalValue + " in " + Village.village.id.ToString());
                                var Final = await Market.RequestSell.SellStoneSecond(Math.Floor(FinnalValue).ToString(), Village.village.id.ToString(), ratehash, "1");
                                StaticVariables.MyVillages.Find(z => z.village.id == Village.village.id).village.stone -=
                                    Math.Floor(FinnalValue);
                            }

                        }
                        else
                        {
                            var myStone = Village.village.stone;
                            var MaxToSend = myStone / Math.Floor(OnePackage);
                            MaxToSend = Math.Ceiling(MaxToSend);
                            var Final = MaxToSend * OnePackage;
                            if (Village.village.stone > Final)
                            {
                                if ((Data.merchants * 1000) > Final)
                                {
                                    var g = await Market.RequestSell.SellStoneFirst(Math.Floor(Final).ToString(), Village.village.id.ToString());
                                    var ratehash = Market.RegexAndJson.RateFinder(g);
                                    StaticVariables.LogsList.Add(DateTime.Now + " Sending request to sell stone " + FinnalValue + " in " + Village.village.id.ToString());
                                    var Finalreq = await Market.RequestSell.SellStoneSecond(Math.Floor(Final).ToString(), Village.village.id.ToString(), ratehash, "1");
                                    StaticVariables.MyVillages.Find(z => z.village.id == Village.village.id).village.stone -=
                                        Math.Floor(Final);
                                }

                            }
                        }
                    }
                    if (StockIron != MaxIron)
                    {
                        var LeftSpace = MaxIron - StockIron;
                        var OnePackage = 1 / Data.rates.iron;
                        var MaxPossiblePackages = LeftSpace / Math.Round(OnePackage);
                        var CounttoSend = Math.Floor(MaxPossiblePackages);
                        var FinnalValue = CounttoSend * OnePackage;
                        if (Village.village.iron > Math.Floor(FinnalValue))
                        {
                            if ((Data.merchants * 1000) > FinnalValue)
                            {
                                var g = await Market.RequestSell.SellIronFirst(Math.Floor(FinnalValue).ToString(), Village.village.id.ToString());
                                var ratehash = Market.RegexAndJson.RateFinder(g);
                                StaticVariables.LogsList.Add(DateTime.Now + " Sending request to sell iron " + FinnalValue + " in " + Village.village.id.ToString());
                                var Final = await Market.RequestSell.SellIronSecond(Math.Floor(FinnalValue).ToString(), Village.village.id.ToString(), ratehash, "1");
                                StaticVariables.MyVillages.Find(z => z.village.id == Village.village.id).village.iron -=
                                    Math.Floor(FinnalValue);
                            }

                        }
                        else
                        {
                            var myIron = Village.village.iron;
                            var MaxToSend = myIron / Math.Floor(OnePackage);
                            MaxToSend = Math.Ceiling(MaxToSend);
                            var Final = MaxToSend * OnePackage;
                            if (Village.village.iron > Final)
                            {
                                if ((Data.merchants * 1000) > Final)
                                {
                                    var g = await Market.RequestSell.SellIronFirst(Math.Floor(Final).ToString(), Village.village.id.ToString());
                                    var ratehash = Market.RegexAndJson.RateFinder(g);
                                    StaticVariables.LogsList.Add(DateTime.Now + " Sending request to sell iron " + FinnalValue + " in " + Village.village.id.ToString());
                                    var Finalreq = await Market.RequestSell.SellIronSecond(Math.Floor(Final).ToString(), Village.village.id.ToString(), ratehash, "1");
                                    StaticVariables.MyVillages.Find(z => z.village.id == Village.village.id).village.iron -=
                                        Math.Floor(Final);
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                StaticVariables.LogsList.Add(DateTime.Now + " Something is wrong in market threw exception");
            }            
        }
    }
}
