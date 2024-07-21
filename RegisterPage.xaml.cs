namespace pantallas_login;

public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        // Aquí puedes añadir lógica para el registro, como validación y creación de usuario

        // Una vez completado el registro, navega a la pantalla de inicio (LoginPage)
        await Navigation.PushAsync(new VerificationPage());
    }
}
