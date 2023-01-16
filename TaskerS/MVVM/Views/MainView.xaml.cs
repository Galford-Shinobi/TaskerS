using TaskerS.MVVM.ViewModels;

namespace TaskerS.MVVM.Views;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();
		BindingContext= new MainViewModel();	
	}
}