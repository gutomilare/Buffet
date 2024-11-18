namespace Buffet.Views;

public partial class Reserva : ContentPage
{

	App PropriedadesApp;

	public Reserva()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_salao.ItemsSource = PropriedadesApp.lista_salao;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Confirmacao());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

}