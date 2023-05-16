using System;
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
        List<DesktopMaterial> materials;
        List<DeskQuote> quotes;
        public AddQuote()
        {
            InitializeComponent();

            List<DeskQuote> quotes = new List<DeskQuote>();

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

        private void getQuoteButton_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(widthValue.Value);
            int depth = Convert.ToInt32(depthValue.Value);
            int drawer = Convert.ToInt32(drawerValue.Value);
            materialList.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            DesktopMaterial material = (DesktopMaterial)materialList.SelectedValue;
            string name = nameText.Text;
            int rushOrder = cmbRushOrder.SelectedIndex;

            DeskQuote quote = new DeskQuote(width, depth, drawer, material, name, rushOrder);

            quotes.Add(quote);

            //DisplayQuote viewDisplayQuote = (DisplayQuote)Tag;
            // viewDisplayQuote.Show();
            //Close();
            //DeskQuote quote = new DeskQuote(width, depth, drawer, material, name, rushOrder);

            //quote.Add(quote);



            DisplayQuote form = new DisplayQuote();
            form.Tag = this.Tag;
            form.Show();
            Close();
          // displayQuote form = new displayQuote(quote) 
        }

        private void materialList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }
    }
}
