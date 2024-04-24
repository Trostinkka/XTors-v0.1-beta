namespace XTors
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void aythUser_Clicked(object sender, EventArgs e)
        {

        }

        private async void Registr_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegPage());

        }
    }

}
