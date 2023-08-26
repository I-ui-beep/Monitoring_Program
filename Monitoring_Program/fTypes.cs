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
    public partial class fTypes : Form
    {
        public fTypes()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = ASUS; Initial Catalog = Monitoring; Integrated Security = True");
        DataTable monTable = new DataTable();
        SqlDataAdapter monAdapter;

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fTypes_Shown(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("Select * FROM TYPES", con);
                monAdapter = new SqlDataAdapter(command);
                monAdapter.Fill(monTable);
                con.Close();
                DGTypes.DataSource = monTable.DefaultView;
                DGTypes.Columns[0].Visible = false;
                DGTypes.Columns[1].HeaderText = "Вид удобрения";

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
                string q = "INSERT INTO TYPES (Name_t) VALUES ('" + txtName_t.Text + "')";
                SqlCommand com = new SqlCommand(q, con);
                com.ExecuteNonQuery();
                SqlCommand comm = new SqlCommand("Select * FROM TYPES", con);
                monAdapter = new SqlDataAdapter(comm);
                monTable.Clear();
                monAdapter.Fill(monTable);
                con.Close();
                DGTypes.DataSource = monTable.DefaultView;
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
                    string Id = DGTypes[0, DGTypes.SelectedRows[0].Index].Value.ToString();
                    string q = "DELETE FROM TYPES WHERE ID=" + Id;
                    SqlCommand com = new SqlCommand(q, con);
                    com.ExecuteNonQuery();
                    SqlCommand comm = new SqlCommand("Select * FROM TYPES", con);
                    monAdapter = new SqlDataAdapter(comm);
                    monTable.Clear();
                    monAdapter.Fill(monTable);
                    con.Close();
                    DGTypes.DataSource = monTable.DefaultView;
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

        private void DGTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGTypes.SelectedRows.Count != 0)
            {
                txtName_t.Text = DGTypes[1, DGTypes.SelectedRows[0].Index].Value.ToString();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string Id = DGTypes[0, DGTypes.SelectedRows[0].Index].Value.ToString();
                string q = "UPDATE TYPES SET Name_t = '" + txtName_t.Text + "' WHERE ID =" + Id;
                SqlCommand com = new SqlCommand(q, con);
                com.ExecuteNonQuery();
                SqlCommand comm = new SqlCommand("Select * FROM TYPES", con);
                monAdapter = new SqlDataAdapter(comm);
                monTable.Clear();
                monAdapter.Fill(monTable);
                con.Close();
                DGTypes.DataSource = monTable.DefaultView;
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
    }
    }