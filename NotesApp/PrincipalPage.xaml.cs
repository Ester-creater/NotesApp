using Android.Widget;

namespace NotesApp;

public partial class PrincipalPage : ContentPage
{

    string fileNmae = Path.Combine(FileSystem.AppDataDirectory, "config.DAT");
    
    public PrincipalPage()
	{
		InitializeComponent();
	}

    private void SalvarBotao_Clicked(object sender, EventArgs e)
    {
        File.WriteAllText(fileName, TextoEditor.Text);
        DisplayAlert("OK", "Arquivo Salvo", "VAleu!");
    
    }

    private void DeletarBotao_Clicked(object sender, EventArgs e)
    {
        File.Delete(fileName);
    }
}