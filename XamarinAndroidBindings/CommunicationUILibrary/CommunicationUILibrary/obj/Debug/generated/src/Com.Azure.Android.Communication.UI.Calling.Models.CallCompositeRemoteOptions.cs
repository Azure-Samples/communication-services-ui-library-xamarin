using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.UI.Calling.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeRemoteOptions']"
	[global::Android.Runtime.Register ("com/azure/android/communication/ui/calling/models/CallCompositeRemoteOptions", DoNotGenerateAcw=true)]
	public sealed partial class CallCompositeRemoteOptions : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/ui/calling/models/CallCompositeRemoteOptions", typeof (CallCompositeRemoteOptions));

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

		internal CallCompositeRemoteOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeRemoteOptions']/constructor[@name='CallCompositeRemoteOptions' and count(parameter)=2 and parameter[1][@type='com.azure.android.communication.ui.calling.models.CallCompositeJoinLocator'] and parameter[2][@type='com.azure.android.communication.common.CommunicationTokenCredential']]"
		[Register (".ctor", "(Lcom/azure/android/communication/ui/calling/models/CallCompositeJoinLocator;Lcom/azure/android/communication/common/CommunicationTokenCredential;)V", "")]
		public unsafe CallCompositeRemoteOptions (global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeJoinLocator locator, global::Com.Azure.Android.Communication.Common.CommunicationTokenCredential credential) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/azure/android/communication/ui/calling/models/CallCompositeJoinLocator;Lcom/azure/android/communication/common/CommunicationTokenCredential;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((locator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locator).Handle);
				__args [1] = new JniArgumentValue ((credential == null) ? IntPtr.Zero : ((global::Java.Lang.Object) credential).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (locator);
				global::System.GC.KeepAlive (credential);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeRemoteOptions']/constructor[@name='CallCompositeRemoteOptions' and count(parameter)=3 and parameter[1][@type='com.azure.android.communication.ui.calling.models.CallCompositeJoinLocator'] and parameter[2][@type='com.azure.android.communication.common.CommunicationTokenCredential'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Lcom/azure/android/communication/ui/calling/models/CallCompositeJoinLocator;Lcom/azure/android/communication/common/CommunicationTokenCredential;Ljava/lang/String;)V", "")]
		public unsafe CallCompositeRemoteOptions (global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeJoinLocator locator, global::Com.Azure.Android.Communication.Common.CommunicationTokenCredential credential, string displayName) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/azure/android/communication/ui/calling/models/CallCompositeJoinLocator;Lcom/azure/android/communication/common/CommunicationTokenCredential;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_displayName = JNIEnv.NewString (displayName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((locator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locator).Handle);
				__args [1] = new JniArgumentValue ((credential == null) ? IntPtr.Zero : ((global::Java.Lang.Object) credential).Handle);
				__args [2] = new JniArgumentValue (native_displayName);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_displayName);
				global::System.GC.KeepAlive (locator);
				global::System.GC.KeepAlive (credential);
			}
		}

		public unsafe global::Com.Azure.Android.Communication.Common.CommunicationTokenCredential Credential {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeRemoteOptions']/method[@name='getCredential' and count(parameter)=0]"
			[Register ("getCredential", "()Lcom/azure/android/communication/common/CommunicationTokenCredential;", "")]
			get {
				const string __id = "getCredential.()Lcom/azure/android/communication/common/CommunicationTokenCredential;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.Common.CommunicationTokenCredential> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeRemoteOptions']/method[@name='getDisplayName' and count(parameter)=0]"
			[Register ("getDisplayName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDisplayName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeJoinLocator Locator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeRemoteOptions']/method[@name='getLocator' and count(parameter)=0]"
			[Register ("getLocator", "()Lcom/azure/android/communication/ui/calling/models/CallCompositeJoinLocator;", "")]
			get {
				const string __id = "getLocator.()Lcom/azure/android/communication/ui/calling/models/CallCompositeJoinLocator;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeJoinLocator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
