using OOPConceptos.Logica;

namespace OOPConceptos.Interfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_validarFecha_Click(object sender, EventArgs e)
        {
            if (txt_year.Text.Length ==0)
            {
                MessageBox.Show("El año ingresado esta vacio", "Warning");
                return;
            }
            if (txt_month.Text.Length == 0)
            {
                MessageBox.Show("El mes ingresado esta vacio", "Warning");
                return;
            }
            if (txt_day.Text.Length == 0)
            {
                MessageBox.Show("El dia ingresado esta vacio", "Warning");
                return;
            }
            try
            {
                var yaer = Convert.ToInt32(txt_year.Text);
                var month = Convert.ToInt32(txt_month.Text);
                var day = Convert.ToInt32(txt_day.Text);

                var fecha = new Date(yaer, month, day);
                MessageBox.Show($"La fecha ingresada {fecha} es correcta", "Succesfull");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Fail");
            }

            
        }
    }
}