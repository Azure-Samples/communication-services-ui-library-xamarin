using System;
using Xamarin.Forms;

namespace CommunicationCallingXamarinSampleApp
{
    public partial class SettingsPage : ContentPage
    {
        public delegate void ProcessSettingsCallback(LocalizationProps localization, DataModelInjectionProps dataModelInjection, OrientationProps orientationProps);
        public event ProcessSettingsCallback Callback;

        String localAvatarName = "";
        String remoteAvatarName = "";
        LocalizationProps _localizationProps;
        DataModelInjectionProps _dataModelInjectionProps;
        OrientationProps _orientationProps;

        public SettingsPage(IComposite callComposite, LocalizationProps localizationProps, DataModelInjectionProps dataModelInjectionProps, OrientationProps orientationProps)
        {
            InitializeComponent();

            _localizationProps = localizationProps;
            _dataModelInjectionProps = dataModelInjectionProps;

            localCatBtn.BorderWidth = 3.0;
            localFoxBtn.BorderWidth = 3.0;
            localKoalaBtn.BorderWidth = 3.0;
            localMonkeyBtn.BorderWidth = 3.0;
            localMouseBtn.BorderWidth = 3.0;
            localOctopusBtn.BorderWidth = 3.0;

            remoteCatBtn.BorderWidth = 3.0;
            remoteFoxBtn.BorderWidth = 3.0;
            remoteKoalaBtn.BorderWidth = 3.0;
            remoteMonkeyBtn.BorderWidth = 3.0;
            remoteMouseBtn.BorderWidth = 3.0;
            remoteOctopusBtn.BorderWidth = 3.0;
            
            languagePicker.ItemsSource = callComposite.languages();
            languagePicker.SelectedItem = _localizationProps.locale;
            callScreenOrientationPicker.ItemsSource = callComposite.orientations();
            callScreenOrientationPicker.SelectedItem = _orientationProps.callScreenOrientation;
            setupScreenOrientationPicker.ItemsSource = callComposite.orientations();
            setupScreenOrientationPicker.SelectedItem = _orientationProps.setupScreenOrientation;

            SetLocalAvatarSelection(_dataModelInjectionProps.localAvatar);
            SetRemoteAvatarSelection(_dataModelInjectionProps.remoteAvatar);
        }

        void OnLeftToRightToggled(object sender, ToggledEventArgs e)
        {
            leftToRightToggle.IsToggled = e.Value;
        }

        async void OnDismissButtonClicked(object sender, EventArgs args)
        {
            if (Callback != null)
            {
                LocalizationProps localization = new LocalizationProps();
                localization.locale = languagePicker.SelectedItem.ToString();
                localization.isLeftToRight = leftToRightToggle.IsToggled;

                OrientationProps orientationProps = new OrientationProps();
                orientationProps.setupScreenOrientation = setupScreenOrientationPicker.SelectedItem.ToString();
                orientationProps.callScreenOrientation = callScreenOrientationPicker.SelectedItem.ToString();

                DataModelInjectionProps dataModelInjection = new DataModelInjectionProps();
                dataModelInjection.localAvatar = localAvatarName;
                dataModelInjection.remoteAvatar = remoteAvatarName;

                Callback(localization, dataModelInjection, orientationProps);
            }

            await Navigation.PopModalAsync(true);
        }

        void OnLocalCatAvatarClicked(object sender, EventArgs e)
        {
            localAvatarName = (localAvatarName != "cat") ? "cat" : "";
            SetLocalAvatarSelection(localAvatarName);
        }

        void OnLocalFoxAvatarClicked(object sender, EventArgs e)
        {
            localAvatarName = (localAvatarName != "fox") ? "fox" : "";
            SetLocalAvatarSelection(localAvatarName);
        }

        void OnLocalKoalaAvatarClicked(object sender, EventArgs e)
        {
            localAvatarName = (localAvatarName != "koala") ? "koala" : "";
            SetLocalAvatarSelection(localAvatarName);
        }

