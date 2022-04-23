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
    public partial class Method_PD : Form
    {
        public static List<string> equation = new List<string> { };
        public static double my_equation = 0;
        public Method_PD(List<string> myequation, string equation_text)
        {
            InitializeComponent();
            this.equation_text.Text = equation_text+" = 0";
            equation = myequation;
        }
      
        private void GetSolution_Click(object sender, EventArgs e)
        {
            bool flag = true;
            (string, string)[] symbols = {(a.Text,"a"),(b.Text,"b"),(exp.Text,"exp")};
            double[] a_b_exp = new double[symbols.Length]; 
            for(int i=0;i<symbols.Length;i++)
            {
                if(check(symbols[i].Item1).Item1)
                {
                    a_b_exp[i] = check(symbols[i].Item1).Item2;
                }
                else
                {
                    flag = false;
                    MessageBox.Show($"{symbols[i].Item2} = {symbols[i].Item1}-данное значение имеет неврный вид. Попробуйте снова.");
                    a.Text = " ";
                    b.Text = " ";
                    exp.Text = " ";
                }
            }
            if(flag)
            {
                answer.Text = HalfDivisionMethod(a_b_exp[0], a_b_exp[1], a_b_exp[2]);
            }
        }
        
        static (bool,double) check(string symb)
        {
            double num;
            if(double.TryParse(symb,out num))
            {
                return (true, num);
            }
            else
            {
                return (false, 0);
            }
        }
        static string HalfDivisionMethod(double a,double b, double exp)//Метод половинного деления
        {
            double x = 0;
            int n = 0;
            while (Math.Abs(b - a) > exp)
            {
                x = (a + b) / 2;
                if (Func(equation,a) * Func(equation,x) > 0) a=x;
                else b = x;
                n++;
            }
            return $"Ответ:\nx={a}\nf(x)={Func(equation,x)}\nn={n}";
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
        static double convertToMath(string str, double X)//Переводит сложный элемент из строки в формулу
        {
            double element = 0;
            switch (str)
            {   //Элементы без минуса
                case "sinX": element = Math.Sin(X); break;
                case "cosX": element = Math.Cos(X); break;
                case "tgX": element = Math.Tan(X); break;
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
        private void Method_PD_Load(object sender, EventArgs e)
        {

        }

    }
}
