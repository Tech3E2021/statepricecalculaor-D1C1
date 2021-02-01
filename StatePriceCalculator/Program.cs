using System;

namespace StatePriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double noItems = 0;
            double itemPrice = 0;
            double totalPrice = 0;
            double totalPriceDiscount = 0;
            double totalPriceDiscountTax = 0;
            string stateCode;
            // userstory 1
            //En velkommen besked til brugeren bår programmet starter
            Console.WriteLine("velkommen til lommeregneren");
            // userstory 2
            //bruger taster antal af vare 
            Console.WriteLine("skriv antallet af vare");
            noItems = Convert.ToInt32(Console.ReadLine());
            // userstory 3
            //bruger taster prisen på varen
            Console.WriteLine("skriv prisen på varen");
            itemPrice = Convert.ToInt32(Console.ReadLine());
            // userstory 4
            //giv brugeren besked om samlet pris
            totalPrice = itemPrice * noItems;
            Console.WriteLine($"den samlede pris uden discount og tax er {totalPrice}");
            // userstory 5
            //spærg om brugeren er don yes no

            // userstory 6
            //hvis nej iterer igennem antal vare og vare pris igen

            // userstory 7
            //udregn discount vis pris
            if (totalPrice <= 999)
            {
                Console.WriteLine("ingen discount");
                totalPriceDiscount = totalPrice;
            }
            else if (totalPrice >= 1000 && totalPrice <= 4999)
            {
                Console.WriteLine("discount 3%");
                totalPriceDiscount = totalPrice * 0.97;
            }
            else if (totalPrice >= 5000 && totalPrice <= 6999)
            {
                Console.WriteLine("discount 5%");
                totalPriceDiscount = totalPrice * 0.95;
            }
            else if (totalPrice >= 7000 && totalPrice <= 9999)
            {
                Console.WriteLine("discount 7%");
                totalPriceDiscount = totalPrice * 0.93;
            }
            else if (totalPrice >= 10000 && totalPrice <= 49999)
            {
                Console.WriteLine("discount 10%");
                totalPriceDiscount = totalPrice * 0.90;
            }
            else
            {
                Console.WriteLine("discount 15%");
                totalPriceDiscount = totalPrice * 0.85;
            }

            //switch (totalPrice)
            //{
            //    case 1 when totalPrice <= 999:
            //        Console.WriteLine("ingen discount");
            //        break;
            //    case 2 when totalPrice >= 1000 && totalPrice <= 4999:
            //        Console.WriteLine("discount 3%");
            //        totalPriceDiscount = totalPrice * 0.97;
            //        break;
            //    case 3 when totalPrice >= 5000 && totalPrice <= 6999:
            //        Console.WriteLine("discount 5%");
            //        totalPriceDiscount = totalPrice * 0.95;
            //        break;
            //    case 4 when totalPrice >= 7000 && totalPrice <= 9999:
            //        Console.WriteLine("discount 7%");
            //        totalPriceDiscount = totalPrice * 0.93;
            //        break;
            //    case 5 when totalPrice >= 10000 && totalPrice <= 49999:
            //        Console.WriteLine("discount 10%");
            //        totalPriceDiscount = totalPrice * 0.90;
            //        break;
            //    default:
            //        Console.WriteLine("discount 15%");
            //        totalPriceDiscount = totalPrice * 0.85;
            //        break;
            //}

            Console.WriteLine($"den samlede pris med discount uden tax er {totalPriceDiscount}");
            // userstory 8
            //indtast stat
            Console.WriteLine("indtast statecode 2 bogstaver");
            stateCode = Console.ReadLine();
            // userstory 9
            //udregn prisen med tax for den specifikke stat
            switch (stateCode)
            {
                case "UT":
                    Console.WriteLine("tax 6.85 % ");
                    totalPriceDiscountTax = totalPriceDiscount* 1.0685;
                    break;
                case "NV":
                    Console.WriteLine("tax 8.00 % ");
                    totalPriceDiscountTax = totalPriceDiscount* 1.08;
                    break;
                case "TX":
                    Console.WriteLine("tax 6.25 % ");
                    totalPriceDiscountTax = totalPriceDiscount* 1.0625;
                    break;
                case "AL":
                    Console.WriteLine("tax 4.00 % ");
                    totalPriceDiscountTax = totalPriceDiscount* 1.04;
                    break;
                case "CA":
                    Console.WriteLine("tax 8.25 % ");
                    totalPriceDiscountTax = totalPriceDiscount* 1.0825;
                    break;
                default:
                    Console.WriteLine("not defined no tax applied please try again");

                    break;
            }
    // userstory 10
    //skriv besked til brugeren med pris samt tax
    Console.WriteLine($"den samlede pris med discount og tax er {totalPriceDiscountTax}");

        }
    }
}
