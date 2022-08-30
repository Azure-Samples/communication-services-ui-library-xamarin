using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.UI.Calling {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.azure.android.communication.ui.calling']/interface[@name='CallCompositeEventHandler']"
	[Register ("com/azure/android/communication/ui/calling/CallCompositeEventHandler", "", "Com.Azure.Android.Communication.UI.Calling.ICallCompositeEventHandlerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ICallCompositeEventHandler : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling']/interface[@name='CallCompositeEventHandler']/method[@name='handle' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("handle", "(Ljava/lang/Object;)V", "GetHandle_Ljava_lang_Object_Handler:Com.Azure.Android.Communication.UI.Calling.ICallCompositeEventHandlerInvoker, CommunicationUILibrary")]
		void Handle (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/azure/android/communication/ui/calling/CallCompositeEventHandler", DoNotGenerateAcw=true)]
	internal partial class ICallCompositeEventHandlerInvoker : global::Java.Lang.Object, ICallCompositeEventHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/ui/calling/CallCompositeEventHandler", typeof (ICallCompositeEventHandlerInvoker));

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

		public static ICallCompositeEventHandler GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICallCompositeEventHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.azure.android.communication.ui.calling.CallCompositeEventHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICallCompositeEventHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_handle_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetHandle_Ljava_lang_Object_Handler ()
		{
			if (cb_handle_Ljava_lang_Object_ == null)
				cb_handle_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Handle_Ljava_lang_Object_);
			return cb_handle_Ljava_lang_Object_;
		}

		static void n_Handle_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.UI.Calling.ICallCompositeEventHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Handle (p0);
		}
#pragma warning restore 0169

		IntPtr id_handle_Ljava_lang_Object_;
		public unsafe void Handle (global::Java.Lang.Object p0)
		{
			if (id_handle_Ljava_lang_Object_ == IntPtr.Zero)
				id_handle_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "handle", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_handle_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}
}
