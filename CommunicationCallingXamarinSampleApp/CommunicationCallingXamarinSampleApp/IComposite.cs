﻿using System.Collections.Generic;
namespace CommunicationCallingXamarinSampleApp
{
    public interface IComposite
    {
        void joinCall(string name, string acsToken, string callID, bool isTeamsCall, LocalizationProps? localization, DataModelInjectionProps? dataModelInjection, OrientationProps orientationProps, CallControlProps callControlProps);
        List<string> languages();
        List<string> orientations();
    }
}
