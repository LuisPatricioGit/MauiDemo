using System.Threading.Tasks;
using MauiControls.Models;

namespace MauiControls.Pages;

public partial class MauiCollectionControls : ContentPage
{
	public MauiCollectionControls()
	{
		InitializeComponent();
		BindingContext = new FotoViewModel();
	}

    private async void alertaCinto_OnChanged(object sender, ToggledEventArgs e)
    {
        await DisplayAlert("Alerta Cinto de Segurança!", $"Ativou/Desativou este acessório!", "OK");
    }

    //  private async void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
    //  {
    //if (e.CurrentItem != null && e.PreviousItem != null)
    //{
    //	Foto anterior = e.PreviousItem as Foto;
    //	Foto actual = e.CurrentItem as Foto;
    //	await DisplayAlert("Carrosel View", $"Anterior = {anterior.Nome} \n\nSeguinte = {actual.Nome}", "OK");
    //}
    //  }
}