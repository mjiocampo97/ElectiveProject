using System;
using OcampoElective2Project.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace OcampoElective2Project
{
	public partial class App : Application
	{
	    public static ViewModelLocator Locator;
	    private readonly InitializeNavigation initNavigation;
        public App ()
		{
			InitializeComponent();
		    if (initNavigation == null)
		    {
		        initNavigation = new InitializeNavigation();
		    }
            MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
