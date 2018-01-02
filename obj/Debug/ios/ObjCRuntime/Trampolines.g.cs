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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::IterableIOSBindings.ITEActionBlock))]
		internal delegate void DITEActionBlock (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDITEActionBlock {
			static internal readonly DITEActionBlock Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DITEActionBlock))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::IterableIOSBindings.ITEActionBlock) (descriptor->Target);
				if (del != null)
					del (NSString.FromHandle (arg0));
			}
		} /* class SDITEActionBlock */
		
		internal class NIDITEActionBlock {
			IntPtr blockPtr;
			DITEActionBlock invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDITEActionBlock (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DITEActionBlock> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDITEActionBlock ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::IterableIOSBindings.ITEActionBlock Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::IterableIOSBindings.ITEActionBlock;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDITEActionBlock ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (string arg0)
			{
				var nsarg0 = NSString.CreateNative (arg0);
				
				invoker (blockPtr, nsarg0);
				NSString.ReleaseNative (nsarg0);
				
			}
		} /* class NIDITEActionBlock */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::IterableIOSBindings.OnFailureHandler))]
		internal delegate void DOnFailureHandler (IntPtr block, IntPtr arg0, IntPtr arg1);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDOnFailureHandler {
			static internal readonly DOnFailureHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DOnFailureHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0, IntPtr arg1) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::IterableIOSBindings.OnFailureHandler) (descriptor->Target);
				if (del != null)
					del (NSString.FromHandle (arg0),  Runtime.GetNSObject<NSData> (arg1));
			}
		} /* class SDOnFailureHandler */
		
		internal class NIDOnFailureHandler {
			IntPtr blockPtr;
			DOnFailureHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDOnFailureHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DOnFailureHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDOnFailureHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::IterableIOSBindings.OnFailureHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::IterableIOSBindings.OnFailureHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDOnFailureHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (string arg0, NSData arg1)
			{
				var nsarg0 = NSString.CreateNative (arg0);
				
				invoker (blockPtr, nsarg0, arg1 == null ? IntPtr.Zero : arg1.Handle);
				NSString.ReleaseNative (nsarg0);
				
			}
		} /* class NIDOnFailureHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::IterableIOSBindings.OnSuccessHandler))]
		internal delegate void DOnSuccessHandler (IntPtr block, IntPtr arg0);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDOnSuccessHandler {
			static internal readonly DOnSuccessHandler Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DOnSuccessHandler))]
			static unsafe void Invoke (IntPtr block, IntPtr arg0) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::IterableIOSBindings.OnSuccessHandler) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSDictionary> (arg0));
			}
		} /* class SDOnSuccessHandler */
		
		internal class NIDOnSuccessHandler {
			IntPtr blockPtr;
			DOnSuccessHandler invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDOnSuccessHandler (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DOnSuccessHandler> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDOnSuccessHandler ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::IterableIOSBindings.OnSuccessHandler Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::IterableIOSBindings.OnSuccessHandler;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDOnSuccessHandler ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSDictionary arg0)
			{
				invoker (blockPtr, arg0 == null ? IntPtr.Zero : arg0.Handle);
			}
		} /* class NIDOnSuccessHandler */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::UIKit.UITextField>))]
		internal delegate void DActionArity1V0 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::UIKit.UITextField>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<UITextField> (obj));
			}
		} /* class SDActionArity1V0 */
		
		internal class NIDActionArity1V0 {
			IntPtr blockPtr;
			DActionArity1V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity1V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::UIKit.UITextField> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				if (BlockLiteral.IsManagedBlock (block)) {
					var existing_delegate = ((BlockLiteral *) block)->Target as global::System.Action<global::UIKit.UITextField>;
					if (existing_delegate != null)
						return existing_delegate;
				}
				return new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::UIKit.UITextField obj)
			{
				invoker (blockPtr, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V0 */
	}
}
