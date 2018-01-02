using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace IterableIOSBindings
{

    [Native]
    public enum IterableAlertViewButtonType : ulong
    {
        Filled,
        Bordered
    }

    [Native]
    public enum IterableInAppNotificationLocation : ulong
    {
        Center,
        Bottom,
        Top,
        Full
    }

    [Native]
    public enum IterableAlertViewControllerTransitionStyle : ulong
    {
        Fade,
        SlideFromTop,
        SlideFromBottom
    }

    [Native]
    public enum PushServicePlatform : ulong
    {
        Sandbox,
        Apns
    }

    public enum InappNotificationType : ulong
    {
        Full,
        Top,
        Center,
        Bottom
    }

    static class CFunctions
    {
        // extern void AddStderrOnce ();
        [DllImport("__Internal")]
        static extern void AddStderrOnce();

        // extern void LogError (NSString *format, ...);
        [DllImport("__Internal")]
        static extern void LogError(NSString format, IntPtr varArgs);

        // extern void LogWarning (NSString *format, ...);
        [DllImport("__Internal")]
        static extern void LogWarning(NSString format, IntPtr varArgs);

        // extern void LogNotice (NSString *format, ...);
        [DllImport("__Internal")]
        static extern void LogNotice(NSString format, IntPtr varArgs);

        // extern void LogInfo (NSString *format, ...);
        [DllImport("__Internal")]
        static extern void LogInfo(NSString format, IntPtr varArgs);
    }
}