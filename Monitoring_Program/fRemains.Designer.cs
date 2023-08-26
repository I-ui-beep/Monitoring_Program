
namespace Monitoring_Program
{
    partial class fRemains
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDate = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.DGRemains = new System.Windows.Forms.DataGridView();
            this.monitoringDataSet5 = new Monitoring_Program.MonitoringDataSet5();
            this.cOSTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOSTSTableAdapter = new Monitoring_Program.MonitoringDataSet5TableAdapters.COSTSTableAdapter();
            this.monitoringDataSet6 = new Monitoring_Program.MonitoringDataSet6();
            this.cOSTSBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cOSTSTableAdapter1 = new Monitoring_Program.MonitoringDataSet6TableAdapters.COSTSTableAdapter();
            this.dtRemains = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGRemains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSTSBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(14, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Дата";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(12, 236);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(140, 100);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Сохранить отчет";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(158, 236);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(145, 100);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // DGRemains
            // 
            this.DGRemains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGRemains.Location = new System.Drawing.Point(12, 38);
            this.DGRemains.Name = "DGRemains";
            this.DGRemains.Size = new System.Drawing.Size(664, 185);
            this.DGRemains.TabIndex = 4;
            // 
            // monitoringDataSet5
            // 
            this.monitoringDataSet5.DataSetName = "MonitoringDataSet5";
            this.monitoringDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOSTSBindingSource
            // 
            this.cOSTSBindingSource.DataMember = "COSTS";
            this.cOSTSBindingSource.DataSource = this.monitoringDataSet5;
            // 
            // cOSTSTableAdapter
            // 
            this.cOSTSTableAdapter.ClearBeforeFill = true;
            // 
            // monitoringDataSet6
            // 
            this.monitoringDataSet6.DataSetName = "MonitoringDataSet6";
            this.monitoringDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOSTSBindingSource1
            // 
            this.cOSTSBindingSource1.DataMember = "COSTS";
            this.cOSTSBindingSource1.DataSource = this.monitoringDataSet6;
            // 
            // cOSTSTableAdapter1
            // 
            this.cOSTSTableAdapter1.ClearBeforeFill = true;
            // 
            // dtRemains
            // 
            this.dtRemains.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRemains.Location = new System.Drawing.Point(53, 12);
            this.dtRemains.Name = "dtRemains";
            this.dtRemains.Size = new System.Drawing.Size(200, 20);
            this.dtRemains.TabIndex = 5;
            this.dtRemains.ValueChanged += new System.EventHandler(this.dtRemains_ValueChanged);
            // 
            // fRemains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 348);
            this.Controls.Add(this.dtRemains);
            this.Controls.Add(this.DGRemains);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lblDate);
            this.Name = "fRemains";
            this.Text = "Отчет по остаткам";
            this.Load += new System.EventHandler(this.fRemains_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGRemains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSTSBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.DataGridView DGRemains;
        private MonitoringDataSet5 monitoringDataSet5;
        private System.Windows.Forms.BindingSource cOSTSBindingSource;
        private MonitoringDataSet5TableAdapters.COSTSTableAdapter cOSTSTableAdapter;
        private MonitoringDataSet6 monitoringDataSet6;
        private System.Windows.Forms.BindingSource cOSTSBindingSource1;
        private MonitoringDataSet6TableAdapters.COSTSTableAdapter cOSTSTableAdapter1;
        private System.Windows.Forms.DateTimePicker dtRemains;
    }
}