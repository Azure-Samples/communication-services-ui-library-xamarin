using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.communication.ui.calling", Managed="Com.Azure.Android.Communication.UI.Calling")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.communication.ui.calling.models", Managed="Com.Azure.Android.Communication.UI.Calling.Models")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.communication.ui.calling.presentation.manager", Managed="Com.Azure.Android.Communication.UI.Calling.Presentation.Manager")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.communication.ui.calling.redux", Managed="Com.Azure.Android.Communication.UI.Calling.Redux")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.communication.ui.calling.redux.state", Managed="Com.Azure.Android.Communication.UI.Calling.Redux.State")]

delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

