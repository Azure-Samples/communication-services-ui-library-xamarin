using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Communication.UI.Calling {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.communication.ui.calling']/class[@name='CallComposite']"
	[global::Android.Runtime.Register ("com/azure/android/communication/ui/calling/CallComposite", DoNotGenerateAcw=true)]
	public sealed partial class CallComposite : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/communication/ui/calling/CallComposite", typeof (CallComposite));

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

		internal CallComposite (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling']/class[@name='CallComposite']/method[@name='addOnErrorEventHandler' and count(parameter)=1 and parameter[1][@type='com.azure.android.communication.ui.calling.CallCompositeEventHandler&lt;com.azure.android.communication.ui.calling.models.CallCompositeErrorEvent&gt;']]"
		[Register ("addOnErrorEventHandler", "(Lcom/azure/android/communication/ui/calling/CallCompositeEventHandler;)V", "")]
		public unsafe void AddOnErrorEventHandler (global::Com.Azure.Android.Communication.UI.Calling.ICallCompositeEventHandler errorHandler)
		{
			const string __id = "addOnErrorEventHandler.(Lcom/azure/android/communication/ui/calling/CallCompositeEventHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((errorHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorHandler).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (errorHandler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling']/class[@name='CallComposite']/method[@name='addOnRemoteParticipantJoinedEventHandler' and count(parameter)=1 and parameter[1][@type='com.azure.android.communication.ui.calling.CallCompositeEventHandler&lt;com.azure.android.communication.ui.calling.models.CallCompositeRemoteParticipantJoinedEvent&gt;']]"
		[Register ("addOnRemoteParticipantJoinedEventHandler", "(Lcom/azure/android/communication/ui/calling/CallCompositeEventHandler;)V", "")]
		public unsafe void AddOnRemoteParticipantJoinedEventHandler (global::Com.Azure.Android.Communication.UI.Calling.ICallCompositeEventHandler eventHandler)
		{
			const string __id = "addOnRemoteParticipantJoinedEventHandler.(Lcom/azure/android/communication/ui/calling/CallCompositeEventHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (eventHandler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling']/class[@name='CallComposite']/method[@name='launch' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.azure.android.communication.ui.calling.models.CallCompositeRemoteOptions']]"
		[Register ("launch", "(Landroid/content/Context;Lcom/azure/android/communication/ui/calling/models/CallCompositeRemoteOptions;)V", "")]
		public unsafe void Launch (global::Android.Content.Context context, global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeRemoteOptions remoteOptions)
		{
			const string __id = "launch.(Landroid/content/Context;Lcom/azure/android/communication/ui/calling/models/CallCompositeRemoteOptions;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((remoteOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) remoteOptions).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (remoteOptions);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling']/class[@name='CallComposite']/method[@name='launch' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.azure.android.communication.ui.calling.models.CallCompositeRemoteOptions'] and parameter[3][@type='com.azure.android.communication.ui.calling.models.CallCompositeLocalOptions']]"
		[Register ("launch", "(Landroid/content/Context;Lcom/azure/android/communication/ui/calling/models/CallCompositeRemoteOptions;Lcom/azure/android/communication/ui/calling/models/CallCompositeLocalOptions;)V", "")]
		public unsafe void Launch (global::Android.Content.Context context, global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeRemoteOptions remoteOptions, global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeLocalOptions localOptions)
		{
			const string __id = "launch.(Landroid/content/Context;Lcom/azure/android/communication/ui/calling/models/CallCompositeRemoteOptions;Lcom/azure/android/communication/ui/calling/models/CallCompositeLocalOptions;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((remoteOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) remoteOptions).Handle);
				__args [2] = new JniArgumentValue ((localOptions == null) ? IntPtr.Zero : ((global::Java.Lang.Object) localOptions).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (remoteOptions);
				global::System.GC.KeepAlive (localOptions);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling']/class[@name='CallComposite']/method[@name='removeOnErrorEventHandler' and count(parameter)=1 and parameter[1][@type='com.azure.android.communication.ui.calling.CallCompositeEventHandler&lt;com.azure.android.communication.ui.calling.models.CallCompositeErrorEvent&gt;']]"
		[Register ("removeOnErrorEventHandler", "(Lcom/azure/android/communication/ui/calling/CallCompositeEventHandler;)V", "")]
		public unsafe void RemoveOnErrorEventHandler (global::Com.Azure.Android.Communication.UI.Calling.ICallCompositeEventHandler errorHandler)
		{
			const string __id = "removeOnErrorEventHandler.(Lcom/azure/android/communication/ui/calling/CallCompositeEventHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((errorHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorHandler).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (errorHandler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling']/class[@name='CallComposite']/method[@name='removeOnRemoteParticipantJoinedEventHandler' and count(parameter)=1 and parameter[1][@type='com.azure.android.communication.ui.calling.CallCompositeEventHandler&lt;com.azure.android.communication.ui.calling.models.CallCompositeRemoteParticipantJoinedEvent&gt;']]"
		[Register ("removeOnRemoteParticipantJoinedEventHandler", "(Lcom/azure/android/communication/ui/calling/CallCompositeEventHandler;)V", "")]
		public unsafe void RemoveOnRemoteParticipantJoinedEventHandler (global::Com.Azure.Android.Communication.UI.Calling.ICallCompositeEventHandler eventHandler)
		{
			const string __id = "removeOnRemoteParticipantJoinedEventHandler.(Lcom/azure/android/communication/ui/calling/CallCompositeEventHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((eventHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eventHandler).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (eventHandler);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.communication.ui.calling']/class[@name='CallComposite']/method[@name='setRemoteParticipantViewData' and count(parameter)=2 and parameter[1][@type='com.azure.android.communication.common.CommunicationIdentifier'] and parameter[2][@type='com.azure.android.communication.ui.calling.models.CallCompositeParticipantViewData']]"
		[Register ("setRemoteParticipantViewData", "(Lcom/azure/android/communication/common/CommunicationIdentifier;Lcom/azure/android/communication/ui/calling/models/CallCompositeParticipantViewData;)Lcom/azure/android/communication/ui/calling/models/CallCompositeSetParticipantViewDataResult;", "")]
		public unsafe global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeSetParticipantViewDataResult SetRemoteParticipantViewData (global::Com.Azure.Android.Communication.Common.CommunicationIdentifier identifier, global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeParticipantViewData participantViewData)
		{
			const string __id = "setRemoteParticipantViewData.(Lcom/azure/android/communication/common/CommunicationIdentifier;Lcom/azure/android/communication/ui/calling/models/CallCompositeParticipantViewData;)Lcom/azure/android/communication/ui/calling/models/CallCompositeSetParticipantViewDataResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((identifier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) identifier).Handle);
				__args [1] = new JniArgumentValue ((participantViewData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) participantViewData).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Azure.Android.Communication.UI.Calling.Models.CallCompositeSetParticipantViewDataResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (identifier);
				global::System.GC.KeepAlive (participantViewData);
			}
		}

	}
}
