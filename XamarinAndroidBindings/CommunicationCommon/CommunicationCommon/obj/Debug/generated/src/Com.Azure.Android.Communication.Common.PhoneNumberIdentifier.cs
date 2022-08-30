using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='PhoneNumberIdentifier']"
	[global::Android.Runtime.Register ("com/azure/android/communication/common/PhoneNumberIdentifier", DoNotGenerateAcw=true)]
	public sealed partial class PhoneNumberIdentifier : global::Com.Azure.Android.Communication.Common.CommunicationIdentifier {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/common/PhoneNumberIdentifier", typeof (PhoneNumberIdentifier));

		internal static new IntPtr class_ref {
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

		internal PhoneNumberIdentifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='PhoneNumberIdentifier']/constructor[@name='PhoneNumberIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe PhoneNumberIdentifier (string phoneNumber) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_phoneNumber = JNIEnv.NewString (phoneNumber);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_phoneNumber);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_phoneNumber);
			}
		}

		public unsafe string PhoneNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='PhoneNumberIdentifier']/method[@name='getPhoneNumber' and count(parameter)=0]"
			[Register ("getPhoneNumber", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getPhoneNumber.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string RawId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='PhoneNumberIdentifier']/method[@name='getRawId' and count(parameter)=0]"
			[Register ("getRawId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getRawId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='PhoneNumberIdentifier']/method[@name='setRawId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRawId", "(Ljava/lang/String;)Lcom/azure/android/communication/common/PhoneNumberIdentifier;", "")]
		public unsafe global::Com.Azure.Android.Communication.Common.PhoneNumberIdentifier SetRawId (string rawId)
		{
			const string __id = "setRawId.(Ljava/lang/String;)Lcom/azure/android/communication/common/PhoneNumberIdentifier;";
			IntPtr native_rawId = JNIEnv.NewString (rawId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rawId);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.Common.PhoneNumberIdentifier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_rawId);
			}
		}

	}
}
