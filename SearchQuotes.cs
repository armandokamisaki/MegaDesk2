using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mega_Desk_Kamisaki
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();

            List<string> desktopMaterials = Enum.GetNames(typeof(DesktopMaterial)).ToList();

            desktopMaterials.Insert(0, "All Materials");

            comSurfaceMaterial.DataSource = desktopMaterials;

            loadGrid();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu main = this.Tag as MainMenu;
            main.Show();
        }

        private void comSurfaceMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;

            if (combo.SelectedIndex == 0)
            {
                loadGrid();
            }
            else
            {
                loadGrid(combo.SelectedValue.ToString());
            }
        }
        private void loadGrid()
        {
            var quotesFile = @"quotes.json";
            if (System.IO.File.Exists(quotesFile))
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(quotesFile))
                {
                    string quotes = reader.ReadToEnd();
                    List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                    dataGridView1.DataSource = deskQuotes.Select(d => new {
                        Date = d.date,
                        Customer = d.CustomerName,
                        Depth = d.Desk.Depth,
                        Width = d.Desk.Width,
                        Drawers = d.Desk.DrawersNum,
                        SurfaceMaterial = d.Desk.DeskMaterial,
                        DeliveryTipe = d.RushPrice,
                        QuoteAmount = d.TotalPrice.ToString("c")

                    }).ToList();
                }
            }
        }

        private void loadGrid(string desktopMaterial)
        {
            var quotesFile = @"quotes.json";
            if (System.IO.File.Exists(quotesFile))
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(quotesFile))
                {
                    string quotes = reader.ReadToEnd();
                    List<DeskQuote> deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);
                    DesktopMaterial desktopMaterialEnum = (DesktopMaterial)Enum.Parse(typeof(DesktopMaterial), desktopMaterial);
                    dataGridView1.DataSource = deskQuotes.Select(d => new {
                        Date = d.date,
                        Customer = d.CustomerName,
                        Depth = d.Desk.Depth,
                        Width = d.Desk.Width,
                        Drawers = d.Desk.DrawersNum,
                        SurfaceMaterial = d.Desk.DeskMaterial,
                        DeliveryTipe = d.RushPrice,
                        QuoteAmount = d.TotalPrice.ToString("c")

                    }).Where(q => q.SurfaceMaterial == desktopMaterialEnum).ToList();
                }
            }
        }
    }
}
