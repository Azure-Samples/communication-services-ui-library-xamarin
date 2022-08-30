using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.UI.Calling.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeErrorEvent']"
	[global::Android.Runtime.Register ("com/azure/android/communication/ui/calling/models/CallCompositeErrorEvent", DoNotGenerateAcw=true)]
	public sealed partial class CallCompositeErrorEvent : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/ui/calling/models/CallCompositeErrorEvent", typeof (CallCompositeErrorEvent));

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

		internal CallCompositeErrorEvent (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeErrorEvent']/constructor[@name='CallCompositeErrorEvent' and count(parameter)=2 and parameter[1][@type='com.azure.android.communication.ui.calling.models.CallCompositeErrorCode'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Lcom/azure/android/communication/ui/calling/models/CallCompositeErrorCode;Ljava/lang/Throwable;)V", "")]
		public unsafe CallCompositeErrorEvent (global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeErrorCode code, global::Java.Lang.Throwable cause) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/azure/android/communication/ui/calling/models/CallCompositeErrorCode;Ljava/lang/Throwable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((code == null) ? IntPtr.Zero : ((global::Java.Lang.Object) code).Handle);
				__args [1] = new JniArgumentValue ((cause == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) cause).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (code);
				global::System.GC.KeepAlive (cause);
			}
		}

		public unsafe global::Java.Lang.Throwable Cause {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeErrorEvent']/method[@name='getCause' and count(parameter)=0]"
			[Register ("getCause", "()Ljava/lang/Throwable;", "")]
			get {
				const string __id = "getCause.()Ljava/lang/Throwable;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeErrorCode ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeErrorEvent']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()Lcom/azure/android/communication/ui/calling/models/CallCompositeErrorCode;", "")]
			get {
				const string __id = "getErrorCode.()Lcom/azure/android/communication/ui/calling/models/CallCompositeErrorCode;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeErrorCode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
