
namespace Трансцендентные_уравнения
{
    partial class Method_K
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
            this.GetSolution = new System.Windows.Forms.Button();
            this.label_exp = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.exp = new System.Windows.Forms.TextBox();
            this.h = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.TextBox();
            this.answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // equation_text
            // 
            this.equation_text.AutoSize = true;
            this.equation_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equation_text.Location = new System.Drawing.Point(34, 26);
            this.equation_text.Name = "equation_text";
            this.equation_text.Size = new System.Drawing.Size(0, 27);
            this.equation_text.TabIndex = 0;
            // 
            // GetSolution
            // 
            this.GetSolution.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetSolution.Location = new System.Drawing.Point(169, 154);
            this.GetSolution.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetSolution.Name = "GetSolution";
            this.GetSolution.Size = new System.Drawing.Size(127, 37);
            this.GetSolution.TabIndex = 15;
            this.GetSolution.Text = "Решить";
            this.GetSolution.UseVisualStyleBackColor = true;
            this.GetSolution.Click += new System.EventHandler(this.GetSolution_Click);
            // 
            // label_exp
            // 
            this.label_exp.AutoSize = true;
            this.label_exp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exp.Location = new System.Drawing.Point(9, 164);
            this.label_exp.Name = "label_exp";
            this.label_exp.Size = new System.Drawing.Size(61, 27);
            this.label_exp.TabIndex = 14;
            this.label_exp.Text = "exp=";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_b.Location = new System.Drawing.Point(32, 118);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(38, 27);
            this.label_b.TabIndex = 13;
            this.label_b.Text = "h=";
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_X.Location = new System.Drawing.Point(33, 72);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(43, 27);
            this.label_X.TabIndex = 12;
            this.label_X.Text = "X=";
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(76, 164);
            this.exp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(55, 22);
            this.exp.TabIndex = 11;
            // 
            // h
            // 
            this.h.Location = new System.Drawing.Point(76, 118);
            this.h.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(55, 22);
            this.h.TabIndex = 10;
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(76, 74);
            this.X.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(55, 22);
            this.X.TabIndex = 9;
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer.Location = new System.Drawing.Point(316, 69);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(0, 27);
            this.answer.TabIndex = 16;
            // 
            // Method_K
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 230);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.GetSolution);
            this.Controls.Add(this.label_exp);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.h);
            this.Controls.Add(this.X);
            this.Controls.Add(this.equation_text);
            this.Name = "Method_K";
            this.Text = "Метод касательных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label equation_text;
        private System.Windows.Forms.Button GetSolution;
        private System.Windows.Forms.Label label_exp;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.TextBox exp;
        private System.Windows.Forms.TextBox h;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label answer;
    }
}