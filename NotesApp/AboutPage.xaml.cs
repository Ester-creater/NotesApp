using Microsoft.Maui.ApplicationModel;

namespace NotesApp;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private void PerfilButton_Clicked(object sender, EventArgs e)
    {
		Uri link = new Uri("https://github.com/Ester-creater");
		Launcher.OpenAsync(link);
    }
}