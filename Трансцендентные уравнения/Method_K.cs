using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Трансцендентные_уравнения
{
    public partial class Method_K : Form
    {
        public static List<string> equation = new List<string> { };
        public static double my_equation = 0;
        public static double my_deriative = 0;
        public Method_K(List<string> myequation, string equation_text)
        {
            InitializeComponent();
            this.equation_text.Text = equation_text + " = 0";
            equation = myequation;
        }
        private void GetSolution_Click(object sender, EventArgs e)
        {
            bool flag = true;
            (string, string)[] symbols = { (X.Text, "X"), (h.Text, "h"), (exp.Text, "exp") };
            double[] X_h_exp = new double[symbols.Length];
            for (int i = 0; i < symbols.Length; i++)
            {
                if (check(symbols[i].Item1).Item1)
                {
                    X_h_exp[i] = check(symbols[i].Item1).Item2;
                }
                else
                {
                    flag = false;
                    MessageBox.Show($"{symbols[i].Item2} = {symbols[i].Item1}-данное значение имеет неврный вид. Попробуйте снова.");
                    X.Text = " ";
                    h.Text = " ";
                    exp.Text = " ";
                }
            }
            if(flag)
            {
                answer.Text = TangentMethod(X_h_exp[0], X_h_exp[1], X_h_exp[2]);
            }

        }
        static string TangentMethod(double X, double h, double exp)//Метод касательных
        {
            double c;
            int n = 0;
            do
            {
                double x1 = X - (Func(equation, X) / DeriativeFunc(equation, X + h));
                c = Math.Abs(x1 - X);
                X = x1;
                n++;
            } while (c > exp);
            return $"Ответ:\nx={X}\nf(x)={Func(equation, X)}\nn={n}";

        }

        static double Func(List<string> elements, double X)
        {
            int num = 0, sum = 0;
            foreach (string element in elements)
            {
                if (int.TryParse(element, out num))
                {
                    sum += num;
                }
                else
                {
                    my_equation += convertToMath(element, X);
                }
            }
            return my_equation += sum;
        }

        static double DeriativeFunc(List<string> elements, double X)
        {
            int num = 0, sum = 0;
            foreach (string element in elements)
            {
                if (int.TryParse(element, out num))
                {
                    sum += num;
                }
                else
                {
                    my_equation += convertToDeriative(element, X);
                }
            }
            return my_equation += sum;
        }
        static double convertToMath(string str, double X)//Переводит сложный элемент из строки в формулу
        {
            double element = 0;
            switch (str)
            {   //Элементы без минуса
                case "sinX": element = Math.Sin(X); break;
                case "cosX": element = Math.Cos(X); break;
                case "tgX": element = Math.Tan(X); break;
                case "ctgX": element = 1 / Math.Tan(X); break;
                case "X": element = X; break;
                case "X^2": element = Math.Pow(X, 2); break;
                case "X^3": element = Math.Pow(X, 3); break;
                case "X^4": element = Math.Pow(X, 4); break;
                case "X^5": element = Math.Pow(X, 5); break;
                case "X^6": element = Math.Pow(X, 6); break;
                case "e^X": element = Math.Pow(Math.E, X); break;

                //Элементы с минусом
                case "-sinX": element = -Math.Sin(X); break;
                case "-cosX": element = -Math.Cos(X); break;
                case "-tgX": element = -Math.Tan(X); break;
                case "-ctgX": element = -1 / Math.Tan(X); break;
                case "-X": element = -X; break;
                case "-X^2": element = -Math.Pow(X, 2); break;
                case "-X^3": element = -Math.Pow(X, 3); break;
                case "-X^4": element = -Math.Pow(X, 4); break;
                case "-X^5": element = -Math.Pow(X, 5); break;
                case "-X^6": element = -Math.Pow(X, 6); break;
                case "-e^X": element = -Math.Pow(Math.E, X); break;

                default: break;
            }
            return element;
        }

        static double convertToDeriative(string str, double X)//Переводит сложный элемент из строки в производную
        {
            double element = 0;
            switch (str)
            {   //Элементы без минуса
                case "sinX": element = Math.Cos(X); break;
                case "cosX": element = -Math.Sin(X); break;
                case "tgX": element = 1 / Math.Pow(Math.Cos(X), 2); break;
                case "X": element = 1; break;
                case "X^2": element = 2 * X; break;
                case "X^3": element = 3 * Math.Pow(X, 2); break;
                case "X^4": element = 4 * Math.Pow(X, 3); break;
                case "X^5": element = 5 * Math.Pow(X, 4); break;
                case "X^6": element = 6 * Math.Pow(X, 5); break;
                case "e^X": element = Math.Pow(Math.E, X); break;

                //Элементы с минусом
                case "-sinX": element = Math.Cos(X); break;
                case "-cosX": element = -Math.Sin(X); break;
                case "-tgX": element = -1 / Math.Pow(Math.Cos(X), 2); break;
                case "-X": element = -1; break;
                case "-X^2": element = -2 * X; break;
                case "-X^3": element = -3 * Math.Pow(X, 2); break;
                case "-X^4": element = -4 * Math.Pow(X, 3); break;
                case "-X^5": element = -5 * Math.Pow(X, 4); break;
                case "-X^6": element = -6 * Math.Pow(X, 5); break;
                case "-e^X": element = -Math.Pow(Math.E, X); break;

                default: break;
            }
            return element;
        }
        static (bool, double) check(string symb)
        {
            double num;
            if (double.TryParse(symb, out num))
            {
                return (true, num);
            }
            else
            {
                return (false, 0);
            }
        }
    }
    
}

