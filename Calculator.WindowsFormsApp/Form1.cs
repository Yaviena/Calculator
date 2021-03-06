using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.WindowsFormsApp
{
    public enum Operation
    {
        None,
        Add,
        Subtract,
        Multiple,
        Divide
    }
    public partial class Form1 : Form
    {
        private string _firstValue;
        private string _secondValue;
        private Operation _currentOperation = Operation.None;
        private bool _isTheResultOnTheScreen;
        public Form1()
        {
            InitializeComponent();
            tbScreen.Text = "0";
        }

        private void OnButtonNumberClick(object sender, EventArgs e)
        {
            var clickedValue = (sender as Button).Text;

            if (tbScreen.Text == "0" && clickedValue != ".")
                tbScreen.Text = string.Empty;

            if (_isTheResultOnTheScreen)
            {
                _isTheResultOnTheScreen = false;
                tbScreen.Text = string.Empty;

                if (clickedValue == ".")
                    clickedValue = "0.";
            }

            tbScreen.Text += clickedValue;
            SetResultButtonState(true);

            if (_currentOperation != Operation.None)
                _secondValue += clickedValue;
            else
                SetOperationButtonState(true);
        }

        private void OnButtonOperationClick(object sender, EventArgs e)
        {
            _firstValue = tbScreen.Text;

            var clickedOperation = (sender as Button).Text;

            _currentOperation = clickedOperation switch
            {
                "+" => Operation.Add,
                "-" => Operation.Subtract,
                "*" => Operation.Multiple,
                "/" => Operation.Divide,
                _ => Operation.None
            };

            tbScreen.Text += $" {clickedOperation} ";

            if (_isTheResultOnTheScreen)
                _isTheResultOnTheScreen = false;

            SetOperationButtonState(false);
            SetResultButtonState(false);
        }

        private void OnButtonResultClick(object sender, EventArgs e)
        {
            if (_currentOperation == Operation.None)
                return;

            var firstNumber = double.Parse(_firstValue);
            var secondNumber = double.Parse(_secondValue);
            var result = Calculate(firstNumber, secondNumber);

            tbScreen.Text = result.ToString();

            _firstValue = string.Empty;
            _secondValue = string.Empty;
            _currentOperation = Operation.None;
            _isTheResultOnTheScreen = true;
            SetOperationButtonState(true);
            SetResultButtonState(true);
        }

        private void OnButtonClearClick(object sender, EventArgs e)
        {
            _firstValue = string.Empty;
            _secondValue = string.Empty;
            _currentOperation = Operation.None;
            _isTheResultOnTheScreen = false;
            tbScreen.Text = "0";
        }
        private double Calculate(double firstNumber, double secondNumber)
        {

            switch (_currentOperation)
            {
                case Operation.None:
                    return firstNumber;
                case Operation.Add:
                    return firstNumber + secondNumber;
                case Operation.Subtract:
                    return firstNumber - secondNumber;
                case Operation.Multiple:
                    return firstNumber * secondNumber;
                case Operation.Divide:
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Dividing by 0 is not permit!");
                        return 0;
                    }
                    return firstNumber / secondNumber;
            }
            return 0;
        }
        private void SetOperationButtonState(bool value)
        {
            btnAdd.Enabled = value;
            btnSubstraction.Enabled = value;
            btnMultiplication.Enabled = value;
            btnDivision.Enabled = value;
        }
        private void SetResultButtonState(bool value)
        {
            btnResult.Enabled = value;
        }
    }
}
