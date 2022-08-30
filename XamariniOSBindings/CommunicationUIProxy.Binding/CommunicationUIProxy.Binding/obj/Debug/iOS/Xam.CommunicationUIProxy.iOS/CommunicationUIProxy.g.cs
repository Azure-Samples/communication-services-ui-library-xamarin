//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace Xam.CommunicationUIProxy.iOS {
	[Register("_TtC21CommunicationUI_Proxy20CommunicationUIProxy", true)]
	public unsafe partial class CommunicationUIProxy : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("_TtC21CommunicationUI_Proxy20CommunicationUIProxy");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public CommunicationUIProxy () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected CommunicationUIProxy (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal CommunicationUIProxy (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setRemoteWithParticipantDataOption:rawId:error:onCompletionCallback:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool SetRemoteWithParticipantDataOption (CommunicationPersonaDataProxy participantDataOption, string rawId, out NSError? error, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<bool, NSError>? onCompletionCallback)
		{
			var participantDataOption__handle__ = participantDataOption!.GetNonNullHandle (nameof (participantDataOption));
			if (rawId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (rawId));
			IntPtr errorValue = IntPtr.Zero;
			var nsrawId = CFString.CreateNative (rawId);
			BlockLiteral *block_ptr_onCompletionCallback;
			BlockLiteral block_onCompletionCallback;
			if (onCompletionCallback is null){
				block_ptr_onCompletionCallback = null;
			} else {
				block_onCompletionCallback = new BlockLiteral ();
				block_ptr_onCompletionCallback = &block_onCompletionCallback;
				block_onCompletionCallback.SetupBlockUnsafe (Trampolines.SDActionArity2V0.Handler, onCompletionCallback);
			}
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setRemoteWithParticipantDataOption:rawId:error:onCompletionCallback:"), participantDataOption__handle__, nsrawId, ref errorValue, (IntPtr) block_ptr_onCompletionCallback);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setRemoteWithParticipantDataOption:rawId:error:onCompletionCallback:"), participantDataOption__handle__, nsrawId, ref errorValue, (IntPtr) block_ptr_onCompletionCallback);
			}
			CFString.ReleaseNative (nsrawId);
			if (block_ptr_onCompletionCallback != null)
				block_ptr_onCompletionCallback->CleanupBlock ();
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("startExperienceWithGroupCall:token:localData:theme:localization:errorCallback:onRemoteParticipantJoinedCallback:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StartExperienceWithGroupCall (GroupCallObjectProxy groupCall, string token, CommunicationLocalDataOptionProxy? localData, CommunicationThemeProxy? theme, CommunicationLocalizationProxy? localization, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<CommunicationErrorProxy>? errorCallback, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSArray<NSString>>? onRemoteParticipantJoinedCallback)
		{
			var groupCall__handle__ = groupCall!.GetNonNullHandle (nameof (groupCall));
			if (token is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (token));
			var localData__handle__ = localData.GetHandle ();
			var theme__handle__ = theme.GetHandle ();
			var localization__handle__ = localization.GetHandle ();
			var nstoken = CFString.CreateNative (token);
			BlockLiteral *block_ptr_errorCallback;
			BlockLiteral block_errorCallback;
			if (errorCallback is null){
				block_ptr_errorCallback = null;
			} else {
				block_errorCallback = new BlockLiteral ();
				block_ptr_errorCallback = &block_errorCallback;
				block_errorCallback.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, errorCallback);
			}
			BlockLiteral *block_ptr_onRemoteParticipantJoinedCallback;
			BlockLiteral block_onRemoteParticipantJoinedCallback;
			if (onRemoteParticipantJoinedCallback is null){
				block_ptr_onRemoteParticipantJoinedCallback = null;
			} else {
				block_onRemoteParticipantJoinedCallback = new BlockLiteral ();
				block_ptr_onRemoteParticipantJoinedCallback = &block_onRemoteParticipantJoinedCallback;
				block_onRemoteParticipantJoinedCallback.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, onRemoteParticipantJoinedCallback);
			}
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("startExperienceWithGroupCall:token:localData:theme:localization:errorCallback:onRemoteParticipantJoinedCallback:"), groupCall__handle__, nstoken, localData__handle__, theme__handle__, localization__handle__, (IntPtr) block_ptr_errorCallback, (IntPtr) block_ptr_onRemoteParticipantJoinedCallback);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("startExperienceWithGroupCall:token:localData:theme:localization:errorCallback:onRemoteParticipantJoinedCallback:"), groupCall__handle__, nstoken, localData__handle__, theme__handle__, localization__handle__, (IntPtr) block_ptr_errorCallback, (IntPtr) block_ptr_onRemoteParticipantJoinedCallback);
			}
			CFString.ReleaseNative (nstoken);
			if (block_ptr_errorCallback != null)
				block_ptr_errorCallback->CleanupBlock ();
			if (block_ptr_onRemoteParticipantJoinedCallback != null)
				block_ptr_onRemoteParticipantJoinedCallback->CleanupBlock ();
		}
		[Export ("startExperienceWithTeamsMeeting:token:localData:theme:localization:errorCallback:onRemoteParticipantJoinedCallback:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void StartExperienceWithTeamsMeeting (TeamsMeetingObjectProxy teamsMeeting, string token, CommunicationLocalDataOptionProxy? localData, CommunicationThemeProxy? theme, CommunicationLocalizationProxy? localization, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<CommunicationErrorProxy>? errorCallback, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<NSArray<NSString>>? onRemoteParticipantJoinedCallback)
		{
			var teamsMeeting__handle__ = teamsMeeting!.GetNonNullHandle (nameof (teamsMeeting));
			if (token is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (token));
			var localData__handle__ = localData.GetHandle ();
			var theme__handle__ = theme.GetHandle ();
			var localization__handle__ = localization.GetHandle ();
			var nstoken = CFString.CreateNative (token);
			BlockLiteral *block_ptr_errorCallback;
			BlockLiteral block_errorCallback;
			if (errorCallback is null){
				block_ptr_errorCallback = null;
			} else {
				block_errorCallback = new BlockLiteral ();
				block_ptr_errorCallback = &block_errorCallback;
				block_errorCallback.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, errorCallback);
			}
			BlockLiteral *block_ptr_onRemoteParticipantJoinedCallback;
			BlockLiteral block_onRemoteParticipantJoinedCallback;
			if (onRemoteParticipantJoinedCallback is null){
				block_ptr_onRemoteParticipantJoinedCallback = null;
			} else {
				block_onRemoteParticipantJoinedCallback = new BlockLiteral ();
				block_ptr_onRemoteParticipantJoinedCallback = &block_onRemoteParticipantJoinedCallback;
				block_onRemoteParticipantJoinedCallback.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, onRemoteParticipantJoinedCallback);
			}
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("startExperienceWithTeamsMeeting:token:localData:theme:localization:errorCallback:onRemoteParticipantJoinedCallback:"), teamsMeeting__handle__, nstoken, localData__handle__, theme__handle__, localization__handle__, (IntPtr) block_ptr_errorCallback, (IntPtr) block_ptr_onRemoteParticipantJoinedCallback);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("startExperienceWithTeamsMeeting:token:localData:theme:localization:errorCallback:onRemoteParticipantJoinedCallback:"), teamsMeeting__handle__, nstoken, localData__handle__, theme__handle__, localization__handle__, (IntPtr) block_ptr_errorCallback, (IntPtr) block_ptr_onRemoteParticipantJoinedCallback);
			}
			CFString.ReleaseNative (nstoken);
			if (block_ptr_errorCallback != null)
				block_ptr_errorCallback->CleanupBlock ();
			if (block_ptr_onRemoteParticipantJoinedCallback != null)
				block_ptr_onRemoteParticipantJoinedCallback->CleanupBlock ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] AvailableLanguages {
			[Export ("getAvailableLanguages")]
			get {
				if (IsDirectBinding) {
					return CFArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getAvailableLanguages")))!;
				} else {
					return CFArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAvailableLanguages")))!;
				}
			}
		}
	} /* class CommunicationUIProxy */
}
