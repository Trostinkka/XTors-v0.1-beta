namespace XTors
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
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
