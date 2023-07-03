using MAUIverter.MVVM.Views;

namespace MAUIverter;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        //UserAppTheme = AppTheme.Dark;
        MainPage = new NavigationPage(new MenuView());
    }
}
