
namespace Monitoring_Program
{
    partial class fCosts
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетОбОстаткахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетОРасходеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетОСтоимостиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DGCosts = new System.Windows.Forms.DataGridView();
            this.lblDate_C = new System.Windows.Forms.Label();
            this.lblId_F = new System.Windows.Forms.Label();
            this.lblValue_C = new System.Windows.Forms.Label();
            this.txtValue_C = new System.Windows.Forms.TextBox();
            this.cbF = new System.Windows.Forms.ComboBox();
            this.fERTILIZERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monitoringDataSet4 = new Monitoring_Program.MonitoringDataSet4();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.fERTILIZERSTableAdapter = new Monitoring_Program.MonitoringDataSet4TableAdapters.FERTILIZERSTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fERTILIZERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетОбОстаткахToolStripMenuItem,
            this.отчетОРасходеToolStripMenuItem,
            this.отчетОСтоимостиToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // отчетОбОстаткахToolStripMenuItem
            // 
            this.отчетОбОстаткахToolStripMenuItem.Name = "отчетОбОстаткахToolStripMenuItem";
            this.отчетОбОстаткахToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отчетОбОстаткахToolStripMenuItem.Text = "Отчет об остатках";
            this.отчетОбОстаткахToolStripMenuItem.Click += new System.EventHandler(this.отчетОбОстаткахToolStripMenuItem_Click);
            // 
            // отчетОРасходеToolStripMenuItem
            // 
            this.отчетОРасходеToolStripMenuItem.Name = "отчетОРасходеToolStripMenuItem";
            this.отчетОРасходеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отчетОРасходеToolStripMenuItem.Text = "Отчет о расходе";
            this.отчетОРасходеToolStripMenuItem.Click += new System.EventHandler(this.отчетОРасходеToolStripMenuItem_Click);
            // 
            // отчетОСтоимостиToolStripMenuItem
            // 
            this.отчетОСтоимостиToolStripMenuItem.Name = "отчетОСтоимостиToolStripMenuItem";
            this.отчетОСтоимостиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отчетОСтоимостиToolStripMenuItem.Text = "Отчет о стоимости";
            this.отчетОСтоимостиToolStripMenuItem.Click += new System.EventHandler(this.отчетОСтоимостиToolStripMenuItem_Click);
            // 
            // DGCosts
            // 
            this.DGCosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCosts.Location = new System.Drawing.Point(12, 27);
            this.DGCosts.Name = "DGCosts";
            this.DGCosts.Size = new System.Drawing.Size(318, 172);
            this.DGCosts.TabIndex = 1;
            this.DGCosts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCosts_CellClick);
            // 
            // lblDate_C
            // 
            this.lblDate_C.AutoSize = true;
            this.lblDate_C.Location = new System.Drawing.Point(12, 216);
            this.lblDate_C.Name = "lblDate_C";
            this.lblDate_C.Size = new System.Drawing.Size(33, 13);
            this.lblDate_C.TabIndex = 2;
            this.lblDate_C.Text = "Дата";
            // 
            // lblId_F
            // 
            this.lblId_F.AutoSize = true;
            this.lblId_F.Location = new System.Drawing.Point(12, 243);
            this.lblId_F.Name = "lblId_F";
            this.lblId_F.Size = new System.Drawing.Size(63, 13);
            this.lblId_F.TabIndex = 3;
            this.lblId_F.Text = "Удобрение";
            // 
            // lblValue_C
            // 
            this.lblValue_C.AutoSize = true;
            this.lblValue_C.Location = new System.Drawing.Point(12, 270);
            this.lblValue_C.Name = "lblValue_C";
            this.lblValue_C.Size = new System.Drawing.Size(86, 13);
            this.lblValue_C.TabIndex = 4;
            this.lblValue_C.Text = "Количество, кг.";
            // 
            // txtValue_C
            // 
            this.txtValue_C.Location = new System.Drawing.Point(101, 267);
            this.txtValue_C.Name = "txtValue_C";
            this.txtValue_C.Size = new System.Drawing.Size(229, 20);
            this.txtValue_C.TabIndex = 5;
            // 
            // cbF
            // 
            this.cbF.DataSource = this.fERTILIZERSBindingSource;
            this.cbF.DisplayMember = "Name_F";
            this.cbF.FormattingEnabled = true;
            this.cbF.Location = new System.Drawing.Point(88, 240);
            this.cbF.Name = "cbF";
            this.cbF.Size = new System.Drawing.Size(242, 21);
            this.cbF.TabIndex = 7;
            this.cbF.ValueMember = "Id";
            // 
            // fERTILIZERSBindingSource
            // 
            this.fERTILIZERSBindingSource.DataMember = "FERTILIZERS";
            this.fERTILIZERSBindingSource.DataSource = this.monitoringDataSet4;
            // 
            // monitoringDataSet4
            // 
            this.monitoringDataSet4.DataSetName = "MonitoringDataSet4";
            this.monitoringDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtDate
            // 
            this.dtDate.CustomFormat = "";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDate.Location = new System.Drawing.Point(51, 214);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(279, 20);
            this.dtDate.TabIndex = 8;
            this.dtDate.Value = new System.DateTime(2021, 1, 8, 0, 0, 0, 0);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(12, 298);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 45);
            this.btAdd.TabIndex = 9;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(93, 298);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 45);
            this.btDel.TabIndex = 10;
            this.btDel.Text = "Удалить";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(174, 298);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 45);
            this.btUpdate.TabIndex = 11;
            this.btUpdate.Text = "Обновить";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(255, 298);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 45);
            this.btClose.TabIndex = 12;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // fERTILIZERSTableAdapter
            // 
            this.fERTILIZERSTableAdapter.ClearBeforeFill = true;
            // 
            // fCosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.cbF);
            this.Controls.Add(this.txtValue_C);
            this.Controls.Add(this.lblValue_C);
            this.Controls.Add(this.lblId_F);
            this.Controls.Add(this.lblDate_C);
            this.Controls.Add(this.DGCosts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fCosts";
            this.Text = "Расход удобрений";
            this.Load += new System.EventHandler(this.fCosts_Load);
            this.Shown += new System.EventHandler(this.fCosts_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fERTILIZERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitoringDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.DataGridView DGCosts;
        private System.Windows.Forms.ToolStripMenuItem отчетОбОстаткахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетОРасходеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетОСтоимостиToolStripMenuItem;
        private System.Windows.Forms.Label lblDate_C;
        private System.Windows.Forms.Label lblId_F;
        private System.Windows.Forms.Label lblValue_C;
        private System.Windows.Forms.TextBox txtValue_C;
        private System.Windows.Forms.ComboBox cbF;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btClose;
        private MonitoringDataSet4 monitoringDataSet4;
        private System.Windows.Forms.BindingSource fERTILIZERSBindingSource;
        private MonitoringDataSet4TableAdapters.FERTILIZERSTableAdapter fERTILIZERSTableAdapter;
    }
}