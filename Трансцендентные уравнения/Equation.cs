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
    /*
     * Добавить ввод/чтение множетелей перед сложными элементами(+/-) если гительман скажет? 
     */
    public partial class Ex_eq : Form
    { 
        bool flag = false;//флаг, нужный для проверки первого элемента уравнения
        public static List<string> elements_list = new List<string> {};//Стринговая запись уравнения
        public static List<string> complex_elements = new List<string>{"cosX","sinX","tgX","e^X","X","X^2","X^3","X^4","X^5","X^6"};//Доступные элементы
        public Ex_eq()
        {
            InitializeComponent();
            equation.Focus();
        }
        private void element_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (element.Text == String.Empty)
                {
                    MessageBox.Show("Вы ничего не ввели!");
                }
                else
                {
                    if (element.Text.Remove(1, element.Text.Length - 1) == "-")//если число с минусом
                    {
                        if (checkElement(element.Text.Remove(0, 1)))
                        {

                            flag = true;
                            ToSolution.Enabled = true;
                            equation.Text += element.Text;
                            elements_list.Add(element.Text);
                            element.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Введенный вами элемент имеет неверный вид.");
                            element.Text = string.Empty;
                        }
                    }
                    else if (element.Text.Remove(1, element.Text.Length - 1) == "+")
                    {
                        MessageBox.Show("Введенный вами элемент имеет неверный вид.");
                        element.Text = "";
                    }
                    else
                    {
                        if (checkElement(element.Text))//если число без минуса
                        {
                            if (flag)
                            {
                                equation.Text += "+" + element.Text;
                            }
                            else
                            {
                                equation.Text += element.Text;
                                flag = true;
                            }
                            ToSolution.Enabled = true;
                            elements_list.Add(element.Text);
                            element.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Введенный вами элемент имеет неверный вид.");
                            element.Text = string.Empty;
                        }
                    }
                }
            }
            else if(e.KeyCode==Keys.Delete)
            {
                ToSolution.Enabled = false;
                equation.Text = "Ваше уравнение: ";
                elements_list.Clear();
                flag = false;
            }
        }
        static bool checkElement(string toCheck)//Проверка элементов уравнения
        {
            char[] el_chars = toCheck.ToCharArray();
            bool flag = false;
            int num;
            for (int i = 0; i < complex_elements.Count; i++)//если элемент является сложным
            {
                if (toCheck == complex_elements[i])
                {
                    flag = true;
                }
            }
            if (int.TryParse(toCheck, out num))//если элемент является числом
            {
                flag = true;
            }
            return flag;

        }
        private void ToSolution_SelectedIndexChanged(object sender, EventArgs e)//Выбор метода из комбобокса
        {
            if (checkTheEquation(elements_list))
            {
                if (ToSolution.SelectedIndex == 0)
                {
                    //Метод половинного деления
                    Form pd = new Method_PD(elements_list, equation.Text);
                    pd.Show();
                }
                else if(ToSolution.SelectedIndex == 1)
                {
                    //Метод простых итераций
                    //Form pi = new Method_PI();
                    //pi.Show();
                    MessageBox.Show("Этот метод недоступен.");
                }
                else if (ToSolution.SelectedIndex == 2)
                {
                    //Метод касательных
                    Form k = new Method_K(elements_list, equation.Text);
                    k.Show();

                }
                else if (ToSolution.SelectedIndex == 3)
                {
                    //Метод хорд
                    Form h = new Method_H(elements_list, equation.Text);
                    h.Show();
                }
            }
            else
            {
                equation.Text = "Ваше уравнение: ";
                elements_list.Clear();
                flag = false;
                MessageBox.Show("В уравнении должен быть Х.");
                ToSolution.Enabled = false;
            }
        }
        static bool checkTheEquation(List<string>elements_list)
        {
        bool flag=false;
        foreach (string element in elements_list)
            {
             for (int i = 0; i < complex_elements.Count; i++)
                {
                  if(element == complex_elements[i])//если среди элементов есть хоть один с Х
                  {
                    flag=true;
                  } 
                  else
                  {
                    continue;
                  }
                }
            }
        return flag;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Rules_Click(object sender, EventArgs e)
        {
        }

    }
}
