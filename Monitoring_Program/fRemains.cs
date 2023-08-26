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
    public partial class fRemains : Form
    {
        public fRemains()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source = ASUS; Initial Catalog = Monitoring; Integrated Security = True");
        DataTable monTable = new DataTable();
        SqlDataAdapter monAdapter;

        private void fRemains_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monitoringDataSet6.COSTS". При необходимости она может быть перемещена или удалена.
            this.cOSTSTableAdapter1.Fill(this.monitoringDataSet6.COSTS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "monitoringDataSet5.COSTS". При необходимости она может быть перемещена или удалена.
            this.cOSTSTableAdapter.Fill(this.monitoringDataSet5.COSTS);

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtRemains_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("Select COSTS.Id, COSTS.Date_C, FERTILIZERS.Id, FERTILIZERS.Name_F, FERTILIZERS.Value_F, COSTS.Value_C, (FERTILIZERS.Value_F)-(COSTS.Value_C) AS Остатки FROM COSTS INNER JOIN FERTILIZERS ON FERTILIZERS.Id = COSTS.Id_F WHERE COSTS.Date_C ='" + dtRemains.Value + "' ", con);
                monAdapter = new SqlDataAdapter(command);
                monAdapter.Fill(monTable);
                con.Close();
                DGRemains.DataSource = monTable.DefaultView;
                DGRemains.Columns[0].Visible = false;
                DGRemains.Columns[1].HeaderText = "Дата";
                DGRemains.Columns[2].Visible = false;
                DGRemains.Columns[3].HeaderText = "Удобрение";
                DGRemains.Columns[4].HeaderText = "Нач. кол-во";
                DGRemains.Columns[5].HeaderText = "Количество";

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
            Microsoft.Office.Interop.Excel._Worksheet worksheet=null;
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Remains";
            for (int i =1; i<DGRemains.Columns.Count+1; i++)
            {
                worksheet.Cells[1,i] = DGRemains.Columns[i - 1].HeaderText;
            }
            for(int i = 0; i<DGRemains.Rows.Count-1;i++)
            {
                for(int j = 0; j<DGRemains.Columns.Count;j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DGRemains.Rows[i].Cells[j].Value;
                }
            }
            var saveFileDialoge = new SaveFileDialog();
            saveFileDialoge.FileName = "Остатки удобрений";
            saveFileDialoge.DefaultExt = ".xlsx";
            if(saveFileDialoge.ShowDialog()==DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }
            app.Quit();
        }
    }
    }
