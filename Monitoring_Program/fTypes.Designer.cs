
namespace Monitoring_Program
{
    partial class fTypes
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
            this.btAdd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.DGTypes = new System.Windows.Forms.DataGridView();
            this.lblTypes = new System.Windows.Forms.Label();
            this.txtName_t = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(275, 50);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(121, 53);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(275, 109);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(121, 53);
            this.btDel.TabIndex = 1;
            this.btDel.Text = "Удалить";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(402, 50);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(121, 53);
            this.btUpdate.TabIndex = 2;
            this.btUpdate.Text = "Обновить";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(402, 109);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(121, 53);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // DGTypes
            // 
            this.DGTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTypes.Location = new System.Drawing.Point(12, 12);
            this.DGTypes.Name = "DGTypes";
            this.DGTypes.Size = new System.Drawing.Size(245, 150);
            this.DGTypes.TabIndex = 4;
            this.DGTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTypes_CellClick);
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.Location = new System.Drawing.Point(272, 16);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(82, 13);
            this.lblTypes.TabIndex = 5;
            this.lblTypes.Text = "Вид удобрений";
            // 
            // txtName_t
            // 
            this.txtName_t.Location = new System.Drawing.Point(360, 13);
            this.txtName_t.Name = "txtName_t";
            this.txtName_t.Size = new System.Drawing.Size(163, 20);
            this.txtName_t.TabIndex = 6;
            // 
            // fTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 176);
            this.Controls.Add(this.txtName_t);
            this.Controls.Add(this.lblTypes);
            this.Controls.Add(this.DGTypes);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btAdd);
            this.Name = "fTypes";
            this.Text = "Виды удобрений";
            this.Shown += new System.EventHandler(this.fTypes_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DGTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.DataGridView DGTypes;
        private System.Windows.Forms.Label lblTypes;
        private System.Windows.Forms.TextBox txtName_t;
    }
}