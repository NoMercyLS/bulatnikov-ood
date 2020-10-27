using Decorator.Beverages;
using Decorator.Condiments;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
			{
				var latte = new CLatte();
				var cinnamon = new CCinnamon(latte);
				var lemon = new CLemon(cinnamon, 2);
				var iceCubes = new CIceCubes(lemon, 2, CIceCubes.IceCubeType.Dry);
				var beverage = new CChocolateCrumbs(iceCubes, 2);

				Console.WriteLine(beverage.GetDescription() + " costs " + beverage.GetCost());
			}
			{
				var beverage =
					new CChocolateCrumbs(
						new CIceCubes(
							new CLemon(
								new CCinnamon(
									new CLatte()),
								2),
							2, CIceCubes.IceCubeType.Dry),
						2);

				Console.WriteLine(beverage.GetDescription() + " costs " + beverage.GetCost());
			}
			{
				var latte = new CLatte(CLatte.LatteSize.Double);
				var cinnamon = new CCinnamon(latte);
				var lemon = new CLemon(cinnamon, 2);
				var iceCubes = new CIceCubes(lemon, 2, CIceCubes.IceCubeType.Dry);
				var beverage = new CChocolateCrumbs(iceCubes, 2);

				Console.WriteLine(beverage.GetDescription() + " costs " + beverage.GetCost());
			}
			{
				var cappuccino = new CCappucino(CCappucino.CappucinoSize.Standart);
				var cinnamon = new CCinnamon(cappuccino);
				var lemon = new CLemon(cinnamon, 2);
				var iceCubes = new CIceCubes(lemon, 2, CIceCubes.IceCubeType.Dry);
				var liquor = new CLiquor(iceCubes, CLiquor.LiquorType.Nut);
				var beverage = new CChocolateCrumbs(liquor, 2);

				Console.WriteLine(beverage.GetDescription() + " costs " + beverage.GetCost());
			}
			{
				var tea = new CTea(CTea.TeaType.DaHongPao);
				var cinnamon = new CCinnamon(tea);
				var lemon = new CLemon(cinnamon, 2);
				var iceCubes = new CIceCubes(lemon, 2, CIceCubes.IceCubeType.Dry);
				var beverage = new CChocolateCrumbs(iceCubes, 2);

				Console.WriteLine(beverage.GetDescription() + " costs " + beverage.GetCost());
			}
		}
    }
}
