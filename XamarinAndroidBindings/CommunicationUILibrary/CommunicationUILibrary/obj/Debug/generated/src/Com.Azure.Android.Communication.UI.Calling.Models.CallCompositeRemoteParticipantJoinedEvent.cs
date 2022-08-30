using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.UI.Calling.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeRemoteParticipantJoinedEvent']"
	[global::Android.Runtime.Register ("com/azure/android/communication/ui/calling/models/CallCompositeRemoteParticipantJoinedEvent", DoNotGenerateAcw=true)]
	public sealed partial class CallCompositeRemoteParticipantJoinedEvent : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/ui/calling/models/CallCompositeRemoteParticipantJoinedEvent", typeof (CallCompositeRemoteParticipantJoinedEvent));

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

		internal CallCompositeRemoteParticipantJoinedEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeRemoteParticipantJoinedEvent']/constructor[@name='CallCompositeRemoteParticipantJoinedEvent' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;com.azure.android.communication.common.CommunicationIdentifier&gt;']]"
		[Register (".ctor", "(Ljava/util/Collection;)V", "")]
		public unsafe CallCompositeRemoteParticipantJoinedEvent (global::System.Collections.Generic.ICollection<global::Com.Azure.Android.Communication.Common.CommunicationIdentifier> identifiers) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Collection;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_identifiers = global::Android.Runtime.JavaCollection<global::Com.Azure.Android.Communication.Common.CommunicationIdentifier>.ToLocalJniHandle (identifiers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_identifiers);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_identifiers);
				global::System.GC.KeepAlive (identifiers);
			}
		}

		public unsafe global::System.Collections.Generic.ICollection<global::Com.Azure.Android.Communication.Common.CommunicationIdentifier> Identifiers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeRemoteParticipantJoinedEvent']/method[@name='getIdentifiers' and count(parameter)=0]"
			[Register ("getIdentifiers", "()Ljava/util/Collection;", "")]
			get {
				const string __id = "getIdentifiers.()Ljava/util/Collection;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaCollection<global::Com.Azure.Android.Communication.Common.CommunicationIdentifier>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
