using System;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        //Opens the form to add a new quote
        private void addButton_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = new AddQuote();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            Hide();
        }


        //Opens the View All Quotes view
        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes view = new ViewAllQuotes();
            view.Tag = this;
            view.Show(this);
            Hide();
        }


        //Opens the Search Quotes view
        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotes = new SearchQuotes();
            viewSearchQuotes.Tag = this;
            viewSearchQuotes.Show(this);
            Hide();
        }

        //Exit the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
