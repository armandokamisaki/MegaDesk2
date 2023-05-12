using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Desk_Kamisaki
{
    internal class DeskQuote
    {
        public const int BASE_PRICE = 200;
        public const int DRAWER_VALUE = 50;

        Desk desk;
        private string customerName;
        private int rushOrder;
        double totalPrice;
        private string date;
        public DeskQuote(int width, int depth, int drawersNum, DesktopMaterial material, string customerName, int rushOrder) 
        {
            //Create a new Desk object
            Desk desk = new Desk(width, depth, drawersNum, material);
            this.customerName = customerName;
            this.rushOrder = rushOrder;
            totalPrice = CalculateTotalPrice();
            date = DateTime.Now.ToString("dd MMMM yyyy");
        }

        public string GetCustomerName() { return customerName; }
        public int GetRushOrder() {  return rushOrder; }
        public double GetTotalPrice() { return totalPrice; } 
        public string GetDate() { return date; }

        public void SetCustomerName(string customerName) { this.customerName = customerName; }
        public void SetRushOrder(int rushOrder) { this.rushOrder = rushOrder; }
        public void SetDate(string date) { this.date = date; }

        public double CalculateTotalPrice()
        {
            
            int width = desk.GetWidth();
            int depth = desk.GetDepth();
            int drawersNum = desk.GetDrawersNum();
            DesktopMaterial material = desk.GetMaterial();

            int deskPrice = CalculateDeskPrice(width, depth);
            int drawersPrice = CalculateDrawersPrice(drawersNum);
            int materialPrice = (int)desk.GetMaterial();
            int rushOrderPrice = CalculateRushOrderPrice(width, depth, rushOrder);
            double totalPrice = deskPrice + drawersPrice + materialPrice + rushOrderPrice; 
            return totalPrice;                        
        }

        public int CalculateDeskPrice(int width, int depth)
        {
            int deskPrice = 0;
            if ((width * depth) < 1000)
            {
                deskPrice = 200;
            }
            else
            {
                deskPrice = (width * depth - 1000) + BASE_PRICE;
            }
            return deskPrice;
        }

        public int CalculateDrawersPrice(int drawersNum) 
        {
            int drawersPrice = drawersNum * DRAWER_VALUE;
            return drawersPrice;
        }

        

        public int CalculateRushOrderPrice(int width, int depth, int rushOrder) 
        {
            int rushOrderPrice = 0;          
            
            // Specifying a file
            string path = @"rushOrderPrices.txt";

            // Calling the ReadAllLines() function
            string[] readText = File.ReadAllLines(path);         
           

            //Array with rush order prices
            int i;
            int j;
            int k = 0;
            string[,] price = new string[3,3];
            try
            {
                while (k < readText.Length)
                {
                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            price[i, j] = readText[k];
                            k++;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error making order prices: ");
                Console.WriteLine(e.Message);
            }
            
            switch (rushOrder)
            {
                case (3):
                    if (width * depth > 2000)
                    {
                        rushOrderPrice = int.Parse(price[0, 2]);
                    }
                    else if (width * depth >= 1000 && width * depth < 2000)
                    {
                        rushOrderPrice = int.Parse(price[0, 1]);
                    }
                    else
                    {
                        rushOrderPrice = int.Parse(price[0, 0]);
                    }
                    return rushOrderPrice;
                    break;
                case (5):
                    if (width * depth > 2000)
                    {
                        rushOrderPrice = int.Parse(price[1, 2]);
                    }
                    else if (width * depth >= 1000 && width * depth < 2000)
                    {
                        rushOrderPrice = int.Parse(price[1, 1]);
                    }
                    else
                    {
                        rushOrderPrice = int.Parse(price[1, 0]);
                    }
                    return rushOrderPrice;
                    break;
                case (7):
                    if (width * depth > 2000)
                    {
                        rushOrderPrice = int.Parse(price[2, 2]);
                    }
                    else if (width * depth >= 1000 && width * depth < 2000)
                    {
                        rushOrderPrice = int.Parse(price[2, 1]);
                    }
                    else
                    {
                        rushOrderPrice = int.Parse(price[2, 0]);
                    }
                    return rushOrderPrice;
                    break;
                default:
                    return rushOrderPrice;                    
            }    

        }

    }
}