        void OnLocalMonkeyAvatarClicked(object sender, EventArgs e)
        {
            localAvatarName = (localAvatarName != "monkey") ? "monkey" : "";
            SetLocalAvatarSelection(localAvatarName);
        }

        void OnLocalMouseAvatarClicked(object sender, EventArgs e)
        {
            localAvatarName = (localAvatarName != "mouse") ? "mouse" : "";
            SetLocalAvatarSelection(localAvatarName);
        }

        void OnLocalOctopusAvatarClicked(object sender, EventArgs e)
        {
            localAvatarName = (localAvatarName != "octopus") ? "octopus" : "";
            SetLocalAvatarSelection(localAvatarName);
        }

        void OnRemoteCatAvatarClicked(object sender, EventArgs e)
        {
            remoteAvatarName = (remoteAvatarName != "cat") ? "cat" : "";
            SetRemoteAvatarSelection(remoteAvatarName);
        }

        void OnRemoteFoxAvatarClicked(object sender, EventArgs e)
        { 
            remoteAvatarName = (remoteAvatarName != "fox") ? "fox" : "";
            SetRemoteAvatarSelection(remoteAvatarName);
        }

        void OnRemoteKoalaAvatarClicked(object sender, EventArgs e)
        {
            remoteAvatarName = (remoteAvatarName != "koala") ? "koala" : "";
            SetRemoteAvatarSelection(remoteAvatarName);
        }

        void OnRemoteMonkeyAvatarClicked(object sender, EventArgs e)
        {
            remoteAvatarName = (remoteAvatarName != "monkey") ? "monkey" : "";
            SetRemoteAvatarSelection(remoteAvatarName);
        }

        void OnRemoteMouseAvatarClicked(object sender, EventArgs e)
        {
            remoteAvatarName = (remoteAvatarName != "mouse") ? "mouse" : "";
            SetRemoteAvatarSelection(remoteAvatarName);
        }

        void OnRemoteOctopusAvatarClicked(object sender, EventArgs e)
        {
            remoteAvatarName = (remoteAvatarName != "octopus") ? "octopus" : "";
            SetRemoteAvatarSelection(remoteAvatarName);
        }

        void SetLocalAvatarSelection(string avatarName)
        {
            localAvatarName = avatarName;
            localCatBtn.BorderColor = (localAvatarName == "cat") ? Color.Red : Color.White;
            localFoxBtn.BorderColor = (localAvatarName == "fox") ? Color.Red : Color.White;
            localKoalaBtn.BorderColor = (localAvatarName == "koala") ? Color.Red : Color.White;
            localMonkeyBtn.BorderColor = (localAvatarName == "monkey") ? Color.Red : Color.White;
            localMouseBtn.BorderColor = (localAvatarName == "mouse") ? Color.Red : Color.White;
            localOctopusBtn.BorderColor = (localAvatarName == "octopus") ? Color.Red : Color.White;

        }

        void SetRemoteAvatarSelection(string avatarName)
        {
            remoteAvatarName = avatarName;
            remoteCatBtn.BorderColor = (remoteAvatarName == "cat") ? Color.Red : Color.White;
            remoteFoxBtn.BorderColor = (remoteAvatarName == "fox") ? Color.Red : Color.White;
            remoteKoalaBtn.BorderColor = (remoteAvatarName == "koala") ? Color.Red : Color.White;
            remoteMonkeyBtn.BorderColor = (remoteAvatarName == "monkey") ? Color.Red : Color.White;
            remoteMouseBtn.BorderColor = (remoteAvatarName == "mouse") ? Color.Red : Color.White;
            remoteOctopusBtn.BorderColor = (remoteAvatarName == "octopus") ? Color.Red : Color.White;
        }
    }

    public struct LocalizationProps
    {
        public string locale;
        public Boolean isLeftToRight;
    }

    public struct DataModelInjectionProps
    {
        public string localAvatar;
        public string remoteAvatar;
    }

    public struct OrientationProps
    {
        public string setupScreenOrientation;
        public string callScreenOrientation;
    }
}
