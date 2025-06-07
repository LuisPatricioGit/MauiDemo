namespace MauiDemo;

public partial class MyPage : ContentPage
{
	public MyPage()
	{
		InitializeComponent();
	}

	private async void Navigate_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MainPage());
	}
}