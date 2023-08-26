
namespace Monitoring_Program
{
    partial class fDirectory
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
            this.btTypes = new System.Windows.Forms.Button();
            this.btDivisions = new System.Windows.Forms.Button();
            this.btFertilizers = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTypes
            // 
            this.btTypes.Location = new System.Drawing.Point(12, 12);
            this.btTypes.Name = "btTypes";
            this.btTypes.Size = new System.Drawing.Size(297, 90);
            this.btTypes.TabIndex = 0;
            this.btTypes.Text = "Виды удобрений";
            this.btTypes.UseVisualStyleBackColor = true;
            this.btTypes.Click += new System.EventHandler(this.btTypes_Click);
            // 
            // btDivisions
            // 
            this.btDivisions.Location = new System.Drawing.Point(12, 108);
            this.btDivisions.Name = "btDivisions";
            this.btDivisions.Size = new System.Drawing.Size(297, 90);
            this.btDivisions.TabIndex = 1;
            this.btDivisions.Text = "Подразделения";
            this.btDivisions.UseVisualStyleBackColor = true;
            this.btDivisions.Click += new System.EventHandler(this.btDivisions_Click);
            // 
            // btFertilizers
            // 
            this.btFertilizers.Location = new System.Drawing.Point(12, 204);
            this.btFertilizers.Name = "btFertilizers";
            this.btFertilizers.Size = new System.Drawing.Size(297, 90);
            this.btFertilizers.TabIndex = 2;
            this.btFertilizers.Text = "Удобрения";
            this.btFertilizers.UseVisualStyleBackColor = true;
            this.btFertilizers.Click += new System.EventHandler(this.btFertilizers_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(12, 300);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(297, 90);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // fDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 409);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btFertilizers);
            this.Controls.Add(this.btDivisions);
            this.Controls.Add(this.btTypes);
            this.Name = "fDirectory";
            this.Text = "Справочники";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btTypes;
        private System.Windows.Forms.Button btDivisions;
        private System.Windows.Forms.Button btFertilizers;
        private System.Windows.Forms.Button btClose;
    }
}