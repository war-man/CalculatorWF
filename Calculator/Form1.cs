using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private double _result;             //для подсчета результата
        private string _operationSign = ""; //значок операции
        private bool _showNewValue;         //факт о вводе нового значения

        public MainForm()
        {
            InitializeComponent();
            Focus();
        }

        private void Numbers_OnClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            //Если на экране ноль либо вводится новое значение - при вводе точки она отобразится после значения
            //при вводе нового значения сначала вытирается старое значения с экрана путем ""
            if (resultDisplay.Text == "0" || _showNewValue)
            {
                switch (b.Text)
                {
                    case ",":
                        resultDisplay.Text = resultDisplay.Text + b.Text;
                        break;

                    //выходим из свича при +/-, чтобы не затереть значение перед сменой знака
                    case "±":
                        break;

                    default:
                        resultDisplay.Text = "";
                        break;
                }
            }
            //для отображения нового значения переменную отвечающую за факт ввода ставим в ложь
            _showNewValue = false;

            switch (b.Text)
            {
                //если нажата кнопка-точка
                case ",":
                    {
                        //если на экране еще нет точки
                        if (!resultDisplay.Text.Contains(","))
                        {
                            //добавляем точку к тому что есть на экране
                            resultDisplay.Text = resultDisplay.Text + b.Text;
                        }

                        break;
                    }

                //при нажатии клавиши +/- если на экране уже есть минус - вытираем его вначале
                case "±" when resultDisplay.Text.Contains("-"):
                    resultDisplay.Text = resultDisplay.Text.TrimStart('-');
                    break;

                //при нажатии клавиши +/- если на экране нету минуса - отнимаем от нуля имеющееся на экране значение
                case "±":
                    resultDisplay.Text = (0 - Convert.ToDouble(resultDisplay.Text)).ToString();
                    break;

                //(если вводится не точка) добавляем значения к тому что есть на экране
                default:
                    resultDisplay.Text = resultDisplay.Text + b.Text;
                    break;
            }
        }

        private void Operators_OnClick(object sender, EventArgs e)
        {
            //перезаписываем знак операции и прошлый результат на новый
            Button b = (Button)sender;
            _operationSign = b.Text;

            _result = double.Parse(resultDisplay.Text);
            _showNewValue = true;
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            resultDisplay.Text = "0";
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            switch (_operationSign)
            {
                case "+":
                    resultDisplay.Text = (_result + double.Parse(resultDisplay.Text)).ToString();
                    break;

                case "-":
                    resultDisplay.Text = (_result - double.Parse(resultDisplay.Text)).ToString();
                    break;

                case "×":
                    resultDisplay.Text = (_result * double.Parse(resultDisplay.Text)).ToString();
                    break;

                case "√":
                    resultDisplay.Text = Math.Sqrt(double.Parse(resultDisplay.Text)).ToString();
                    break;

                case "x²":
                    resultDisplay.Text = Math.Pow(double.Parse(resultDisplay.Text), 2).ToString();
                    break;

                case "÷":
                    if (resultDisplay.Text == "0" && !_showNewValue)
                    {
                        _result = 0;
                        MessageBox.Show("Делить на ноль нельзя!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        break;
                    }
                    resultDisplay.Text = (_result / double.Parse(resultDisplay.Text)).ToString();
                    break;
            }
            _showNewValue = true;
            _operationSign = "\0";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Закрыть приложение?", "Закрытие", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.D0 || e.KeyData == Keys.NumPad0)
                BtnZero.PerformClick();
            else if (e.KeyData == Keys.D1 || e.KeyData == Keys.NumPad1)
                BtnOne.PerformClick();
            else if (e.KeyData == Keys.D2 || e.KeyData == Keys.NumPad2)
                BtnTwo.PerformClick();
            else if (e.KeyData == Keys.D3 || e.KeyData == Keys.NumPad3)
                BtnThree.PerformClick();
            else if (e.KeyData == Keys.D4 || e.KeyData == Keys.NumPad4)
                BtnFour.PerformClick();
            else if (e.KeyData == Keys.D5 || e.KeyData == Keys.NumPad5)
                BtnFive.PerformClick();
            else if (e.KeyData == Keys.D6 || e.KeyData == Keys.NumPad6)
                BtnSix.PerformClick();
            else if (e.KeyData == Keys.D7 || e.KeyData == Keys.NumPad7)
                BtnSeven.PerformClick();
            else if (e.KeyData == Keys.D8 || e.KeyData == Keys.NumPad8)
                BtnEight.PerformClick();
            else if (e.KeyData == Keys.D9 || e.KeyData == Keys.NumPad9)
                BtnNine.PerformClick();
            else if (e.KeyData == Keys.Decimal)
                BtnDot.PerformClick();

            else if (e.KeyData == Keys.Add)
                BtnAdd.PerformClick();
            else if (e.KeyData == Keys.Subtract)
                BtnMinus.PerformClick();
            else if (e.KeyData == Keys.Divide)
                BtnDivide.PerformClick();
            else if (e.KeyData == Keys.Multiply)
                BtnMultiply.PerformClick();
            else if (e.KeyData == Keys.Enter)
                BtnEquals.PerformClick();
        }
    }
}
