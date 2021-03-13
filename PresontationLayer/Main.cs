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
    public partial class Main : Form
    {
        CustomerDataContext ctx = new CustomerDataContext();
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            var fullList = (from cust in ctx.Customers
                            join address in ctx.Addresses on cust.CustomerId equals address.CustomerId
                            select new OutputFormating
                            {
                                ID = cust.CustomerId,
                                First = cust.Firstname,
                                Last = cust.Lastname,
                                Street = address.Street,
                                City = address.City,
                                State = address.State,
                                Zip = address.Zip
                            }).ToList();
            //var fullList = ctx.Customers.OrderBy(a => a.Firstname).Select(s => new { s.Firstname, s.Lastname }).ToList();
            dataGridView1.DataSource = fullList;
            dataGridView1.Columns[0].Visible = false;
            NameChangeGo.Enabled = false;
            ChangeAddressGo.Enabled = false;
        }

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            NameChangeGo.Enabled = true;
            ChangeAddressGo.Enabled = true;
        }

        //tryed to use the leave function but found that to click on a button was to have this fire and thus you could not click a button
        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            //NameChangeGo.Enabled = false;
            //ChangeAddressGo.Enabled = false;
        }

        private void NameChangeGo_Click(object sender, EventArgs e)
        {

            ChangeName Change = new ChangeName((int)dataGridView1.SelectedRows[0].Cells[0].Value);
            Change.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NameChangeGo.Enabled = false;
            ChangeAddressGo.Enabled = false;
        }

        private void ChangeAddressGo_Click(object sender, EventArgs e)
        {
            AddressChange Change = new AddressChange((int)dataGridView1.SelectedRows[0].Cells[0].Value);
            Change.Show();
            this.Hide();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
