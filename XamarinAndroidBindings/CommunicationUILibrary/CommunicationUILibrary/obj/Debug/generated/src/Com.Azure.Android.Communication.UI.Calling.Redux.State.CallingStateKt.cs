using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.UI.Calling.Redux.State {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.ui.calling.redux.state']/class[@name='CallingStateKt']"
	[global::Android.Runtime.Register ("com/azure/android/communication/ui/calling/redux/state/CallingStateKt", DoNotGenerateAcw=true)]
	public sealed partial class CallingStateKt : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/ui/calling/redux/state/CallingStateKt", typeof (CallingStateKt));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal CallingStateKt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.redux.state']/class[@name='CallingStateKt']/method[@name='isDisconnected' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("isDisconnected", "(Ljava/lang/Object;)Z", "")]
		public static unsafe bool IsDisconnected (global::Java.Lang.Object obj)
		{
			const string __id = "isDisconnected.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (obj);
			}
		}

	}
}
