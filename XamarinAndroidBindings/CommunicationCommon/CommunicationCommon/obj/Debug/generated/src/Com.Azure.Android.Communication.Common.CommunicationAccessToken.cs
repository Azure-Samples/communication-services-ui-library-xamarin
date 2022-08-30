using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationAccessToken']"
	[global::Android.Runtime.Register ("com/azure/android/communication/common/CommunicationAccessToken", DoNotGenerateAcw=true)]
	public sealed partial class CommunicationAccessToken : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/common/CommunicationAccessToken", typeof (CommunicationAccessToken));

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

		internal CommunicationAccessToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationAccessToken']/constructor[@name='CommunicationAccessToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='org.threeten.bp.OffsetDateTime']]"
		[Register (".ctor", "(Ljava/lang/String;Lorg/threeten/bp/OffsetDateTime;)V", "")]
		public unsafe CommunicationAccessToken (string token, global::ThreeTen.BP.OffsetDateTime expiresAt) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lorg/threeten/bp/OffsetDateTime;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_token = JNIEnv.NewString (token);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_token);
				__args [1] = new JniArgumentValue ((expiresAt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) expiresAt).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_token);
				global::System.GC.KeepAlive (expiresAt);
			}
		}

		public unsafe global::ThreeTen.BP.OffsetDateTime ExpiresAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationAccessToken']/method[@name='getExpiresAt' and count(parameter)=0]"
			[Register ("getExpiresAt", "()Lorg/threeten/bp/OffsetDateTime;", "")]
			get {
				const string __id = "getExpiresAt.()Lorg/threeten/bp/OffsetDateTime;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::ThreeTen.BP.OffsetDateTime> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationAccessToken']/method[@name='isExpired' and count(parameter)=0]"
			[Register ("isExpired", "()Z", "")]
			get {
				const string __id = "isExpired.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationAccessToken']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
