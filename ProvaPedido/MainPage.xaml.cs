namespace ProvaPedido
{
    public partial class MainPage : ContentPage
    {
        int valor = 0;
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            SidesPicker.SelectedIndex = 0;
        }

        private void RollBtn_Clicked (object sender, EventArgs e)
        {
            //Pegar o valor que foi selecionado pelo usuário no picker
            valor = Convert.ToInt32(SidesPicker.SelectedItem) +1 ;
            //Jogar esse valor em uma variavel
            //Sortear um número em um dado utilizando o Random
            //Colocar o valor sorteado em uma variável
            int umvalor = 0;
            umvalor = new Random().Next(1, valor);
            //Exibir o valor para um usuário na ResultLabel
           
            ResultLabel.Text = umvalor.ToString();
        }

    }
}

