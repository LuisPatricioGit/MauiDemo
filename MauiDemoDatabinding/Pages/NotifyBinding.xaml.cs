using System.Threading.Tasks;
using MauiDemoDatabinding.Models;

namespace MauiDemoDatabinding.Pages;

public partial class NotifyBinding : ContentPage
{
	Produto produto = new Produto();

	public NotifyBinding()
	{
		InitializeComponent();

		produto = new Produto
		{
			Nome = "DragonBall",
			Preco = 15.00m,
			Stock = 5
		};
		BindingContext = produto;
	}

    private async void btnActualiza_Clicked(object sender, EventArgs e)
    {
		produto.Nome = "Sonic The Hedgehog";
		produto.Preco = 10.00m;
		produto.Stock = 10;

		await DisplayAlert("Produto Atualizado", 
							$"{produto.Nome} - {produto.Preco} - {produto.Stock}",
							"OK");
    }
}