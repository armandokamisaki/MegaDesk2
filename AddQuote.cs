using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mega_Desk_Kamisaki
{
    public partial class AddQuote : Form
    {
        public static AddQuote instance;
       
        public DeskQuote quote;

        public AddQuote()
        {
            InitializeComponent();
            instance = this;
          
           
            List<DesktopMaterial> materials = new List<DesktopMaterial>();
            materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            foreach (DesktopMaterial material in materials)
            {
                if (materials.Contains(material))
                {
                    materialList.Items.Add(material);
                }
            }
        }



        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu main = this.Tag as MainMenu;
            main.Show();
        }

        public void getQuoteButton_Click(object sender, EventArgs e)
        {
            //Creat a desk object and set the value for the properties
            Desk desk = new Desk();
            desk.Width = Convert.ToInt32(widthValue.Value);
            desk.Depth = Convert.ToInt32(depthValue.Value);
            desk.DrawersNum = Convert.ToInt32(drawerValue.Value);                
            //Get the value for Desktop material
            materialList.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            desk.DeskMaterial = (DesktopMaterial)materialList.SelectedValue;

            //Create a DeskQuote object and set the value for the properties
            DeskQuote quote = new DeskQuote();
            quote.CustomerName = nameText.Text;
            quote.RushPrice = Convert.ToInt32(cmbRushOrder.SelectedIndex);
            quote.RushPrice = CalculateRushOrder(quote.RushPrice);            
            quote.TotalPrice = quote.CalculateTotalPrice(desk.Width, desk.Depth, desk.DrawersNum, desk.DeskMaterial, quote.RushPrice);
            quote.Desk = desk;
                       
            //Create an array and add the DeskQuote object to it
            ArrayList quotes = new ArrayList();
            quotes.Add(quote);

            //DisplayQuote viewDisplayQuote = (DisplayQuote)Tag;
            DisplayQuote display = new DisplayQuote(quote);
            display.Show();
            //this.Close();
        }

        private void materialList_SelectedIndexChanged(object sender, EventArgs e)
        {          
            
        }
        public int CalculateRushOrder(int rushPrice)
        {
            //Set value for number of days for rush order
            int days = 0;
            switch (rushPrice)
            {
                case 0:
                    days = 3;
                    break;
                case 1:
                    days = 5;
                    break;
                case 2:
                     days = 7;
                    break;
                default:
                    days = 0;       
                    break;
            }
            return days;

        }
        
    }
}
