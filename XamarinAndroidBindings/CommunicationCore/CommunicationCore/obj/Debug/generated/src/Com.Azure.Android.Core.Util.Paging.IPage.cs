using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Core.Util.Paging {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.azure.android.core.util.paging']/interface[@name='Page']"
	[Register ("com/azure/android/core/util/paging/Page", "", "Com.Azure.Android.Core.Util.Paging.IPageInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"C", "T"})]
	public partial interface IPage : IJavaObject, IJavaPeerable {
		global::Java.Lang.Object ContinuationToken {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util.paging']/interface[@name='Page']/method[@name='getContinuationToken' and count(parameter)=0]"
			[Register ("getContinuationToken", "()Ljava/lang/Object;", "GetGetContinuationTokenHandler:Com.Azure.Android.Core.Util.Paging.IPageInvoker, CommunicationCore")]
			get; 
		}

		global::System.Collections.IList Elements {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util.paging']/interface[@name='Page']/method[@name='getElements' and count(parameter)=0]"
			[Register ("getElements", "()Ljava/util/List;", "GetGetElementsHandler:Com.Azure.Android.Core.Util.Paging.IPageInvoker, CommunicationCore")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/azure/android/core/util/paging/Page", DoNotGenerateAcw=true)]
	internal partial class IPageInvoker : global::Java.Lang.Object, IPage {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/core/util/paging/Page", typeof (IPageInvoker));

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

		public static IPage GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPage> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.azure.android.core.util.paging.Page'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPageInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getContinuationToken;
#pragma warning disable 0169
		static Delegate GetGetContinuationTokenHandler ()
		{
			if (cb_getContinuationToken == null)
				cb_getContinuationToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContinuationToken);
			return cb_getContinuationToken;
		}

		static IntPtr n_GetContinuationToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.Paging.IPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContinuationToken);
		}
#pragma warning restore 0169

		IntPtr id_getContinuationToken;
		public unsafe global::Java.Lang.Object ContinuationToken {
			get {
				if (id_getContinuationToken == IntPtr.Zero)
					id_getContinuationToken = JNIEnv.GetMethodID (class_ref, "getContinuationToken", "()Ljava/lang/Object;");
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContinuationToken), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getElements;
#pragma warning disable 0169
		static Delegate GetGetElementsHandler ()
		{
			if (cb_getElements == null)
				cb_getElements = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetElements);
			return cb_getElements;
		}

		static IntPtr n_GetElements (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Core.Util.Paging.IPage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Elements);
		}
#pragma warning restore 0169

		IntPtr id_getElements;
		public unsafe global::System.Collections.IList Elements {
			get {
				if (id_getElements == IntPtr.Zero)
					id_getElements = JNIEnv.GetMethodID (class_ref, "getElements", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getElements), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
