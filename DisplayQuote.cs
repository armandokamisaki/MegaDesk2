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

namespace Mega_Desk_Kamisaki
{
    public partial class DisplayQuote : Form
    {
              
        public DeskQuote quote;
        public DisplayQuote(DeskQuote quotes)
        {
            InitializeComponent();

                    
            this.quote = quotes;
            
            //Display deskquote at the TextBox
            TextDisplay.Text = quote.ToString();
        }
                       
        private void btnmenu_Click(object sender, EventArgs e)
        {
            Application.OpenForms[2].Close();
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Close();
        }
    }   
}
