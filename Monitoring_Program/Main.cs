using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Monitoring_Program
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = ASUS; Initial Catalog = Monitoring; Integrated Security = True");
        DataTable monTable = new DataTable();

        private void btDirectory_Click(object sender, EventArgs e)
        {
               fDirectory fD = new fDirectory();
               fD.ShowDialog();
        }

        private void btCosts_Click(object sender, EventArgs e)
        {
            fCosts fC = new fCosts();
            fC.ShowDialog();

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

