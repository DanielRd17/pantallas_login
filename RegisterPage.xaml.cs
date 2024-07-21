namespace pantallas_login;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        // Aqu� puedes a�adir l�gica para el registro, como validaci�n y creaci�n de usuario

        // Una vez completado el registro, navega a la pantalla de inicio (LoginPage)
        await Navigation.PushAsync(new VerificationPage());
    }
}
