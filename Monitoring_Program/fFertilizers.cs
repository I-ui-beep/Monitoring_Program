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
    public partial class fFertilizers : Form
    {
        public fFertilizers()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = ASUS; Initial Catalog = Monitoring; Integrated Security = True");
        DataTable monTable = new DataTable();
        SqlDataAdapter monAdapter;

        private void fFertilizers_Shown(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("Select FERTILIZERS.Id, FERTILIZERS.Name_F, TYPES.Id, TYPES.Name_t, DIVISIONS.Id, DIVISIONS.Name_D, DIVISIONS.Аddress, FERTILIZERS.Value_F, FERTILIZERS.Price FROM FERTILIZERS INNER JOIN TYPES ON TYPES.Id = FERTILIZERS.Id_Types JOIN DIVISIONS ON DIVISIONS.Id = FERTILIZERS.Id_D", con);
                monAdapter = new SqlDataAdapter(command);
                monAdapter.Fill(monTable);
                con.Close();
                DGFertilizers.DataSource = monTable.DefaultView;
                DGFertilizers.Columns[0].Visible = false;
                DGFertilizers.Columns[1].HeaderText = "Название";
                DGFertilizers.Columns[2].Visible = false;
                DGFertilizers.Columns[3].HeaderText = "Вид";
                DGFertilizers.Columns[4].Visible = false;
                DGFertilizers.Columns[5].HeaderText = "Подразделение";
                DGFertilizers.Columns[6].Visible = false;
                DGFertilizers.Columns[7].HeaderText = "Количество";
                DGFertilizers.Columns[8].HeaderText = "Цена за кг";
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
                string q = "INSERT INTO FERTILIZERS (Name_F,Id_Types,Id_D, Value_F, Price) VALUES ('" + txtName_F.Text + "','" + cbTypes.SelectedValue + "','" + cbDivisions.SelectedValue + "','" + txtValue_F.Text + "','" + txtPrice.Text + "')";
                SqlCommand com = new SqlCommand(q, con);
                com.ExecuteNonQuery();
                SqlCommand comm = new SqlCommand("Select FERTILIZERS.Id, FERTILIZERS.Name_F, TYPES.Id, TYPES.Name_t, DIVISIONS.Id, DIVISIONS.Name_D, DIVISIONS.Аddress, FERTILIZERS.Value_F, FERTILIZERS.Price FROM FERTILIZERS INNER JOIN TYPES ON TYPES.Id = FERTILIZERS.Id_Types JOIN DIVISIONS ON DIVISIONS.Id = FERTILIZERS.Id_D", con);
                monAdapter = new SqlDataAdapter(comm);
                monTable.Clear();
                monAdapter.Fill(monTable);
                con.Close();
                DGFertilizers.DataSource = monTable.DefaultView;
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

        private void fFertilizers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monitoringDataSet3.DIVISIONS". При необходимости она может быть перемещена или удалена.
            this.dIVISIONSTableAdapter.Fill(this.monitoringDataSet3.DIVISIONS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monitoringDataSet2.TYPES". При необходимости она может быть перемещена или удалена.
            this.tYPESTableAdapter1.Fill(this.monitoringDataSet2.TYPES);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monitoringDataSet.TYPES". При необходимости она может быть перемещена или удалена.
            this.tYPESTableAdapter.Fill(this.monitoringDataSet.TYPES);

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string Id = DGFertilizers[0, DGFertilizers.SelectedRows[0].Index].Value.ToString();
                string q = "DELETE FROM FERTILIZERS WHERE ID=" + Id;
                SqlCommand com = new SqlCommand(q, con);
                com.ExecuteNonQuery();
                SqlCommand comm = new SqlCommand("Select FERTILIZERS.Id, FERTILIZERS.Name_F, TYPES.Id, TYPES.Name_t, DIVISIONS.Id, DIVISIONS.Name_D, DIVISIONS.Аddress, FERTILIZERS.Value_F, FERTILIZERS.Price FROM FERTILIZERS INNER JOIN TYPES ON TYPES.Id = FERTILIZERS.Id_Types JOIN DIVISIONS ON DIVISIONS.Id = FERTILIZERS.Id_D", con);
                monAdapter = new SqlDataAdapter(comm);
                monTable.Clear();
                monAdapter.Fill(monTable);
                con.Close();
                DGFertilizers.DataSource = monTable.DefaultView;
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

        private void DGFertilizers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGFertilizers.SelectedRows.Count != 0)
            {
                txtName_F.Text = DGFertilizers[1, DGFertilizers.SelectedRows[0].Index].Value.ToString();
                cbTypes.SelectedValue = DGFertilizers[2, DGFertilizers.SelectedRows[0].Index].Value.ToString();
                cbDivisions.SelectedValue = DGFertilizers[4, DGFertilizers.SelectedRows[0].Index].Value.ToString();
                txtValue_F.Text = DGFertilizers[7, DGFertilizers.SelectedRows[0].Index].Value.ToString();
                txtPrice.Text = DGFertilizers[8, DGFertilizers.SelectedRows[0].Index].Value.ToString();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string Id = DGFertilizers[0, DGFertilizers.SelectedRows[0].Index].Value.ToString();
                string q = "UPDATE FERTILIZERS SET Name_F = '" + txtName_F.Text + "', Id_Types = '" + cbTypes.SelectedValue + "', Id_D = '"+cbDivisions.SelectedValue+"', Value_F = '"+txtValue_F.Text+"', Price = '"+txtPrice.Text+"' WHERE ID =" + Id;
                SqlCommand com = new SqlCommand(q, con);
                com.ExecuteNonQuery();
                SqlCommand comm = new SqlCommand("Select FERTILIZERS.Id, FERTILIZERS.Name_F, TYPES.Id, TYPES.Name_t, DIVISIONS.Id, DIVISIONS.Name_D, DIVISIONS.Аddress, FERTILIZERS.Value_F, FERTILIZERS.Price FROM FERTILIZERS INNER JOIN TYPES ON TYPES.Id = FERTILIZERS.Id_Types JOIN DIVISIONS ON DIVISIONS.Id = FERTILIZERS.Id_D", con);
                monAdapter = new SqlDataAdapter(comm);
                monTable.Clear();
                monAdapter.Fill(monTable);
                con.Close();
                DGFertilizers.DataSource = monTable.DefaultView;
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
