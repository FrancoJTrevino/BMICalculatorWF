namespace BMICalculatorWF
{
    public partial class FormBMI : Form
    {
        List<string> _english = ["Language:", "Measurement system:", "Introduce your weight:", "Introduce your height:", "Evaluate", "Pounds & Inches", "Kilos & Meters", "Introduce a valid option for your weight or height", "Your BMI is ", "You're underweight!", "You're normal!", "You're overweight!", "You're obese!", "You're extremely obese!"];
        List<string> _spanish = ["Idioma:", "Sistema de medición:", "Introduzca su peso:", "Introduzca su altura:", "Evaluar", "Libras y Pulgadas", "Kilos y Metros", "Introduzca una opción valida para su peso o altura", "Su IMC es de ", "Tienes bajo peso!", "Estas saludable!", "Tienes sobrepeso!", "Tienes obesidad!", "Tienes obesidad mórbida!"];
        public FormBMI()
        {
            InitializeComponent();
        }
        private void FormBMI_Load(object sender, EventArgs e)
        {
            cbLanguage.SelectedIndex = 0;
            cbSystem.SelectedIndex = 0;
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLanguage.SelectedIndex == 0)
            {
                cbSystem.Items.Clear();
                lblLanguage.Text = _english[0];
                lblSystem.Text = _english[1];
                lblSelectWeight.Text = _english[2];
                lblSelectHeight.Text = _english[3];
                btnCalc.Text = _english[4];
                cbSystem.Items.Add(_english[5]);
                cbSystem.Items.Add(_english[6]);
            }
            else
            {
                cbSystem.Items.Clear();
                lblLanguage.Text = _spanish[0];
                lblSystem.Text = _spanish[1];
                lblSelectWeight.Text = _spanish[2];
                lblSelectHeight.Text = _spanish[3];
                btnCalc.Text = _spanish[4];
                cbSystem.Items.Add(_spanish[5]);
                cbSystem.Items.Add(_spanish[6]);
            }
            cbSystem.SelectedIndex = 0;
        }

        private void cbSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSystem.SelectedIndex == 0)
            {
                lblWeight.Text = "Lb.";
                lblHeight.Text = "in.";
            }
            else
            {
                lblWeight.Text = "Kg.";
                lblHeight.Text = "m.";
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtHeight.Text.Length == 0 || txtWeight.Text.Length == 0)
            {
                MessageBox.Show("Error", cbLanguage.SelectedIndex == 0 ? _english[7] : _spanish[7], MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double Height = Convert.ToDouble(txtHeight.Text);
            double Weight = Convert.ToDouble(txtWeight.Text);
            double BMI = Weight / (Height * Height);
            if (cbSystem.SelectedIndex == 0) BMI *= 703;
            string result = cbLanguage.SelectedIndex == 0 ? _english[8] + Math.Round(BMI,2) + ". ": _spanish[8] + Math.Round(BMI, 2) + ". ";
            switch (true)
            {
                case true when BMI < 18.5:
                    result += cbLanguage.SelectedIndex == 0 ? _english[9] : _spanish[9]; break;
                case true when BMI >= 18.5 && BMI < 25:
                    result += cbLanguage.SelectedIndex == 0 ? _english[10] : _spanish[10]; break;
                case true when BMI >= 25 && BMI < 30:
                    result += cbLanguage.SelectedIndex == 0 ? _english[11] : _spanish[11]; break;
                case true when BMI >= 30 && BMI < 35:
                    result += cbLanguage.SelectedIndex == 0 ? _english[12] : _spanish[12]; break;
                case true when BMI >= 35:
                    result += cbLanguage.SelectedIndex == 0 ? _english[13] : _spanish[13]; break;
            }

            lblResult.Visible = true;
            lblResult.Text = result;
        }
    }
}
