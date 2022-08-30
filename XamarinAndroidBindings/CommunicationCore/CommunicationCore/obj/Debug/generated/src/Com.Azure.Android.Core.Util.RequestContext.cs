using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Core.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='RequestContext']"
	[global::Android.Runtime.Register ("com/azure/android/core/util/RequestContext", DoNotGenerateAcw=true)]
	public partial class RequestContext : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='RequestContext']/field[@name='NONE']"
		[Register ("NONE")]
		public static global::Com.Azure.Android.Core.Util.RequestContext None {
			get {
				const string __id = "NONE.Lcom/azure/android/core/util/RequestContext;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.RequestContext> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/core/util/RequestContext", typeof (RequestContext));

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

		protected RequestContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='RequestContext']/constructor[@name='RequestContext' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register (".ctor", "(Ljava/lang/Object;Ljava/lang/Object;)V", "")]
		public unsafe RequestContext (global::Java.Lang.Object key, global::Java.Lang.Object value) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/Object;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (key);
				global::System.GC.KeepAlive (value);
			}
		}

		static Delegate cb_addData_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAddData_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_addData_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_addData_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddData_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_addData_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static IntPtr n_AddData_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.RequestContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_key, JniHandleOwnership.DoNotTransfer);
			var value = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddData (key, value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='RequestContext']/method[@name='addData' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("addData", "(Ljava/lang/Object;Ljava/lang/Object;)Lcom/azure/android/core/util/RequestContext;", "GetAddData_Ljava_lang_Object_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Com.Azure.Android.Core.Util.RequestContext AddData (global::Java.Lang.Object key, global::Java.Lang.Object value)
		{
			const string __id = "addData.(Ljava/lang/Object;Ljava/lang/Object;)Lcom/azure/android/core/util/RequestContext;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				__args [1] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.RequestContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (key);
				global::System.GC.KeepAlive (value);
			}
		}

		static Delegate cb_getData_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetData_Ljava_lang_Object_Handler ()
		{
			if (cb_getData_Ljava_lang_Object_ == null)
				cb_getData_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetData_Ljava_lang_Object_);
			return cb_getData_Ljava_lang_Object_;
		}

		static IntPtr n_GetData_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.RequestContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_key, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetData (key));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='RequestContext']/method[@name='getData' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getData", "(Ljava/lang/Object;)Lcom/azure/android/core/util/Option;", "GetGetData_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Com.Azure.Android.Core.Util.Option GetData (global::Java.Lang.Object key)
		{
			const string __id = "getData.(Ljava/lang/Object;)Lcom/azure/android/core/util/Option;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((key == null) ? IntPtr.Zero : ((global::Java.Lang.Object) key).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.Option> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (key);
			}
		}

	}
}
