using TaskerS.MVVM.Views;

namespace TaskerS;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainView());
	}
}
