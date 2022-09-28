![Hero Image](/mobile-ui-library-hero-image.png)

# Azure Communication UI Mobile Library for Xamarin

This project demonstrates the integration of Azure Communication UI library into Xamarin Forms that utilizes the native Azure Communication UI library and Azure Communication Services to build a calling experience that features both voice and video calling. 


## Features

Please refer to our native [UI Library overview](https://docs.microsoft.com/en-us/azure/communication-services/concepts/ui-library/ui-library-overview?pivots=platform-mobile)

## Prerequisites

- iOS [Requirements](https://github.com/Azure/communication-ui-library-ios#requirements)
- Android [Requirements](https://github.com/Azure/communication-ui-library-android#prerequisites)
- Visual Studio [Setup Instructions](https://docs.microsoft.com/en-us/xamarin/get-started/installation/?pivots=macos)
- Azure Communication Services Token [See example](https://docs.microsoft.com/azure/communication-services/tutorials/trusted-service-tutorial)


## Run Sample

Clone repo and open `CommunicationCallingXamarinSampleApp.sln` in Visual Studio

#### For Android

Run `downloadJarScript.sh` and all the required jar/aar's will be downloaded in their specific folders.
After cloning repo, open terminal and navigate to the `XamarinAndroidBindings` folder and run the following command:

### Windows

Windows users can use powershell and run the script as an administator.

```cs
./downloadJarScript.sh
```

### Mac
```cs
chmod +x downloadJarScript.sh && ./downloadJarScript.sh
```

Set `CommunicationCallingXamarinSampleApp.Android` as start up project, build solution and select a device or emulator to run application.

#### For iOS
It is recommended building the binding libraries on MacOS first. 

First navigate to `XamariniOSindins/CommunicationUIProxy.Binding` and build the `CommunicationUIProxy.Binding.sln`. 
This will generate `CommunicationUIProxy.Binding\bin` folder where it will have `NativeLibrary.dll` for you to use. 

Open `CommunicationCallingXamarinSampleApp.sln`. Under the `CommunicationCallingXamarinSampleApp.iOS/References` right click and `Add Reference`. In the `.Net Assembly` tab we can browse to where the `.dll` of our binding library and add it as a reference. 
Now you can including the library into your project by adding `using Xam.CommunicationUIProxy.iOS;` at the top of you `.cs` files. 

Set `CommunicationCallingXamarinSampleApp.iOS` as start up project, build, and select a device or emulator to run application.


## Key Sample Highlights

### Folder Structure

```
| CommunicationCallingXamarinSampleApp
    | CommunicationCallingXamarinSampleApp.Android -> Android Xamarin sample application.
    | CommunicationCallingXamarinSampleApp.Android -> iOS Xamarin sample application.
    | CommunicationCallingXamarinSampleApp -> Common code for Android and iOS (UI).
| XamarinAndroidBindings
    | CommunicationUILibrary -> Bindings for Azure Communication UI library 
    | CommunicationCommon -> Bindings for communication common (required for object `CommunicationTokenCredentials`)
    | CommunicationCore -> Bindings for communication core (required for object `ExpandableStringEnum`)
| XamariniOSBindings
    | CommunicationUIProxy.Binding -> Bindings for Azure Communication UI library 
```



### Android and iOS Common code 

The common code for Android and iOS include `UI` and `interface` to trigger a call in Android and iOS specific projects.

`CommunicationCallingXamarinSampleApp/JoinCallPage.xaml.cs` has common UI code for Android and iOS. On Button click, Android and iOS app is triggered to start a call.

```cs
void OnButtonClicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tokenEntry.Text) && !String.IsNullOrEmpty(meetingEntry.Text))
            {
                callComposite.joinCall(name.Text, tokenEntry.Text, meetingEntry.Text, isTeamsCall, _localization, _dataModelInjection);
            }
        }
```


`CommunicationCallingXamarinSampleApp/IComposite.cs` has common interface used by Android and iOS sample application to start a call.

```cs
namespace CommunicationCallingXamarinSampleApp
{
    public interface IComposite
    {
        void joinCall(string name, string acsToken, string callID, bool isTeamsCall, LocalizationProps? localization, DataModelInjectionProps? dataModelInjection);
        List<string> languages();
    }
}

```

### Bridging Guide

To learn more about how this sample was created and communicates with the native ACS Mobile UI Library, please refer to our briding guides:

[Android Bridging Guide](XamarinAndroidBindings/README.md)

[iOS Bridging Guide](XamariniOSBindings/README.md)




