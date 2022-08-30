using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Core.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='CancellationToken']"
	[global::Android.Runtime.Register ("com/azure/android/core/util/CancellationToken", DoNotGenerateAcw=true)]
	public sealed partial class CancellationToken : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='CancellationToken']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.Azure.Android.Core.Util.CancellationToken None {
			get {
				const string __id = "NONE.Lcom/azure/android/core/util/CancellationToken;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.CancellationToken> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/core/util/CancellationToken", typeof (CancellationToken));

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

		internal CancellationToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='CancellationToken']/constructor[@name='CancellationToken' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CancellationToken () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe bool IsCancellationRequested {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='CancellationToken']/method[@name='isCancellationRequested' and count(parameter)=0]"
			[Register ("isCancellationRequested", "()Z", "")]
			get {
				const string __id = "isCancellationRequested.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='CancellationToken']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "")]
		public unsafe void Cancel ()
		{
			const string __id = "cancel.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='CancellationToken']/method[@name='registerOnCancel' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("registerOnCancel", "(Ljava/lang/Runnable;)V", "")]
		public unsafe void RegisterOnCancel (global::Java.Lang.IRunnable onCancel)
		{
			const string __id = "registerOnCancel.(Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onCancel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onCancel).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (onCancel);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='CancellationToken']/method[@name='registerOnCancel' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("registerOnCancel", "(Ljava/lang/String;Ljava/lang/Runnable;)V", "")]
		public unsafe void RegisterOnCancel (string id, global::Java.Lang.IRunnable onCancel)
		{
			const string __id = "registerOnCancel.(Ljava/lang/String;Ljava/lang/Runnable;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_id);
				__args [1] = new JniArgumentValue ((onCancel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onCancel).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
				global::System.GC.KeepAlive (onCancel);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='CancellationToken']/method[@name='unregisterOnCancel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unregisterOnCancel", "(Ljava/lang/String;)V", "")]
		public unsafe void UnregisterOnCancel (string id)
		{
			const string __id = "unregisterOnCancel.(Ljava/lang/String;)V";
			IntPtr native_id = JNIEnv.NewString (id);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_id);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_id);
			}
		}

	}
}
