using System;
using Xamarin.Forms;

namespace CommunicationCallingXamarinSampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnJoinCallButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new JoinCallPage());
        }
    }
}
