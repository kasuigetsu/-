
namespace Трансцендентные_уравнения
{
    partial class Ex_eq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ex_eq));
            this.element = new System.Windows.Forms.TextBox();
            this.equation = new System.Windows.Forms.Label();
            this.for_equation = new System.Windows.Forms.Label();
            this.ToSolution = new System.Windows.Forms.ComboBox();
            this.for_solution = new System.Windows.Forms.Label();
            this.Rules = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // element
            // 
            this.element.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.element.Location = new System.Drawing.Point(318, 64);
            this.element.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.element.Name = "element";
            this.element.Size = new System.Drawing.Size(169, 34);
            this.element.TabIndex = 2;
            this.element.KeyDown += new System.Windows.Forms.KeyEventHandler(this.element_KeyDown);
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equation.Location = new System.Drawing.Point(12, 20);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(193, 27);
            this.equation.TabIndex = 3;
            this.equation.Text = "Ваше уравнение: ";
            this.equation.Click += new System.EventHandler(this.label1_Click);
            // 
            // for_equation
            // 
            this.for_equation.AutoSize = true;
            this.for_equation.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.for_equation.Location = new System.Drawing.Point(9, 64);
            this.for_equation.Name = "for_equation";
            this.for_equation.Size = new System.Drawing.Size(303, 27);
            this.for_equation.TabIndex = 4;
            this.for_equation.Text = "Введите элемент уравнения:";
            // 
            // ToSolution
            // 
            this.ToSolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToSolution.Enabled = false;
            this.ToSolution.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToSolution.FormattingEnabled = true;
            this.ToSolution.Items.AddRange(new object[] {
            "Метод половинного деления",
            "Метод простых итераций",
            "Метод касательных ",
            "Метод хорд"});
            this.ToSolution.Location = new System.Drawing.Point(300, 126);
            this.ToSolution.Name = "ToSolution";
            this.ToSolution.Size = new System.Drawing.Size(242, 34);
            this.ToSolution.TabIndex = 6;
            this.ToSolution.SelectedIndexChanged += new System.EventHandler(this.ToSolution_SelectedIndexChanged);
            // 
            // for_solution
            // 
            this.for_solution.AutoSize = true;
            this.for_solution.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.for_solution.Location = new System.Drawing.Point(9, 121);
            this.for_solution.Name = "for_solution";
            this.for_solution.Size = new System.Drawing.Size(285, 27);
            this.for_solution.TabIndex = 7;
            this.for_solution.Text = "Выберите метод решения: \r\n";
            // 
            // Rules
            // 
            this.Rules.AutoSize = true;
            this.Rules.Location = new System.Drawing.Point(560, 64);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(324, 152);
            this.Rules.TabIndex = 8;
            this.Rules.Text = resources.GetString("Rules.Text");
            this.Rules.Click += new System.EventHandler(this.Rules_Click);
            // 
            // Ex_eq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(889, 246);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.for_solution);
            this.Controls.Add(this.ToSolution);
            this.Controls.Add(this.for_equation);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.element);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Ex_eq";
            this.Text = "Трансцендентные уравнения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox element;
        private System.Windows.Forms.Label equation;
        private System.Windows.Forms.Label for_equation;
        private System.Windows.Forms.ComboBox ToSolution;
        private System.Windows.Forms.Label for_solution;
        private System.Windows.Forms.Label Rules;
    }
}

