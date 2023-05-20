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
using Newtonsoft.Json;
using static System.IO.File;

namespace Mega_Desk_Kamisaki
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            loadGrid();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu main = this.Tag as MainMenu;
            main.Show();
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
    }
}
