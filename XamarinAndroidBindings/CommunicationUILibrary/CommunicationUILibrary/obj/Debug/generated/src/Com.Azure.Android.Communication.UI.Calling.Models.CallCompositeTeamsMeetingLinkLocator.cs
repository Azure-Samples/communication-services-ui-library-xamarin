using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.UI.Calling.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeTeamsMeetingLinkLocator']"
	[global::Android.Runtime.Register ("com/azure/android/communication/ui/calling/models/CallCompositeTeamsMeetingLinkLocator", DoNotGenerateAcw=true)]
	public sealed partial class CallCompositeTeamsMeetingLinkLocator : global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeJoinLocator {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/ui/calling/models/CallCompositeTeamsMeetingLinkLocator", typeof (CallCompositeTeamsMeetingLinkLocator));

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

		internal CallCompositeTeamsMeetingLinkLocator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeTeamsMeetingLinkLocator']/constructor[@name='CallCompositeTeamsMeetingLinkLocator' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe CallCompositeTeamsMeetingLinkLocator (string meetingLink) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_meetingLink = JNIEnv.NewString (meetingLink);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_meetingLink);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_meetingLink);
			}
		}

		public unsafe string MeetingLink {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeTeamsMeetingLinkLocator']/method[@name='getMeetingLink' and count(parameter)=0]"
			[Register ("getMeetingLink", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getMeetingLink.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
