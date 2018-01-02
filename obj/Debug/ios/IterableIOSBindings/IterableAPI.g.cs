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
	[Register("IterableAPI", true)]
	public unsafe partial class IterableAPI : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("IterableAPI");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public IterableAPI () : base (NSObjectFlag.Empty)
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
		protected IterableAPI (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal IterableAPI (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithApiKey:andEmail:launchOptions:useCustomLaunchOptions:")]
		[CompilerGenerated]
		public IterableAPI (string apiKey, string email, NSDictionary launchOptions, bool useCustomLaunchOptions)
			: base (NSObjectFlag.Empty)
		{
			if (apiKey == null)
				throw new ArgumentNullException ("apiKey");
			if (email == null)
				throw new ArgumentNullException ("email");
			var nsapiKey = NSString.CreateNative (apiKey);
			var nsemail = NSString.CreateNative (email);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_bool (this.Handle, Selector.GetHandle ("initWithApiKey:andEmail:launchOptions:useCustomLaunchOptions:"), nsapiKey, nsemail, launchOptions == null ? IntPtr.Zero : launchOptions.Handle, useCustomLaunchOptions), "initWithApiKey:andEmail:launchOptions:useCustomLaunchOptions:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("initWithApiKey:andEmail:launchOptions:useCustomLaunchOptions:"), nsapiKey, nsemail, launchOptions == null ? IntPtr.Zero : launchOptions.Handle, useCustomLaunchOptions), "initWithApiKey:andEmail:launchOptions:useCustomLaunchOptions:");
			}
			NSString.ReleaseNative (nsapiKey);
			NSString.ReleaseNative (nsemail);
			
		}
		
		[Export ("initWithApiKey:andUserId:")]
		[CompilerGenerated]
		public IterableAPI (string apiKey, string userId)
			: base (NSObjectFlag.Empty)
		{
			if (apiKey == null)
				throw new ArgumentNullException ("apiKey");
			if (userId == null)
				throw new ArgumentNullException ("userId");
			var nsapiKey = NSString.CreateNative (apiKey);
			var nsuserId = NSString.CreateNative (userId);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithApiKey:andUserId:"), nsapiKey, nsuserId), "initWithApiKey:andUserId:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithApiKey:andUserId:"), nsapiKey, nsuserId), "initWithApiKey:andUserId:");
			}
			NSString.ReleaseNative (nsapiKey);
			NSString.ReleaseNative (nsuserId);
			
		}
		
		[Export ("initWithApiKey:andUserId:launchOptions:")]
		[CompilerGenerated]
		public IterableAPI (string apiKey, string userId, NSDictionary launchOptions)
			: base (NSObjectFlag.Empty)
		{
			if (apiKey == null)
				throw new ArgumentNullException ("apiKey");
			if (userId == null)
				throw new ArgumentNullException ("userId");
			var nsapiKey = NSString.CreateNative (apiKey);
			var nsuserId = NSString.CreateNative (userId);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithApiKey:andUserId:launchOptions:"), nsapiKey, nsuserId, launchOptions == null ? IntPtr.Zero : launchOptions.Handle), "initWithApiKey:andUserId:launchOptions:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithApiKey:andUserId:launchOptions:"), nsapiKey, nsuserId, launchOptions == null ? IntPtr.Zero : launchOptions.Handle), "initWithApiKey:andUserId:launchOptions:");
			}
			NSString.ReleaseNative (nsapiKey);
			NSString.ReleaseNative (nsuserId);
			
		}
		
		[Export ("initWithApiKey:andUserId:launchOptions:useCustomLaunchOptions:")]
		[CompilerGenerated]
		public IterableAPI (string apiKey, NSDictionary launchOptions, bool useCustomLaunchOptions, string userId)
			: base (NSObjectFlag.Empty)
		{
			if (apiKey == null)
				throw new ArgumentNullException ("apiKey");
			if (userId == null)
				throw new ArgumentNullException ("userId");
			var nsapiKey = NSString.CreateNative (apiKey);
			var nsuserId = NSString.CreateNative (userId);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool_IntPtr (this.Handle, Selector.GetHandle ("initWithApiKey:andUserId:launchOptions:useCustomLaunchOptions:"), nsapiKey, launchOptions == null ? IntPtr.Zero : launchOptions.Handle, useCustomLaunchOptions, nsuserId), "initWithApiKey:andUserId:launchOptions:useCustomLaunchOptions:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithApiKey:andUserId:launchOptions:useCustomLaunchOptions:"), nsapiKey, launchOptions == null ? IntPtr.Zero : launchOptions.Handle, useCustomLaunchOptions, nsuserId), "initWithApiKey:andUserId:launchOptions:useCustomLaunchOptions:");
			}
			NSString.ReleaseNative (nsapiKey);
			NSString.ReleaseNative (nsuserId);
			
		}
		
		[Export ("clearSharedInstance")]
		[CompilerGenerated]
		public static void ClearSharedInstance ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (class_ptr, Selector.GetHandle ("clearSharedInstance"));
		}
		
		[Export ("disableDeviceForAllUsers")]
		[CompilerGenerated]
		public virtual void DisableDeviceForAllUsers ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("disableDeviceForAllUsers"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disableDeviceForAllUsers"));
			}
		}
		
		[Export ("disableDeviceForAllUsersWithOnSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe virtual void DisableDeviceForAllUsersWithOnSuccess ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOnSuccessHandler))]OnSuccessHandler onSuccess, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOnFailureHandler))]OnFailureHandler onFailure)
		{
			if (onSuccess == null)
				throw new ArgumentNullException ("onSuccess");
			if (onFailure == null)
				throw new ArgumentNullException ("onFailure");
			BlockLiteral *block_ptr_onSuccess;
			BlockLiteral block_onSuccess;
			block_onSuccess = new BlockLiteral ();
			block_ptr_onSuccess = &block_onSuccess;
			block_onSuccess.SetupBlock (Trampolines.SDOnSuccessHandler.Handler, onSuccess);
			BlockLiteral *block_ptr_onFailure;
			BlockLiteral block_onFailure;
			block_onFailure = new BlockLiteral ();
			block_ptr_onFailure = &block_onFailure;
			block_onFailure.SetupBlock (Trampolines.SDOnFailureHandler.Handler, onFailure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("disableDeviceForAllUsersWithOnSuccess:onFailure:"), (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("disableDeviceForAllUsersWithOnSuccess:onFailure:"), (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
			}
			block_ptr_onSuccess->CleanupBlock ();
			block_ptr_onFailure->CleanupBlock ();
			
		}
		
		[Export ("disableDeviceForCurrentUser")]
		[CompilerGenerated]
		public virtual void DisableDeviceForCurrentUser ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("disableDeviceForCurrentUser"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disableDeviceForCurrentUser"));
			}
		}
		
		[Export ("disableDeviceForCurrentUserWithOnSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe virtual void DisableDeviceForCurrentUserWithOnSuccess ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOnSuccessHandler))]OnSuccessHandler onSuccess, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOnFailureHandler))]OnFailureHandler onFailure)
		{
			if (onSuccess == null)
				throw new ArgumentNullException ("onSuccess");
			if (onFailure == null)
				throw new ArgumentNullException ("onFailure");
			BlockLiteral *block_ptr_onSuccess;
			BlockLiteral block_onSuccess;
			block_onSuccess = new BlockLiteral ();
			block_ptr_onSuccess = &block_onSuccess;
			block_onSuccess.SetupBlock (Trampolines.SDOnSuccessHandler.Handler, onSuccess);
			BlockLiteral *block_ptr_onFailure;
			BlockLiteral block_onFailure;
			block_onFailure = new BlockLiteral ();
			block_ptr_onFailure = &block_onFailure;
			block_onFailure.SetupBlock (Trampolines.SDOnFailureHandler.Handler, onFailure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("disableDeviceForCurrentUserWithOnSuccess:onFailure:"), (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("disableDeviceForCurrentUserWithOnSuccess:onFailure:"), (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
			}
			block_ptr_onSuccess->CleanupBlock ();
			block_ptr_onFailure->CleanupBlock ();
			
		}
		
		[Export ("getAndTrackDeeplink:callbackBlock:")]
		[CompilerGenerated]
		public unsafe static void GetAndTrackDeeplink (NSUrl webpageURL, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDITEActionBlock))]ITEActionBlock callbackBlock)
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
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("getAndTrackDeeplink:callbackBlock:"), webpageURL.Handle, (IntPtr) block_ptr_callbackBlock);
			block_ptr_callbackBlock->CleanupBlock ();
			
		}
		
		[Export ("getInAppMessages:")]
		[CompilerGenerated]
		public virtual void GetInAppMessages (NSNumber count)
		{
			if (count == null)
				throw new ArgumentNullException ("count");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getInAppMessages:"), count.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getInAppMessages:"), count.Handle);
			}
		}
		
		[Export ("getInAppMessages:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe virtual void GetInAppMessages (NSNumber count, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOnSuccessHandler))]OnSuccessHandler onSuccess, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOnFailureHandler))]OnFailureHandler onFailure)
		{
			if (count == null)
				throw new ArgumentNullException ("count");
			if (onSuccess == null)
				throw new ArgumentNullException ("onSuccess");
			if (onFailure == null)
				throw new ArgumentNullException ("onFailure");
			BlockLiteral *block_ptr_onSuccess;
			BlockLiteral block_onSuccess;
			block_onSuccess = new BlockLiteral ();
			block_ptr_onSuccess = &block_onSuccess;
			block_onSuccess.SetupBlock (Trampolines.SDOnSuccessHandler.Handler, onSuccess);
			BlockLiteral *block_ptr_onFailure;
			BlockLiteral block_onFailure;
			block_onFailure = new BlockLiteral ();
			block_ptr_onFailure = &block_onFailure;
			block_onFailure.SetupBlock (Trampolines.SDOnFailureHandler.Handler, onFailure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("getInAppMessages:onSuccess:onFailure:"), count.Handle, (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("getInAppMessages:onSuccess:onFailure:"), count.Handle, (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
			}
			block_ptr_onSuccess->CleanupBlock ();
			block_ptr_onFailure->CleanupBlock ();
			
		}
		
		[Export ("inAppConsume:")]
		[CompilerGenerated]
		public virtual void InAppConsume (string messageId)
		{
			if (messageId == null)
				throw new ArgumentNullException ("messageId");
			var nsmessageId = NSString.CreateNative (messageId);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("inAppConsume:"), nsmessageId);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("inAppConsume:"), nsmessageId);
			}
			NSString.ReleaseNative (nsmessageId);
			
		}
		
		[Export ("registerToken:appName:pushServicePlatform:")]
		[CompilerGenerated]
		public virtual void RegisterToken (NSData token, string appName, PushServicePlatform pushServicePlatform)
		{
			if (token == null)
				throw new ArgumentNullException ("token");
			if (appName == null)
				throw new ArgumentNullException ("appName");
			var nsappName = NSString.CreateNative (appName);
			
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64 (this.Handle, Selector.GetHandle ("registerToken:appName:pushServicePlatform:"), token.Handle, nsappName, (UInt64)pushServicePlatform);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt32 (this.Handle, Selector.GetHandle ("registerToken:appName:pushServicePlatform:"), token.Handle, nsappName, (UInt32)pushServicePlatform);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt64 (this.SuperHandle, Selector.GetHandle ("registerToken:appName:pushServicePlatform:"), token.Handle, nsappName, (UInt64)pushServicePlatform);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt32 (this.SuperHandle, Selector.GetHandle ("registerToken:appName:pushServicePlatform:"), token.Handle, nsappName, (UInt32)pushServicePlatform);
				}
			}
			NSString.ReleaseNative (nsappName);
			
		}
		
		[Export ("registerToken:appName:pushServicePlatform:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe virtual void RegisterToken (NSData token, string appName, PushServicePlatform pushServicePlatform, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOnSuccessHandler))]OnSuccessHandler onSuccess, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOnFailureHandler))]OnFailureHandler onFailure)
		{
			if (token == null)
				throw new ArgumentNullException ("token");
			if (appName == null)
				throw new ArgumentNullException ("appName");
			if (onSuccess == null)
				throw new ArgumentNullException ("onSuccess");
			if (onFailure == null)
				throw new ArgumentNullException ("onFailure");
			var nsappName = NSString.CreateNative (appName);
			BlockLiteral *block_ptr_onSuccess;
			BlockLiteral block_onSuccess;
			block_onSuccess = new BlockLiteral ();
			block_ptr_onSuccess = &block_onSuccess;
			block_onSuccess.SetupBlock (Trampolines.SDOnSuccessHandler.Handler, onSuccess);
			BlockLiteral *block_ptr_onFailure;
			BlockLiteral block_onFailure;
			block_onFailure = new BlockLiteral ();
			block_ptr_onFailure = &block_onFailure;
			block_onFailure.SetupBlock (Trampolines.SDOnFailureHandler.Handler, onFailure);
			
			if (IsDirectBinding) {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("registerToken:appName:pushServicePlatform:onSuccess:onFailure:"), token.Handle, nsappName, (UInt64)pushServicePlatform, (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_UInt32_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("registerToken:appName:pushServicePlatform:onSuccess:onFailure:"), token.Handle, nsappName, (UInt32)pushServicePlatform, (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
				}
			} else {
				if (IntPtr.Size == 8) {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("registerToken:appName:pushServicePlatform:onSuccess:onFailure:"), token.Handle, nsappName, (UInt64)pushServicePlatform, (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_UInt32_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("registerToken:appName:pushServicePlatform:onSuccess:onFailure:"), token.Handle, nsappName, (UInt32)pushServicePlatform, (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
				}
			}
			NSString.ReleaseNative (nsappName);
			block_ptr_onSuccess->CleanupBlock ();
			block_ptr_onFailure->CleanupBlock ();
			
		}
		
		[Export ("sharedInstanceWithApiKey:andUserId:launchOptions:")]
		[CompilerGenerated]
		public static IterableAPI SharedInstanceWithApiKey (string apiKey, NSDictionary launchOptions, string userId)
		{
			if (apiKey == null)
				throw new ArgumentNullException ("apiKey");
			if (userId == null)
				throw new ArgumentNullException ("userId");
			var nsapiKey = NSString.CreateNative (apiKey);
			var nsuserId = NSString.CreateNative (userId);
			
			IterableAPI ret;
			ret =  Runtime.GetNSObject<IterableAPI> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("sharedInstanceWithApiKey:andUserId:launchOptions:"), nsapiKey, launchOptions == null ? IntPtr.Zero : launchOptions.Handle, nsuserId));
			NSString.ReleaseNative (nsapiKey);
			NSString.ReleaseNative (nsuserId);
			
			return ret;
		}
		
		[Export ("sharedInstanceWithApiKey:andEmail:launchOptions:")]
		[CompilerGenerated]
		public static IterableAPI SharedInstanceWithApiKey (string apiKey, string email, NSDictionary launchOptions)
		{
			if (apiKey == null)
				throw new ArgumentNullException ("apiKey");
			if (email == null)
				throw new ArgumentNullException ("email");
			var nsapiKey = NSString.CreateNative (apiKey);
			var nsemail = NSString.CreateNative (email);
			
			IterableAPI ret;
			ret =  Runtime.GetNSObject<IterableAPI> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("sharedInstanceWithApiKey:andEmail:launchOptions:"), nsapiKey, nsemail, launchOptions == null ? IntPtr.Zero : launchOptions.Handle));
			NSString.ReleaseNative (nsapiKey);
			NSString.ReleaseNative (nsemail);
			
			return ret;
		}
		
		[Export ("showSystemNotification:body:button:callbackBlock:")]
		[CompilerGenerated]
		public unsafe virtual void ShowSystemNotification (string title, string body, string button, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDITEActionBlock))]ITEActionBlock callbackBlock)
		{
			if (title == null)
				throw new ArgumentNullException ("title");
			if (body == null)
				throw new ArgumentNullException ("body");
			if (button == null)
				throw new ArgumentNullException ("button");
			if (callbackBlock == null)
				throw new ArgumentNullException ("callbackBlock");
			var nstitle = NSString.CreateNative (title);
			var nsbody = NSString.CreateNative (body);
			var nsbutton = NSString.CreateNative (button);
			BlockLiteral *block_ptr_callbackBlock;
			BlockLiteral block_callbackBlock;
			block_callbackBlock = new BlockLiteral ();
			block_ptr_callbackBlock = &block_callbackBlock;
			block_callbackBlock.SetupBlock (Trampolines.SDITEActionBlock.Handler, callbackBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("showSystemNotification:body:button:callbackBlock:"), nstitle, nsbody, nsbutton, (IntPtr) block_ptr_callbackBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("showSystemNotification:body:button:callbackBlock:"), nstitle, nsbody, nsbutton, (IntPtr) block_ptr_callbackBlock);
			}
			NSString.ReleaseNative (nstitle);
			NSString.ReleaseNative (nsbody);
			NSString.ReleaseNative (nsbutton);
			block_ptr_callbackBlock->CleanupBlock ();
			
		}
		
		[Export ("showSystemNotification:body:buttonLeft:buttonRight:callbackBlock:")]
		[CompilerGenerated]
		public unsafe virtual void ShowSystemNotification (string title, string body, string buttonLeft, string buttonRight, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDITEActionBlock))]ITEActionBlock callbackBlock)
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
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("showSystemNotification:body:buttonLeft:buttonRight:callbackBlock:"), nstitle, nsbody, nsbuttonLeft, nsbuttonRight, (IntPtr) block_ptr_callbackBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("showSystemNotification:body:buttonLeft:buttonRight:callbackBlock:"), nstitle, nsbody, nsbuttonLeft, nsbuttonRight, (IntPtr) block_ptr_callbackBlock);
			}
			NSString.ReleaseNative (nstitle);
			NSString.ReleaseNative (nsbody);
			NSString.ReleaseNative (nsbuttonLeft);
			NSString.ReleaseNative (nsbuttonRight);
			block_ptr_callbackBlock->CleanupBlock ();
			
		}
		
		[Export ("spawnInAppNotification:")]
		[CompilerGenerated]
		public unsafe virtual void SpawnInAppNotification ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDITEActionBlock))]ITEActionBlock callbackBlock)
		{
			if (callbackBlock == null)
				throw new ArgumentNullException ("callbackBlock");
			BlockLiteral *block_ptr_callbackBlock;
			BlockLiteral block_callbackBlock;
			block_callbackBlock = new BlockLiteral ();
			block_ptr_callbackBlock = &block_callbackBlock;
			block_callbackBlock.SetupBlock (Trampolines.SDITEActionBlock.Handler, callbackBlock);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("spawnInAppNotification:"), (IntPtr) block_ptr_callbackBlock);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("spawnInAppNotification:"), (IntPtr) block_ptr_callbackBlock);
			}
			block_ptr_callbackBlock->CleanupBlock ();
			
		}
		
		[Export ("track:")]
		[CompilerGenerated]
		public virtual void Track (string eventName)
		{
			if (eventName == null)
				throw new ArgumentNullException ("eventName");
			var nseventName = NSString.CreateNative (eventName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("track:"), nseventName);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("track:"), nseventName);
			}
			NSString.ReleaseNative (nseventName);
			
		}
		
		[Export ("track:dataFields:")]
		[CompilerGenerated]
		public virtual void Track (string eventName, NSDictionary dataFields)
		{
			if (eventName == null)
				throw new ArgumentNullException ("eventName");
			var nseventName = NSString.CreateNative (eventName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("track:dataFields:"), nseventName, dataFields == null ? IntPtr.Zero : dataFields.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("track:dataFields:"), nseventName, dataFields == null ? IntPtr.Zero : dataFields.Handle);
			}
			NSString.ReleaseNative (nseventName);
			
		}
		
		[Export ("track:dataFields:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe virtual void Track (string eventName, NSDictionary dataFields, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOnSuccessHandler))]OnSuccessHandler onSuccess, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOnFailureHandler))]OnFailureHandler onFailure)
		{
			if (eventName == null)
				throw new ArgumentNullException ("eventName");
			if (onSuccess == null)
				throw new ArgumentNullException ("onSuccess");
			if (onFailure == null)
				throw new ArgumentNullException ("onFailure");
			var nseventName = NSString.CreateNative (eventName);
			BlockLiteral *block_ptr_onSuccess;
			BlockLiteral block_onSuccess;
			block_onSuccess = new BlockLiteral ();
			block_ptr_onSuccess = &block_onSuccess;
			block_onSuccess.SetupBlock (Trampolines.SDOnSuccessHandler.Handler, onSuccess);
			BlockLiteral *block_ptr_onFailure;
			BlockLiteral block_onFailure;
			block_onFailure = new BlockLiteral ();
			block_ptr_onFailure = &block_onFailure;
			block_onFailure.SetupBlock (Trampolines.SDOnFailureHandler.Handler, onFailure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("track:dataFields:onSuccess:onFailure:"), nseventName, dataFields == null ? IntPtr.Zero : dataFields.Handle, (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("track:dataFields:onSuccess:onFailure:"), nseventName, dataFields == null ? IntPtr.Zero : dataFields.Handle, (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
			}
			NSString.ReleaseNative (nseventName);
			block_ptr_onSuccess->CleanupBlock ();
			block_ptr_onFailure->CleanupBlock ();
			
		}
		
		[Export ("trackInAppClick:buttonIndex:")]
		[CompilerGenerated]
		public virtual void TrackInAppClick (string messageId, NSNumber buttonIndex)
		{
			if (messageId == null)
				throw new ArgumentNullException ("messageId");
			if (buttonIndex == null)
				throw new ArgumentNullException ("buttonIndex");
			var nsmessageId = NSString.CreateNative (messageId);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("trackInAppClick:buttonIndex:"), nsmessageId, buttonIndex.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("trackInAppClick:buttonIndex:"), nsmessageId, buttonIndex.Handle);
			}
			NSString.ReleaseNative (nsmessageId);
			
		}
		
		[Export ("trackInAppClick:buttonURL:")]
		[CompilerGenerated]
		public virtual void TrackInAppClick (string messageId, string buttonURL)
		{
			if (messageId == null)
				throw new ArgumentNullException ("messageId");
			if (buttonURL == null)
				throw new ArgumentNullException ("buttonURL");
			var nsmessageId = NSString.CreateNative (messageId);
			var nsbuttonURL = NSString.CreateNative (buttonURL);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("trackInAppClick:buttonURL:"), nsmessageId, nsbuttonURL);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("trackInAppClick:buttonURL:"), nsmessageId, nsbuttonURL);
			}
			NSString.ReleaseNative (nsmessageId);
			NSString.ReleaseNative (nsbuttonURL);
			
		}
		
		[Export ("trackInAppOpen:")]
		[CompilerGenerated]
		public virtual void TrackInAppOpen (string messageId)
		{
			if (messageId == null)
				throw new ArgumentNullException ("messageId");
			var nsmessageId = NSString.CreateNative (messageId);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("trackInAppOpen:"), nsmessageId);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("trackInAppOpen:"), nsmessageId);
			}
			NSString.ReleaseNative (nsmessageId);
			
		}
		
		[Export ("trackPurchase:items:")]
		[CompilerGenerated]
		public virtual void TrackPurchase (NSNumber total, CommerceItem[] items)
		{
			if (total == null)
				throw new ArgumentNullException ("total");
			if (items == null)
				throw new ArgumentNullException ("items");
			var nsa_items = NSArray.FromNSObjects (items);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("trackPurchase:items:"), total.Handle, nsa_items.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("trackPurchase:items:"), total.Handle, nsa_items.Handle);
			}
			nsa_items.Dispose ();
			
		}
		
		[Export ("trackPurchase:items:dataFields:")]
		[CompilerGenerated]
		public virtual void TrackPurchase (NSNumber total, CommerceItem[] items, NSDictionary dataFields)
		{
			if (total == null)
				throw new ArgumentNullException ("total");
			if (items == null)
				throw new ArgumentNullException ("items");
			var nsa_items = NSArray.FromNSObjects (items);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("trackPurchase:items:dataFields:"), total.Handle, nsa_items.Handle, dataFields == null ? IntPtr.Zero : dataFields.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("trackPurchase:items:dataFields:"), total.Handle, nsa_items.Handle, dataFields == null ? IntPtr.Zero : dataFields.Handle);
			}
			nsa_items.Dispose ();
			
		}
		
		[Export ("trackPurchase:items:dataFields:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe virtual void TrackPurchase (NSNumber total, CommerceItem[] items, NSDictionary dataFields, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOnSuccessHandler))]OnSuccessHandler onSuccess, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOnFailureHandler))]OnFailureHandler onFailure)
		{
			if (total == null)
				throw new ArgumentNullException ("total");
			if (items == null)
				throw new ArgumentNullException ("items");
			if (onSuccess == null)
				throw new ArgumentNullException ("onSuccess");
			if (onFailure == null)
				throw new ArgumentNullException ("onFailure");
			var nsa_items = NSArray.FromNSObjects (items);
			BlockLiteral *block_ptr_onSuccess;
			BlockLiteral block_onSuccess;
			block_onSuccess = new BlockLiteral ();
			block_ptr_onSuccess = &block_onSuccess;
			block_onSuccess.SetupBlock (Trampolines.SDOnSuccessHandler.Handler, onSuccess);
			BlockLiteral *block_ptr_onFailure;
			BlockLiteral block_onFailure;
			block_onFailure = new BlockLiteral ();
			block_ptr_onFailure = &block_onFailure;
			block_onFailure.SetupBlock (Trampolines.SDOnFailureHandler.Handler, onFailure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("trackPurchase:items:dataFields:onSuccess:onFailure:"), total.Handle, nsa_items.Handle, dataFields == null ? IntPtr.Zero : dataFields.Handle, (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("trackPurchase:items:dataFields:onSuccess:onFailure:"), total.Handle, nsa_items.Handle, dataFields == null ? IntPtr.Zero : dataFields.Handle, (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
			}
			nsa_items.Dispose ();
			block_ptr_onSuccess->CleanupBlock ();
			block_ptr_onFailure->CleanupBlock ();
			
		}
		
		[Export ("trackPushOpen:")]
		[CompilerGenerated]
		public virtual void TrackPushOpen (NSDictionary userInfo)
		{
			if (userInfo == null)
				throw new ArgumentNullException ("userInfo");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("trackPushOpen:"), userInfo.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("trackPushOpen:"), userInfo.Handle);
			}
		}
		
		[Export ("trackPushOpen:dataFields:")]
		[CompilerGenerated]
		public virtual void TrackPushOpen (NSDictionary userInfo, NSDictionary dataFields)
		{
			if (userInfo == null)
				throw new ArgumentNullException ("userInfo");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("trackPushOpen:dataFields:"), userInfo.Handle, dataFields == null ? IntPtr.Zero : dataFields.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("trackPushOpen:dataFields:"), userInfo.Handle, dataFields == null ? IntPtr.Zero : dataFields.Handle);
			}
		}
		
		[Export ("trackPushOpen:dataFields:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe virtual void TrackPushOpen (NSDictionary userInfo, NSDictionary dataFields, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOnSuccessHandler))]OnSuccessHandler onSuccess, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOnFailureHandler))]OnFailureHandler onFailure)
		{
			if (userInfo == null)
				throw new ArgumentNullException ("userInfo");
			if (onSuccess == null)
				throw new ArgumentNullException ("onSuccess");
			if (onFailure == null)
				throw new ArgumentNullException ("onFailure");
			BlockLiteral *block_ptr_onSuccess;
			BlockLiteral block_onSuccess;
			block_onSuccess = new BlockLiteral ();
			block_ptr_onSuccess = &block_onSuccess;
			block_onSuccess.SetupBlock (Trampolines.SDOnSuccessHandler.Handler, onSuccess);
			BlockLiteral *block_ptr_onFailure;
			BlockLiteral block_onFailure;
			block_onFailure = new BlockLiteral ();
			block_ptr_onFailure = &block_onFailure;
			block_onFailure.SetupBlock (Trampolines.SDOnFailureHandler.Handler, onFailure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("trackPushOpen:dataFields:onSuccess:onFailure:"), userInfo.Handle, dataFields == null ? IntPtr.Zero : dataFields.Handle, (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("trackPushOpen:dataFields:onSuccess:onFailure:"), userInfo.Handle, dataFields == null ? IntPtr.Zero : dataFields.Handle, (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
			}
			block_ptr_onSuccess->CleanupBlock ();
			block_ptr_onFailure->CleanupBlock ();
			
		}
		
		[Export ("trackPushOpen:templateId:messageId:appAlreadyRunning:dataFields:")]
		[CompilerGenerated]
		public virtual void TrackPushOpen (NSNumber campaignId, NSNumber templateId, string messageId, bool appAlreadyRunning, NSDictionary dataFields)
		{
			if (campaignId == null)
				throw new ArgumentNullException ("campaignId");
			if (templateId == null)
				throw new ArgumentNullException ("templateId");
			if (messageId == null)
				throw new ArgumentNullException ("messageId");
			var nsmessageId = NSString.CreateNative (messageId);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_IntPtr (this.Handle, Selector.GetHandle ("trackPushOpen:templateId:messageId:appAlreadyRunning:dataFields:"), campaignId.Handle, templateId.Handle, nsmessageId, appAlreadyRunning, dataFields == null ? IntPtr.Zero : dataFields.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("trackPushOpen:templateId:messageId:appAlreadyRunning:dataFields:"), campaignId.Handle, templateId.Handle, nsmessageId, appAlreadyRunning, dataFields == null ? IntPtr.Zero : dataFields.Handle);
			}
			NSString.ReleaseNative (nsmessageId);
			
		}
		
		[Export ("trackPushOpen:templateId:messageId:appAlreadyRunning:dataFields:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe virtual void TrackPushOpen (NSNumber campaignId, NSNumber templateId, string messageId, bool appAlreadyRunning, NSDictionary dataFields, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOnSuccessHandler))]OnSuccessHandler onSuccess, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOnFailureHandler))]OnFailureHandler onFailure)
		{
			if (campaignId == null)
				throw new ArgumentNullException ("campaignId");
			if (templateId == null)
				throw new ArgumentNullException ("templateId");
			if (messageId == null)
				throw new ArgumentNullException ("messageId");
			if (onSuccess == null)
				throw new ArgumentNullException ("onSuccess");
			if (onFailure == null)
				throw new ArgumentNullException ("onFailure");
			var nsmessageId = NSString.CreateNative (messageId);
			BlockLiteral *block_ptr_onSuccess;
			BlockLiteral block_onSuccess;
			block_onSuccess = new BlockLiteral ();
			block_ptr_onSuccess = &block_onSuccess;
			block_onSuccess.SetupBlock (Trampolines.SDOnSuccessHandler.Handler, onSuccess);
			BlockLiteral *block_ptr_onFailure;
			BlockLiteral block_onFailure;
			block_onFailure = new BlockLiteral ();
			block_ptr_onFailure = &block_onFailure;
			block_onFailure.SetupBlock (Trampolines.SDOnFailureHandler.Handler, onFailure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("trackPushOpen:templateId:messageId:appAlreadyRunning:dataFields:onSuccess:onFailure:"), campaignId.Handle, templateId.Handle, nsmessageId, appAlreadyRunning, dataFields == null ? IntPtr.Zero : dataFields.Handle, (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("trackPushOpen:templateId:messageId:appAlreadyRunning:dataFields:onSuccess:onFailure:"), campaignId.Handle, templateId.Handle, nsmessageId, appAlreadyRunning, dataFields == null ? IntPtr.Zero : dataFields.Handle, (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
			}
			NSString.ReleaseNative (nsmessageId);
			block_ptr_onSuccess->CleanupBlock ();
			block_ptr_onFailure->CleanupBlock ();
			
		}
		
		[Export ("updateSubscriptions:unsubscribedChannelIds:unsubscribedMessageTypeIds:")]
		[CompilerGenerated]
		public virtual void UpdateSubscriptions (NSNumber[] emailListIds, NSNumber[] unsubscribedChannelIds, NSNumber[] unsubscribedMessageTypeIds)
		{
			var nsa_emailListIds = emailListIds == null ? null : NSArray.FromNSObjects (emailListIds);
			var nsa_unsubscribedChannelIds = unsubscribedChannelIds == null ? null : NSArray.FromNSObjects (unsubscribedChannelIds);
			var nsa_unsubscribedMessageTypeIds = unsubscribedMessageTypeIds == null ? null : NSArray.FromNSObjects (unsubscribedMessageTypeIds);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("updateSubscriptions:unsubscribedChannelIds:unsubscribedMessageTypeIds:"), nsa_emailListIds == null ? IntPtr.Zero : nsa_emailListIds.Handle, nsa_unsubscribedChannelIds == null ? IntPtr.Zero : nsa_unsubscribedChannelIds.Handle, nsa_unsubscribedMessageTypeIds == null ? IntPtr.Zero : nsa_unsubscribedMessageTypeIds.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("updateSubscriptions:unsubscribedChannelIds:unsubscribedMessageTypeIds:"), nsa_emailListIds == null ? IntPtr.Zero : nsa_emailListIds.Handle, nsa_unsubscribedChannelIds == null ? IntPtr.Zero : nsa_unsubscribedChannelIds.Handle, nsa_unsubscribedMessageTypeIds == null ? IntPtr.Zero : nsa_unsubscribedMessageTypeIds.Handle);
			}
			if (nsa_emailListIds != null)
				nsa_emailListIds.Dispose ();
			if (nsa_unsubscribedChannelIds != null)
				nsa_unsubscribedChannelIds.Dispose ();
			if (nsa_unsubscribedMessageTypeIds != null)
				nsa_unsubscribedMessageTypeIds.Dispose ();
			
		}
		
		[Export ("updateUser:mergeNestedObjects:onSuccess:onFailure:")]
		[CompilerGenerated]
		public unsafe virtual void UpdateUser (NSDictionary dataFields, bool mergeNestedObjects, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOnSuccessHandler))]OnSuccessHandler onSuccess, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDOnFailureHandler))]OnFailureHandler onFailure)
		{
			if (dataFields == null)
				throw new ArgumentNullException ("dataFields");
			if (onSuccess == null)
				throw new ArgumentNullException ("onSuccess");
			if (onFailure == null)
				throw new ArgumentNullException ("onFailure");
			BlockLiteral *block_ptr_onSuccess;
			BlockLiteral block_onSuccess;
			block_onSuccess = new BlockLiteral ();
			block_ptr_onSuccess = &block_onSuccess;
			block_onSuccess.SetupBlock (Trampolines.SDOnSuccessHandler.Handler, onSuccess);
			BlockLiteral *block_ptr_onFailure;
			BlockLiteral block_onFailure;
			block_onFailure = new BlockLiteral ();
			block_ptr_onFailure = &block_onFailure;
			block_onFailure.SetupBlock (Trampolines.SDOnFailureHandler.Handler, onFailure);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("updateUser:mergeNestedObjects:onSuccess:onFailure:"), dataFields.Handle, mergeNestedObjects, (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("updateUser:mergeNestedObjects:onSuccess:onFailure:"), dataFields.Handle, mergeNestedObjects, (IntPtr) block_ptr_onSuccess, (IntPtr) block_ptr_onFailure);
			}
			block_ptr_onSuccess->CleanupBlock ();
			block_ptr_onFailure->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public virtual string ApiKey {
			[Export ("apiKey")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("apiKey")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("apiKey")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Email {
			[Export ("email")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("email")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("email")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string HexToken {
			[Export ("hexToken")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("hexToken")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hexToken")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public static IterableAPI SharedInstance {
			[Export ("sharedInstance")]
			get {
				IterableAPI ret;
				ret =  Runtime.GetNSObject<IterableAPI> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")));
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string UserId {
			[Export ("userId")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userId")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userId")));
				}
			}
			
		}
		
	} /* class IterableAPI */
}
