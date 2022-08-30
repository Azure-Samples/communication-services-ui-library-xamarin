using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Core.Util {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.azure.android.core.util']/interface[@name='AsyncStream']"
	[Register ("com/azure/android/core/util/AsyncStream", "", "Com.Azure.Android.Core.Util.IAsyncStreamInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IAsyncStream : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/interface[@name='AsyncStream']/method[@name='forEach' and count(parameter)=1 and parameter[1][@type='com.azure.android.core.util.AsyncStreamHandler&lt;T&gt;']]"
		[Register ("forEach", "(Lcom/azure/android/core/util/AsyncStreamHandler;)Lcom/azure/android/core/util/CancellationToken;", "GetForEach_Lcom_azure_android_core_util_AsyncStreamHandler_Handler:Com.Azure.Android.Core.Util.IAsyncStreamInvoker, CommunicationCore")]
		global::Com.Azure.Android.Core.Util.CancellationToken ForEach (global::Com.Azure.Android.Core.Util.IAsyncStreamHandler p0);

	}

	[global::Android.Runtime.Register ("com/azure/android/core/util/AsyncStream", DoNotGenerateAcw=true)]
	internal partial class IAsyncStreamInvoker : global::Java.Lang.Object, IAsyncStream {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/core/util/AsyncStream", typeof (IAsyncStreamInvoker));

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

		public static IAsyncStream GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncStream> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.azure.android.core.util.AsyncStream'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncStreamInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.IAsyncStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
