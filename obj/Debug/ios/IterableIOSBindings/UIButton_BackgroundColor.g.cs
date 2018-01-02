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
	public unsafe static partial class UIButton_BackgroundColor  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("UIButton");
		
		[Export ("ITESetButtonBackgroundColor:forState:")]
		[CompilerGenerated]
		public static void ITESetButtonBackgroundColor (this global::UIKit.UIButton This, global::UIKit.UIColor color, global::UIKit.UIControlState state)
		{
			if (color == null)
				throw new ArgumentNullException ("color");
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt64 (This.Handle, Selector.GetHandle ("ITESetButtonBackgroundColor:forState:"), color.Handle, (UInt64)state);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UInt32 (This.Handle, Selector.GetHandle ("ITESetButtonBackgroundColor:forState:"), color.Handle, (UInt32)state);
			}
		}
		
	} /* class UIButton_BackgroundColor */
}
