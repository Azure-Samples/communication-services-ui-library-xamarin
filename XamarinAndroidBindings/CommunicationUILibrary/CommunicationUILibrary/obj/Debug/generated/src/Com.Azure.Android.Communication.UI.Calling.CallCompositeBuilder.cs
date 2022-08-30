using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.UI.Calling {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.ui.calling']/class[@name='CallCompositeBuilder']"
	[global::Android.Runtime.Register ("com/azure/android/communication/ui/calling/CallCompositeBuilder", DoNotGenerateAcw=true)]
	public sealed partial class CallCompositeBuilder : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/ui/calling/CallCompositeBuilder", typeof (CallCompositeBuilder));

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

		internal CallCompositeBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.ui.calling']/class[@name='CallCompositeBuilder']/constructor[@name='CallCompositeBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CallCompositeBuilder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling']/class[@name='CallCompositeBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/azure/android/communication/ui/calling/CallComposite;", "")]
		public unsafe global::Com.Azure.Android.Communication.UI.Calling.CallComposite Build ()
		{
			const string __id = "build.()Lcom/azure/android/communication/ui/calling/CallComposite;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.UI.Calling.CallComposite> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling']/class[@name='CallCompositeBuilder']/method[@name='localization' and count(parameter)=1 and parameter[1][@type='com.azure.android.communication.ui.calling.models.CallCompositeLocalizationOptions']]"
		[Register ("localization", "(Lcom/azure/android/communication/ui/calling/models/CallCompositeLocalizationOptions;)Lcom/azure/android/communication/ui/calling/CallCompositeBuilder;", "")]
		public unsafe global::Com.Azure.Android.Communication.UI.Calling.CallCompositeBuilder Localization (global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeLocalizationOptions localization)
		{
			const string __id = "localization.(Lcom/azure/android/communication/ui/calling/models/CallCompositeLocalizationOptions;)Lcom/azure/android/communication/ui/calling/CallCompositeBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((localization == null) ? IntPtr.Zero : ((global::Java.Lang.Object) localization).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.UI.Calling.CallCompositeBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (localization);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling']/class[@name='CallCompositeBuilder']/method[@name='theme' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("theme", "(I)Lcom/azure/android/communication/ui/calling/CallCompositeBuilder;", "")]
		public unsafe global::Com.Azure.Android.Communication.UI.Calling.CallCompositeBuilder Theme (int themeId)
		{
			const string __id = "theme.(I)Lcom/azure/android/communication/ui/calling/CallCompositeBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (themeId);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.UI.Calling.CallCompositeBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
