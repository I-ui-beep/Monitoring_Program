
namespace Monitoring_Program
{
    partial class fDivisions
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
            this.DGDivisions = new System.Windows.Forms.DataGridView();
            this.lblName_D = new System.Windows.Forms.Label();
            this.txtName_D = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGDivisions)).BeginInit();
            this.SuspendLayout();
            // 
            // DGDivisions
            // 
            this.DGDivisions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGDivisions.Location = new System.Drawing.Point(12, 12);
            this.DGDivisions.Name = "DGDivisions";
            this.DGDivisions.Size = new System.Drawing.Size(245, 150);
            this.DGDivisions.TabIndex = 5;
            this.DGDivisions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDivisions_CellClick);
            // 
            // lblName_D
            // 
            this.lblName_D.AutoSize = true;
            this.lblName_D.Location = new System.Drawing.Point(275, 12);
            this.lblName_D.Name = "lblName_D";
            this.lblName_D.Size = new System.Drawing.Size(87, 13);
            this.lblName_D.TabIndex = 6;
            this.lblName_D.Text = "Подразделение";
            // 
            // txtName_D
            // 
            this.txtName_D.Location = new System.Drawing.Point(368, 9);
            this.txtName_D.Name = "txtName_D";
            this.txtName_D.Size = new System.Drawing.Size(143, 20);
            this.txtName_D.TabIndex = 7;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(263, 61);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(121, 47);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(263, 115);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(121, 47);
            this.btDel.TabIndex = 9;
            this.btDel.Text = "Удалить";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(390, 61);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(121, 45);
            this.btUpdate.TabIndex = 10;
            this.btUpdate.Text = "Обновить";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(390, 112);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(121, 50);
            this.btClose.TabIndex = 11;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(275, 35);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(38, 13);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Адрес";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(322, 35);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(189, 20);
            this.txtAddress.TabIndex = 13;
            // 
            // fDivisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 170);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtName_D);
            this.Controls.Add(this.lblName_D);
            this.Controls.Add(this.DGDivisions);
            this.Name = "fDivisions";
            this.Text = "Подразделения";
            this.Shown += new System.EventHandler(this.fDivisions_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DGDivisions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGDivisions;
        private System.Windows.Forms.Label lblName_D;
        private System.Windows.Forms.TextBox txtName_D;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
    }
}