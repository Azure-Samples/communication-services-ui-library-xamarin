using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationCloudEnvironment']"
	[global::Android.Runtime.Register ("com/azure/android/communication/common/CommunicationCloudEnvironment", DoNotGenerateAcw=true)]
	public sealed partial class CommunicationCloudEnvironment : global::Com.Azure.Android.Core.Util.ExpandableStringEnum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationCloudEnvironment']/field[@name='DOD']"
		[Register ("DOD")]
		public static global::Com.Azure.Android.Communication.Common.CommunicationCloudEnvironment Dod {
			get {
				const string __id = "DOD.Lcom/azure/android/communication/common/CommunicationCloudEnvironment;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.Common.CommunicationCloudEnvironment> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationCloudEnvironment']/field[@name='GCCH']"
		[Register ("GCCH")]
		public static global::Com.Azure.Android.Communication.Common.CommunicationCloudEnvironment Gcch {
			get {
				const string __id = "GCCH.Lcom/azure/android/communication/common/CommunicationCloudEnvironment;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.Common.CommunicationCloudEnvironment> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationCloudEnvironment']/field[@name='PUBLIC']"
		[Register ("PUBLIC")]
		public static global::Com.Azure.Android.Communication.Common.CommunicationCloudEnvironment Public {
			get {
				const string __id = "PUBLIC.Lcom/azure/android/communication/common/CommunicationCloudEnvironment;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.Common.CommunicationCloudEnvironment> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/common/CommunicationCloudEnvironment", typeof (CommunicationCloudEnvironment));

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

		internal CommunicationCloudEnvironment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationCloudEnvironment']/constructor[@name='CommunicationCloudEnvironment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CommunicationCloudEnvironment () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationCloudEnvironment']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromString", "(Ljava/lang/String;)Lcom/azure/android/communication/common/CommunicationCloudEnvironment;", "")]
		public static unsafe global::Com.Azure.Android.Communication.Common.CommunicationCloudEnvironment FromString (string name)
		{
			const string __id = "fromString.(Ljava/lang/String;)Lcom/azure/android/communication/common/CommunicationCloudEnvironment;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.Common.CommunicationCloudEnvironment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

	}
}
