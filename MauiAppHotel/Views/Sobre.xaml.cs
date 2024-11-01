namespace MauiAppHotel.Views;

public partial class Sobre : ContentPage
{
    public Sobre()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {

            Navigation.PushAsync(new ContratacaoHospedagem());
        }catch (Exception ex) {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}