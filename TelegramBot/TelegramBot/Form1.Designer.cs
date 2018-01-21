namespace TelegramBot
{
    partial class MainForm
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
            this.BtnRun = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(156, 75);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(75, 23);
            this.BtnRun.TabIndex = 0;
            this.BtnRun.Text = "Погнали";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(102, 34);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(187, 20);
            this.txtKey.TabIndex = 1;
            this.txtKey.Text = "534019017:AAELV-mhMoSc0lD6LjdVZCaCk3nifBeQygo";
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 143);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.BtnRun);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.TextBox txtKey;
    }
}

