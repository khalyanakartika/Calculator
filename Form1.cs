using System;
using System.Windows.Forms;

namespace selasa
{
    public partial class kalkulator : Form
    {
        private string input = "";
        private double result = 0;
        private char operation;
        private bool operationPressed = false;

        public kalkulator()
        {
            InitializeComponent();
        }

        private void Kalkulator_Load(object sender, EventArgs e)
        {
            input_angka.Text = "0";
        }

        private void input_angka_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            input = "";
            result = 0;
            operationPressed = false;
            input_angka.Text = "0";
        }

        private void OperasiHitung(char op)
        {
            if (operationPressed) return;

            result = double.Parse(input_angka.Text);
            operation = op;
            operationPressed = true;
            input_angka.Text += " " + op + " ";
        }

        private void button_kali_Click(object sender, EventArgs e)
        {
            OperasiHitung('*');
        }

        private void button_bagi_Click(object sender, EventArgs e)
        {
            OperasiHitung('/');
        }

        private void button_tambah_Click(object sender, EventArgs e)
        {
            OperasiHitung('+');
        }

        private void button_kurang_Click(object sender, EventArgs e)
        {
            OperasiHitung('-');
        }

        private void button_koma_Click(object sender, EventArgs e)
        {
            if (!input_angka.Text.EndsWith("."))
            {
                input_angka.Text += ".";
            }
        }

        private void button_samadengan_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = input_angka.Text.Split(' ');
                if (parts.Length < 3)
                {
                    MessageBox.Show("Masukkan angka dengan benar!");
                    return;
                }

                double firstNumber = double.Parse(parts[0]);
                double secondNumber = double.Parse(parts[2]);

                switch (operation)
                {
                    case '+':
                        result = firstNumber + secondNumber;
                        break;
                    case '-':
                        result = firstNumber - secondNumber;
                        break;
                    case '*':
                        result = firstNumber * secondNumber;
                        break;
                    case '/':
                        if (secondNumber != 0) 
                            result = firstNumber / secondNumber;
                        else
                        {
                            MessageBox.Show("TETOT GA BISA DI / 0");
                            return;
                        }
                        break;
                }
                input_angka.Text = result.ToString();
                operationPressed = false;
            }
            catch
            {
                MessageBox.Show("Input tidak valid!");
            }
        }

        private void InputAngka(string angka)
        {
            if (input_angka.Text == "0")
            {
                input_angka.Text = angka;
            }
            else if (operationPressed)
            {
                input_angka.Text += angka; 
                operationPressed = false;
            }
            else
            {
                input_angka.Text += angka;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            InputAngka("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputAngka("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputAngka("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InputAngka("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InputAngka("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InputAngka("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InputAngka("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InputAngka("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InputAngka("9");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            InputAngka("0");
        }

    }
}
