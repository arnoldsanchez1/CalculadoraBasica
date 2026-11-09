using System;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Verifica que los TextBox no estén vacíos y que contengan números
        // antes de realizar cualquier operación.
        private bool verificar_Contenido()
        {
            bool valido = true;

            ErrorEncontrado.Clear();

            if (string.IsNullOrWhiteSpace(txtnum1.Text))
            {
                ErrorEncontrado.SetError(txtnum1, "Ingrese el primer número.");
                valido = false;
            }
            else if (!double.TryParse(txtnum1.Text, out _))
            {
                ErrorEncontrado.SetError(txtnum1, "Debe ingresar un valor numérico.");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtnum2.Text))
            {
                ErrorEncontrado.SetError(txtnum2, "Ingrese el segundo número.");
                valido = false;
            }
            else if (!double.TryParse(txtnum2.Text, out _))
            {
                ErrorEncontrado.SetError(txtnum2, "Debe ingresar un valor numérico.");
                valido = false;
            }

            return valido;
        }

        // Suma los dos números.
        private void btn_sumar_Click(object sender, EventArgs e)
        {
            if (!verificar_Contenido())
                return;

            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtnum2.Text);

            double resultado = num1 + num2;

            MessageBox.Show("Resultado: " + resultado, "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Resta el segundo número al primero.
        private void btn_restar_Click(object sender, EventArgs e)
        {
            if (!verificar_Contenido())
                return;

            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtnum2.Text);

            double resultado = num1 - num2;

            MessageBox.Show("Resultado: " + resultado, "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Multiplica los dos números.
        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            if (!verificar_Contenido())
                return;

            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtnum2.Text);

            double resultado = num1 * num2;

            MessageBox.Show("Resultado: " + resultado, "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Divide el primer número entre el segundo; no permite dividir entre cero.
        private void btn_dividir_Click(object sender, EventArgs e)
        {
            if (!verificar_Contenido())
                return;

            double num1 = double.Parse(txtnum1.Text);
            double num2 = double.Parse(txtnum2.Text);
            if (num2 == 0)
            {
                MessageBox.Show("No se puede dividir entre cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double resultado = num1 / num2;

            MessageBox.Show("Resultado: " + resultado, "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
