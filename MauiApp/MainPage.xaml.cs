namespace MauiApp
{
    public partial class MainPage : ContentPage
    {
        string vez = "0";
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button disparador = (Button)sender;
            disparador.IsEnabled = false;

            if (vez = = "0")
            {
                disparador.Text = "0";
                vez = "X";
            }
            else
            {
                disparador.Text = "X";
                vez = "0";
            }

            // verificando se o "X" ganhou na primeira linha

            if (bnt10.Text == "X" &&
                bnt11.Text == "X" &&
                bnt12.Text == "X")

            }
            
            if (bnt20.Text == "X" &&
            bnt21.Text == "X" && 
            bnt22.Text == "X");
