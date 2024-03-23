using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace lab02
{
    public partial class FormBai3 : Form
    {
        public FormBai3()
        {
            InitializeComponent();
        }

        static string ToPostFixed(string expression)
        {
            string[] elements = expression.Split(' ');
            Stack<string> stack = new Stack<string>();
            List<string> result = new List<string>();
            double num;
            foreach (string e in elements)
            {
                if (double.TryParse(e, out num))
                {
                    result.Add(e);
                }
                else if (e == "(")
                {
                    stack.Push(e);
                }
                else if (e == ")")
                {
                    while (stack.Count > 0 && stack.Peek() != "(")
                    {
                        result.Add(stack.Pop());
                    }
                    stack.Pop();
                }
                else
                {
                    while (stack.Count > 0 && (Prec(e) <= Prec(stack.Peek())))
                    {
                        result.Add(stack.Pop());
                    }
                    stack.Push(e);
                }
            }

            while (stack.Count > 0)
            {
                result.Add(stack.Pop());
            }

            string ketqua = PerformOperation(result);
            stack.Clear();
            result.Clear();
            return ketqua;

        }

        static string PerformOperation(List<string> postfix)
        {
            double result = 0;
            Stack<string> stack = new Stack<string>();
            double num;
            foreach (string e in postfix)
            {
                if (double.TryParse(e, out num))
                {
                    stack.Push(e);
                }
                else if (IsOperator(e))
                {
                    double b = double.Parse(stack.Pop());
                    double a = double.Parse(stack.Pop());
                    switch (e)
                    {
                        case "+":
                            result = a + b; break;
                        case "-":
                            result = a - b; break;
                        case "*":
                            result = a * b; break;
                        case "/":
                            result = a / b; break;
                        default:
                            MessageBox.Show($"Error: {e}"); break;
                    }
                    stack.Push(result.ToString());
                }
            }
            stack.Clear();
            return result.ToString();
        }

        static bool IsOperator(string element)
        {
            return element == "+" || element == "-" || element == "*" || element == "/";
        }

        static int Prec(string operatorSymbol)
        {
            if (operatorSymbol == "+" || operatorSymbol == "-")
            {
                return 1;
            }
            else if (operatorSymbol == "*" || operatorSymbol == "/")
            {
                return 2;
            }
            return -1;
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            rTBInput.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text File|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);
                rTBInput.Text = sr.ReadToEnd();
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs1 = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs1);
                string[] lines = rTBInput.Text.Split("\n");
                foreach (string line in lines)
                {
                    if (!string.IsNullOrEmpty(line))
                    {
                        rTBOutput.Text += line + "=" + ToPostFixed(line) + "\r\n";
                    }
                }
                sw.Write(rTBOutput.Text);
                sw.Flush();
                fs1.Close();
            }
        }
    }
}
