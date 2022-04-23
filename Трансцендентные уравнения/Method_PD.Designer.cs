
namespace Трансцендентные_уравнения
{
    partial class Method_PD
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
            this.equation_text = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.exp = new System.Windows.Forms.TextBox();
            this.label_a = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_exp = new System.Windows.Forms.Label();
            this.GetSolution = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // equation_text
            // 
            this.equation_text.AutoSize = true;
            this.equation_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equation_text.Location = new System.Drawing.Point(36, 23);
            this.equation_text.Name = "equation_text";
            this.equation_text.Size = new System.Drawing.Size(0, 27);
            this.equation_text.TabIndex = 0;
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(77, 61);
            this.a.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(55, 27);
            this.a.TabIndex = 1;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(77, 105);
            this.b.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(55, 27);
            this.b.TabIndex = 2;
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(77, 151);
            this.exp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(55, 27);
            this.exp.TabIndex = 3;
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_a.Location = new System.Drawing.Point(34, 59);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(37, 27);
            this.label_a.TabIndex = 4;
            this.label_a.Text = "a=";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_b.Location = new System.Drawing.Point(33, 105);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(38, 27);
            this.label_b.TabIndex = 6;
            this.label_b.Text = "b=";
            // 
            // label_exp
            // 
            this.label_exp.AutoSize = true;
            this.label_exp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exp.Location = new System.Drawing.Point(10, 151);
            this.label_exp.Name = "label_exp";
            this.label_exp.Size = new System.Drawing.Size(61, 27);
            this.label_exp.TabIndex = 7;
            this.label_exp.Text = "exp=";
            // 
            // GetSolution
            // 
            this.GetSolution.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetSolution.Location = new System.Drawing.Point(170, 141);
            this.GetSolution.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetSolution.Name = "GetSolution";
            this.GetSolution.Size = new System.Drawing.Size(127, 37);
            this.GetSolution.TabIndex = 8;
            this.GetSolution.Text = "Решить";
            this.GetSolution.UseVisualStyleBackColor = true;
            this.GetSolution.Click += new System.EventHandler(this.GetSolution_Click);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer.Location = new System.Drawing.Point(330, 61);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(0, 27);
            this.answer.TabIndex = 9;
            // 
            // Method_PD
            // 
            this.AcceptButton = this.GetSolution;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 208);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.GetSolution);
            this.Controls.Add(this.label_exp);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.equation_text);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Method_PD";
            this.Text = "Метод половинного деления";
            this.Load += new System.EventHandler(this.Method_PD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label equation_text;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox exp;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_exp;
        private System.Windows.Forms.Button GetSolution;
        private System.Windows.Forms.Label answer;
    }
}