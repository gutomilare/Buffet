namespace Buffet.Views;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new Reserva());
		} catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
		
    }

}