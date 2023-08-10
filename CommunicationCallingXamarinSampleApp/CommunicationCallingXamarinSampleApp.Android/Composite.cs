﻿using System;
using System.Collections.Generic;
using System.Net;
using Android.Graphics;
using Android.Util;
using Com.Azure.Android.Communication.Common;
using Com.Azure.Android.Communication.UI.Calling;
using Com.Azure.Android.Communication.UI.Calling.Models;
using Java.Interop;
using Java.Util;

[assembly: Xamarin.Forms.Dependency(typeof(CommunicationCallingXamarinSampleApp.Droid.Composite))]
namespace CommunicationCallingXamarinSampleApp.Droid
{
    public class Composite : IComposite
    {
        public void joinCall(string name, string acsToken, string callID, bool isTeamsCall, LocalizationProps? localization, DataModelInjectionProps? dataModelInjection)
        {
            CommunicationTokenCredential credentials = new CommunicationTokenCredential(acsToken);


            int layoutDirection = (int)(localization.Value.isLeftToRight ? Android.Util.LayoutDirections.Rtl : Android.Util.LayoutDirections.Ltr);

            CallComposite callComposite =
                new CallCompositeBuilder()
                .Theme(Resource.Style.MyCompany_CallComposite)
                .Localization(new CallCompositeLocalizationOptions(Locale.ForLanguageTag(localization.Value.locale), layoutDirection)).Build();


            callComposite.AddOnErrorEventHandler(new EventHandler());
            callComposite.AddOnRemoteParticipantJoinedEventHandler(new RemoteParticipantJoinedHandler(callComposite, dataModelInjection));
            callComposite.AddOnCallStateChangedEventHandler(new CallStateChangedEventHandler());
            callComposite.AddOnDismissedEventHandler(new CallCompositeDismissedEventHandler());

            CallCompositeParticipantViewData personaData = null;

            if (dataModelInjection != null)
            {
                var context = MainActivity.Instance.ApplicationContext;
                int resID = context.Resources.GetIdentifier(dataModelInjection.Value.localAvatar, "drawable", context.PackageName);
                Bitmap avatarBitMap = BitmapFactory.DecodeResource(context.Resources, resID);
                personaData = new CallCompositeParticipantViewData();
                personaData.SetAvatarBitmap(avatarBitMap);
                personaData.SetDisplayName(name);
            }


            if (isTeamsCall)
            {

                CallCompositeTeamsMeetingLinkLocator locator = new CallCompositeTeamsMeetingLinkLocator(callID);


                CallCompositeRemoteOptions remoteOptions = new CallCompositeRemoteOptions(locator, credentials, name);


                if (personaData != null)
                {
                    callComposite.Launch(MainActivity.Instance, remoteOptions, new CallCompositeLocalOptions(personaData));

                }
                else
                {
                    callComposite.Launch(MainActivity.Instance, remoteOptions);

                }
            }
            else
            {

                CallCompositeGroupCallLocator locator = new CallCompositeGroupCallLocator(UUID.FromString(callID));

                CallCompositeRemoteOptions remoteOptions = new CallCompositeRemoteOptions(locator, credentials, name);

                if (personaData != null)
                {
                    callComposite.Launch(MainActivity.Instance, remoteOptions, new CallCompositeLocalOptions(personaData));

                }
                else
                {
                    callComposite.Launch(MainActivity.Instance, remoteOptions);

                }

            }

            // to dismiss composite
            // callComposite.Dismiss();
        }

        public List<string> languages()
        {
            List<String> localeStrings = new List<String>();

            foreach (Locale locale in CallCompositeSupportedLocale.SupportedLocales)
            {
                localeStrings.Add(locale.Language);
            }

            return localeStrings;
        }

        public class EventHandler : Java.Lang.Object, ICallCompositeEventHandler
        {
            public void Disposed()
            {
            }

            public void DisposeUnlessReferenced()
            {
            }

            public void Finalized()
            {
            }

            public void Handle(Java.Lang.Object eventArgs)
            {
                if (eventArgs is CallCompositeErrorEvent)
                {
                    var error = eventArgs as CallCompositeErrorEvent;
                    Console.WriteLine(error.ErrorCode.ToString());
                }
            }

            public void SetJniIdentityHashCode(int value)
            {
            }

            public void SetJniManagedPeerState(JniManagedPeerStates value)
            {
            }

            public void SetPeerReference(JniObjectReference reference)
            {
            }

            public void UnregisterFromRuntime()
            {
            }

            protected virtual void Dispose(bool disposing)
            {

            }

            public void Dispose()
            {

            }
        }

        private class CallStateChangedEventHandler : Java.Lang.Object, ICallCompositeEventHandler
        {
            public void Disposed()
            {
            }

            public void DisposeUnlessReferenced()
            {
            }

            public void Finalized()
            {
            }

            public void Handle(Java.Lang.Object eventArgs)
            {
                if (eventArgs is CallCompositeCallStateEvent)
                {
                    var callState = eventArgs as CallCompositeCallStateEvent;
                    Console.WriteLine(callState.Code.ToString());
                }
            }

            public void SetJniIdentityHashCode(int value)
            {
            }

            public void SetJniManagedPeerState(JniManagedPeerStates value)
            {
            }

            public void SetPeerReference(JniObjectReference reference)
            {
            }

            public void UnregisterFromRuntime()
            {
            }

            protected virtual void Dispose(bool disposing)
            {

            }

            public void Dispose()
            {

            }
        }

        private class CallCompositeDismissedEventHandler : Java.Lang.Object, ICallCompositeEventHandler
        {
            public void Disposed()
            {
            }

            public void DisposeUnlessReferenced()
            {
            }

            public void Finalized()
            {
            }

            public void Handle(Java.Lang.Object eventArgs)
            {
                if (eventArgs is CallCompositeDismissedEvent)
                {
                    var dismissedEvent = eventArgs as CallCompositeDismissedEvent;
                    Console.WriteLine("CallCompositeDismissedEvent");
                }
            }

            public void SetJniIdentityHashCode(int value)
            {
            }

            public void SetJniManagedPeerState(JniManagedPeerStates value)
            {
            }

            public void SetPeerReference(JniObjectReference reference)
            {
            }

            public void UnregisterFromRuntime()
            {
            }

            protected virtual void Dispose(bool disposing)
            {

            }

            public void Dispose()
            {

            }
        }
    }
}
