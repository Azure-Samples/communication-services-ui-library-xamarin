using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='MicrosoftTeamsUserIdentifier']"
	[global::Android.Runtime.Register ("com/azure/android/communication/common/MicrosoftTeamsUserIdentifier", DoNotGenerateAcw=true)]
	public sealed partial class MicrosoftTeamsUserIdentifier : global::Com.Azure.Android.Communication.Common.CommunicationIdentifier {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/common/MicrosoftTeamsUserIdentifier", typeof (MicrosoftTeamsUserIdentifier));

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

		internal MicrosoftTeamsUserIdentifier (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='MicrosoftTeamsUserIdentifier']/constructor[@name='MicrosoftTeamsUserIdentifier' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MicrosoftTeamsUserIdentifier (string userId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_userId = JNIEnv.NewString (userId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_userId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userId);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='MicrosoftTeamsUserIdentifier']/constructor[@name='MicrosoftTeamsUserIdentifier' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/lang/String;Z)V", "")]
		public unsafe MicrosoftTeamsUserIdentifier (string userId, bool isAnonymous) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_userId = JNIEnv.NewString (userId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_userId);
				__args [1] = new JniArgumentValue (isAnonymous);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userId);
			}
		}

		public unsafe global::Com.Azure.Android.Communication.Common.CommunicationCloudEnvironment CloudEnvironment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='MicrosoftTeamsUserIdentifier']/method[@name='getCloudEnvironment' and count(parameter)=0]"
			[Register ("getCloudEnvironment", "()Lcom/azure/android/communication/common/CommunicationCloudEnvironment;", "")]
			get {
				const string __id = "getCloudEnvironment.()Lcom/azure/android/communication/common/CommunicationCloudEnvironment;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.Common.CommunicationCloudEnvironment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsAnonymous {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='MicrosoftTeamsUserIdentifier']/method[@name='isAnonymous' and count(parameter)=0]"
			[Register ("isAnonymous", "()Z", "")]
			get {
				const string __id = "isAnonymous.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string RawId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='MicrosoftTeamsUserIdentifier']/method[@name='getRawId' and count(parameter)=0]"
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

		public unsafe string UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='MicrosoftTeamsUserIdentifier']/method[@name='getUserId' and count(parameter)=0]"
			[Register ("getUserId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getUserId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='MicrosoftTeamsUserIdentifier']/method[@name='setCloudEnvironment' and count(parameter)=1 and parameter[1][@type='com.azure.android.communication.common.CommunicationCloudEnvironment']]"
		[Register ("setCloudEnvironment", "(Lcom/azure/android/communication/common/CommunicationCloudEnvironment;)Lcom/azure/android/communication/common/MicrosoftTeamsUserIdentifier;", "")]
		public unsafe global::Com.Azure.Android.Communication.Common.MicrosoftTeamsUserIdentifier SetCloudEnvironment (global::Com.Azure.Android.Communication.Common.CommunicationCloudEnvironment cloudEnvironment)
		{
			const string __id = "setCloudEnvironment.(Lcom/azure/android/communication/common/CommunicationCloudEnvironment;)Lcom/azure/android/communication/common/MicrosoftTeamsUserIdentifier;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cloudEnvironment == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cloudEnvironment).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.Common.MicrosoftTeamsUserIdentifier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cloudEnvironment);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='MicrosoftTeamsUserIdentifier']/method[@name='setRawId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setRawId", "(Ljava/lang/String;)Lcom/azure/android/communication/common/MicrosoftTeamsUserIdentifier;", "")]
		public unsafe global::Com.Azure.Android.Communication.Common.MicrosoftTeamsUserIdentifier SetRawId (string rawId)
		{
			const string __id = "setRawId.(Ljava/lang/String;)Lcom/azure/android/communication/common/MicrosoftTeamsUserIdentifier;";
			IntPtr native_rawId = JNIEnv.NewString (rawId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rawId);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.Common.MicrosoftTeamsUserIdentifier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_rawId);
			}
		}

	}
}
