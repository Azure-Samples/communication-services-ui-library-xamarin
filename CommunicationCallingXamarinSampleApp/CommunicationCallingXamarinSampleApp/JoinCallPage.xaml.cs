using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CommunicationCallingXamarinSampleApp
{
    public partial class JoinCallPage : ContentPage
    {
        IComposite callComposite = DependencyService.Get<IComposite>();
        bool isTeamsCall = false;

        const String groupCallTitle = "Group call ID";
        const String groupCallEntryPlaceholder = "Enter call ID";
        const String groupCallSubtitle = "Start a call to get a call ID.";

        const String teamsMeetingTitle = "Teams meeting";
        const String teamsMeetingEntryPlaceholder = "Enter invite link";
        const String teamsMeetingSubtitle = "Get link from the meeting invite or anyone in the call.";

        LocalizationProps _localization;
        DataModelInjectionProps _dataModelInjection;
        OrientationProps _orientationProps;
        CallControlProps _callControlProps;

        public JoinCallPage()
        {
            InitializeComponent();

            _localization = new LocalizationProps();
            _localization.locale = "en";
            _localization.isLeftToRight = true;

            _dataModelInjection = new DataModelInjectionProps();
            _dataModelInjection.localAvatar = "";
            _dataModelInjection.remoteAvatar = "";

            _orientationProps = new OrientationProps();
            _orientationProps.setupScreenOrientation = "PORTRAIT";
            _orientationProps.callScreenOrientation = "USER";

            _callControlProps = new CallControlProps();
            _callControlProps.isSkipSetupON = false;
            _callControlProps.isMicrophoneON = false;
            _callControlProps.isCameraON = false;
        }

        async void OnToolbarClicked(object sender, EventArgs e)
        {
            SettingsPage settingsPage = new SettingsPage(callComposite, _localization, _dataModelInjection, _orientationProps);
            settingsPage.Callback += new SettingsPage.ProcessSettingsCallback(ProcessSettings);
            await Navigation.PushModalAsync(settingsPage, true);
        }

        void ProcessSettings(LocalizationProps localization, DataModelInjectionProps dataModelInjection, OrientationProps orientationProps, CallControlProps callControlProps)
        {
            _localization = localization;
            _dataModelInjection = dataModelInjection;
            _orientationProps = orientationProps;
            _callControlProps = callControlProps;
            Console.WriteLine("locale is " + localization.locale + " isLeftToRight is " + localization.isLeftToRight);
        }

        void OnGroupCallClicked(object sender, EventArgs e)
        {
            if (isTeamsCall)
            {
                isTeamsCall = false;
                teamsMeetingPivot.TextColor = Color.FromHex("#6E6E6E");
                groupCallPivot.TextColor = Color.White;
                runningFrame.TranslateTo(runningFrame.X, 0, 150);
            }

            meetingTitleLabel.Text = groupCallTitle;
            meetingEntry.Placeholder = groupCallEntryPlaceholder;
            meetingSubtitleLabel.Text = groupCallSubtitle;
        }

        void OnTeamsMeetingClicked(object sender, EventArgs e)
        {
            if (!isTeamsCall)
            {
                isTeamsCall = true;
                teamsMeetingPivot.TextColor = Color.White;
                groupCallPivot.TextColor = Color.FromHex("#6E6E6E");
                runningFrame.TranslateTo(runningFrame.X + 171.5, 0, 150);
            }

            meetingTitleLabel.Text = teamsMeetingTitle;
            meetingEntry.Placeholder = teamsMeetingEntryPlaceholder;
            meetingSubtitleLabel.Text = teamsMeetingSubtitle;
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tokenEntry.Text) && !String.IsNullOrEmpty(meetingEntry.Text))
            {
                callComposite.joinCall(name.Text, tokenEntry.Text, meetingEntry.Text, isTeamsCall, _localization, _dataModelInjection, _orientationProps, _callControlProps);
            }
        }

    }
}
