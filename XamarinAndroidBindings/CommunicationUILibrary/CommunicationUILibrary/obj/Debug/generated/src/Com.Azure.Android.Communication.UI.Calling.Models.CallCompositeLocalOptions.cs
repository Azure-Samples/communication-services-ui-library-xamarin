using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.UI.Calling.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeLocalOptions']"
	[global::Android.Runtime.Register ("com/azure/android/communication/ui/calling/models/CallCompositeLocalOptions", DoNotGenerateAcw=true)]
	public sealed partial class CallCompositeLocalOptions : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/ui/calling/models/CallCompositeLocalOptions", typeof (CallCompositeLocalOptions));

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

		internal CallCompositeLocalOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeLocalOptions']/constructor[@name='CallCompositeLocalOptions' and count(parameter)=1 and parameter[1][@type='com.azure.android.communication.ui.calling.models.CallCompositeParticipantViewData']]"
		[Register (".ctor", "(Lcom/azure/android/communication/ui/calling/models/CallCompositeParticipantViewData;)V", "")]
		public unsafe CallCompositeLocalOptions (global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeParticipantViewData participantViewData) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/azure/android/communication/ui/calling/models/CallCompositeParticipantViewData;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((participantViewData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) participantViewData).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (participantViewData);
			}
		}

		public unsafe global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeParticipantViewData ParticipantViewData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeLocalOptions']/method[@name='getParticipantViewData' and count(parameter)=0]"
			[Register ("getParticipantViewData", "()Lcom/azure/android/communication/ui/calling/models/CallCompositeParticipantViewData;", "")]
			get {
				const string __id = "getParticipantViewData.()Lcom/azure/android/communication/ui/calling/models/CallCompositeParticipantViewData;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeParticipantViewData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
