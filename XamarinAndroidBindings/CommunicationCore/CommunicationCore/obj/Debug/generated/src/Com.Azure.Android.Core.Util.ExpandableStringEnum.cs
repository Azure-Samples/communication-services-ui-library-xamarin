using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Core.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='ExpandableStringEnum']"
	[global::Android.Runtime.Register ("com/azure/android/core/util/ExpandableStringEnum", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.azure.android.core.util.ExpandableStringEnum<T>"})]
	public abstract partial class ExpandableStringEnum : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/core/util/ExpandableStringEnum", typeof (ExpandableStringEnum));

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

		protected ExpandableStringEnum (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='ExpandableStringEnum']/constructor[@name='ExpandableStringEnum' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExpandableStringEnum () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='ExpandableStringEnum']/method[@name='fromString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("fromString", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/azure/android/core/util/ExpandableStringEnum;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.azure.android.core.util.ExpandableStringEnum<T>"})]
		protected static unsafe global::Java.Lang.Object FromString (string name, global::Java.Lang.Class clazz)
		{
			const string __id = "fromString.(Ljava/lang/String;Ljava/lang/Class;)Lcom/azure/android/core/util/ExpandableStringEnum;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (clazz);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='ExpandableStringEnum']/method[@name='values' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("values", "(Ljava/lang/Class;)Ljava/util/Collection;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.azure.android.core.util.ExpandableStringEnum<T>"})]
		protected static unsafe global::System.Collections.ICollection Values (global::Java.Lang.Class clazz)
		{
			const string __id = "values.(Ljava/lang/Class;)Ljava/util/Collection;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaCollection.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (clazz);
			}
		}

	}

	[global::Android.Runtime.Register ("com/azure/android/core/util/ExpandableStringEnum", DoNotGenerateAcw=true)]
	internal partial class ExpandableStringEnumInvoker : ExpandableStringEnum {
		public ExpandableStringEnumInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/core/util/ExpandableStringEnum", typeof (ExpandableStringEnumInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}
