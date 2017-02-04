using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverBot.BuildQueue
{
    class Core
    {
        public static bool Calc(UserVillages.VillageStructure.Example myvill, string name)
        {
            switch (name)
            {
                case "Main":
                {
                    return main(myvill);
                }
                case "Farm":
                    {
                        return farm(myvill);
                    }
                case "Storage":
                    {
                        return storage(myvill);
                    }
                case "Place":
                    {
                        return place(myvill);
                    }
                case "Barracks":
                    {
                        return barracks(myvill);
                    }
                case "Church":
                    {
                        return church(myvill);
                    }
                case "Church First":
                    {
                        return church_f(myvill);
                    }
                case "Smith":
                    {
                        return smith(myvill);
                    }
                case "Wood":
                    {
                        return wood(myvill);
                    }
                case "Stone":
                    {
                        return stone(myvill);
                    }
                case "Iron":
                    {
                        return iron(myvill);
                    }
                case "Market":
                    {
                        return market(myvill);
                    }
                case "Stable":
                    {
                        return stable(myvill);
                    }
                case "Wall":
                    {
                        return wall(myvill);
                    }
                case "Garage":
                    {
                        return garage(myvill);
                    }
                case "Hide":
                    {
                        return hide(myvill);
                    }
                case "Snob":
                    {
                        return snob(myvill);
                    }
                case "Statue":
                    {
                        return statue(myvill);
                    }
                case "Watchtower":
                    {
                        return watchtower(myvill);
                    }
            }
            return false;
        }

        private static bool main(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Main.Wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.main; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Main.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Main.Stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.main; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Main.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Main.Iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.main; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Main.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }

        private static bool farm(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Farm.Wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.farm; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Farm.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Farm.Stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.farm; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Farm.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Farm.Iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.farm; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Farm.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }

        private static bool storage(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Storage.Wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.storage; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Storage.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Storage.Stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.storage; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Storage.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Storage.Iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.storage; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Storage.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }

        private static bool place(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Place.Wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.place; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Place.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Place.Stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.place; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Place.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Place.Iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.place; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Place.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }

        private static bool barracks(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Barracks.Wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.barracks; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Barracks.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Barracks.Stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.barracks; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Barracks.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Barracks.Iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.barracks; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Barracks.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }

        private static bool church(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Church.Wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.church; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Church.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Church.Stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.church; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Church.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Church.Iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.church; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Church.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }

        private static bool church_f(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Church_f.Wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.church_f; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Church_f.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Church_f.Stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.church_f; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Church_f.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Church_f.Iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.church_f; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Church_f.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }

        private static bool smith(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Smith.Wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.smith; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Smith.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Smith.Stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.smith; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Smith.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Smith.Iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.smith; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Smith.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }

        private static bool wood(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Wood.wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.wood; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Wood.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Wood.Stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.wood; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Wood.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Wood.Iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.wood; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Wood.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }

        private static bool stone(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Stone.Wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.stone; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Stone.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Stone.stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.stone; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Stone.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Stone.Iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.stone; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Stone.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }

        private static bool iron(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Iron.Wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.iron; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Iron.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Iron.Stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.iron; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Iron.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Iron.iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.iron; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Iron.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }

        private static bool market(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Market.Wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.market; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Market.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Market.Stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.market; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Market.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Market.Iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.market; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Market.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }

        private static bool stable(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Stable.Wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.stable; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Stable.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Stable.Stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.stable; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Stable.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Stable.Iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.stable; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Stable.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }

        private static bool wall(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Wall.Wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.wall; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Wall.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Wall.Stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.wall; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Wall.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Wall.Iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.wall; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Wall.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }

        private static bool garage(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Garage.Wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.garage; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Garage.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Garage.Stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.garage; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Garage.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Garage.Iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.garage; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Garage.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }

        private static bool hide(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Hide.Wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.hide; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Hide.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Hide.Stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.hide; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Hide.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Hide.Iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.hide; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Hide.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }

        private static bool snob(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Snob.Wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.snob; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Snob.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Snob.Stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.snob; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Snob.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Snob.Iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.snob; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Snob.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }

        private static bool statue(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Statue.Wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.statue; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Statue.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Statue.Stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.statue; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Statue.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Statue.Iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.statue; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Statue.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }

        private static bool watchtower(UserVillages.VillageStructure.Example myvill)
        {
            var wood = double.Parse(StaticVariables.WorldSettingsBuildings.Watchtower.Wood, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.watchtower; i++)
            {
                wood *= double.Parse(StaticVariables.WorldSettingsBuildings.Watchtower.Wood_factor, CultureInfo.InvariantCulture);
            }
            wood = Math.Ceiling(wood);

            var stone = double.Parse(StaticVariables.WorldSettingsBuildings.Watchtower.Stone, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.watchtower; i++)
            {
                stone *= double.Parse(StaticVariables.WorldSettingsBuildings.Watchtower.Stone_factor, CultureInfo.InvariantCulture);
            }
            stone = Math.Ceiling(stone);
            var iron = double.Parse(StaticVariables.WorldSettingsBuildings.Watchtower.Iron, CultureInfo.InvariantCulture);
            for (int i = 0; i < myvill.village.buildings.watchtower; i++)
            {
                iron *= double.Parse(StaticVariables.WorldSettingsBuildings.Watchtower.Iron_factor, CultureInfo.InvariantCulture);
            }
            iron = Math.Ceiling(iron);
            if (wood < myvill.village.wood && stone < myvill.village.stone &&
                iron < myvill.village.iron)
            {
                return true;
            }
            return false;
        }
    }
}
