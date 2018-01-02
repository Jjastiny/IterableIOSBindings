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
	[Register("IterableAlertView", true)]
	public unsafe partial class IterableAlertView : global::UIKit.UIView {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("IterableAlertView");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public IterableAlertView () : base (NSObjectFlag.Empty)
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
		public IterableAlertView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected IterableAlertView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal IterableAlertView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setInAppLocation:")]
		[CompilerGenerated]
		public virtual void SetInAppLocation (IterableInAppNotificationLocation location)
		{
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setInAppLocation:"), (UInt64)location);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setInAppLocation:"), (UInt32)location);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setInAppLocation:"), (UInt64)location);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setInAppLocation:"), (UInt32)location);
				}
			}
		}
		
		[Export ("updateHorizontalConstraint")]
		[CompilerGenerated]
		public virtual void UpdateHorizontalConstraint ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("updateHorizontalConstraint"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("updateHorizontalConstraint"));
			}
		}
		
		[CompilerGenerated]
		object __mt_ActionButtons_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIButton[] ActionButtons {
			[Export ("actionButtons", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIButton[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<global::UIKit.UIButton>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("actionButtons")));
				} else {
					ret = NSArray.ArrayFromHandle<global::UIKit.UIButton>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("actionButtons")));
				}
				MarkDirty ();
				__mt_ActionButtons_var = ret;
				return ret;
			}
			
			[Export ("setActionButtons:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setActionButtons:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setActionButtons:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				MarkDirty ();
				__mt_ActionButtons_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIView AlertBackgroundView {
			[Export ("alertBackgroundView")]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("alertBackgroundView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("alertBackgroundView")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.NSLayoutConstraint BackgroundViewVerticalCenteringConstraint {
			[Export ("backgroundViewVerticalCenteringConstraint")]
			get {
				global::UIKit.NSLayoutConstraint ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.NSLayoutConstraint> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundViewVerticalCenteringConstraint")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.NSLayoutConstraint> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundViewVerticalCenteringConstraint")));
				}
				return ret;
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
		object __mt_ContentView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView ContentView {
			[Export ("contentView", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contentView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentView")));
				}
				MarkDirty ();
				__mt_ContentView_var = ret;
				return ret;
			}
			
			[Export ("setContentView:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setContentView:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setContentView:"), value.Handle);
				}
				MarkDirty ();
				__mt_ContentView_var = value;
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
		object __mt_MessageTextView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UITextView MessageTextView {
			[Export ("messageTextView", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UITextView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UITextView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("messageTextView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UITextView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("messageTextView")));
				}
				MarkDirty ();
				__mt_MessageTextView_var = ret;
				return ret;
			}
			
			[Export ("setMessageTextView:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMessageTextView:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMessageTextView:"), value.Handle);
				}
				MarkDirty ();
				__mt_MessageTextView_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_TextFields_var;
		[CompilerGenerated]
		public virtual global::UIKit.UITextField[] TextFields {
			[Export ("textFields", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UITextField[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<global::UIKit.UITextField>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("textFields")));
				} else {
					ret = NSArray.ArrayFromHandle<global::UIKit.UITextField>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("textFields")));
				}
				MarkDirty ();
				__mt_TextFields_var = ret;
				return ret;
			}
			
			[Export ("setTextFields:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTextFields:"), nsa_value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTextFields:"), nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				MarkDirty ();
				__mt_TextFields_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_TitleLabel_var;
		[CompilerGenerated]
		public virtual global::UIKit.UILabel TitleLabel {
			[Export ("titleLabel", ArgumentSemantic.UnsafeUnretained)]
			get {
				global::UIKit.UILabel ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UILabel> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("titleLabel")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UILabel> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("titleLabel")));
				}
				MarkDirty ();
				__mt_TitleLabel_var = ret;
				return ret;
			}
			
			[Export ("setTitleLabel:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTitleLabel:"), value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTitleLabel:"), value.Handle);
				}
				MarkDirty ();
				__mt_TitleLabel_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ActionButtons_var = null;
				__mt_ButtonColor_var = null;
				__mt_ButtonTitleColor_var = null;
				__mt_ButtonTitleFont_var = null;
				__mt_CancelButtonColor_var = null;
				__mt_CancelButtonTitleColor_var = null;
				__mt_CancelButtonTitleFont_var = null;
				__mt_ContentView_var = null;
				__mt_DestructiveButtonColor_var = null;
				__mt_DestructiveButtonTitleColor_var = null;
				__mt_DestructiveButtonTitleFont_var = null;
				__mt_MessageTextView_var = null;
				__mt_TextFields_var = null;
				__mt_TitleLabel_var = null;
			}
		}
		public partial class IterableAlertViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal IterableAlertViewAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new IterableAlertViewAppearance Appearance {
			get { return new IterableAlertViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new IterableAlertViewAppearance GetAppearance<T> () where T: IterableAlertView {
			return new IterableAlertViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new IterableAlertViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new IterableAlertViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new IterableAlertViewAppearance GetAppearance (UITraitCollection traits) {
			return new IterableAlertViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new IterableAlertViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new IterableAlertViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new IterableAlertViewAppearance GetAppearance<T> (UITraitCollection traits) where T: IterableAlertView {
			return new IterableAlertViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new IterableAlertViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: IterableAlertView{
			return new IterableAlertViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class IterableAlertView */
}
