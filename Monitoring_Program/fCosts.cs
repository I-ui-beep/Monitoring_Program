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
    public partial class fCosts : Form
    {
        public fCosts()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = ASUS; Initial Catalog = Monitoring; Integrated Security = True");
        DataTable monTable = new DataTable();
        SqlDataAdapter monAdapter;

        private void fCosts_Shown(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("Select COSTS.Id, COSTS.Date_C, FERTILIZERS.Id, FERTILIZERS.Name_F, COSTS.Value_C FROM COSTS INNER JOIN FERTILIZERS ON FERTILIZERS.Id = COSTS.Id_F", con);
                monAdapter = new SqlDataAdapter(command);
                monAdapter.Fill(monTable);
                con.Close();
                DGCosts.DataSource = monTable.DefaultView;
                DGCosts.Columns[0].Visible = false;
                DGCosts.Columns[1].HeaderText = "Дата";
                DGCosts.Columns[2].Visible = false;
                DGCosts.Columns[3].HeaderText = "Удобрение";
                DGCosts.Columns[4].HeaderText = "Количество";

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
                string q = "INSERT INTO COSTS (Date_C, Id_F, Value_C) VALUES ('" +dtDate.Value + "','" + cbF.SelectedValue + "','" + txtValue_C.Text +"')";
                SqlCommand com = new SqlCommand(q, con);
                com.ExecuteNonQuery();
                SqlCommand comm = new SqlCommand("Select COSTS.Id, COSTS.Date_C, FERTILIZERS.Id, FERTILIZERS.Name_F, COSTS.Value_C FROM COSTS INNER JOIN FERTILIZERS ON FERTILIZERS.Id = COSTS.Id_F", con);
                monAdapter = new SqlDataAdapter(comm);
                monTable.Clear();
                monAdapter.Fill(monTable);
                con.Close();
                DGCosts.DataSource = monTable.DefaultView;
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

        private void fCosts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monitoringDataSet4.FERTILIZERS". При необходимости она может быть перемещена или удалена.
            this.fERTILIZERSTableAdapter.Fill(this.monitoringDataSet4.FERTILIZERS);

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string Id = DGCosts[0, DGCosts.SelectedRows[0].Index].Value.ToString();
                string q = "DELETE FROM COSTS WHERE ID=" + Id;
                SqlCommand com = new SqlCommand(q, con);
                com.ExecuteNonQuery();
                SqlCommand comm = new SqlCommand("Select COSTS.Id, COSTS.Date_C, FERTILIZERS.Id, FERTILIZERS.Name_F, COSTS.Value_C FROM COSTS INNER JOIN FERTILIZERS ON FERTILIZERS.Id = COSTS.Id_F", con);
                monAdapter = new SqlDataAdapter(comm);
                monTable.Clear();
                monAdapter.Fill(monTable);
                con.Close();
                DGCosts.DataSource = monTable.DefaultView;
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

        private void DGCosts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGCosts.SelectedRows.Count != 0)
            {
                dtDate.Value = (DateTime)DGCosts[1, DGCosts.SelectedRows[0].Index].Value; ;
                cbF.SelectedValue = DGCosts[2, DGCosts.SelectedRows[0].Index].Value.ToString();
                txtValue_C.Text = DGCosts[4, DGCosts.SelectedRows[0].Index].Value.ToString();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string Id = DGCosts[0, DGCosts.SelectedRows[0].Index].Value.ToString();
                string q = "UPDATE COSTS SET Date_C = '" + dtDate.Value + "', Id_F = '" + cbF.SelectedValue + "', Value_C = '" + txtValue_C.Text + "' WHERE ID =" + Id;
                SqlCommand com = new SqlCommand(q, con);
                com.ExecuteNonQuery();
                SqlCommand comm = new SqlCommand("Select COSTS.Id, COSTS.Date_C, FERTILIZERS.Id, FERTILIZERS.Name_F, COSTS.Value_C FROM COSTS INNER JOIN FERTILIZERS ON FERTILIZERS.Id = COSTS.Id_F", con);
                monAdapter = new SqlDataAdapter(comm);
                monTable.Clear();
                monAdapter.Fill(monTable);
                con.Close();
                DGCosts.DataSource = monTable.DefaultView;
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

        private void отчетОбОстаткахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fRemains fR = new fRemains();
            fR.ShowDialog();
        }

        private void отчетОРасходеToolStripMenuItem_Click(object sender, EventArgs e)
        {
              fC fCOSTS= new fC();
            fCOSTS.ShowDialog();
        }

        private void отчетОСтоимостиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fPrice fPrice = new fPrice();
            fPrice.ShowDialog();
        }
    }
}
