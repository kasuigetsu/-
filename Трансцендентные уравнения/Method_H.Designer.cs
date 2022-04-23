
namespace Трансцендентные_уравнения
{
    partial class Method_H
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
            this.answer = new System.Windows.Forms.Label();
            this.GetSolution = new System.Windows.Forms.Button();
            this.label_exp = new System.Windows.Forms.Label();
            this.label_p = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.exp = new System.Windows.Forms.TextBox();
            this.P = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.TextBox();
            this.equation_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer.Location = new System.Drawing.Point(338, 67);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(0, 27);
            this.answer.TabIndex = 18;
            // 
            // GetSolution
            // 
            this.GetSolution.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetSolution.Location = new System.Drawing.Point(178, 147);
            this.GetSolution.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetSolution.Name = "GetSolution";
            this.GetSolution.Size = new System.Drawing.Size(127, 37);
            this.GetSolution.TabIndex = 17;
            this.GetSolution.Text = "Решить";
            this.GetSolution.UseVisualStyleBackColor = true;
            this.GetSolution.Click += new System.EventHandler(this.GetSolution_Click);
            // 
            // label_exp
            // 
            this.label_exp.AutoSize = true;
            this.label_exp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_exp.Location = new System.Drawing.Point(18, 157);
            this.label_exp.Name = "label_exp";
            this.label_exp.Size = new System.Drawing.Size(61, 27);
            this.label_exp.TabIndex = 16;
            this.label_exp.Text = "exp=";
            // 
            // label_p
            // 
            this.label_p.AutoSize = true;
            this.label_p.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_p.Location = new System.Drawing.Point(41, 111);
            this.label_p.Name = "label_p";
            this.label_p.Size = new System.Drawing.Size(40, 27);
            this.label_p.TabIndex = 15;
            this.label_p.Text = "P=";
            // 
            // label_x
            // 
            this.label_x.AutoSize = true;
            this.label_x.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_x.Location = new System.Drawing.Point(42, 65);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(43, 27);
            this.label_x.TabIndex = 14;
            this.label_x.Text = "X=";
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(91, 157);
            this.exp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(55, 22);
            this.exp.TabIndex = 13;
            // 
            // P
            // 
            this.P.Location = new System.Drawing.Point(91, 111);
            this.P.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(55, 22);
            this.P.TabIndex = 12;
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(91, 67);
            this.X.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(55, 22);
            this.X.TabIndex = 11;
            // 
            // equation_text
            // 
            this.equation_text.AutoSize = true;
            this.equation_text.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equation_text.Location = new System.Drawing.Point(44, 29);
            this.equation_text.Name = "equation_text";
            this.equation_text.Size = new System.Drawing.Size(0, 27);
            this.equation_text.TabIndex = 10;
            // 
            // Method_H
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 235);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.GetSolution);
            this.Controls.Add(this.label_exp);
            this.Controls.Add(this.label_p);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.P);
            this.Controls.Add(this.X);
            this.Controls.Add(this.equation_text);
            this.Name = "Method_H";
            this.Text = "Метод хорд";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Button GetSolution;
        private System.Windows.Forms.Label label_exp;
        private System.Windows.Forms.Label label_p;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.TextBox exp;
        private System.Windows.Forms.TextBox P;
        private System.Windows.Forms.TextBox X;
        private System.Windows.Forms.Label equation_text;
    }
}