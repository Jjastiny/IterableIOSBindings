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
	[Register("IterableDeeplinkManager", true)]
	public unsafe partial class IterableDeeplinkManager : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("IterableDeeplinkManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public IterableDeeplinkManager () : base (NSObjectFlag.Empty)
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
		protected IterableDeeplinkManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal IterableDeeplinkManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("getAndTrackDeeplink:callbackBlock:")]
		[CompilerGenerated]
		public unsafe virtual void GetAndTrackDeeplink (NSUrl webpageURL, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDITEActionBlock))]ITEActionBlock callbackBlock)
		{
			if (webpageURL == null)
				throw new ArgumentNullException ("webpageURL");
			if (callbackBlock == null)
				throw new ArgumentNullException ("callbackBlock");
			BlockLiteral *block_ptr_callbackBlock;
			BlockLiteral block_callbackBlock;
			block_callbackBlock = new BlockLiteral ();
			block_ptr_callbackBlock = &block_callbackBlock;
			block_callbackBlock.SetupBlock (Trampolines.SDITEActionBlock.Handler, callbackBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("getAndTrackDeeplink:callbackBlock:"), webpageURL.Handle, (IntPtr) block_ptr_callbackBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("getAndTrackDeeplink:callbackBlock:"), webpageURL.Handle, (IntPtr) block_ptr_callbackBlock);
			}
			block_ptr_callbackBlock->CleanupBlock ();
			
		}
		
		[Export ("instance")]
		[CompilerGenerated]
		public static IterableDeeplinkManager Instance ()
		{
			return  Runtime.GetNSObject<IterableDeeplinkManager> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("instance")));
		}
		
	} /* class IterableDeeplinkManager */
}
