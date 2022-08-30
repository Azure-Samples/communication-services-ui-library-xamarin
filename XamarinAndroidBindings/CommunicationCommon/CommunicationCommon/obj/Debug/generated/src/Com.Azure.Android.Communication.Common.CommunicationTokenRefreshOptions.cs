using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationTokenRefreshOptions']"
	[global::Android.Runtime.Register ("com/azure/android/communication/common/CommunicationTokenRefreshOptions", DoNotGenerateAcw=true)]
	public sealed partial class CommunicationTokenRefreshOptions : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/common/CommunicationTokenRefreshOptions", typeof (CommunicationTokenRefreshOptions));

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

		internal CommunicationTokenRefreshOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationTokenRefreshOptions']/constructor[@name='CommunicationTokenRefreshOptions' and count(parameter)=2 and parameter[1][@type='java.util.concurrent.Callable&lt;java.lang.String&gt;'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/util/concurrent/Callable;Z)V", "")]
		public unsafe CommunicationTokenRefreshOptions (global::Java.Util.Concurrent.ICallable tokenRefresher, bool refreshProactively) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/concurrent/Callable;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((tokenRefresher == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenRefresher).Handle);
				__args [1] = new JniArgumentValue (refreshProactively);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (tokenRefresher);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationTokenRefreshOptions']/constructor[@name='CommunicationTokenRefreshOptions' and count(parameter)=3 and parameter[1][@type='java.util.concurrent.Callable&lt;java.lang.String&gt;'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/util/concurrent/Callable;ZLjava/lang/String;)V", "")]
		public unsafe CommunicationTokenRefreshOptions (global::Java.Util.Concurrent.ICallable tokenRefresher, bool refreshProactively, string initialToken) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/concurrent/Callable;ZLjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_initialToken = JNIEnv.NewString (initialToken);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((tokenRefresher == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tokenRefresher).Handle);
				__args [1] = new JniArgumentValue (refreshProactively);
				__args [2] = new JniArgumentValue (native_initialToken);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_initialToken);
				global::System.GC.KeepAlive (tokenRefresher);
			}
		}

		public unsafe string InitialToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationTokenRefreshOptions']/method[@name='getInitialToken' and count(parameter)=0]"
			[Register ("getInitialToken", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getInitialToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsRefreshProactively {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationTokenRefreshOptions']/method[@name='isRefreshProactively' and count(parameter)=0]"
			[Register ("isRefreshProactively", "()Z", "")]
			get {
				const string __id = "isRefreshProactively.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Java.Util.Concurrent.ICallable TokenRefresher {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.common']/class[@name='CommunicationTokenRefreshOptions']/method[@name='getTokenRefresher' and count(parameter)=0]"
			[Register ("getTokenRefresher", "()Ljava/util/concurrent/Callable;", "")]
			get {
				const string __id = "getTokenRefresher.()Ljava/util/concurrent/Callable;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
