namespace loginMaui;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try { 
		
		
		
		}catch (Exception ex) {
			DisplayAlert("Ops", ex.Message, "Fechar");
		
		
		
		}//fecha o cath
    }//fecha button
}//fecha classe