namespace pantallas_login;

public partial class ForgotPasswordPage : ContentPage
{
    public ForgotPasswordPage()
    {
        InitializeComponent();
    }

    private async void OnSendTokenClicked(object sender, EventArgs e)
    {
        // Aqu� puedes a�adir la l�gica para enviar el token de recuperaci�n de contrase�a.
        // Despu�s de enviar el token, navega a la p�gina de restablecimiento de contrase�a.

        await Navigation.PushAsync(new ResetPasswordPage());
    }
}
