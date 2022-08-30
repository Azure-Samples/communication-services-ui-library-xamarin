using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Core.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='DateTimeRfc1123']"
	[global::Android.Runtime.Register ("com/azure/android/core/util/DateTimeRfc1123", DoNotGenerateAcw=true)]
	public sealed partial class DateTimeRfc1123 : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/core/util/DateTimeRfc1123", typeof (DateTimeRfc1123));

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

		internal DateTimeRfc1123 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='DateTimeRfc1123']/constructor[@name='DateTimeRfc1123' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe DateTimeRfc1123 (string formattedString) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_formattedString = JNIEnv.NewString (formattedString);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_formattedString);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_formattedString);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='DateTimeRfc1123']/constructor[@name='DateTimeRfc1123' and count(parameter)=1 and parameter[1][@type='org.threeten.bp.OffsetDateTime']]"
		[Register (".ctor", "(Lorg/threeten/bp/OffsetDateTime;)V", "")]
		public unsafe DateTimeRfc1123 (global::ThreeTen.BP.OffsetDateTime dateTime) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lorg/threeten/bp/OffsetDateTime;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dateTime == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dateTime).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dateTime);
			}
		}

		public unsafe global::ThreeTen.BP.OffsetDateTime DateTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='DateTimeRfc1123']/method[@name='getDateTime' and count(parameter)=0]"
			[Register ("getDateTime", "()Lorg/threeten/bp/OffsetDateTime;", "")]
			get {
				const string __id = "getDateTime.()Lorg/threeten/bp/OffsetDateTime;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::ThreeTen.BP.OffsetDateTime> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
