using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.UI.Calling.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeErrorCode']"
	[global::Android.Runtime.Register ("com/azure/android/communication/ui/calling/models/CallCompositeErrorCode", DoNotGenerateAcw=true)]
	public sealed partial class CallCompositeErrorCode : global::Com.Azure.Android.Core.Util.ExpandableStringEnum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeErrorCode']/field[@name='CALL_END_FAILED']"
		[Register ("CALL_END_FAILED")]
		public static global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeErrorCode CallEndFailed {
			get {
				const string __id = "CALL_END_FAILED.Lcom/azure/android/communication/ui/calling/models/CallCompositeErrorCode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeErrorCode']/field[@name='CALL_JOIN_FAILED']"
		[Register ("CALL_JOIN_FAILED")]
		public static global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeErrorCode CallJoinFailed {
			get {
				const string __id = "CALL_JOIN_FAILED.Lcom/azure/android/communication/ui/calling/models/CallCompositeErrorCode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeErrorCode']/field[@name='TOKEN_EXPIRED']"
		[Register ("TOKEN_EXPIRED")]
		public static global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeErrorCode TokenExpired {
			get {
				const string __id = "TOKEN_EXPIRED.Lcom/azure/android/communication/ui/calling/models/CallCompositeErrorCode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeErrorCode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/ui/calling/models/CallCompositeErrorCode", typeof (CallCompositeErrorCode));

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

		internal CallCompositeErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeErrorCode']/constructor[@name='CallCompositeErrorCode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CallCompositeErrorCode () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeErrorCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()Ljava/util/Collection;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeErrorCode> Values ()
		{
			const string __id = "values.()Ljava/util/Collection;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Android.Runtime.JavaCollection<global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeErrorCode>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
