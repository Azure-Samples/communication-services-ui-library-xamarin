using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Core.Util.Paging {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.azure.android.core.util.paging']/interface[@name='PagedAsyncStreamCore']"
	[Register ("com/azure/android/core/util/paging/PagedAsyncStreamCore", "", "Com.Azure.Android.Core.Util.Paging.IPagedAsyncStreamCoreInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"C", "T", "P extends com.azure.android.core.util.paging.Page<C, T>"})]
	public partial interface IPagedAsyncStreamCore : global::Com.Azure.Android.Core.Util.IAsyncStream {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util.paging']/interface[@name='PagedAsyncStreamCore']/method[@name='byPage' and count(parameter)=0]"
		[Register ("byPage", "()Lcom/azure/android/core/util/AsyncStream;", "GetByPageHandler:Com.Azure.Android.Core.Util.Paging.IPagedAsyncStreamCoreInvoker, CommunicationCore")]
		global::Com.Azure.Android.Core.Util.IAsyncStream ByPage ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util.paging']/interface[@name='PagedAsyncStreamCore']/method[@name='byPage' and count(parameter)=1 and parameter[1][@type='C']]"
		[Register ("byPage", "(Ljava/lang/Object;)Lcom/azure/android/core/util/AsyncStream;", "GetByPage_Ljava_lang_Object_Handler:Com.Azure.Android.Core.Util.Paging.IPagedAsyncStreamCoreInvoker, CommunicationCore")]
		global::Com.Azure.Android.Core.Util.IAsyncStream ByPage (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util.paging']/interface[@name='PagedAsyncStreamCore']/method[@name='from' and count(parameter)=1 and parameter[1][@type='C']]"
		[Register ("from", "(Ljava/lang/Object;)Lcom/azure/android/core/util/AsyncStream;", "GetFrom_Ljava_lang_Object_Handler:Com.Azure.Android.Core.Util.Paging.IPagedAsyncStreamCoreInvoker, CommunicationCore")]
		global::Com.Azure.Android.Core.Util.IAsyncStream From (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util.paging']/interface[@name='PagedAsyncStreamCore']/method[@name='getPage' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.azure.android.core.util.BiConsumer&lt;P, java.lang.Throwable&gt;']]"
		[Register ("getPage", "(Ljava/lang/String;Lcom/azure/android/core/util/BiConsumer;)V", "GetGetPage_Ljava_lang_String_Lcom_azure_android_core_util_BiConsumer_Handler:Com.Azure.Android.Core.Util.Paging.IPagedAsyncStreamCoreInvoker, CommunicationCore")]
		void GetPage (string p0, global::Com.Azure.Android.Core.Util.IBiConsumer p1);

	}

	[global::Android.Runtime.Register ("com/azure/android/core/util/paging/PagedAsyncStreamCore", DoNotGenerateAcw=true)]
	internal partial class IPagedAsyncStreamCoreInvoker : global::Java.Lang.Object, IPagedAsyncStreamCore {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/core/util/paging/PagedAsyncStreamCore", typeof (IPagedAsyncStreamCoreInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IPagedAsyncStreamCore GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPagedAsyncStreamCore> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.azure.android.core.util.paging.PagedAsyncStreamCore'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPagedAsyncStreamCoreInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_byPage;
#pragma warning disable 0169
		static Delegate GetByPageHandler ()
		{
			if (cb_byPage == null)
				cb_byPage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ByPage);
			return cb_byPage;
		}

		static IntPtr n_ByPage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.Paging.IPagedAsyncStreamCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ByPage ());
		}
#pragma warning restore 0169

		IntPtr id_byPage;
		public unsafe global::Com.Azure.Android.Core.Util.IAsyncStream ByPage ()
		{
			if (id_byPage == IntPtr.Zero)
				id_byPage = JNIEnv.GetMethodID (class_ref, "byPage", "()Lcom/azure/android/core/util/AsyncStream;");
			return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.IAsyncStream> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_byPage), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_byPage_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetByPage_Ljava_lang_Object_Handler ()
		{
			if (cb_byPage_Ljava_lang_Object_ == null)
				cb_byPage_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ByPage_Ljava_lang_Object_);
			return cb_byPage_Ljava_lang_Object_;
		}

		static IntPtr n_ByPage_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.Paging.IPagedAsyncStreamCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ByPage (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_byPage_Ljava_lang_Object_;
		public unsafe global::Com.Azure.Android.Core.Util.IAsyncStream ByPage (global::Java.Lang.Object p0)
		{
			if (id_byPage_Ljava_lang_Object_ == IntPtr.Zero)
				id_byPage_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "byPage", "(Ljava/lang/Object;)Lcom/azure/android/core/util/AsyncStream;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.IAsyncStream> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_byPage_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_from_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFrom_Ljava_lang_Object_Handler ()
		{
			if (cb_from_Ljava_lang_Object_ == null)
				cb_from_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_From_Ljava_lang_Object_);
			return cb_from_Ljava_lang_Object_;
		}

		static IntPtr n_From_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.Paging.IPagedAsyncStreamCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.From (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_from_Ljava_lang_Object_;
		public unsafe global::Com.Azure.Android.Core.Util.IAsyncStream From (global::Java.Lang.Object p0)
		{
			if (id_from_Ljava_lang_Object_ == IntPtr.Zero)
				id_from_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "from", "(Ljava/lang/Object;)Lcom/azure/android/core/util/AsyncStream;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.IAsyncStream> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_from_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getPage_Ljava_lang_String_Lcom_azure_android_core_util_BiConsumer_;
#pragma warning disable 0169
		static Delegate GetGetPage_Ljava_lang_String_Lcom_azure_android_core_util_BiConsumer_Handler ()
		{
			if (cb_getPage_Ljava_lang_String_Lcom_azure_android_core_util_BiConsumer_ == null)
				cb_getPage_Ljava_lang_String_Lcom_azure_android_core_util_BiConsumer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_GetPage_Ljava_lang_String_Lcom_azure_android_core_util_BiConsumer_);
			return cb_getPage_Ljava_lang_String_Lcom_azure_android_core_util_BiConsumer_;
		}

		static void n_GetPage_Ljava_lang_String_Lcom_azure_android_core_util_BiConsumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.Paging.IPagedAsyncStreamCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Com.Azure.Android.Core.Util.IBiConsumer)global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.IBiConsumer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetPage (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_getPage_Ljava_lang_String_Lcom_azure_android_core_util_BiConsumer_;
		public unsafe void GetPage (string p0, global::Com.Azure.Android.Core.Util.IBiConsumer p1)
		{
			if (id_getPage_Ljava_lang_String_Lcom_azure_android_core_util_BiConsumer_ == IntPtr.Zero)
				id_getPage_Ljava_lang_String_Lcom_azure_android_core_util_BiConsumer_ = JNIEnv.GetMethodID (class_ref, "getPage", "(Ljava/lang/String;Lcom/azure/android/core/util/BiConsumer;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getPage_Ljava_lang_String_Lcom_azure_android_core_util_BiConsumer_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_forEach_Lcom_azure_android_core_util_AsyncStreamHandler_;
#pragma warning disable 0169
		static Delegate GetForEach_Lcom_azure_android_core_util_AsyncStreamHandler_Handler ()
		{
			if (cb_forEach_Lcom_azure_android_core_util_AsyncStreamHandler_ == null)
				cb_forEach_Lcom_azure_android_core_util_AsyncStreamHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ForEach_Lcom_azure_android_core_util_AsyncStreamHandler_);
			return cb_forEach_Lcom_azure_android_core_util_AsyncStreamHandler_;
		}

		static IntPtr n_ForEach_Lcom_azure_android_core_util_AsyncStreamHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.Paging.IPagedAsyncStreamCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Com.Azure.Android.Core.Util.IAsyncStreamHandler)global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.IAsyncStreamHandler> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ForEach (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_forEach_Lcom_azure_android_core_util_AsyncStreamHandler_;
		public unsafe global::Com.Azure.Android.Core.Util.CancellationToken ForEach (global::Com.Azure.Android.Core.Util.IAsyncStreamHandler p0)
		{
			if (id_forEach_Lcom_azure_android_core_util_AsyncStreamHandler_ == IntPtr.Zero)
				id_forEach_Lcom_azure_android_core_util_AsyncStreamHandler_ = JNIEnv.GetMethodID (class_ref, "forEach", "(Lcom/azure/android/core/util/AsyncStreamHandler;)Lcom/azure/android/core/util/CancellationToken;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.CancellationToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_forEach_Lcom_azure_android_core_util_AsyncStreamHandler_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
