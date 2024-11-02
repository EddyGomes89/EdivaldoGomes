namespace loginMaui;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try { 
		 List <DadosUsuario> lista_usuarios = new List<DadosUsuario>()
			{
				new DadosUsuario()
				{
					Usuario = "Jose",
					Senha = "123"
				},
                new DadosUsuario()
                {
                    Usuario = "Maria",
                    Senha = "123"
                }
            };//fecha list

			DadosUsuario dados_digitados = new DadosUsuario()
			{
				Usuario = txt_usuario.Text,
				Senha = txt_senha.Text
			};
			//linq
			if(lista_usuarios.Any(
				i => (dados_digitados.Usuario == i.Usuario && 
			      dados_digitados.Senha == i.Senha)) )
			{
				await SecureStorage.Default.SetAsync("usuario_logado", dados_digitados.Usuario);
			 App.Current.MainPage = new Protegida();
			
			} else
			{
				throw new Exception("Usuario ou senha incorretos");


			}


		
		}catch (Exception ex) {
			await DisplayAlert("Ops", ex.Message, "Fechar");
		
		
		}//fecha o cath
    }//fecha button
}//fecha classe