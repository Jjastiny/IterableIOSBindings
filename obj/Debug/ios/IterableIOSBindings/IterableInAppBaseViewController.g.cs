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
	[Register("IterableInAppBaseViewController", true)]
	public unsafe partial class IterableInAppBaseViewController : global::UIKit.UIViewController {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("IterableInAppBaseViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public IterableInAppBaseViewController () : base (NSObjectFlag.Empty)
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
		public IterableInAppBaseViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected IterableInAppBaseViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal IterableInAppBaseViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("ITEActionButtonClicked:")]
		[CompilerGenerated]
		public virtual void ITEActionButtonClicked (global::UIKit.UIButton sender)
		{
			if (sender == null)
				throw new ArgumentNullException ("sender");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("ITEActionButtonClicked:"), sender.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("ITEActionButtonClicked:"), sender.Handle);
			}
		}
		
		[Export ("ITEAddActionButton:actionString:")]
		[CompilerGenerated]
		public virtual void ITEAddActionButton (nint id, string actionString)
		{
			if (actionString == null)
				throw new ArgumentNullException ("actionString");
			var nsactionString = NSString.CreateNative (actionString);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nint_IntPtr (this.Handle, Selector.GetHandle ("ITEAddActionButton:actionString:"), id, nsactionString);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint_IntPtr (this.SuperHandle, Selector.GetHandle ("ITEAddActionButton:actionString:"), id, nsactionString);
			}
			NSString.ReleaseNative (nsactionString);
			
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
		
		[Export ("ITESetData:")]
		[CompilerGenerated]
		public virtual void ITESetData (NSDictionary jsonPayload)
		{
			if (jsonPayload == null)
				throw new ArgumentNullException ("jsonPayload");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("ITESetData:"), jsonPayload.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("ITESetData:"), jsonPayload.Handle);
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
		
	} /* class IterableInAppBaseViewController */
}
