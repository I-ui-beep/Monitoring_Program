
namespace Monitoring_Program
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btDirectory = new System.Windows.Forms.Button();
            this.btCosts = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btDirectory
            // 
            this.btDirectory.Location = new System.Drawing.Point(12, 12);
            this.btDirectory.Name = "btDirectory";
            this.btDirectory.Size = new System.Drawing.Size(349, 139);
            this.btDirectory.TabIndex = 0;
            this.btDirectory.Text = "Справочники";
            this.btDirectory.UseVisualStyleBackColor = true;
            this.btDirectory.Click += new System.EventHandler(this.btDirectory_Click);
            // 
            // btCosts
            // 
            this.btCosts.Location = new System.Drawing.Point(12, 157);
            this.btCosts.Name = "btCosts";
            this.btCosts.Size = new System.Drawing.Size(349, 139);
            this.btCosts.TabIndex = 1;
            this.btCosts.Text = "Расход удобрений";
            this.btCosts.UseVisualStyleBackColor = true;
            this.btCosts.Click += new System.EventHandler(this.btCosts_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(12, 302);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(349, 139);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Закрыть";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 450);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btCosts);
            this.Controls.Add(this.btDirectory);
            this.Name = "Main";
            this.Text = "Меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btDirectory;
        private System.Windows.Forms.Button btCosts;
        private System.Windows.Forms.Button btClose;
    }
}

