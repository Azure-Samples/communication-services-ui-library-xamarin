using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationTokenCredential']"
	[global::Android.Runtime.Register ("com/azure/android/communication/common/CommunicationTokenCredential", DoNotGenerateAcw=true)]
	public sealed partial class CommunicationTokenCredential : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/common/CommunicationTokenCredential", typeof (CommunicationTokenCredential));

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

		internal CommunicationTokenCredential (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationTokenCredential']/constructor[@name='CommunicationTokenCredential' and count(parameter)=1 and parameter[1][@type='com.azure.android.communication.common.CommunicationTokenRefreshOptions']]"
		[Register (".ctor", "(Lcom/azure/android/communication/common/CommunicationTokenRefreshOptions;)V", "")]
		public unsafe CommunicationTokenCredential (global::Com.Azure.Android.Communication.Common.CommunicationTokenRefreshOptions tokenRefreshOptions) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/azure/android/communication/common/CommunicationTokenRefreshOptions;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tokenRefreshOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenRefreshOptions).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (tokenRefreshOptions);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationTokenCredential']/constructor[@name='CommunicationTokenCredential' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe CommunicationTokenCredential (string userToken) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_userToken = JNIEnv.NewString (userToken);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_userToken);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userToken);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationTokenCredential']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "")]
		public unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
