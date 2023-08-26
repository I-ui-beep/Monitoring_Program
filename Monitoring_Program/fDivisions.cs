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
    public partial class fDivisions : Form
    {
        public fDivisions()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = ASUS; Initial Catalog = Monitoring; Integrated Security = True");
        DataTable monTable = new DataTable();
        SqlDataAdapter monAdapter;

        private void fDivisions_Shown(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("Select * FROM DIVISIONS", con);
                monAdapter = new SqlDataAdapter(command);
                monAdapter.Fill(monTable);
                con.Close();
                DGDivisions.DataSource = monTable.DefaultView;
                DGDivisions.Columns[0].Visible = false;
                DGDivisions.Columns[1].HeaderText = "Подразделение";
                DGDivisions.Columns[2].HeaderText = "Адрес";

            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string q = "INSERT INTO DIVISIONS (Name_D, Аddress) VALUES ('" + txtName_D.Text + "','" + txtAddress.Text + "')";
                SqlCommand com = new SqlCommand(q, con);
                com.ExecuteNonQuery();
                SqlCommand comm = new SqlCommand("Select * FROM DIVISIONS", con);
                monAdapter = new SqlDataAdapter(comm);
                monTable.Clear();
                monAdapter.Fill(monTable);
                con.Close();
                DGDivisions.DataSource = monTable.DefaultView;
            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string Id = DGDivisions[0, DGDivisions.SelectedRows[0].Index].Value.ToString();
                string q = "DELETE FROM DIVISIONS WHERE ID=" + Id;
                SqlCommand com = new SqlCommand(q, con);
                com.ExecuteNonQuery();
                SqlCommand comm = new SqlCommand("Select * FROM DIVISIONS", con);
                monAdapter = new SqlDataAdapter(comm);
                monTable.Clear();
                monAdapter.Fill(monTable);
                con.Close();
                DGDivisions.DataSource = monTable.DefaultView;
            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void DGDivisions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGDivisions.SelectedRows.Count != 0)
            {
                txtName_D.Text = DGDivisions[1, DGDivisions.SelectedRows[0].Index].Value.ToString();
                txtAddress.Text = DGDivisions[2, DGDivisions.SelectedRows[0].Index].Value.ToString();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                string Id = DGDivisions[0, DGDivisions.SelectedRows[0].Index].Value.ToString();
                SqlCommand com = new SqlCommand("UPDATE DIVISIONS SET Name_D = '" + txtName_D.Text + "', Аddress ='" + txtAddress.Text+"' WHERE ID =" + Id, con);
                com.ExecuteNonQuery();
                SqlCommand comm = new SqlCommand("Select * FROM DIVISIONS", con);
                monAdapter = new SqlDataAdapter(comm);
                monTable.Clear();
                monAdapter.Fill(monTable);
                con.Close();
                DGDivisions.DataSource = monTable.DefaultView;
            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
