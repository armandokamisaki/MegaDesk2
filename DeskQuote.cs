using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Desk_Kamisaki
{
    public class DeskQuote
    {
        //Constants
        public const int BASE_PRICE = 200;
        public const int DRAWER_VALUE = 50;

        //Quote date
        string today = DateTime.Now.ToString("dd MMMM yyyy");

        //Properties
        public Desk Desk { get; set; }
       
        public string CustomerName { get; set; }
        public int RushPrice { get; set; }
        public int TotalPrice { get; set; }
        public string date { get; set; }
        
        

        
        public int CalculateTotalPrice(int width, int depth, int drawersNum, DesktopMaterial material, int rushPrice)
        {

            
            int deskPrice = CalculateDeskPrice(width, depth);
            int drawersPrice = CalculateDrawersPrice(drawersNum);
            int materialPrice = (int)material;
            int rushOrderPrice = CalculateRushOrderPrice(width, depth, rushPrice);
            int totalPrice = deskPrice + drawersPrice + materialPrice + rushOrderPrice; 
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
                   
                default:
                    return rushOrderPrice;                    
            }    

        }
        //Return oject's information
        public override string ToString() { 
            return "Customer Name: " + CustomerName + "\r\n Quote date: " + date + "\r\n Width: " + this.Desk.Width + "\r\n Depth: " + this.Desk.Depth + "\r\n Number of drawers: " + this.Desk.DrawersNum +
                "\r\n Surface Material: " + this.Desk.DeskMaterial.ToString() + "\r\n Rush Order (days): " +
                this.RushPrice + "\r\n Total Price: $" + this.TotalPrice.ToString("N2") + "\r\n";
        }

    }
}
