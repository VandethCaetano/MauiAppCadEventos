namespace MauiAppCadEventos;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
    }

    private void bnt_voltar_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}