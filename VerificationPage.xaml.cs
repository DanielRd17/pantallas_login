namespace pantallas_login;

public partial class VerificationPage : ContentPage
{
    public VerificationPage()
    {
        InitializeComponent();
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        // Aqu� puedes a�adir l�gica para verificar el c�digo

        // Una vez completado el registro, navega a la pantalla de inicio (LoginPage)
        await Navigation.PushAsync(new LoginPage());
    }
}
