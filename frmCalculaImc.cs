namespace ImcApp
{
    public partial class frmCalculaIMC : Form
    {
        public frmCalculaIMC()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            //Pega o n�mero do campo peso e gauarda na v�riavel.
            decimal peso = NumPeso.Value;

            //Pega o n�mero do campo altura e gauarda na v�riavel.
            decimal altura = NumAltura.Value;

            //C�lculo do IMC

            decimal imc = peso / (altura * altura);

            Resultado.Text = imc.ToString("N2");


        }


    }

}