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
            //Pega o número do campo peso e gauarda na váriavel.
            decimal peso = NumPeso.Value;

            //Pega o número do campo altura e gauarda na váriavel.
            decimal altura = NumAltura.Value;

            //Cálculo do IMC

            decimal imc = peso / (altura * altura);

            Resultado.Text = imc.ToString("N2");


        }


    }

}