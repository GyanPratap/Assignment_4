using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que10
{
    internal class Program
    {
        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        static void Main(string[] args)
        {
            Season currentSeason = Season.Summer;
            switch (currentSeason)
            {
                case Season.Spring:
                    Console.WriteLine("It's spring! Flowers are blooming.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's summer! Enjoy the warm weather.");
                    break;
                case Season.Autumn:
                    Console.WriteLine("It's autumn! Leaves are falling.");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's winter! Time to bundle up.");
                    break;
                default:
                    Console.WriteLine("Invalid season.");
                    break;
            }
        }
    }
}

