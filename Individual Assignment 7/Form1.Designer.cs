namespace Individual_Assignment_7
{
    partial class Form1
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
            this.correct_label = new System.Windows.Forms.Label();
            this.incorrect_label = new System.Windows.Forms.Label();
            this.passed_label = new System.Windows.Forms.Label();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.incorrect_list_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // correct_label
            // 
            this.correct_label.AutoSize = true;
            this.correct_label.Location = new System.Drawing.Point(115, 62);
            this.correct_label.Name = "correct_label";
            this.correct_label.Size = new System.Drawing.Size(124, 16);
            this.correct_label.TabIndex = 1;
            this.correct_label.Text = "Answered correctly:";
            // 
            // incorrect_label
            // 
            this.incorrect_label.AutoSize = true;
            this.incorrect_label.Location = new System.Drawing.Point(115, 107);
            this.incorrect_label.Name = "incorrect_label";
            this.incorrect_label.Size = new System.Drawing.Size(134, 16);
            this.incorrect_label.TabIndex = 2;
            this.incorrect_label.Text = "Answered incorrectly:";
            // 
            // passed_label
            // 
            this.passed_label.AutoSize = true;
            this.passed_label.Location = new System.Drawing.Point(115, 166);
            this.passed_label.Name = "passed_label";
            this.passed_label.Size = new System.Drawing.Size(45, 16);
            this.passed_label.TabIndex = 3;
            this.passed_label.Text = "Result";
            // 
            // calculate_btn
            // 
            this.calculate_btn.Location = new System.Drawing.Point(128, 245);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(75, 23);
            this.calculate_btn.TabIndex = 4;
            this.calculate_btn.Text = "Calclulate";
            this.calculate_btn.UseVisualStyleBackColor = true;
            this.calculate_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // incorrect_list_label
            // 
            this.incorrect_list_label.AutoSize = true;
            this.incorrect_list_label.Location = new System.Drawing.Point(118, 197);
            this.incorrect_list_label.Name = "incorrect_list_label";
            this.incorrect_list_label.Size = new System.Drawing.Size(10, 16);
            this.incorrect_list_label.TabIndex = 5;
            this.incorrect_list_label.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.incorrect_list_label);
            this.Controls.Add(this.calculate_btn);
            this.Controls.Add(this.passed_label);
            this.Controls.Add(this.incorrect_label);
            this.Controls.Add(this.correct_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label correct_label;
        private System.Windows.Forms.Label incorrect_label;
        private System.Windows.Forms.Label passed_label;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.Label incorrect_list_label;
    }
}

