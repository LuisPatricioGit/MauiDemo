using System.Globalization;
using System.Threading.Tasks;

namespace MauiControls.Pages;

public partial class MauiSetValueControls : ContentPage
{
    public MauiSetValueControls()
    {
        InitializeComponent();
    }

    private async void CheckBox1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("CheckBox", "Selecionado", "Ok");
        }
        else
        {
            await DisplayAlert("CheckBox", "Desselecionado", "Ok");
        }
    }

    private async void CheckBox2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("CheckBox", "Selecionado 2", "Ok");
        }
        else
        {
            await DisplayAlert("CheckBox", "Desselecionado 2", "Ok");
        }
    }

    private async void CheckBox3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("CheckBox", "Selecionado 3", "Ok");
        }
        else
        {
            await DisplayAlert("CheckBox", "Desselecionado 3", "Ok");
        }
    }

    private void slider1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = Math.Round(slider1.Value, 2);
        lblSlider.Text = value.ToString();
    }

    private void stepper1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
        lblStepper.Text = string.Format($"Valor do Stepper: {value}");
    }

    private async void switch1_Toggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            await DisplayAlert("Switch", "Ligado", "Ok");
        }
        else
        {
            await DisplayAlert("Switch", "Desligado", "Ok");
        }
    }

    private async void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        CultureInfo culture = new CultureInfo("pt-PT");
        var data = ((DatePicker)sender).Date;
        var dataSelecionada = data.ToString("d", culture);
        await DisplayAlert("Data selecionada", dataSelecionada, "OK");
    }

    private async void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (time1 != null)
        {
            var horaSelecionada = time1.Time.ToString(@"hh\:mm");
            await DisplayAlert("Data selecionada", horaSelecionada, "OK");
        }
    }
}