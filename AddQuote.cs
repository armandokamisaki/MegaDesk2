using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mega_Desk_Kamisaki
{
    public partial class AddQuote : Form
    {
        public static AddQuote instance;
        List<DesktopMaterial> materials;
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
            mainMenu viewMainMenu = (mainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainMenu main = this.Tag as mainMenu;
            main.Show();
        }

        public void getQuoteButton_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk();
            desk.Width = Convert.ToInt32(widthValue.Value);
            desk.Depth = Convert.ToInt32(depthValue.Value);
            desk.DrawersNum = Convert.ToInt32(drawerValue.Value);

            //Set value for number od drawers
            switch(desk.DrawersNum)
            {
                case 0:
                    desk.DrawersNum = 3;
                    break;
                case 1:
                    desk.DrawersNum = 5;
                    break;
                case 2:
                    desk.DrawersNum = 7;
                    break;
                default:
                    desk.DrawersNum = 0;
                    break;
            }

            materialList.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            desk.DeskMaterial = (DesktopMaterial)materialList.SelectedValue;

            DeskQuote quote = new DeskQuote();
            quote.CustomerName = nameText.Text;
            quote.RushPrice = cmbRushOrder.SelectedIndex;
            quote.TotalPrice = quote.CalculateTotalPrice(desk.Width, desk.Depth, desk.DrawersNum, desk.DeskMaterial, quote.RushPrice);
            quote.Desk = desk;

           

            ArrayList quotes = new ArrayList();
            quotes.Add(quote);

            DisplayQuote viewDisplayQuote = (DisplayQuote)Tag;
            viewDisplayQuote.Show();
            Close();
        }

        private void materialList_SelectedIndexChanged(object sender, EventArgs e)
        {          
            
        }
        
    }
}
