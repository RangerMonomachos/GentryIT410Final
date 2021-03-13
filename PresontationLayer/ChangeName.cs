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
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace PresontationLayer
{
    public partial class ChangeName : Form
    {
        int ID = -1;
        CustomerDataContext ctx = new CustomerDataContext();
        public ChangeName(int IDToChange)
        {
            InitializeComponent();
            ID = IDToChange;
        }

        private void ChangeName_Load(object sender, EventArgs e)
        {
            FirstNameOutput.Text = ctx.Customers.Where(a => a.CustomerId == ID).Select(s => s.Firstname).FirstOrDefault().ToString();
            LastNameChange.Text = ctx.Customers.Where(a => a.CustomerId == ID).Select(s => s.Lastname).FirstOrDefault().ToString();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            ////exicute the stored procedure
            var IdToBePassed = new SqlParameter("@Id", ID);
            var FirstName = new SqlParameter("@FirstName", FirstNameOutput.Text.ToString());
            var Change = ctx.Database.ExecuteSqlRaw("EXECUTE UpdateUserFirst @Id, @FirstName", IdToBePassed, FirstName);

            //switch back to the main form
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
