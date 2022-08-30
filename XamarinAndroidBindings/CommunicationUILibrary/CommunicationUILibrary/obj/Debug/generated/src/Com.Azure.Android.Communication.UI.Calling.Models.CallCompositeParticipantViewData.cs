using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.UI.Calling.Models {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeParticipantViewData']"
	[global::Android.Runtime.Register ("com/azure/android/communication/ui/calling/models/CallCompositeParticipantViewData", DoNotGenerateAcw=true)]
	public sealed partial class CallCompositeParticipantViewData : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/ui/calling/models/CallCompositeParticipantViewData", typeof (CallCompositeParticipantViewData));

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

		internal CallCompositeParticipantViewData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeParticipantViewData']/constructor[@name='CallCompositeParticipantViewData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CallCompositeParticipantViewData () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		public unsafe global::Android.Graphics.Bitmap AvatarBitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeParticipantViewData']/method[@name='getAvatarBitmap' and count(parameter)=0]"
			[Register ("getAvatarBitmap", "()Landroid/graphics/Bitmap;", "")]
			get {
				const string __id = "getAvatarBitmap.()Landroid/graphics/Bitmap;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string DisplayName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeParticipantViewData']/method[@name='getDisplayName' and count(parameter)=0]"
			[Register ("getDisplayName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDisplayName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Android.Widget.ImageView.ScaleType ScaleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeParticipantViewData']/method[@name='getScaleType' and count(parameter)=0]"
			[Register ("getScaleType", "()Landroid/widget/ImageView$ScaleType;", "")]
			get {
				const string __id = "getScaleType.()Landroid/widget/ImageView$ScaleType;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView.ScaleType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeParticipantViewData']/method[@name='setAvatarBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setAvatarBitmap", "(Landroid/graphics/Bitmap;)Lcom/azure/android/communication/ui/calling/models/CallCompositeParticipantViewData;", "")]
		public unsafe global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeParticipantViewData SetAvatarBitmap (global::Android.Graphics.Bitmap avatarBitmap)
		{
			const string __id = "setAvatarBitmap.(Landroid/graphics/Bitmap;)Lcom/azure/android/communication/ui/calling/models/CallCompositeParticipantViewData;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((avatarBitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) avatarBitmap).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeParticipantViewData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (avatarBitmap);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeParticipantViewData']/method[@name='setDisplayName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDisplayName", "(Ljava/lang/String;)Lcom/azure/android/communication/ui/calling/models/CallCompositeParticipantViewData;", "")]
		public unsafe global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeParticipantViewData SetDisplayName (string displayName)
		{
			const string __id = "setDisplayName.(Ljava/lang/String;)Lcom/azure/android/communication/ui/calling/models/CallCompositeParticipantViewData;";
			IntPtr native_displayName = JNIEnv.NewString (displayName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_displayName);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeParticipantViewData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_displayName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling.models']/class[@name='CallCompositeParticipantViewData']/method[@name='setScaleType' and count(parameter)=1 and parameter[1][@type='android.widget.ImageView.ScaleType']]"
		[Register ("setScaleType", "(Landroid/widget/ImageView$ScaleType;)Lcom/azure/android/communication/ui/calling/models/CallCompositeParticipantViewData;", "")]
		public unsafe global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeParticipantViewData SetScaleType (global::Android.Widget.ImageView.ScaleType scaleType)
		{
			const string __id = "setScaleType.(Landroid/widget/ImageView$ScaleType;)Lcom/azure/android/communication/ui/calling/models/CallCompositeParticipantViewData;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((scaleType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scaleType).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeParticipantViewData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (scaleType);
			}
		}

	}
}
