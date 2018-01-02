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
	[Register("IterableAlertViewButton", true)]
	public unsafe partial class IterableAlertViewButton : global::UIKit.UIButton {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("IterableAlertViewButton");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public IterableAlertViewButton () : base (NSObjectFlag.Empty)
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
		public IterableAlertViewButton (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected IterableAlertViewButton (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal IterableAlertViewButton (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual nfloat CornerRadius {
			[Export ("cornerRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("cornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cornerRadius"));
				}
			}
			
			[Export ("setCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual IterableAlertViewButtonType Type {
			[Export ("type", ArgumentSemantic.UnsafeUnretained)]
			get {
				IterableAlertViewButtonType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (IterableAlertViewButtonType) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
					} else {
						ret = (IterableAlertViewButtonType) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (IterableAlertViewButtonType) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type"));
					} else {
						ret = (IterableAlertViewButtonType) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type"));
					}
				}
				return ret;
			}
			
			[Export ("setType:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setType:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setType:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setType:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setType:"), (UInt32)value);
					}
				}
			}
		}
		
		public partial class IterableAlertViewButtonAppearance : global::UIKit.UIButton.UIButtonAppearance {
			protected internal IterableAlertViewButtonAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new IterableAlertViewButtonAppearance Appearance {
			get { return new IterableAlertViewButtonAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new IterableAlertViewButtonAppearance GetAppearance<T> () where T: IterableAlertViewButton {
			return new IterableAlertViewButtonAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new IterableAlertViewButtonAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new IterableAlertViewButtonAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new IterableAlertViewButtonAppearance GetAppearance (UITraitCollection traits) {
			return new IterableAlertViewButtonAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new IterableAlertViewButtonAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new IterableAlertViewButtonAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new IterableAlertViewButtonAppearance GetAppearance<T> (UITraitCollection traits) where T: IterableAlertViewButton {
			return new IterableAlertViewButtonAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new IterableAlertViewButtonAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: IterableAlertViewButton{
			return new IterableAlertViewButtonAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class IterableAlertViewButton */
}
