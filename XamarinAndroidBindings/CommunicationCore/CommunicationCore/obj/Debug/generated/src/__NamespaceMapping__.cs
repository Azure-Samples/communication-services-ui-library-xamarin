using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.core.exception", Managed="Com.Azure.Android.Core.Exception")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.core.util", Managed="Com.Azure.Android.Core.Util")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.android.core.util.paging", Managed="Com.Azure.Android.Core.Util.Paging")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.azure.core.micro", Managed="Com.Azure.Core.Micro")]

delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

