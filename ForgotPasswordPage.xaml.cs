namespace pantallas_login;

public partial class ForgotPasswordPage : ContentPage
{
    public ForgotPasswordPage()
    {
        InitializeComponent();
    }

    private async void OnSendTokenClicked(object sender, EventArgs e)
    {
        // Aquí puedes añadir la lógica para enviar el token de recuperación de contraseña.
        // Después de enviar el token, navega a la página de restablecimiento de contraseña.

        await Navigation.PushAsync(new ResetPasswordPage());
    }
}
