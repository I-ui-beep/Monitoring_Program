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
    public partial class fPrice : Form
    {
        public fPrice()
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

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("Select COSTS.Id, COSTS.Date_C, FERTILIZERS.Id, FERTILIZERS.Name_F, COSTS.Value_C, FERTILIZERS.Price, (FERTILIZERS.Price)*(COSTS.Value_C) AS Стоимость FROM COSTS INNER JOIN FERTILIZERS ON FERTILIZERS.Id = COSTS.Id_F WHERE COSTS.Date_C BETWEEN '" + dtStart.Value + "' AND '" + dtEnd.Value + "'", con);
                monAdapter = new SqlDataAdapter(command);
                monAdapter.Fill(monTable);
                con.Close();
                DGPrice.DataSource = monTable.DefaultView;
                DGPrice.Columns[0].Visible = false;
                DGPrice.Columns[1].HeaderText = "Дата";
                DGPrice.Columns[2].Visible = false;
                DGPrice.Columns[3].HeaderText = "Удобрение";
                DGPrice.Columns[4].HeaderText = "Количество";
                DGPrice.Columns[5].HeaderText = "Цена за кг.";

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

        private void btSave_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Price";
            for (int i = 1; i < DGPrice.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DGPrice.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < DGPrice.Rows.Count - 1; i++)
            {
                for (int j = 0; j < DGPrice.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DGPrice.Rows[i].Cells[j].Value;
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Стоимость израсходованных удобрений";
            saveFileDialoge.DefaultExt = ".xlsx";
            if (saveFileDialoge.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }
    }
}
