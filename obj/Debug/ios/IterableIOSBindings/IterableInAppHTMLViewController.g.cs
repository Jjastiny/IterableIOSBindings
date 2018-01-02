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
	[Register("IterableInAppHTMLViewController", true)]
	public unsafe partial class IterableInAppHTMLViewController : global::UIKit.UIViewController {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("IterableInAppHTMLViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public IterableInAppHTMLViewController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public IterableInAppHTMLViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected IterableInAppHTMLViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal IterableInAppHTMLViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithData:")]
		[CompilerGenerated]
		public IterableInAppHTMLViewController (NSObject htmlString)
			: base (NSObjectFlag.Empty)
		{
			if (htmlString == null)
				throw new ArgumentNullException ("htmlString");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithData:"), htmlString.Handle), "initWithData:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithData:"), htmlString.Handle), "initWithData:");
			}
		}
		
		[Export ("ITESetCallback:")]
		[CompilerGenerated]
		public unsafe virtual void ITESetCallback ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDITEActionBlock))]ITEActionBlock callbackBlock)
		{
			if (callbackBlock == null)
				throw new ArgumentNullException ("callbackBlock");
			BlockLiteral *block_ptr_callbackBlock;
			BlockLiteral block_callbackBlock;
			block_callbackBlock = new BlockLiteral ();
			block_ptr_callbackBlock = &block_callbackBlock;
			block_callbackBlock.SetupBlock (Trampolines.SDITEActionBlock.Handler, callbackBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("ITESetCallback:"), (IntPtr) block_ptr_callbackBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("ITESetCallback:"), (IntPtr) block_ptr_callbackBlock);
			}
			block_ptr_callbackBlock->CleanupBlock ();
			
		}
		
		[Export ("ITESetPadding:")]
		[CompilerGenerated]
		public virtual void ITESetPadding (global::UIKit.UIEdgeInsets insetPadding)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UIEdgeInsets (this.Handle, Selector.GetHandle ("ITESetPadding:"), insetPadding);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UIEdgeInsets (this.SuperHandle, Selector.GetHandle ("ITESetPadding:"), insetPadding);
			}
		}
		
		[Export ("ITESetTrackParams:")]
		[CompilerGenerated]
		public virtual void ITESetTrackParams (IterableNotificationMetadata trackParams)
		{
			if (trackParams == null)
				throw new ArgumentNullException ("trackParams");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("ITESetTrackParams:"), trackParams.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("ITESetTrackParams:"), trackParams.Handle);
			}
		}
		
		[Export ("setLocation:")]
		[CompilerGenerated]
		public static InappNotificationType SetLocation (global::UIKit.UIEdgeInsets insetPadding)
		{
			return (InappNotificationType) global::ApiDefinition.Messaging.UInt64_objc_msgSend_UIEdgeInsets (class_ptr, Selector.GetHandle ("setLocation:"), insetPadding);
		}
		
		[CompilerGenerated]
		public virtual string Html {
			[Export ("getHtml")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getHtml")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getHtml")));
				}
			}
			
		}
		
	} /* class IterableInAppHTMLViewController */
}
