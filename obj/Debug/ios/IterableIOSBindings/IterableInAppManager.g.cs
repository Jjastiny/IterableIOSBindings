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
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
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

namespace IterableIOSBindings {
	[Register("IterableInAppManager", true)]
	public unsafe partial class IterableInAppManager : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("IterableInAppManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public IterableInAppManager () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected IterableInAppManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal IterableInAppManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("decodePadding:")]
		[CompilerGenerated]
		public static int DecodePadding (NSObject value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("decodePadding:"), value.Handle);
		}
		
		[Export ("getIntColorFromKey:keyString:")]
		[CompilerGenerated]
		public static int GetIntColorFromKey (NSDictionary payload, string keyString)
		{
			if (payload == null)
				throw new ArgumentNullException ("payload");
			if (keyString == null)
				throw new ArgumentNullException ("keyString");
			var nskeyString = NSString.CreateNative (keyString);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("getIntColorFromKey:keyString:"), payload.Handle, nskeyString);
			NSString.ReleaseNative (nskeyString);
			
			return ret;
		}
		
		[Export ("getNextMessageFromPayload:")]
		[CompilerGenerated]
		public static NSDictionary GetNextMessageFromPayload (NSDictionary payload)
		{
			if (payload == null)
				throw new ArgumentNullException ("payload");
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("getNextMessageFromPayload:"), payload.Handle));
		}
		
		[Export ("getPaddingFromPayload:")]
		[CompilerGenerated]
		public static global::UIKit.UIEdgeInsets GetPaddingFromPayload (NSDictionary payload)
		{
			if (payload == null)
				throw new ArgumentNullException ("payload");
			global::UIKit.UIEdgeInsets ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("getPaddingFromPayload:"), payload.Handle);
				} else {
					global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret_IntPtr (out ret, class_ptr, Selector.GetHandle ("getPaddingFromPayload:"), payload.Handle);
				}
			} else if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret_IntPtr (out ret, class_ptr, Selector.GetHandle ("getPaddingFromPayload:"), payload.Handle);
			} else {
				global::ApiDefinition.Messaging.UIEdgeInsets_objc_msgSend_stret_IntPtr (out ret, class_ptr, Selector.GetHandle ("getPaddingFromPayload:"), payload.Handle);
			}
			return ret;
		}
		
		[Export ("showIterableNotification:trackParams:callbackBlock:")]
		[CompilerGenerated]
		public unsafe static void ShowIterableNotification (NSDictionary dialogOptions, IterableNotificationMetadata trackParams, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDITEActionBlock))]ITEActionBlock callbackBlock)
		{
			if (dialogOptions == null)
				throw new ArgumentNullException ("dialogOptions");
			if (trackParams == null)
				throw new ArgumentNullException ("trackParams");
			if (callbackBlock == null)
				throw new ArgumentNullException ("callbackBlock");
			BlockLiteral *block_ptr_callbackBlock;
			BlockLiteral block_callbackBlock;
			block_callbackBlock = new BlockLiteral ();
			block_ptr_callbackBlock = &block_callbackBlock;
			block_callbackBlock.SetupBlock (Trampolines.SDITEActionBlock.Handler, callbackBlock);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("showIterableNotification:trackParams:callbackBlock:"), dialogOptions.Handle, trackParams.Handle, (IntPtr) block_ptr_callbackBlock);
			block_ptr_callbackBlock->CleanupBlock ();
			
		}
		
		[Export ("showIterableNotificationHTML:trackParams:callbackBlock:backgroundAlpha:padding:")]
		[CompilerGenerated]
		public unsafe static void ShowIterableNotificationHTML (string htmlString, IterableNotificationMetadata trackParams, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDITEActionBlock))]ITEActionBlock callbackBlock, double backgroundAlpha, global::UIKit.UIEdgeInsets padding)
		{
			if (htmlString == null)
				throw new ArgumentNullException ("htmlString");
			if (trackParams == null)
				throw new ArgumentNullException ("trackParams");
			if (callbackBlock == null)
				throw new ArgumentNullException ("callbackBlock");
			var nshtmlString = NSString.CreateNative (htmlString);
			BlockLiteral *block_ptr_callbackBlock;
			BlockLiteral block_callbackBlock;
			block_callbackBlock = new BlockLiteral ();
			block_ptr_callbackBlock = &block_callbackBlock;
			block_callbackBlock.SetupBlock (Trampolines.SDITEActionBlock.Handler, callbackBlock);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_Double_UIEdgeInsets (class_ptr, Selector.GetHandle ("showIterableNotificationHTML:trackParams:callbackBlock:backgroundAlpha:padding:"), nshtmlString, trackParams.Handle, (IntPtr) block_ptr_callbackBlock, backgroundAlpha, padding);
			NSString.ReleaseNative (nshtmlString);
			block_ptr_callbackBlock->CleanupBlock ();
			
		}
		
		[Export ("showIterableNotificationHTML:callbackBlock:")]
		[CompilerGenerated]
		public unsafe static void ShowIterableNotificationHTML (string htmlString, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDITEActionBlock))]ITEActionBlock callbackBlock)
		{
			if (htmlString == null)
				throw new ArgumentNullException ("htmlString");
			if (callbackBlock == null)
				throw new ArgumentNullException ("callbackBlock");
			var nshtmlString = NSString.CreateNative (htmlString);
			BlockLiteral *block_ptr_callbackBlock;
			BlockLiteral block_callbackBlock;
			block_callbackBlock = new BlockLiteral ();
			block_ptr_callbackBlock = &block_callbackBlock;
			block_callbackBlock.SetupBlock (Trampolines.SDITEActionBlock.Handler, callbackBlock);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("showIterableNotificationHTML:callbackBlock:"), nshtmlString, (IntPtr) block_ptr_callbackBlock);
			NSString.ReleaseNative (nshtmlString);
			block_ptr_callbackBlock->CleanupBlock ();
			
		}
		
		[Export ("showSystemNotification:body:buttonLeft:buttonRight:callbackBlock:")]
		[CompilerGenerated]
		public unsafe static void ShowSystemNotification (string title, string body, string buttonLeft, string buttonRight, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDITEActionBlock))]ITEActionBlock callbackBlock)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (body == null)
				throw new ArgumentNullException ("body");
			if (buttonLeft == null)
				throw new ArgumentNullException ("buttonLeft");
			if (buttonRight == null)
				throw new ArgumentNullException ("buttonRight");
			if (callbackBlock == null)
				throw new ArgumentNullException ("callbackBlock");
			var nstitle = NSString.CreateNative (title);
			var nsbody = NSString.CreateNative (body);
			var nsbuttonLeft = NSString.CreateNative (buttonLeft);
			var nsbuttonRight = NSString.CreateNative (buttonRight);
			BlockLiteral *block_ptr_callbackBlock;
			BlockLiteral block_callbackBlock;
			block_callbackBlock = new BlockLiteral ();
			block_ptr_callbackBlock = &block_callbackBlock;
			block_callbackBlock.SetupBlock (Trampolines.SDITEActionBlock.Handler, callbackBlock);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("showSystemNotification:body:buttonLeft:buttonRight:callbackBlock:"), nstitle, nsbody, nsbuttonLeft, nsbuttonRight, (IntPtr) block_ptr_callbackBlock);
			NSString.ReleaseNative (nstitle);
			NSString.ReleaseNative (nsbody);
			NSString.ReleaseNative (nsbuttonLeft);
			NSString.ReleaseNative (nsbuttonRight);
			block_ptr_callbackBlock->CleanupBlock ();
			
		}
		
	} /* class IterableInAppManager */
}
