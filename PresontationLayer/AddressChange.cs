using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace PresontationLayer
{
    public partial class AddressChange : Form
    {
        CustomerDataContext ctx = new CustomerDataContext();
        int IDUsed = -1;
        public AddressChange(int IDToChange)
        {
            InitializeComponent();
            IDUsed = IDToChange;
            ctx.Update(ctx.Addresses.Where(c => c.CustomerId == IDUsed).FirstOrDefault());
        }

        private void AddressChange_Load(object sender, EventArgs e)
        {
            StreetInOut.Text = ctx.Addresses.Where(s => s.CustomerId == IDUsed).Select(s => s.Street).FirstOrDefault().ToString();
            CityInOut.Text = ctx.Addresses.Where(s => s.CustomerId == IDUsed).Select(s => s.City).FirstOrDefault().ToString();
            StateInOut.Text = ctx.Addresses.Where(s => s.CustomerId == IDUsed).Select(s => s.State).FirstOrDefault().ToString();
            ZipInOut.Text = ctx.Addresses.Where(s => s.CustomerId == IDUsed).Select(s => s.Zip).FirstOrDefault().ToString();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            //update the address from the textboxes on the UI
            var changed = ctx.Addresses.Where(c => c.CustomerId == IDUsed).FirstOrDefault();
            changed.Street = StreetInOut.Text;
            changed.City = CityInOut.Text;
            changed.State = StateInOut.Text;
            changed.Zip = ZipInOut.Text;
            ctx.SaveChanges();

            //return to the Main form
            Main returntomain = new Main();
            returntomain.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
