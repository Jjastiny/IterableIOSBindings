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
	[Register("IterableNotificationMetadata", true)]
	public unsafe partial class IterableNotificationMetadata : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("IterableNotificationMetadata");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public IterableNotificationMetadata () : base (NSObjectFlag.Empty)
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
		protected IterableNotificationMetadata (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal IterableNotificationMetadata (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("metadataFromInAppOptions:")]
		[CompilerGenerated]
		public static IterableNotificationMetadata MetadataFromInAppOptions (string messageId)
		{
			if (messageId == null)
				throw new ArgumentNullException ("messageId");
			var nsmessageId = NSString.CreateNative (messageId);
			
			IterableNotificationMetadata ret;
			ret =  Runtime.GetNSObject<IterableNotificationMetadata> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("metadataFromInAppOptions:"), nsmessageId));
			NSString.ReleaseNative (nsmessageId);
			
			return ret;
		}
		
		[Export ("metadataFromLaunchOptions:")]
		[CompilerGenerated]
		public static IterableNotificationMetadata MetadataFromLaunchOptions (NSDictionary userInfo)
		{
			if (userInfo == null)
				throw new ArgumentNullException ("userInfo");
			return  Runtime.GetNSObject<IterableNotificationMetadata> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("metadataFromLaunchOptions:"), userInfo.Handle));
		}
		
		[CompilerGenerated]
		public virtual NSNumber CampaignId {
			[Export ("campaignId", ArgumentSemantic.Copy)]
			get {
				NSNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("campaignId")));
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("campaignId")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsGhostPush {
			[Export ("isGhostPush")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isGhostPush"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isGhostPush"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsProof {
			[Export ("isProof")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isProof"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isProof"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsRealCampaignNotification {
			[Export ("isRealCampaignNotification")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRealCampaignNotification"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRealCampaignNotification"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsTestPush {
			[Export ("isTestPush")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isTestPush"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isTestPush"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string MessageId {
			[Export ("messageId")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("messageId")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("messageId")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSNumber TemplateId {
			[Export ("templateId", ArgumentSemantic.Copy)]
			get {
				NSNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("templateId")));
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("templateId")));
				}
				return ret;
			}
			
		}
		
	} /* class IterableNotificationMetadata */
}
