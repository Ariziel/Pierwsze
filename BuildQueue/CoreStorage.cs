using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SilverBot.UserVillages;

namespace SilverBot.BuildQueue
{
    class CoreStorage
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

        private static bool main(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.main.wood;
            var stone = myvill.village.buildings.buildingsReq.main.stone;
            var iron = myvill.village.buildings.buildingsReq.main.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool farm(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.farm.wood;
            var stone = myvill.village.buildings.buildingsReq.farm.stone;
            var iron = myvill.village.buildings.buildingsReq.farm.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool storage(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.storage.wood;
            var stone = myvill.village.buildings.buildingsReq.storage.stone;
            var iron = myvill.village.buildings.buildingsReq.storage.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool place(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.place.wood;
            var stone = myvill.village.buildings.buildingsReq.place.stone;
            var iron = myvill.village.buildings.buildingsReq.place.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool barracks(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.barracks.wood;
            var stone = myvill.village.buildings.buildingsReq.barracks.stone;
            var iron = myvill.village.buildings.buildingsReq.barracks.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool church(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.church.wood;
            var stone = myvill.village.buildings.buildingsReq.church.stone;
            var iron = myvill.village.buildings.buildingsReq.church.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool church_f(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.church_f.wood;
            var stone = myvill.village.buildings.buildingsReq.church_f.stone;
            var iron = myvill.village.buildings.buildingsReq.church_f.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool smith(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.smith.wood;
            var stone = myvill.village.buildings.buildingsReq.smith.stone;
            var iron = myvill.village.buildings.buildingsReq.smith.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool wood(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.wood.wood;
            var stone = myvill.village.buildings.buildingsReq.wood.stone;
            var iron = myvill.village.buildings.buildingsReq.wood.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool stone(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.stone.wood;
            var stone = myvill.village.buildings.buildingsReq.stone.stone;
            var iron = myvill.village.buildings.buildingsReq.stone.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool iron(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.iron.wood;
            var stone = myvill.village.buildings.buildingsReq.iron.stone;
            var iron = myvill.village.buildings.buildingsReq.iron.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool market(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.market.wood;
            var stone = myvill.village.buildings.buildingsReq.market.stone;
            var iron = myvill.village.buildings.buildingsReq.market.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool stable(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.stable.wood;
            var stone = myvill.village.buildings.buildingsReq.stable.stone;
            var iron = myvill.village.buildings.buildingsReq.stable.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool wall(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.wall.wood;
            var stone = myvill.village.buildings.buildingsReq.wall.stone;
            var iron = myvill.village.buildings.buildingsReq.wall.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool garage(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.garage.wood;
            var stone = myvill.village.buildings.buildingsReq.garage.stone;
            var iron = myvill.village.buildings.buildingsReq.garage.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool hide(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.hide.wood;
            var stone = myvill.village.buildings.buildingsReq.hide.stone;
            var iron = myvill.village.buildings.buildingsReq.hide.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool snob(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.snob.wood;
            var stone = myvill.village.buildings.buildingsReq.snob.stone;
            var iron = myvill.village.buildings.buildingsReq.snob.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool statue(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.statue.wood;
            var stone = myvill.village.buildings.buildingsReq.statue.stone;
            var iron = myvill.village.buildings.buildingsReq.statue.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool watchtower(VillageStructure.Example myvill)
        {
            var wood = myvill.village.buildings.buildingsReq.watchtower.wood;
            var stone = myvill.village.buildings.buildingsReq.watchtower.stone;
            var iron = myvill.village.buildings.buildingsReq.watchtower.iron;
            if (wood > myvill.village.wood || stone > myvill.village.stone || iron > myvill.village.iron)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
