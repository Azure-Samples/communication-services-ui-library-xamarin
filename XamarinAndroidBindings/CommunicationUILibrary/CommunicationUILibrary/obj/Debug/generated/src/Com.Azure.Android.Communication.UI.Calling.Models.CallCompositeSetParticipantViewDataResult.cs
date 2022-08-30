using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.UI.Calling.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeSetParticipantViewDataResult']"
	[global::Android.Runtime.Register ("com/azure/android/communication/ui/calling/models/CallCompositeSetParticipantViewDataResult", DoNotGenerateAcw=true)]
	public sealed partial class CallCompositeSetParticipantViewDataResult : global::Com.Azure.Android.Core.Util.ExpandableStringEnum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeSetParticipantViewDataResult']/field[@name='PARTICIPANT_NOT_IN_CALL']"
		[Register ("PARTICIPANT_NOT_IN_CALL")]
		public static global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeSetParticipantViewDataResult ParticipantNotInCall {
			get {
				const string __id = "PARTICIPANT_NOT_IN_CALL.Lcom/azure/android/communication/ui/calling/models/CallCompositeSetParticipantViewDataResult;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeSetParticipantViewDataResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeSetParticipantViewDataResult']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public static global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeSetParticipantViewDataResult Success {
			get {
				const string __id = "SUCCESS.Lcom/azure/android/communication/ui/calling/models/CallCompositeSetParticipantViewDataResult;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeSetParticipantViewDataResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/ui/calling/models/CallCompositeSetParticipantViewDataResult", typeof (CallCompositeSetParticipantViewDataResult));

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

		internal CallCompositeSetParticipantViewDataResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeSetParticipantViewDataResult']/constructor[@name='CallCompositeSetParticipantViewDataResult' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CallCompositeSetParticipantViewDataResult () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeSetParticipantViewDataResult']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()Ljava/util/Collection;", "")]
		public static unsafe global::System.Collections.Generic.ICollection<global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeSetParticipantViewDataResult> Values ()
		{
			const string __id = "values.()Ljava/util/Collection;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Android.Runtime.JavaCollection<global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeSetParticipantViewDataResult>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
