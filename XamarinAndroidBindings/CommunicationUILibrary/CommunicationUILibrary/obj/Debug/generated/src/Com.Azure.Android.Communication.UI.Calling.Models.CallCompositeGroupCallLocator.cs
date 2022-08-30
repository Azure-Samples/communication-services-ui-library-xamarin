using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.UI.Calling.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeGroupCallLocator']"
	[global::Android.Runtime.Register ("com/azure/android/communication/ui/calling/models/CallCompositeGroupCallLocator", DoNotGenerateAcw=true)]
	public sealed partial class CallCompositeGroupCallLocator : global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeJoinLocator {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/ui/calling/models/CallCompositeGroupCallLocator", typeof (CallCompositeGroupCallLocator));

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

		internal CallCompositeGroupCallLocator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeGroupCallLocator']/constructor[@name='CallCompositeGroupCallLocator' and count(parameter)=1 and parameter[1][@type='java.util.UUID']]"
		[Register (".ctor", "(Ljava/util/UUID;)V", "")]
		public unsafe CallCompositeGroupCallLocator (global::Java.Util.UUID groupId) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/UUID;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((groupId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) groupId).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (groupId);
			}
		}

		public unsafe global::Java.Util.UUID GroupId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeGroupCallLocator']/method[@name='getGroupId' and count(parameter)=0]"
			[Register ("getGroupId", "()Ljava/util/UUID;", "")]
			get {
				const string __id = "getGroupId.()Ljava/util/UUID;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.UUID> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
