using System;
using System.Collections.Generic;
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
        private DateTime date;
        public DeskQuote(int width, int depth, int drawersNum, DesktopMaterial material, string customerName, int rushOrder) 
        {
            //Create a new Desk object
            Desk desk = new Desk(width, depth, drawersNum, material);
            this.customerName = customerName;
            this.rushOrder = rushOrder;
            totalPrice = calculateTotalPrice();
            date = DateTime.Now;
        }

        public string getCustomerName() { return customerName; }
        public int getRushOrder() {  return rushOrder; }
        public double getTotalPrice() { return totalPrice; } 
        public DateTime getDate() { return date; }

        public void setCustomerName(string customerName) { this.customerName = customerName; }
        public void setRushOrder(int rushOrder) { this.rushOrder = rushOrder; }
        public void setDate(DateTime date) { this.date = date; }

        public double calculateTotalPrice()
        {
            
            int width = desk.getWidth();
            int depth = desk.getDepth();
            int drawersNum = desk.getDrawersNum();
            DesktopMaterial material = desk.getMaterial();

            int deskPrice = calculateDeskPrice(width, depth);
            int drawersPrice = calculateDrawersPrice(drawersNum);
            int materialPrice = (int)desk.getMaterial();
            int rushOrderPrice = calculateRushOrderPrice(width, depth, rushOrder);
            double totalPrice = deskPrice + drawersPrice + materialPrice + rushOrderPrice; 
            return totalPrice;                        
        }

        public int calculateDeskPrice(int width, int depth)
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

        public int calculateDrawersPrice(int drawersNum) 
        {
            int drawersPrice = drawersNum * DRAWER_VALUE;
            return drawersPrice;
        }

        

        public int calculateRushOrderPrice(int width, int depth, int rushOrder) 
        {
            int rushOrderPrice = 0;
            switch (rushOrder)
            {
                case (3):
                    if (width * depth > 2000)
                    {
                        rushOrderPrice = 80;
                    }
                    else if (width * depth >= 1000 && width * depth < 2000)
                    {
                        rushOrderPrice = 70;
                    }
                    else
                    {
                        rushOrderPrice = 60;
                    }
                    return rushOrderPrice;
                    break;
                case (5):
                    if (width * depth > 2000)
                    {
                        rushOrderPrice = 60;
                    }
                    else if (width * depth >= 1000 && width * depth < 2000)
                    {
                        rushOrderPrice = 50;
                    }
                    else
                    {
                        rushOrderPrice = 40;
                    }
                    return rushOrderPrice;
                    break;
                case (7):
                    if (width * depth > 2000)
                    {
                        rushOrderPrice = 40;
                    }
                    else if (width * depth >= 1000 && width * depth < 2000)
                    {
                        rushOrderPrice = 35;
                    }
                    else
                    {
                        rushOrderPrice = 30;
                    }
                    return rushOrderPrice;
                    break;
                default:
                    return rushOrderPrice;                    
            }    

        }

    }
}
