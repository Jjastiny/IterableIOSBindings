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
	[Register("IterableAlertViewController", true)]
	public unsafe partial class IterableAlertViewController : IterableInAppBaseViewController {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("IterableAlertViewController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public IterableAlertViewController () : base (NSObjectFlag.Empty)
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
		public IterableAlertViewController (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected IterableAlertViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal IterableAlertViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addAction:")]
		[CompilerGenerated]
		public virtual void AddAction (IterableAlertAction action)
		{
			if (action == null)
				throw new ArgumentNullException ("action");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addAction:"), action.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addAction:"), action.Handle);
			}
		}
		
		[Export ("addTextFieldWithConfigurationHandler:")]
		[CompilerGenerated]
		public unsafe virtual void AddTextFieldWithConfigurationHandler ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<global::UIKit.UITextField> configurationHandler)
		{
			if (configurationHandler == null)
				throw new ArgumentNullException ("configurationHandler");
			BlockLiteral *block_ptr_configurationHandler;
			BlockLiteral block_configurationHandler;
			block_configurationHandler = new BlockLiteral ();
			block_ptr_configurationHandler = &block_configurationHandler;
			block_configurationHandler.SetupBlock (Trampolines.SDActionArity1V0.Handler, configurationHandler);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addTextFieldWithConfigurationHandler:"), (IntPtr) block_ptr_configurationHandler);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addTextFieldWithConfigurationHandler:"), (IntPtr) block_ptr_configurationHandler);
			}
			block_ptr_configurationHandler->CleanupBlock ();
			
		}
		
		[Export ("alertControllerWithTitle:message:")]
		[CompilerGenerated]
		public static IterableAlertViewController AlertControllerWithTitle (string title, string message)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (message == null)
				throw new ArgumentNullException ("message");
			var nstitle = NSString.CreateNative (title);
			var nsmessage = NSString.CreateNative (message);
			
			IterableAlertViewController ret;
			ret =  Runtime.GetNSObject<IterableAlertViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("alertControllerWithTitle:message:"), nstitle, nsmessage));
			NSString.ReleaseNative (nstitle);
			NSString.ReleaseNative (nsmessage);
			
			return ret;
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
		
		[CompilerGenerated]
		public virtual IterableAlertAction[] Actions {
			[Export ("actions")]
			get {
				IterableAlertAction[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<IterableAlertAction>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("actions")));
				} else {
					ret = NSArray.ArrayFromHandle<IterableAlertAction>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("actions")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_AlertViewBackgroundColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor AlertViewBackgroundColor {
			[Export ("alertViewBackgroundColor", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("alertViewBackgroundColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alertViewBackgroundColor")));
				}
				MarkDirty ();
				__mt_AlertViewBackgroundColor_var = ret;
				return ret;
			}
			
			[Export ("setAlertViewBackgroundColor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAlertViewBackgroundColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAlertViewBackgroundColor:"), value.Handle);
				}
				MarkDirty ();
				__mt_AlertViewBackgroundColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_AlertViewContentView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView AlertViewContentView {
			[Export ("alertViewContentView", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("alertViewContentView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alertViewContentView")));
				}
				MarkDirty ();
				__mt_AlertViewContentView_var = ret;
				return ret;
			}
			
			[Export ("setAlertViewContentView:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAlertViewContentView:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAlertViewContentView:"), value.Handle);
				}
				MarkDirty ();
				__mt_AlertViewContentView_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual nfloat AlertViewCornerRadius {
			[Export ("alertViewCornerRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("alertViewCornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alertViewCornerRadius"));
				}
			}
			
			[Export ("setAlertViewCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setAlertViewCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setAlertViewCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool BackgroundTapDismissalGestureEnabled {
			[Export ("backgroundTapDismissalGestureEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundTapDismissalGestureEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundTapDismissalGestureEnabled"));
				}
			}
			
			[Export ("setBackgroundTapDismissalGestureEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setBackgroundTapDismissalGestureEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setBackgroundTapDismissalGestureEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ButtonColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ButtonColor {
			[Export ("buttonColor", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("buttonColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("buttonColor")));
				}
				MarkDirty ();
				__mt_ButtonColor_var = ret;
				return ret;
			}
			
			[Export ("setButtonColor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setButtonColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setButtonColor:"), value.Handle);
				}
				MarkDirty ();
				__mt_ButtonColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual nfloat ButtonCornerRadius {
			[Export ("buttonCornerRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("buttonCornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("buttonCornerRadius"));
				}
			}
			
			[Export ("setButtonCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setButtonCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setButtonCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ButtonTitleColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor ButtonTitleColor {
			[Export ("buttonTitleColor", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("buttonTitleColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("buttonTitleColor")));
				}
				MarkDirty ();
				__mt_ButtonTitleColor_var = ret;
				return ret;
			}
			
			[Export ("setButtonTitleColor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setButtonTitleColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setButtonTitleColor:"), value.Handle);
				}
				MarkDirty ();
				__mt_ButtonTitleColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_ButtonTitleFont_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIFont ButtonTitleFont {
			[Export ("buttonTitleFont", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("buttonTitleFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("buttonTitleFont")));
				}
				MarkDirty ();
				__mt_ButtonTitleFont_var = ret;
				return ret;
			}
			
			[Export ("setButtonTitleFont:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setButtonTitleFont:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setButtonTitleFont:"), value.Handle);
				}
				MarkDirty ();
				__mt_ButtonTitleFont_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_CancelButtonColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor CancelButtonColor {
			[Export ("cancelButtonColor", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cancelButtonColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelButtonColor")));
				}
				MarkDirty ();
				__mt_CancelButtonColor_var = ret;
				return ret;
			}
			
			[Export ("setCancelButtonColor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCancelButtonColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCancelButtonColor:"), value.Handle);
				}
				MarkDirty ();
				__mt_CancelButtonColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_CancelButtonTitleColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor CancelButtonTitleColor {
			[Export ("cancelButtonTitleColor", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cancelButtonTitleColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelButtonTitleColor")));
				}
				MarkDirty ();
				__mt_CancelButtonTitleColor_var = ret;
				return ret;
			}
			
			[Export ("setCancelButtonTitleColor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCancelButtonTitleColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCancelButtonTitleColor:"), value.Handle);
				}
				MarkDirty ();
				__mt_CancelButtonTitleColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_CancelButtonTitleFont_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIFont CancelButtonTitleFont {
			[Export ("cancelButtonTitleFont", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cancelButtonTitleFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelButtonTitleFont")));
				}
				MarkDirty ();
				__mt_CancelButtonTitleFont_var = ret;
				return ret;
			}
			
			[Export ("setCancelButtonTitleFont:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCancelButtonTitleFont:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCancelButtonTitleFont:"), value.Handle);
				}
				MarkDirty ();
				__mt_CancelButtonTitleFont_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual nfloat ContentImageHeight {
			[Export ("contentImageHeight")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("contentImageHeight"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentImageHeight"));
				}
			}
			
			[Export ("setContentImageHeight:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setContentImageHeight:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setContentImageHeight:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual nfloat ContentImageWidth {
			[Export ("contentImageWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("contentImageWidth"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentImageWidth"));
				}
			}
			
			[Export ("setContentImageWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setContentImageWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setContentImageWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_DestructiveButtonColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor DestructiveButtonColor {
			[Export ("destructiveButtonColor", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("destructiveButtonColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("destructiveButtonColor")));
				}
				MarkDirty ();
				__mt_DestructiveButtonColor_var = ret;
				return ret;
			}
			
			[Export ("setDestructiveButtonColor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDestructiveButtonColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDestructiveButtonColor:"), value.Handle);
				}
				MarkDirty ();
				__mt_DestructiveButtonColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DestructiveButtonTitleColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor DestructiveButtonTitleColor {
			[Export ("destructiveButtonTitleColor", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("destructiveButtonTitleColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("destructiveButtonTitleColor")));
				}
				MarkDirty ();
				__mt_DestructiveButtonTitleColor_var = ret;
				return ret;
			}
			
			[Export ("setDestructiveButtonTitleColor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDestructiveButtonTitleColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDestructiveButtonTitleColor:"), value.Handle);
				}
				MarkDirty ();
				__mt_DestructiveButtonTitleColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DestructiveButtonTitleFont_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIFont DestructiveButtonTitleFont {
			[Export ("destructiveButtonTitleFont", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("destructiveButtonTitleFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("destructiveButtonTitleFont")));
				}
				MarkDirty ();
				__mt_DestructiveButtonTitleFont_var = ret;
				return ret;
			}
			
			[Export ("setDestructiveButtonTitleFont:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDestructiveButtonTitleFont:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDestructiveButtonTitleFont:"), value.Handle);
				}
				MarkDirty ();
				__mt_DestructiveButtonTitleFont_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DisabledButtonColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor DisabledButtonColor {
			[Export ("disabledButtonColor", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("disabledButtonColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disabledButtonColor")));
				}
				MarkDirty ();
				__mt_DisabledButtonColor_var = ret;
				return ret;
			}
			
			[Export ("setDisabledButtonColor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDisabledButtonColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDisabledButtonColor:"), value.Handle);
				}
				MarkDirty ();
				__mt_DisabledButtonColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_DisabledButtonTitleColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor DisabledButtonTitleColor {
			[Export ("disabledButtonTitleColor", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("disabledButtonTitleColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disabledButtonTitleColor")));
				}
				MarkDirty ();
				__mt_DisabledButtonTitleColor_var = ret;
				return ret;
			}
			
			[Export ("setDisabledButtonTitleColor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDisabledButtonTitleColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDisabledButtonTitleColor:"), value.Handle);
				}
				MarkDirty ();
				__mt_DisabledButtonTitleColor_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual nfloat MaximumWidth {
			[Export ("maximumWidth")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("maximumWidth"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maximumWidth"));
				}
			}
			
			[Export ("setMaximumWidth:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setMaximumWidth:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setMaximumWidth:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Message {
			[Export ("message")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("message")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("message")));
				}
			}
			
			[Export ("setMessage:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMessage:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMessage:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_MessageColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor MessageColor {
			[Export ("messageColor", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("messageColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("messageColor")));
				}
				MarkDirty ();
				__mt_MessageColor_var = ret;
				return ret;
			}
			
			[Export ("setMessageColor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMessageColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMessageColor:"), value.Handle);
				}
				MarkDirty ();
				__mt_MessageColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_MessageFont_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIFont MessageFont {
			[Export ("messageFont", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("messageFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("messageFont")));
				}
				MarkDirty ();
				__mt_MessageFont_var = ret;
				return ret;
			}
			
			[Export ("setMessageFont:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMessageFont:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMessageFont:"), value.Handle);
				}
				MarkDirty ();
				__mt_MessageFont_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShowsStatusBar {
			[Export ("showsStatusBar")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showsStatusBar"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showsStatusBar"));
				}
			}
			
			[Export ("setShowsStatusBar:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShowsStatusBar:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShowsStatusBar:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual nfloat StartingDimmingBackgroundAlpha {
			[Export ("startingDimmingBackgroundAlpha")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("startingDimmingBackgroundAlpha"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startingDimmingBackgroundAlpha"));
				}
			}
			
			[Export ("setStartingDimmingBackgroundAlpha:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setStartingDimmingBackgroundAlpha:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setStartingDimmingBackgroundAlpha:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool SwipeDismissalGestureEnabled {
			[Export ("swipeDismissalGestureEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("swipeDismissalGestureEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("swipeDismissalGestureEnabled"));
				}
			}
			
			[Export ("setSwipeDismissalGestureEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSwipeDismissalGestureEnabled:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSwipeDismissalGestureEnabled:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UITextField[] TextFields {
			[Export ("textFields")]
			get {
				global::UIKit.UITextField[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<global::UIKit.UITextField>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("textFields")));
				} else {
					ret = NSArray.ArrayFromHandle<global::UIKit.UITextField>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("textFields")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_TitleColor_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIColor TitleColor {
			[Export ("titleColor", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIColor ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("titleColor")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("titleColor")));
				}
				MarkDirty ();
				__mt_TitleColor_var = ret;
				return ret;
			}
			
			[Export ("setTitleColor:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTitleColor:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTitleColor:"), value.Handle);
				}
				MarkDirty ();
				__mt_TitleColor_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_TitleFont_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIFont TitleFont {
			[Export ("titleFont", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIFont ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("titleFont")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIFont> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("titleFont")));
				}
				MarkDirty ();
				__mt_TitleFont_var = ret;
				return ret;
			}
			
			[Export ("setTitleFont:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTitleFont:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTitleFont:"), value.Handle);
				}
				MarkDirty ();
				__mt_TitleFont_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual IterableAlertViewControllerTransitionStyle TransitionStyle {
			[Export ("transitionStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				IterableAlertViewControllerTransitionStyle ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (IterableAlertViewControllerTransitionStyle) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("transitionStyle"));
					} else {
						ret = (IterableAlertViewControllerTransitionStyle) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("transitionStyle"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (IterableAlertViewControllerTransitionStyle) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transitionStyle"));
					} else {
						ret = (IterableAlertViewControllerTransitionStyle) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transitionStyle"));
					}
				}
				return ret;
			}
			
			[Export ("setTransitionStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setTransitionStyle:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setTransitionStyle:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setTransitionStyle:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setTransitionStyle:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_AlertViewBackgroundColor_var = null;
				__mt_AlertViewContentView_var = null;
				__mt_ButtonColor_var = null;
				__mt_ButtonTitleColor_var = null;
				__mt_ButtonTitleFont_var = null;
				__mt_CancelButtonColor_var = null;
				__mt_CancelButtonTitleColor_var = null;
				__mt_CancelButtonTitleFont_var = null;
				__mt_DestructiveButtonColor_var = null;
				__mt_DestructiveButtonTitleColor_var = null;
				__mt_DestructiveButtonTitleFont_var = null;
				__mt_DisabledButtonColor_var = null;
				__mt_DisabledButtonTitleColor_var = null;
				__mt_MessageColor_var = null;
				__mt_MessageFont_var = null;
				__mt_TitleColor_var = null;
				__mt_TitleFont_var = null;
			}
		}
	} /* class IterableAlertViewController */
}
