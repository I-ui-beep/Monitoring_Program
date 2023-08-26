
namespace Monitoring_Program
{
    partial class fPrice
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
            this.btClose = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.DGPrice = new System.Windows.Forms.DataGridView();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(195, 203);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(168, 62);
            this.btClose.TabIndex = 0;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(12, 203);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(177, 62);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Сохранить отчет";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(185, 12);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(140, 20);
            this.dtEnd.TabIndex = 3;
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
            // 
            // DGPrice
            // 
            this.DGPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPrice.Location = new System.Drawing.Point(12, 47);
            this.DGPrice.Name = "DGPrice";
            this.DGPrice.Size = new System.Drawing.Size(567, 150);
            this.DGPrice.TabIndex = 4;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(12, 18);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(14, 13);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "C";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(160, 18);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(19, 13);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "по";
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(32, 12);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(122, 20);
            this.dtStart.TabIndex = 2;
            // 
            // fPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 276);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.DGPrice);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btClose);
            this.Name = "fPrice";
            this.Text = "Отчет о стоимости";
            ((System.ComponentModel.ISupportInitialize)(this.DGPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DataGridView DGPrice;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
    }
}