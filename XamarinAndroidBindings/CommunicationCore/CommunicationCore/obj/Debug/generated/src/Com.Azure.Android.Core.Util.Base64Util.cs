using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Azure.Android.Core.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='Base64Util']"
	[global::Android.Runtime.Register ("com/azure/android/core/util/Base64Util", DoNotGenerateAcw=true)]
	public sealed partial class Base64Util : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/azure/android/core/util/Base64Util", typeof (Base64Util));

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

		internal Base64Util (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='Base64Util']/method[@name='decode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decode", "([B)[B", "")]
		public static unsafe byte[] Decode (byte[] encoded)
		{
			const string __id = "decode.([B)[B";
			IntPtr native_encoded = JNIEnv.NewArray (encoded);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_encoded);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (encoded != null) {
					JNIEnv.CopyArray (native_encoded, encoded);
					JNIEnv.DeleteLocalRef (native_encoded);
				}
				global::System.GC.KeepAlive (encoded);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='Base64Util']/method[@name='decodeString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decodeString", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] DecodeString (string encoded)
		{
			const string __id = "decodeString.(Ljava/lang/String;)[B";
			IntPtr native_encoded = JNIEnv.NewString (encoded);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_encoded);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_encoded);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='Base64Util']/method[@name='decodeURL' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("decodeURL", "([B)[B", "")]
		public static unsafe byte[] DecodeURL (byte[] src)
		{
			const string __id = "decodeURL.([B)[B";
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_src);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
				global::System.GC.KeepAlive (src);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='Base64Util']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encode", "([B)[B", "")]
		public static unsafe byte[] Encode (byte[] src)
		{
			const string __id = "encode.([B)[B";
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_src);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
				global::System.GC.KeepAlive (src);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='Base64Util']/method[@name='encodeToString' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeToString", "([B)Ljava/lang/String;", "")]
		public static unsafe string EncodeToString (byte[] src)
		{
			const string __id = "encodeToString.([B)Ljava/lang/String;";
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_src);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
				global::System.GC.KeepAlive (src);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.azure.android.core.util']/class[@name='Base64Util']/method[@name='encodeURLWithoutPadding' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeURLWithoutPadding", "([B)[B", "")]
		public static unsafe byte[] EncodeURLWithoutPadding (byte[] src)
		{
			const string __id = "encodeURLWithoutPadding.([B)[B";
			IntPtr native_src = JNIEnv.NewArray (src);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_src);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (src != null) {
					JNIEnv.CopyArray (native_src, src);
					JNIEnv.DeleteLocalRef (native_src);
				}
				global::System.GC.KeepAlive (src);
			}
		}

	}
}
