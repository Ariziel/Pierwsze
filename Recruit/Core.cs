using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverBot.Recruit
{
    public class Core
    {
        public static double CheckSpear(string torecruit, string villid)
        {
            var village = StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid);
            var wood = StaticVariables.WorldUnitInfo.Spear.Wood;
            var stone = StaticVariables.WorldUnitInfo.Spear.Stone;
            var iron = StaticVariables.WorldUnitInfo.Spear.Iron;
            var TotalToRecruit = int.Parse(torecruit, CultureInfo.InvariantCulture);
            if (TotalToRecruit >= StaticVariables.MinimumInfantryPackage)
            {
                var maxFromWood = Math.Floor(village.village.wood/double.Parse(wood, CultureInfo.InvariantCulture));
                var maxFromStone = Math.Floor(village.village.stone / double.Parse(stone, CultureInfo.InvariantCulture));
                var maxFromIron = Math.Floor(village.village.iron / double.Parse(iron, CultureInfo.InvariantCulture));
                if (StaticVariables.MinimumInfantryPackage <= maxFromWood && StaticVariables.MinimumInfantryPackage <= maxFromStone && StaticVariables.MinimumInfantryPackage <= maxFromIron)
                {                
                    return StaticVariables.MinimumInfantryPackage;
                }
            }
            return 0;
        }

        public static void RemoveResourcesSpear(string villid)
        {
            var wood = StaticVariables.WorldUnitInfo.Spear.Wood;
            var stone = StaticVariables.WorldUnitInfo.Spear.Stone;
            var iron = StaticVariables.WorldUnitInfo.Spear.Iron;
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.wood -=
                       (StaticVariables.MinimumInfantryPackage * double.Parse(wood, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.stone -=
                (StaticVariables.MinimumInfantryPackage * double.Parse(stone, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.iron -=
                (StaticVariables.MinimumInfantryPackage * double.Parse(iron, CultureInfo.InvariantCulture));
        }

        public static double CheckSword(string torecruit, string villid)
        {
            var village = StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid);
            var wood = StaticVariables.WorldUnitInfo.Sword.Wood;
            var stone = StaticVariables.WorldUnitInfo.Sword.Stone;
            var iron = StaticVariables.WorldUnitInfo.Sword.Iron;
            var TotalToRecruit = int.Parse(torecruit, CultureInfo.InvariantCulture);
            if (TotalToRecruit >= StaticVariables.MinimumInfantryPackage)
            {
                var maxFromWood = Math.Floor(village.village.wood / double.Parse(wood, CultureInfo.InvariantCulture));
                var maxFromStone = Math.Floor(village.village.stone / double.Parse(stone, CultureInfo.InvariantCulture));
                var maxFromIron = Math.Floor(village.village.iron / double.Parse(iron, CultureInfo.InvariantCulture));
                if (StaticVariables.MinimumInfantryPackage <= maxFromWood && StaticVariables.MinimumInfantryPackage <= maxFromStone && StaticVariables.MinimumInfantryPackage <= maxFromIron)
                {
                    return StaticVariables.MinimumInfantryPackage;
                }
            }
            return 0;
        }

        public static void RemoveResourcesSword(string villid)
        {
            var wood = StaticVariables.WorldUnitInfo.Sword.Wood;
            var stone = StaticVariables.WorldUnitInfo.Sword.Stone;
            var iron = StaticVariables.WorldUnitInfo.Sword.Iron;
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.wood -=
                       (StaticVariables.MinimumInfantryPackage * double.Parse(wood, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.stone -=
                (StaticVariables.MinimumInfantryPackage * double.Parse(stone, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.iron -=
                (StaticVariables.MinimumInfantryPackage * double.Parse(iron, CultureInfo.InvariantCulture));
        }

        public static double CheckAxe(string torecruit, string villid)
        {
            var village = StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid);
            var wood = StaticVariables.WorldUnitInfo.Axe.Wood;
            var stone = StaticVariables.WorldUnitInfo.Axe.Stone;
            var iron = StaticVariables.WorldUnitInfo.Axe.Iron;
            var TotalToRecruit = int.Parse(torecruit, CultureInfo.InvariantCulture);
            if (TotalToRecruit >= StaticVariables.MinimumInfantryPackage)
            {
                var maxFromWood = Math.Floor(village.village.wood / double.Parse(wood, CultureInfo.InvariantCulture));
                var maxFromStone = Math.Floor(village.village.stone / double.Parse(stone, CultureInfo.InvariantCulture));
                var maxFromIron = Math.Floor(village.village.iron / double.Parse(iron, CultureInfo.InvariantCulture));
                if (StaticVariables.MinimumInfantryPackage <= maxFromWood && StaticVariables.MinimumInfantryPackage <= maxFromStone && StaticVariables.MinimumInfantryPackage <= maxFromIron)
                {
                    return StaticVariables.MinimumInfantryPackage;
                }
            }
            return 0;
        }

        public static void RemoveResourcesAxe(string villid)
        {
            var wood = StaticVariables.WorldUnitInfo.Axe.Wood;
            var stone = StaticVariables.WorldUnitInfo.Axe.Stone;
            var iron = StaticVariables.WorldUnitInfo.Axe.Iron;
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.wood -=
                       (StaticVariables.MinimumInfantryPackage * double.Parse(wood, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.stone -=
                (StaticVariables.MinimumInfantryPackage * double.Parse(stone, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.iron -=
                (StaticVariables.MinimumInfantryPackage * double.Parse(iron, CultureInfo.InvariantCulture));
        }

        public static double CheckArcher(string torecruit, string villid)
        {
            var village = StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid);
            var wood = StaticVariables.WorldUnitInfo.Archer.Wood;
            var stone = StaticVariables.WorldUnitInfo.Archer.Stone;
            var iron = StaticVariables.WorldUnitInfo.Archer.Iron;
            var TotalToRecruit = int.Parse(torecruit, CultureInfo.InvariantCulture);
            if (TotalToRecruit >= StaticVariables.MinimumInfantryPackage)
            {
                var maxFromWood = Math.Floor(village.village.wood / double.Parse(wood, CultureInfo.InvariantCulture));
                var maxFromStone = Math.Floor(village.village.stone / double.Parse(stone, CultureInfo.InvariantCulture));
                var maxFromIron = Math.Floor(village.village.iron / double.Parse(iron, CultureInfo.InvariantCulture));
                if (StaticVariables.MinimumInfantryPackage <= maxFromWood && StaticVariables.MinimumInfantryPackage <= maxFromStone && StaticVariables.MinimumInfantryPackage <= maxFromIron)
                {
                    return StaticVariables.MinimumInfantryPackage;
                }
            }
            return 0;
        }

        public static void RemoveResourcesArcher(string villid)
        {
            var wood = StaticVariables.WorldUnitInfo.Archer.Wood;
            var stone = StaticVariables.WorldUnitInfo.Archer.Stone;
            var iron = StaticVariables.WorldUnitInfo.Archer.Iron;
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.wood -=
                       (StaticVariables.MinimumInfantryPackage * double.Parse(wood, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.stone -=
                (StaticVariables.MinimumInfantryPackage * double.Parse(stone, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.iron -=
                (StaticVariables.MinimumInfantryPackage * double.Parse(iron, CultureInfo.InvariantCulture));
        }

        public static double CheckSpy(string torecruit, string villid)
        {
            var village = StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid);
            var wood = StaticVariables.WorldUnitInfo.Spy.Wood;
            var stone = StaticVariables.WorldUnitInfo.Spy.Stone;
            var iron = StaticVariables.WorldUnitInfo.Spy.Iron;
            var TotalToRecruit = int.Parse(torecruit, CultureInfo.InvariantCulture);
            if (TotalToRecruit >= StaticVariables.MinimumCavalaryPackage)
            {
                var maxFromWood = Math.Floor(village.village.wood / double.Parse(wood, CultureInfo.InvariantCulture));
                var maxFromStone = Math.Floor(village.village.stone / double.Parse(stone, CultureInfo.InvariantCulture));
                var maxFromIron = Math.Floor(village.village.iron / double.Parse(iron, CultureInfo.InvariantCulture));
                if (StaticVariables.MinimumCavalaryPackage <= maxFromWood && StaticVariables.MinimumCavalaryPackage <= maxFromStone && StaticVariables.MinimumCavalaryPackage <= maxFromIron)
                {
                    return StaticVariables.MinimumCavalaryPackage;
                }
            }
            return 0;
        }

        public static void RemoveResourcesSpy(string villid)
        {
            var wood = StaticVariables.WorldUnitInfo.Spy.Wood;
            var stone = StaticVariables.WorldUnitInfo.Spy.Stone;
            var iron = StaticVariables.WorldUnitInfo.Spy.Iron;
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.wood -=
                       (StaticVariables.MinimumCavalaryPackage * double.Parse(wood, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.stone -=
                (StaticVariables.MinimumCavalaryPackage * double.Parse(stone, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.iron -=
                (StaticVariables.MinimumCavalaryPackage * double.Parse(iron, CultureInfo.InvariantCulture));
        }

        public static double CheckLight(string torecruit, string villid)
        {
            var village = StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid);
            var wood = StaticVariables.WorldUnitInfo.Light.Wood;
            var stone = StaticVariables.WorldUnitInfo.Light.Stone;
            var iron = StaticVariables.WorldUnitInfo.Light.Iron;
            var TotalToRecruit = int.Parse(torecruit, CultureInfo.InvariantCulture);
            if (TotalToRecruit >= StaticVariables.MinimumCavalaryPackage)
            {
                var maxFromWood = Math.Floor(village.village.wood / double.Parse(wood, CultureInfo.InvariantCulture));
                var maxFromStone = Math.Floor(village.village.stone / double.Parse(stone, CultureInfo.InvariantCulture));
                var maxFromIron = Math.Floor(village.village.iron / double.Parse(iron, CultureInfo.InvariantCulture));
                if (StaticVariables.MinimumCavalaryPackage <= maxFromWood && StaticVariables.MinimumCavalaryPackage <= maxFromStone && StaticVariables.MinimumCavalaryPackage <= maxFromIron)
                {
                    return StaticVariables.MinimumCavalaryPackage;
                }
            }
            return 0;
        }

        public static void RemoveResourcesLight(string villid)
        {
            var wood = StaticVariables.WorldUnitInfo.Light.Wood;
            var stone = StaticVariables.WorldUnitInfo.Light.Stone;
            var iron = StaticVariables.WorldUnitInfo.Light.Iron;
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.wood -=
                       (StaticVariables.MinimumCavalaryPackage * double.Parse(wood, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.stone -=
                (StaticVariables.MinimumCavalaryPackage * double.Parse(stone, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.iron -=
                (StaticVariables.MinimumCavalaryPackage * double.Parse(iron, CultureInfo.InvariantCulture));
        }

        public static double CheckMarcher(string torecruit, string villid)
        {
            var village = StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid);
            var wood = StaticVariables.WorldUnitInfo.Marcher.Wood;
            var stone = StaticVariables.WorldUnitInfo.Marcher.Stone;
            var iron = StaticVariables.WorldUnitInfo.Marcher.Iron;
            var TotalToRecruit = int.Parse(torecruit, CultureInfo.InvariantCulture);
            if (TotalToRecruit >= StaticVariables.MinimumCavalaryPackage)
            {
                var maxFromWood = Math.Floor(village.village.wood / double.Parse(wood, CultureInfo.InvariantCulture));
                var maxFromStone = Math.Floor(village.village.stone / double.Parse(stone, CultureInfo.InvariantCulture));
                var maxFromIron = Math.Floor(village.village.iron / double.Parse(iron, CultureInfo.InvariantCulture));
                if (StaticVariables.MinimumCavalaryPackage <= maxFromWood && StaticVariables.MinimumCavalaryPackage <= maxFromStone && StaticVariables.MinimumCavalaryPackage <= maxFromIron)
                {
                    return StaticVariables.MinimumCavalaryPackage;
                }
            }
            return 0;
        }

        public static void RemoveResourcesMarcher(string villid)
        {
            var wood = StaticVariables.WorldUnitInfo.Marcher.Wood;
            var stone = StaticVariables.WorldUnitInfo.Marcher.Stone;
            var iron = StaticVariables.WorldUnitInfo.Marcher.Iron;
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.wood -=
                       (StaticVariables.MinimumCavalaryPackage * double.Parse(wood, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.stone -=
                (StaticVariables.MinimumCavalaryPackage * double.Parse(stone, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.iron -=
                (StaticVariables.MinimumCavalaryPackage * double.Parse(iron, CultureInfo.InvariantCulture));
        }

        public static double CheckHeavy(string torecruit, string villid)
        {
            var village = StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid);
            var wood = StaticVariables.WorldUnitInfo.Heavy.Wood;
            var stone = StaticVariables.WorldUnitInfo.Heavy.Stone;
            var iron = StaticVariables.WorldUnitInfo.Heavy.Iron;
            var TotalToRecruit = int.Parse(torecruit, CultureInfo.InvariantCulture);
            if (TotalToRecruit >= StaticVariables.MinimumCavalaryPackage)
            {
                var maxFromWood = Math.Floor(village.village.wood / double.Parse(wood, CultureInfo.InvariantCulture));
                var maxFromStone = Math.Floor(village.village.stone / double.Parse(stone, CultureInfo.InvariantCulture));
                var maxFromIron = Math.Floor(village.village.iron / double.Parse(iron, CultureInfo.InvariantCulture));
                if (StaticVariables.MinimumCavalaryPackage <= maxFromWood && StaticVariables.MinimumCavalaryPackage <= maxFromStone && StaticVariables.MinimumCavalaryPackage <= maxFromIron)
                {
                    return StaticVariables.MinimumCavalaryPackage;
                }
            }
            return 0;
        }

        public static void RemoveResourcesHeavy(string villid)
        {
            var wood = StaticVariables.WorldUnitInfo.Heavy.Wood;
            var stone = StaticVariables.WorldUnitInfo.Heavy.Stone;
            var iron = StaticVariables.WorldUnitInfo.Heavy.Iron;
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.wood -=
                       (StaticVariables.MinimumCavalaryPackage * double.Parse(wood, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.stone -=
                (StaticVariables.MinimumCavalaryPackage * double.Parse(stone, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.iron -=
                (StaticVariables.MinimumCavalaryPackage * double.Parse(iron, CultureInfo.InvariantCulture));
        }

        public static double CheckRam(string torecruit, string villid)
        {
            var village = StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid);
            var wood = StaticVariables.WorldUnitInfo.Ram.Wood;
            var stone = StaticVariables.WorldUnitInfo.Ram.Stone;
            var iron = StaticVariables.WorldUnitInfo.Ram.Iron;
            var TotalToRecruit = int.Parse(torecruit, CultureInfo.InvariantCulture);
            if (TotalToRecruit >= StaticVariables.MinimumOthersPackage)
            {
                var maxFromWood = Math.Floor(village.village.wood / double.Parse(wood, CultureInfo.InvariantCulture));
                var maxFromStone = Math.Floor(village.village.stone / double.Parse(stone, CultureInfo.InvariantCulture));
                var maxFromIron = Math.Floor(village.village.iron / double.Parse(iron, CultureInfo.InvariantCulture));
                if (StaticVariables.MinimumOthersPackage <= maxFromWood && StaticVariables.MinimumOthersPackage <= maxFromStone && StaticVariables.MinimumOthersPackage <= maxFromIron)
                {
                    return StaticVariables.MinimumOthersPackage;
                }
            }
            return 0;
        }

        public static void RemoveResourcesRam(string villid)
        {
            var wood = StaticVariables.WorldUnitInfo.Ram.Wood;
            var stone = StaticVariables.WorldUnitInfo.Ram.Stone;
            var iron = StaticVariables.WorldUnitInfo.Ram.Iron;
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.wood -=
                       (StaticVariables.MinimumOthersPackage * double.Parse(wood, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.stone -=
                (StaticVariables.MinimumOthersPackage * double.Parse(stone, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.iron -=
                (StaticVariables.MinimumOthersPackage * double.Parse(iron, CultureInfo.InvariantCulture));
        }

        public static double CheckCatapult(string torecruit, string villid)
        {
            var village = StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid);
            var wood = StaticVariables.WorldUnitInfo.Catapult.Wood;
            var stone = StaticVariables.WorldUnitInfo.Catapult.Stone;
            var iron = StaticVariables.WorldUnitInfo.Catapult.Iron;
            var TotalToRecruit = int.Parse(torecruit, CultureInfo.InvariantCulture);
            if (TotalToRecruit >= StaticVariables.MinimumOthersPackage)
            {
                var maxFromWood = Math.Floor(village.village.wood / double.Parse(wood, CultureInfo.InvariantCulture));
                var maxFromStone = Math.Floor(village.village.stone / double.Parse(stone, CultureInfo.InvariantCulture));
                var maxFromIron = Math.Floor(village.village.iron / double.Parse(iron, CultureInfo.InvariantCulture));
                if (StaticVariables.MinimumOthersPackage <= maxFromWood && StaticVariables.MinimumOthersPackage <= maxFromStone && StaticVariables.MinimumOthersPackage <= maxFromIron)
                {
                    return StaticVariables.MinimumOthersPackage;
                }
            }
            return 0;
        }

        public static void RemoveResourcesCatapult(string villid)
        {
            var wood = StaticVariables.WorldUnitInfo.Catapult.Wood;
            var stone = StaticVariables.WorldUnitInfo.Catapult.Stone;
            var iron = StaticVariables.WorldUnitInfo.Catapult.Iron;
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.wood -=
                       (StaticVariables.MinimumOthersPackage * double.Parse(wood, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.stone -=
                (StaticVariables.MinimumOthersPackage * double.Parse(stone, CultureInfo.InvariantCulture));
            StaticVariables.MyVillages.Find(x => x.village.id.ToString() == villid).village.iron -=
                (StaticVariables.MinimumOthersPackage * double.Parse(iron, CultureInfo.InvariantCulture));
        }
    }
}
