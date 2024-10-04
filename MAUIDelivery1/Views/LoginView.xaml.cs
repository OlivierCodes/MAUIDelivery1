namespace MAUIDelivery1.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}

    private async void CreateAccount_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new CreateAccountView());

    }
}