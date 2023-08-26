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
    public partial class fDirectory : Form
    {
        public fDirectory()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = ASUS; Initial Catalog = Monitoring; Integrated Security = True");
        DataTable monTable = new DataTable();

        private void btTypes_Click(object sender, EventArgs e)
        {
            fTypes fT = new fTypes();
            fT.ShowDialog();
        }

        private void btDivisions_Click(object sender, EventArgs e)
        {
            fDivisions fD = new fDivisions();
            fD.ShowDialog();
        }

        private void btFertilizers_Click(object sender, EventArgs e)
        {
            fFertilizers fF = new fFertilizers();
            fF.ShowDialog();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
