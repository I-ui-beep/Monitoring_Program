
namespace Monitoring_Program
{
    partial class fFertilizers
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
            this.DGFertilizers = new System.Windows.Forms.DataGridView();
            this.lblName_F = new System.Windows.Forms.Label();
            this.lblTypes = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblValue_F = new System.Windows.Forms.Label();
            this.lblDivisions = new System.Windows.Forms.Label();
            this.txtName_F = new System.Windows.Forms.TextBox();
            this.txtValue_F = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.tYPESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.monitoringDataSet2 = new Monitoring_Program.MonitoringDataSet2();
            this.cbDivisions = new System.Windows.Forms.ComboBox();
            this.dIVISIONSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monitoringDataSet3 = new Monitoring_Program.MonitoringDataSet3();
            this.btAdd = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.monitoringDataSet = new Monitoring_Program.MonitoringDataSet();
            this.tYPESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tYPESTableAdapter = new Monitoring_Program.MonitoringDataSetTableAdapters.TYPESTableAdapter();
            this.tYPESTableAdapter1 = new Monitoring_Program.MonitoringDataSet2TableAdapters.TYPESTableAdapter();
            this.dIVISIONSTableAdapter = new Monitoring_Program.MonitoringDataSet3TableAdapters.DIVISIONSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DGFertilizers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIVISIONSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGFertilizers
            // 
            this.DGFertilizers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGFertilizers.Location = new System.Drawing.Point(12, 12);
            this.DGFertilizers.Name = "DGFertilizers";
            this.DGFertilizers.Size = new System.Drawing.Size(576, 215);
            this.DGFertilizers.TabIndex = 6;
            this.DGFertilizers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGFertilizers_CellClick);
            // 
            // lblName_F
            // 
            this.lblName_F.AutoSize = true;
            this.lblName_F.Location = new System.Drawing.Point(12, 236);
            this.lblName_F.Name = "lblName_F";
            this.lblName_F.Size = new System.Drawing.Size(113, 13);
            this.lblName_F.TabIndex = 7;
            this.lblName_F.Text = "Название удобрения";
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Location = new System.Drawing.Point(12, 262);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(82, 13);
            this.lblTypes.TabIndex = 8;
            this.lblTypes.Text = "Вид удобрения";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(12, 342);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(65, 13);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Цена за кг.";
            // 
            // lblValue_F
            // 
            this.lblValue_F.AutoSize = true;
            this.lblValue_F.Location = new System.Drawing.Point(12, 316);
            this.lblValue_F.Name = "lblValue_F";
            this.lblValue_F.Size = new System.Drawing.Size(86, 13);
            this.lblValue_F.TabIndex = 10;
            this.lblValue_F.Text = "Количество, кг.";
            // 
            // lblDivisions
            // 
            this.lblDivisions.AutoSize = true;
            this.lblDivisions.Location = new System.Drawing.Point(12, 289);
            this.lblDivisions.Name = "lblDivisions";
            this.lblDivisions.Size = new System.Drawing.Size(87, 13);
            this.lblDivisions.TabIndex = 11;
            this.lblDivisions.Text = "Подразделение";
            // 
            // txtName_F
            // 
            this.txtName_F.Location = new System.Drawing.Point(131, 236);
            this.txtName_F.Name = "txtName_F";
            this.txtName_F.Size = new System.Drawing.Size(340, 20);
            this.txtName_F.TabIndex = 12;
            // 
            // txtValue_F
            // 
            this.txtValue_F.Location = new System.Drawing.Point(100, 313);
            this.txtValue_F.Name = "txtValue_F";
            this.txtValue_F.Size = new System.Drawing.Size(371, 20);
            this.txtValue_F.TabIndex = 13;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(83, 339);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(388, 20);
            this.txtPrice.TabIndex = 14;
            // 
            // cbTypes
            // 
            this.cbTypes.DataSource = this.tYPESBindingSource1;
            this.cbTypes.DisplayMember = "Name_t";
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Location = new System.Drawing.Point(100, 259);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(371, 21);
            this.cbTypes.TabIndex = 15;
            this.cbTypes.ValueMember = "Id";
            // 
            // tYPESBindingSource1
            // 
            this.tYPESBindingSource1.DataMember = "TYPES";
            this.tYPESBindingSource1.DataSource = this.monitoringDataSet2;
            // 
            // monitoringDataSet2
            // 
            this.monitoringDataSet2.DataSetName = "MonitoringDataSet2";
            this.monitoringDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbDivisions
            // 
            this.cbDivisions.DataSource = this.dIVISIONSBindingSource;
            this.cbDivisions.DisplayMember = "Name_D";
            this.cbDivisions.FormattingEnabled = true;
            this.cbDivisions.Location = new System.Drawing.Point(100, 286);
            this.cbDivisions.Name = "cbDivisions";
            this.cbDivisions.Size = new System.Drawing.Size(371, 21);
            this.cbDivisions.TabIndex = 16;
            this.cbDivisions.ValueMember = "Id";
            // 
            // dIVISIONSBindingSource
            // 
            this.dIVISIONSBindingSource.DataMember = "DIVISIONS";
            this.dIVISIONSBindingSource.DataSource = this.monitoringDataSet3;
            // 
            // monitoringDataSet3
            // 
            this.monitoringDataSet3.DataSetName = "MonitoringDataSet3";
            this.monitoringDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(12, 365);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(113, 42);
            this.btAdd.TabIndex = 19;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(369, 365);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(102, 42);
            this.btClose.TabIndex = 20;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(250, 365);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(113, 42);
            this.btUpdate.TabIndex = 21;
            this.btUpdate.Text = "Обновить";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(131, 365);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(113, 42);
            this.btDel.TabIndex = 22;
            this.btDel.Text = "Удалить";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // monitoringDataSet
            // 
            this.monitoringDataSet.DataSetName = "MonitoringDataSet";
            this.monitoringDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tYPESBindingSource
            // 
            this.tYPESBindingSource.DataMember = "TYPES";
            this.tYPESBindingSource.DataSource = this.monitoringDataSet;
            // 
            // tYPESTableAdapter
            // 
            this.tYPESTableAdapter.ClearBeforeFill = true;
            // 
            // tYPESTableAdapter1
            // 
            this.tYPESTableAdapter1.ClearBeforeFill = true;
            // 
            // dIVISIONSTableAdapter
            // 
            this.dIVISIONSTableAdapter.ClearBeforeFill = true;
            // 
            // fFertilizers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 412);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.cbDivisions);
            this.Controls.Add(this.cbTypes);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtValue_F);
            this.Controls.Add(this.txtName_F);
            this.Controls.Add(this.lblDivisions);
            this.Controls.Add(this.lblValue_F);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTypes);
            this.Controls.Add(this.lblName_F);
            this.Controls.Add(this.DGFertilizers);
            this.Name = "fFertilizers";
            this.Text = "Удобрения";
            this.Load += new System.EventHandler(this.fFertilizers_Load);
            this.Shown += new System.EventHandler(this.fFertilizers_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DGFertilizers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIVISIONSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGFertilizers;
        private System.Windows.Forms.Label lblName_F;
        private System.Windows.Forms.Label lblTypes;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblValue_F;
        private System.Windows.Forms.Label lblDivisions;
        private System.Windows.Forms.TextBox txtName_F;
        private System.Windows.Forms.TextBox txtValue_F;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.ComboBox cbDivisions;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDel;
        private MonitoringDataSet monitoringDataSet;
        private System.Windows.Forms.BindingSource tYPESBindingSource;
        private MonitoringDataSetTableAdapters.TYPESTableAdapter tYPESTableAdapter;
        private MonitoringDataSet2 monitoringDataSet2;
        private System.Windows.Forms.BindingSource tYPESBindingSource1;
        private MonitoringDataSet2TableAdapters.TYPESTableAdapter tYPESTableAdapter1;
        private MonitoringDataSet3 monitoringDataSet3;
        private System.Windows.Forms.BindingSource dIVISIONSBindingSource;
        private MonitoringDataSet3TableAdapters.DIVISIONSTableAdapter dIVISIONSTableAdapter;
    }
}