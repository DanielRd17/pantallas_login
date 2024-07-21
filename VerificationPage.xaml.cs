namespace pantallas_login;

public partial class VerificationPage : ContentPage
{
    public VerificationPage()
    {
        InitializeComponent();
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        // Aquí puedes añadir lógica para verificar el código

        // Una vez completado el registro, navega a la pantalla de inicio (LoginPage)
        await Navigation.PushAsync(new LoginPage());
    }
}
