using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.UI.Calling.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeLocalizationOptions']"
	[global::Android.Runtime.Register ("com/azure/android/communication/ui/calling/models/CallCompositeLocalizationOptions", DoNotGenerateAcw=true)]
	public sealed partial class CallCompositeLocalizationOptions : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/ui/calling/models/CallCompositeLocalizationOptions", typeof (CallCompositeLocalizationOptions));

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

		internal CallCompositeLocalizationOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeLocalizationOptions']/constructor[@name='CallCompositeLocalizationOptions' and count(parameter)=1 and parameter[1][@type='java.util.Locale']]"
		[Register (".ctor", "(Ljava/util/Locale;)V", "")]
		public unsafe CallCompositeLocalizationOptions (global::Java.Util.Locale locale) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Locale;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((locale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locale).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (locale);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeLocalizationOptions']/constructor[@name='CallCompositeLocalizationOptions' and count(parameter)=2 and parameter[1][@type='java.util.Locale'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/util/Locale;I)V", "")]
		public unsafe CallCompositeLocalizationOptions (global::Java.Util.Locale locale, int layoutDirection) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Locale;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((locale == null) ? IntPtr.Zero : ((global::Java.Lang.Object) locale).Handle);
				__args [1] = new JniArgumentValue (layoutDirection);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (locale);
			}
		}

		public unsafe global::Java.Lang.Integer LayoutDirection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeLocalizationOptions']/method[@name='getLayoutDirection' and count(parameter)=0]"
			[Register ("getLayoutDirection", "()Ljava/lang/Integer;", "")]
			get {
				const string __id = "getLayoutDirection.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Util.Locale Locale {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeLocalizationOptions']/method[@name='getLocale' and count(parameter)=0]"
			[Register ("getLocale", "()Ljava/util/Locale;", "")]
			get {
				const string __id = "getLocale.()Ljava/util/Locale;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Locale> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
