using MyMauiApp.Platforms.iOS;
using System;
namespace MyMauiApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		Composite composite = new Composite();
		string name = "";
		string acsToken = "";
		string callId = "";
		bool isTeamsCall = true;
		composite.JoinCall(name, acsToken, callId, isTeamsCall);
	}
}


