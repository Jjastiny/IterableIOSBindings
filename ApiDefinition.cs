using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace IterableIOSBindings
{

    // @interface CommerceItem : NSObject
    [BaseType(typeof(NSObject))]
    interface CommerceItem
    {
        // @property (readwrite, nonatomic, strong) NSString * _Nonnull id;
        [Export("id", ArgumentSemantic.Strong)]
        string Id { get; set; }

        // @property (readwrite, nonatomic, strong) NSString * _Nonnull name;
        [Export("name", ArgumentSemantic.Strong)]
        string Name { get; set; }

        // @property (readwrite, nonatomic, strong) NSNumber * _Nonnull price;
        [Export("price", ArgumentSemantic.Strong)]
        NSNumber Price { get; set; }

        // @property (readwrite, nonatomic) NSUInteger quantity;
        [Export("quantity")]
        nuint Quantity { get; set; }

        // -(id _Nonnull)initWithId:(NSString * _Nonnull)id name:(NSString * _Nonnull)name price:(NSNumber * _Nonnull)price quantity:(NSUInteger)quantity;
        [Export("initWithId:name:price:quantity:")]
        IntPtr Constructor(string id, string name, NSNumber price, nuint quantity);

        // -(NSDictionary * _Nonnull)toDictionary;
        [Export("toDictionary")]
        NSDictionary ToDictionary { get; }
    }

    // @interface BackgroundColor (UIButton)
    [Category]
    [BaseType(typeof(UIButton))]
    interface UIButton_BackgroundColor
    {
        // -(void)ITESetButtonBackgroundColor:(UIColor *)color forState:(UIControlState)state;
        [Export("ITESetButtonBackgroundColor:forState:")]
        void ITESetButtonBackgroundColor(UIColor color, UIControlState state);
    }

    // @interface IterableAlertViewButton : UIButton
    [BaseType(typeof(UIButton))]
    interface IterableAlertViewButton
    {
        // @property (nonatomic) IterableAlertViewButtonType type;
        [Export("type", ArgumentSemantic.Assign)]
        IterableAlertViewButtonType Type { get; set; }

        // @property (nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }
    }

    // @interface IterableAlertView : UIView
    [BaseType(typeof(UIView))]
    interface IterableAlertView
    {
        // -(void)setInAppLocation:(IterableInAppNotificationLocation)location;
        [Export("setInAppLocation:")]
        void SetInAppLocation(IterableInAppNotificationLocation location);

        // -(void)updateHorizontalConstraint;
        [Export("updateHorizontalConstraint")]
        void UpdateHorizontalConstraint();

        // @property UILabel * titleLabel;
        [Export("titleLabel", ArgumentSemantic.Assign)]
        UILabel TitleLabel { get; set; }

        // @property UITextView * messageTextView;
        [Export("messageTextView", ArgumentSemantic.Assign)]
        UITextView MessageTextView { get; set; }

        // @property (nonatomic) UIView * contentView;
        [Export("contentView", ArgumentSemantic.Assign)]
        UIView ContentView { get; set; }

        // @property (nonatomic) UIFont * buttonTitleFont;
        [Export("buttonTitleFont", ArgumentSemantic.Assign)]
        UIFont ButtonTitleFont { get; set; }

        // @property (nonatomic) UIFont * cancelButtonTitleFont;
        [Export("cancelButtonTitleFont", ArgumentSemantic.Assign)]
        UIFont CancelButtonTitleFont { get; set; }

        // @property (nonatomic) UIFont * destructiveButtonTitleFont;
        [Export("destructiveButtonTitleFont", ArgumentSemantic.Assign)]
        UIFont DestructiveButtonTitleFont { get; set; }

        // @property (nonatomic) UIColor * buttonColor;
        [Export("buttonColor", ArgumentSemantic.Assign)]
        UIColor ButtonColor { get; set; }

        // @property (nonatomic) UIColor * buttonTitleColor;
        [Export("buttonTitleColor", ArgumentSemantic.Assign)]
        UIColor ButtonTitleColor { get; set; }

        // @property (nonatomic) UIColor * cancelButtonColor;
        [Export("cancelButtonColor", ArgumentSemantic.Assign)]
        UIColor CancelButtonColor { get; set; }

        // @property (nonatomic) UIColor * cancelButtonTitleColor;
        [Export("cancelButtonTitleColor", ArgumentSemantic.Assign)]
        UIColor CancelButtonTitleColor { get; set; }

        // @property (nonatomic) UIColor * destructiveButtonColor;
        [Export("destructiveButtonColor", ArgumentSemantic.Assign)]
        UIColor DestructiveButtonColor { get; set; }

        // @property (nonatomic) UIColor * destructiveButtonTitleColor;
        [Export("destructiveButtonTitleColor", ArgumentSemantic.Assign)]
        UIColor DestructiveButtonTitleColor { get; set; }

        // @property (nonatomic) CGFloat buttonCornerRadius;
        [Export("buttonCornerRadius")]
        nfloat ButtonCornerRadius { get; set; }

        // @property (nonatomic) CGFloat maximumWidth;
        [Export("maximumWidth")]
        nfloat MaximumWidth { get; set; }

        // @property (readonly, nonatomic) UIView * alertBackgroundView;
        [Export("alertBackgroundView")]
        UIView AlertBackgroundView { get; }

        // @property (readonly, nonatomic) NSLayoutConstraint * backgroundViewVerticalCenteringConstraint;
        [Export("backgroundViewVerticalCenteringConstraint")]
        NSLayoutConstraint BackgroundViewVerticalCenteringConstraint { get; }

        // @property (nonatomic) NSArray * actionButtons;
        [Export("actionButtons", ArgumentSemantic.Assign)]
        UIButton[] ActionButtons { get; set; }

        // @property (nonatomic) NSArray * textFields;
        [Export("textFields", ArgumentSemantic.Assign)]
        UITextField[] TextFields { get; set; }
    }

    // @interface IterableConstants : NSObject
    [BaseType(typeof(NSObject))]
    interface IterableConstants
    {
    }

    [Static]
    partial interface Constants
    {
        // extern NSString *const ITBL_KEY_API_KEY;
        [Field("ITBL_KEY_API_KEY", "__Internal")]
        NSString ITBL_KEY_API_KEY { get; }

        // extern NSString *const ITBL_KEY_APPLICATION_NAME;
        [Field("ITBL_KEY_APPLICATION_NAME", "__Internal")]
        NSString ITBL_KEY_APPLICATION_NAME { get; }

        // extern NSString *const ITBL_KEY_CAMPAIGN_ID;
        [Field("ITBL_KEY_CAMPAIGN_ID", "__Internal")]
        NSString ITBL_KEY_CAMPAIGN_ID { get; }

        // extern NSString *const ITBL_KEY_COUNT;
        [Field("ITBL_KEY_COUNT", "__Internal")]
        NSString ITBL_KEY_COUNT { get; }

        // extern NSString *const ITBL_KEY_CURRENT_EMAIL;
        [Field("ITBL_KEY_CURRENT_EMAIL", "__Internal")]
        NSString ITBL_KEY_CURRENT_EMAIL { get; }

        // extern NSString *const ITBL_KEY_DATA_FIELDS;
        [Field("ITBL_KEY_DATA_FIELDS", "__Internal")]
        NSString ITBL_KEY_DATA_FIELDS { get; }

        // extern NSString *const ITBL_KEY_DEVICE;
        [Field("ITBL_KEY_DEVICE", "__Internal")]
        NSString ITBL_KEY_DEVICE { get; }

        // extern NSString *const ITBL_KEY_EMAIL;
        [Field("ITBL_KEY_EMAIL", "__Internal")]
        NSString ITBL_KEY_EMAIL { get; }

        // extern NSString *const ITBL_KEY_EMAIL_LIST_IDS;
        [Field("ITBL_KEY_EMAIL_LIST_IDS", "__Internal")]
        NSString ITBL_KEY_EMAIL_LIST_IDS { get; }

        // extern NSString *const ITBL_KEY_EVENT_NAME;
        [Field("ITBL_KEY_EVENT_NAME", "__Internal")]
        NSString ITBL_KEY_EVENT_NAME { get; }

        // extern NSString *const ITBL_KEY_ITEMS;
        [Field("ITBL_KEY_ITEMS", "__Internal")]
        NSString ITBL_KEY_ITEMS { get; }

        // extern NSString *const ITBL_KEY_MERGE_NESTED;
        [Field("ITBL_KEY_MERGE_NESTED", "__Internal")]
        NSString ITBL_KEY_MERGE_NESTED { get; }

        // extern NSString *const ITBL_KEY_MESSAGE_ID;
        [Field("ITBL_KEY_MESSAGE_ID", "__Internal")]
        NSString ITBL_KEY_MESSAGE_ID { get; }

        // extern NSString *const ITBL_KEY_NEW_EMAIL;
        [Field("ITBL_KEY_NEW_EMAIL", "__Internal")]
        NSString ITBL_KEY_NEW_EMAIL { get; }

        // extern NSString *const ITBL_KEY_PLATFORM;
        [Field("ITBL_KEY_PLATFORM", "__Internal")]
        NSString ITBL_KEY_PLATFORM { get; }

        // extern NSString *const ITBL_KEY_RECIPIENT_EMAIL;
        [Field("ITBL_KEY_RECIPIENT_EMAIL", "__Internal")]
        NSString ITBL_KEY_RECIPIENT_EMAIL { get; }

        // extern NSString *const ITBL_KEY_SDK_VERSION;
        [Field("ITBL_KEY_SDK_VERSION", "__Internal")]
        NSString ITBL_KEY_SDK_VERSION { get; }

        // extern NSString *const ITBL_KEY_SEND_AT;
        [Field("ITBL_KEY_SEND_AT", "__Internal")]
        NSString ITBL_KEY_SEND_AT { get; }

        // extern NSString *const ITBL_KEY_TOKEN;
        [Field("ITBL_KEY_TOKEN", "__Internal")]
        NSString ITBL_KEY_TOKEN { get; }

        // extern NSString *const ITBL_KEY_TEMPLATE_ID;
        [Field("ITBL_KEY_TEMPLATE_ID", "__Internal")]
        NSString ITBL_KEY_TEMPLATE_ID { get; }

        // extern NSString *const ITBL_KEY_TOTAL;
        [Field("ITBL_KEY_TOTAL", "__Internal")]
        NSString ITBL_KEY_TOTAL { get; }

        // extern NSString *const ITBL_KEY_UNSUB_CHANNEL;
        [Field("ITBL_KEY_UNSUB_CHANNEL", "__Internal")]
        NSString ITBL_KEY_UNSUB_CHANNEL { get; }

        // extern NSString *const ITBL_KEY_UNSUB_MESSAGE;
        [Field("ITBL_KEY_UNSUB_MESSAGE", "__Internal")]
        NSString ITBL_KEY_UNSUB_MESSAGE { get; }

        // extern NSString *const ITBL_KEY_USER;
        [Field("ITBL_KEY_USER", "__Internal")]
        NSString ITBL_KEY_USER { get; }

        // extern NSString *const ITBL_KEY_USER_ID;
        [Field("ITBL_KEY_USER_ID", "__Internal")]
        NSString ITBL_KEY_USER_ID { get; }

        // extern NSString *const ITBL_DEVICE_LOCALIZED_MODEL;
        [Field("ITBL_DEVICE_LOCALIZED_MODEL", "__Internal")]
        NSString ITBL_DEVICE_LOCALIZED_MODEL { get; }

        // extern NSString *const ITBL_DEVICE_ID_VENDOR;
        [Field("ITBL_DEVICE_ID_VENDOR", "__Internal")]
        NSString ITBL_DEVICE_ID_VENDOR { get; }

        // extern NSString *const ITBL_DEVICE_MODEL;
        [Field("ITBL_DEVICE_MODEL", "__Internal")]
        NSString ITBL_DEVICE_MODEL { get; }

        // extern NSString *const ITBL_DEVICE_SYSTEM_NAME;
        [Field("ITBL_DEVICE_SYSTEM_NAME", "__Internal")]
        NSString ITBL_DEVICE_SYSTEM_NAME { get; }

        // extern NSString *const ITBL_DEVICE_SYSTEM_VERSION;
        [Field("ITBL_DEVICE_SYSTEM_VERSION", "__Internal")]
        NSString ITBL_DEVICE_SYSTEM_VERSION { get; }

        // extern NSString *const ITBL_DEVICE_USER_INTERFACE;
        [Field("ITBL_DEVICE_USER_INTERFACE", "__Internal")]
        NSString ITBL_DEVICE_USER_INTERFACE { get; }
    }

    // typedef void (^ITEActionBlock)(NSString *);
    delegate void ITEActionBlock(string arg0);

    // @interface IterableNotificationMetadata : NSObject
    [BaseType(typeof(NSObject))]
    interface IterableNotificationMetadata
    {
        // @property (readonly, copy, nonatomic) NSNumber * _Nonnull campaignId;
        [Export("campaignId", ArgumentSemantic.Copy)]
        NSNumber CampaignId { get; }

        // @property (readonly, copy, nonatomic) NSNumber * _Nonnull templateId;
        [Export("templateId", ArgumentSemantic.Copy)]
        NSNumber TemplateId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull messageId;
        [Export("messageId")]
        string MessageId { get; }

        // @property (readonly, nonatomic) BOOL isGhostPush;
        [Export("isGhostPush")]
        bool IsGhostPush { get; }

        // +(instancetype _Nullable)metadataFromLaunchOptions:(NSDictionary * _Nonnull)userInfo;
        [Static]
        [Export("metadataFromLaunchOptions:")]
        [return: NullAllowed]
        IterableNotificationMetadata MetadataFromLaunchOptions(NSDictionary userInfo);

        // +(instancetype _Nullable)metadataFromInAppOptions:(NSString * _Nonnull)messageId;
        [Static]
        [Export("metadataFromInAppOptions:")]
        [return: NullAllowed]
        IterableNotificationMetadata MetadataFromInAppOptions(string messageId);

        // -(BOOL)isProof;
        [Export("isProof")]
        bool IsProof { get; }

        // -(BOOL)isTestPush;
        [Export("isTestPush")]
        bool IsTestPush { get; }

        // -(BOOL)isRealCampaignNotification;
        [Export("isRealCampaignNotification")]
        bool IsRealCampaignNotification { get; }
    }

    // @interface IterableInAppManager : NSObject
    [BaseType(typeof(NSObject))]
    interface IterableInAppManager
    {
        // +(void)showIterableNotification:(NSDictionary *)dialogOptions trackParams:(IterableNotificationMetadata *)trackParams callbackBlock:(ITEActionBlock)callbackBlock;
        [Static]
        [Export("showIterableNotification:trackParams:callbackBlock:")]
        void ShowIterableNotification(NSDictionary dialogOptions, IterableNotificationMetadata trackParams, ITEActionBlock callbackBlock);

        // +(void)showIterableNotificationHTML:(NSString *)htmlString trackParams:(IterableNotificationMetadata *)trackParams callbackBlock:(ITEActionBlock)callbackBlock backgroundAlpha:(double)backgroundAlpha padding:(UIEdgeInsets)padding;
        [Static]
        [Export("showIterableNotificationHTML:trackParams:callbackBlock:backgroundAlpha:padding:")]
        void ShowIterableNotificationHTML(string htmlString, IterableNotificationMetadata trackParams, ITEActionBlock callbackBlock, double backgroundAlpha, UIEdgeInsets padding);

        // +(void)showIterableNotificationHTML:(NSString *)htmlString callbackBlock:(ITEActionBlock)callbackBlock;
        [Static]
        [Export("showIterableNotificationHTML:callbackBlock:")]
        void ShowIterableNotificationHTML(string htmlString, ITEActionBlock callbackBlock);

        // +(void)showSystemNotification:(NSString *)title body:(NSString *)body buttonLeft:(NSString *)buttonLeft buttonRight:(NSString *)buttonRight callbackBlock:(ITEActionBlock)callbackBlock;
        [Static]
        [Export("showSystemNotification:body:buttonLeft:buttonRight:callbackBlock:")]
        void ShowSystemNotification(string title, string body, string buttonLeft, string buttonRight, ITEActionBlock callbackBlock);

        // +(NSDictionary *)getNextMessageFromPayload:(NSDictionary *)payload;
        [Static]
        [Export("getNextMessageFromPayload:")]
        NSDictionary GetNextMessageFromPayload(NSDictionary payload);

        // +(int)getIntColorFromKey:(NSDictionary *)payload keyString:(NSString *)keyString;
        [Static]
        [Export("getIntColorFromKey:keyString:")]
        int GetIntColorFromKey(NSDictionary payload, string keyString);

        // +(UIEdgeInsets)getPaddingFromPayload:(NSDictionary *)payload;
        [Static]
        [Export("getPaddingFromPayload:")]
        UIEdgeInsets GetPaddingFromPayload(NSDictionary payload);

        // +(int)decodePadding:(NSObject *)value;
        [Static]
        [Export("decodePadding:")]
        int DecodePadding(NSObject value);
    }

    // @interface IterableInAppBaseViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface IterableInAppBaseViewController
    {
        // -(void)ITEActionButtonClicked:(UIButton *)sender;
        [Export("ITEActionButtonClicked:")]
        void ITEActionButtonClicked(UIButton sender);

        // -(void)ITEAddActionButton:(NSInteger)id actionString:(NSString *)actionString;
        [Export("ITEAddActionButton:actionString:")]
        void ITEAddActionButton(nint id, string actionString);

        // -(void)ITESetCallback:(ITEActionBlock)callbackBlock;
        [Export("ITESetCallback:")]
        void ITESetCallback(ITEActionBlock callbackBlock);

        // -(void)ITESetData:(NSDictionary *)jsonPayload;
        [Export("ITESetData:")]
        void ITESetData(NSDictionary jsonPayload);

        // -(void)ITESetTrackParams:(IterableNotificationMetadata *)trackParams;
        [Export("ITESetTrackParams:")]
        void ITESetTrackParams(IterableNotificationMetadata trackParams);
    }

    // @interface IterableAlertAction : NSObject
    [BaseType(typeof(NSObject))]
    interface IterableAlertAction
    {
        // +(instancetype)actionWithTitle:(NSString *)title style:(UIAlertActionStyle)style actionName:(NSString *)actionName;
        [Static]
        [Export("actionWithTitle:style:actionName:")]
        IterableAlertAction ActionWithTitle(string title, UIAlertActionStyle style, string actionName);

        // @property (nonatomic) NSString * title;
        [Export("title")]
        string Title { get; set; }

        // @property (nonatomic) UIAlertActionStyle style;
        [Export("style", ArgumentSemantic.Assign)]
        UIAlertActionStyle Style { get; set; }

        // @property (nonatomic) NSString * actionName;
        [Export("actionName")]
        string ActionName { get; set; }

        // @property (nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { get; set; }
    }

    // @interface IterableAlertViewController : IterableInAppBaseViewController
    [BaseType(typeof(IterableInAppBaseViewController))]
    interface IterableAlertViewController
    {
        // +(instancetype)alertControllerWithTitle:(NSString *)title message:(NSString *)message;
        [Static]
        [Export("alertControllerWithTitle:message:")]
        IterableAlertViewController AlertControllerWithTitle(string title, string message);

        // -(void)ITESetData:(NSDictionary *)jsonPayload;
        [Export("ITESetData:")]
        void ITESetData(NSDictionary jsonPayload);

        // @property (nonatomic) NSString * message;
        [Export("message")]
        string Message { get; set; }

        // @property (nonatomic) BOOL showsStatusBar;
        [Export("showsStatusBar")]
        bool ShowsStatusBar { get; set; }

        // @property (nonatomic) UIView * alertViewContentView;
        [Export("alertViewContentView", ArgumentSemantic.Assign)]
        UIView AlertViewContentView { get; set; }

        // @property (nonatomic) IterableAlertViewControllerTransitionStyle transitionStyle;
        [Export("transitionStyle", ArgumentSemantic.Assign)]
        IterableAlertViewControllerTransitionStyle TransitionStyle { get; set; }

        // @property (nonatomic) BOOL backgroundTapDismissalGestureEnabled;
        [Export("backgroundTapDismissalGestureEnabled")]
        bool BackgroundTapDismissalGestureEnabled { get; set; }

        // @property (nonatomic) BOOL swipeDismissalGestureEnabled;
        [Export("swipeDismissalGestureEnabled")]
        bool SwipeDismissalGestureEnabled { get; set; }

        // @property (nonatomic) UIColor * alertViewBackgroundColor;
        [Export("alertViewBackgroundColor", ArgumentSemantic.Assign)]
        UIColor AlertViewBackgroundColor { get; set; }

        // @property (nonatomic) CGFloat maximumWidth;
        [Export("maximumWidth")]
        nfloat MaximumWidth { get; set; }

        // @property (nonatomic) UIFont * titleFont;
        [Export("titleFont", ArgumentSemantic.Assign)]
        UIFont TitleFont { get; set; }

        // @property (nonatomic) UIFont * messageFont;
        [Export("messageFont", ArgumentSemantic.Assign)]
        UIFont MessageFont { get; set; }

        // @property (nonatomic) UIFont * buttonTitleFont;
        [Export("buttonTitleFont", ArgumentSemantic.Assign)]
        UIFont ButtonTitleFont { get; set; }

        // @property (nonatomic) UIFont * cancelButtonTitleFont;
        [Export("cancelButtonTitleFont", ArgumentSemantic.Assign)]
        UIFont CancelButtonTitleFont { get; set; }

        // @property (nonatomic) UIFont * destructiveButtonTitleFont;
        [Export("destructiveButtonTitleFont", ArgumentSemantic.Assign)]
        UIFont DestructiveButtonTitleFont { get; set; }

        // @property (nonatomic) UIColor * titleColor;
        [Export("titleColor", ArgumentSemantic.Assign)]
        UIColor TitleColor { get; set; }

        // @property (nonatomic) UIColor * messageColor;
        [Export("messageColor", ArgumentSemantic.Assign)]
        UIColor MessageColor { get; set; }

        // @property (nonatomic) UIColor * buttonColor;
        [Export("buttonColor", ArgumentSemantic.Assign)]
        UIColor ButtonColor { get; set; }

        // @property (nonatomic) UIColor * cancelButtonColor;
        [Export("cancelButtonColor", ArgumentSemantic.Assign)]
        UIColor CancelButtonColor { get; set; }

        // @property (nonatomic) UIColor * destructiveButtonColor;
        [Export("destructiveButtonColor", ArgumentSemantic.Assign)]
        UIColor DestructiveButtonColor { get; set; }

        // @property (nonatomic) UIColor * disabledButtonColor;
        [Export("disabledButtonColor", ArgumentSemantic.Assign)]
        UIColor DisabledButtonColor { get; set; }

        // @property (nonatomic) UIColor * buttonTitleColor;
        [Export("buttonTitleColor", ArgumentSemantic.Assign)]
        UIColor ButtonTitleColor { get; set; }

        // @property (nonatomic) UIColor * cancelButtonTitleColor;
        [Export("cancelButtonTitleColor", ArgumentSemantic.Assign)]
        UIColor CancelButtonTitleColor { get; set; }

        // @property (nonatomic) UIColor * destructiveButtonTitleColor;
        [Export("destructiveButtonTitleColor", ArgumentSemantic.Assign)]
        UIColor DestructiveButtonTitleColor { get; set; }

        // @property (nonatomic) UIColor * disabledButtonTitleColor;
        [Export("disabledButtonTitleColor", ArgumentSemantic.Assign)]
        UIColor DisabledButtonTitleColor { get; set; }

        // @property (nonatomic) CGFloat alertViewCornerRadius;
        [Export("alertViewCornerRadius")]
        nfloat AlertViewCornerRadius { get; set; }

        // @property (nonatomic) CGFloat buttonCornerRadius;
        [Export("buttonCornerRadius")]
        nfloat ButtonCornerRadius { get; set; }

        // @property (nonatomic) CGFloat startingDimmingBackgroundAlpha;
        [Export("startingDimmingBackgroundAlpha")]
        nfloat StartingDimmingBackgroundAlpha { get; set; }

        // @property (readonly, nonatomic) NSArray * actions;
        [Export("actions")]
        IterableAlertAction[] Actions { get; }

        // @property (readonly, nonatomic) NSArray * textFields;
        [Export("textFields")]
        UITextField[] TextFields { get; }

        // @property (nonatomic) CGFloat contentImageWidth;
        [Export("contentImageWidth")]
        nfloat ContentImageWidth { get; set; }

        // @property (nonatomic) CGFloat contentImageHeight;
        [Export("contentImageHeight")]
        nfloat ContentImageHeight { get; set; }

        // -(void)addAction:(IterableAlertAction *)action;
        [Export("addAction:")]
        void AddAction(IterableAlertAction action);

        // -(void)addTextFieldWithConfigurationHandler:(void (^)(UITextField *))configurationHandler;
        [Export("addTextFieldWithConfigurationHandler:")]
        void AddTextFieldWithConfigurationHandler(Action<UITextField> configurationHandler);
    }

    // typedef void (^OnSuccessHandler)(NSDictionary * _Nonnull);
    delegate void OnSuccessHandler(NSDictionary arg0);

    // typedef void (^OnFailureHandler)(NSString * _Nonnull, NSData * _Nullable);
    delegate void OnFailureHandler(string arg0, [NullAllowed] NSData arg1);

    // @interface IterableAPI : NSObject
    [BaseType(typeof(NSObject))]
    interface IterableAPI
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull apiKey;
        [Export("apiKey")]
        string ApiKey { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull email;
        [Export("email")]
        string Email { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull userId;
        [Export("userId")]
        string UserId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull hexToken;
        [Export("hexToken")]
        string HexToken { get; }

        // -(instancetype _Nonnull)initWithApiKey:(NSString * _Nonnull)apiKey andEmail:(NSString * _Nonnull)email launchOptions:(NSDictionary * _Nullable)launchOptions useCustomLaunchOptions:(BOOL)useCustomLaunchOptions;
        [Export("initWithApiKey:andEmail:launchOptions:useCustomLaunchOptions:")]
        IntPtr Constructor(string apiKey, string email, [NullAllowed] NSDictionary launchOptions, bool useCustomLaunchOptions);

        // -(instancetype _Nonnull)initWithApiKey:(NSString * _Nonnull)apiKey andUserId:(NSString * _Nonnull)userId;
        [Export("initWithApiKey:andUserId:")]
        IntPtr Constructor(string apiKey, string userId);

        // -(instancetype _Nonnull)initWithApiKey:(NSString * _Nonnull)apiKey andUserId:(NSString * _Nonnull)userId launchOptions:(NSDictionary * _Nullable)launchOptions;
        [Export("initWithApiKey:andUserId:launchOptions:")]
        IntPtr Constructor(string apiKey, string userId, [NullAllowed] NSDictionary launchOptions);

        // -(instancetype _Nonnull)initWithApiKey:(NSString * _Nonnull)apiKey andUserId:(NSString * _Nonnull)userId launchOptions:(NSDictionary * _Nullable)launchOptions useCustomLaunchOptions:(BOOL)useCustomLaunchOptions;
        [Export("initWithApiKey:andUserId:launchOptions:useCustomLaunchOptions:")]
        IntPtr Constructor(string apiKey, [NullAllowed] NSDictionary launchOptions, bool useCustomLaunchOptions, string userId);

        // +(IterableAPI * _Nonnull)sharedInstanceWithApiKey:(NSString * _Nonnull)apiKey andUserId:(NSString * _Nonnull)userId launchOptions:(NSDictionary * _Nullable)launchOptions;
        [Static]
        [Export("sharedInstanceWithApiKey:andUserId:launchOptions:")]
        IterableAPI SharedInstanceWithApiKey(string apiKey, [NullAllowed] NSDictionary launchOptions, string userId);

        // +(IterableAPI * _Nonnull)sharedInstanceWithApiKey:(NSString * _Nonnull)apiKey andEmail:(NSString * _Nonnull)email launchOptions:(NSDictionary * _Nullable)launchOptions;
        [Static]
        [Export("sharedInstanceWithApiKey:andEmail:launchOptions:")]
        IterableAPI SharedInstanceWithApiKey(string apiKey, string email, [NullAllowed] NSDictionary launchOptions);

        // +(IterableAPI * _Nullable)sharedInstance;
        [Static]
        [NullAllowed, Export("sharedInstance")]
        IterableAPI SharedInstance { get; }

        // +(void)clearSharedInstance;
        [Static]
        [Export("clearSharedInstance")]
        void ClearSharedInstance();

        // -(void)registerToken:(NSData * _Nonnull)token appName:(NSString * _Nonnull)appName pushServicePlatform:(PushServicePlatform)pushServicePlatform;
        [Export("registerToken:appName:pushServicePlatform:")]
        void RegisterToken(NSData token, string appName, PushServicePlatform pushServicePlatform);

        // -(void)registerToken:(NSData * _Nonnull)token appName:(NSString * _Nonnull)appName pushServicePlatform:(PushServicePlatform)pushServicePlatform onSuccess:(OnSuccessHandler _Nonnull)onSuccess onFailure:(OnFailureHandler _Nonnull)onFailure;
        [Export("registerToken:appName:pushServicePlatform:onSuccess:onFailure:")]
        void RegisterToken(NSData token, string appName, PushServicePlatform pushServicePlatform, OnSuccessHandler onSuccess, OnFailureHandler onFailure);

        // -(void)disableDeviceForCurrentUser;
        [Export("disableDeviceForCurrentUser")]
        void DisableDeviceForCurrentUser();

        // -(void)disableDeviceForAllUsers;
        [Export("disableDeviceForAllUsers")]
        void DisableDeviceForAllUsers();

        // -(void)disableDeviceForCurrentUserWithOnSuccess:(OnSuccessHandler _Nonnull)onSuccess onFailure:(OnFailureHandler _Nonnull)onFailure;
        [Export("disableDeviceForCurrentUserWithOnSuccess:onFailure:")]
        void DisableDeviceForCurrentUserWithOnSuccess(OnSuccessHandler onSuccess, OnFailureHandler onFailure);

        // -(void)disableDeviceForAllUsersWithOnSuccess:(OnSuccessHandler _Nonnull)onSuccess onFailure:(OnFailureHandler _Nonnull)onFailure;
        [Export("disableDeviceForAllUsersWithOnSuccess:onFailure:")]
        void DisableDeviceForAllUsersWithOnSuccess(OnSuccessHandler onSuccess, OnFailureHandler onFailure);

        // -(void)updateUser:(NSDictionary * _Nonnull)dataFields mergeNestedObjects:(BOOL)mergeNestedObjects onSuccess:(OnSuccessHandler _Nonnull)onSuccess onFailure:(OnFailureHandler _Nonnull)onFailure;
        [Export("updateUser:mergeNestedObjects:onSuccess:onFailure:")]
        void UpdateUser(NSDictionary dataFields, bool mergeNestedObjects, OnSuccessHandler onSuccess, OnFailureHandler onFailure);

        // -(void)trackPurchase:(NSNumber * _Nonnull)total items:(NSArray<CommerceItem *> * _Nonnull)items;
        [Export("trackPurchase:items:")]
        void TrackPurchase(NSNumber total, CommerceItem[] items);

        // -(void)trackPurchase:(NSNumber * _Nonnull)total items:(NSArray<CommerceItem *> * _Nonnull)items dataFields:(NSDictionary * _Nullable)dataFields;
        [Export("trackPurchase:items:dataFields:")]
        void TrackPurchase(NSNumber total, CommerceItem[] items, [NullAllowed] NSDictionary dataFields);

        // -(void)trackPurchase:(NSNumber * _Nonnull)total items:(NSArray<CommerceItem *> * _Nonnull)items dataFields:(NSDictionary * _Nullable)dataFields onSuccess:(OnSuccessHandler _Nonnull)onSuccess onFailure:(OnFailureHandler _Nonnull)onFailure;
        [Export("trackPurchase:items:dataFields:onSuccess:onFailure:")]
        void TrackPurchase(NSNumber total, CommerceItem[] items, [NullAllowed] NSDictionary dataFields, OnSuccessHandler onSuccess, OnFailureHandler onFailure);

        // -(void)trackPushOpen:(NSDictionary * _Nonnull)userInfo;
        [Export("trackPushOpen:")]
        void TrackPushOpen(NSDictionary userInfo);

        // -(void)trackPushOpen:(NSDictionary * _Nonnull)userInfo dataFields:(NSDictionary * _Nullable)dataFields;
        [Export("trackPushOpen:dataFields:")]
        void TrackPushOpen(NSDictionary userInfo, [NullAllowed] NSDictionary dataFields);

        // -(void)trackPushOpen:(NSDictionary * _Nonnull)userInfo dataFields:(NSDictionary * _Nullable)dataFields onSuccess:(OnSuccessHandler _Nonnull)onSuccess onFailure:(OnFailureHandler _Nonnull)onFailure;
        [Export("trackPushOpen:dataFields:onSuccess:onFailure:")]
        void TrackPushOpen(NSDictionary userInfo, [NullAllowed] NSDictionary dataFields, OnSuccessHandler onSuccess, OnFailureHandler onFailure);

        // -(void)trackPushOpen:(NSNumber * _Nonnull)campaignId templateId:(NSNumber * _Nonnull)templateId messageId:(NSString * _Nonnull)messageId appAlreadyRunning:(BOOL)appAlreadyRunning dataFields:(NSDictionary * _Nullable)dataFields;
        [Export("trackPushOpen:templateId:messageId:appAlreadyRunning:dataFields:")]
        void TrackPushOpen(NSNumber campaignId, NSNumber templateId, string messageId, bool appAlreadyRunning, [NullAllowed] NSDictionary dataFields);

        // -(void)trackPushOpen:(NSNumber * _Nonnull)campaignId templateId:(NSNumber * _Nonnull)templateId messageId:(NSString * _Nonnull)messageId appAlreadyRunning:(BOOL)appAlreadyRunning dataFields:(NSDictionary * _Nullable)dataFields onSuccess:(OnSuccessHandler _Nonnull)onSuccess onFailure:(OnFailureHandler _Nonnull)onFailure;
        [Export("trackPushOpen:templateId:messageId:appAlreadyRunning:dataFields:onSuccess:onFailure:")]
        void TrackPushOpen(NSNumber campaignId, NSNumber templateId, string messageId, bool appAlreadyRunning, [NullAllowed] NSDictionary dataFields, OnSuccessHandler onSuccess, OnFailureHandler onFailure);

        // -(void)track:(NSString * _Nonnull)eventName;
        [Export("track:")]
        void Track(string eventName);

        // -(void)track:(NSString * _Nonnull)eventName dataFields:(NSDictionary * _Nullable)dataFields;
        [Export("track:dataFields:")]
        void Track(string eventName, [NullAllowed] NSDictionary dataFields);

        // -(void)track:(NSString * _Nonnull)eventName dataFields:(NSDictionary * _Nullable)dataFields onSuccess:(OnSuccessHandler _Nonnull)onSuccess onFailure:(OnFailureHandler _Nonnull)onFailure;
        [Export("track:dataFields:onSuccess:onFailure:")]
        void Track(string eventName, [NullAllowed] NSDictionary dataFields, OnSuccessHandler onSuccess, OnFailureHandler onFailure);

        // -(void)updateSubscriptions:(NSArray * _Nullable)emailListIds unsubscribedChannelIds:(NSArray * _Nullable)unsubscribedChannelIds unsubscribedMessageTypeIds:(NSArray * _Nullable)unsubscribedMessageTypeIds;
        [Export("updateSubscriptions:unsubscribedChannelIds:unsubscribedMessageTypeIds:")]
        void UpdateSubscriptions([NullAllowed] NSNumber[] emailListIds, [NullAllowed] NSNumber[] unsubscribedChannelIds, [NullAllowed] NSNumber[] unsubscribedMessageTypeIds);

        // -(void)spawnInAppNotification:(ITEActionBlock _Nonnull)callbackBlock;
        [Export("spawnInAppNotification:")]
        void SpawnInAppNotification(ITEActionBlock callbackBlock);

        // -(void)getInAppMessages:(NSNumber * _Nonnull)count;
        [Export("getInAppMessages:")]
        void GetInAppMessages(NSNumber count);

        // -(void)getInAppMessages:(NSNumber * _Nonnull)count onSuccess:(OnSuccessHandler _Nonnull)onSuccess onFailure:(OnFailureHandler _Nonnull)onFailure;
        [Export("getInAppMessages:onSuccess:onFailure:")]
        void GetInAppMessages(NSNumber count, OnSuccessHandler onSuccess, OnFailureHandler onFailure);

        // -(void)trackInAppOpen:(NSString * _Nonnull)messageId;
        [Export("trackInAppOpen:")]
        void TrackInAppOpen(string messageId);

        // -(void)trackInAppClick:(NSString * _Nonnull)messageId buttonIndex:(NSNumber * _Nonnull)buttonIndex;
        [Export("trackInAppClick:buttonIndex:")]
        void TrackInAppClick(string messageId, NSNumber buttonIndex);

        // -(void)trackInAppClick:(NSString * _Nonnull)messageId buttonURL:(NSString * _Nonnull)buttonURL;
        [Export("trackInAppClick:buttonURL:")]
        void TrackInAppClick(string messageId, string buttonURL);

        // -(void)inAppConsume:(NSString * _Nonnull)messageId;
        [Export("inAppConsume:")]
        void InAppConsume(string messageId);

        // -(void)showSystemNotification:(NSString * _Nonnull)title body:(NSString * _Nonnull)body button:(NSString * _Nonnull)button callbackBlock:(ITEActionBlock _Nonnull)callbackBlock;
        [Export("showSystemNotification:body:button:callbackBlock:")]
        void ShowSystemNotification(string title, string body, string button, ITEActionBlock callbackBlock);

        // -(void)showSystemNotification:(NSString * _Nonnull)title body:(NSString * _Nonnull)body buttonLeft:(NSString * _Nonnull)buttonLeft buttonRight:(NSString * _Nonnull)buttonRight callbackBlock:(ITEActionBlock _Nonnull)callbackBlock;
        [Export("showSystemNotification:body:buttonLeft:buttonRight:callbackBlock:")]
        void ShowSystemNotification(string title, string body, string buttonLeft, string buttonRight, ITEActionBlock callbackBlock);

        // +(void)getAndTrackDeeplink:(NSURL * _Nonnull)webpageURL callbackBlock:(ITEActionBlock _Nonnull)callbackBlock;
        [Static]
        [Export("getAndTrackDeeplink:callbackBlock:")]
        void GetAndTrackDeeplink(NSUrl webpageURL, ITEActionBlock callbackBlock);
    }

    // @interface IterableDeeplinkManager : NSObject
    [BaseType(typeof(NSObject))]
    interface IterableDeeplinkManager
    {
        // +(instancetype)instance;
        [Static]
        [Export("instance")]
        IterableDeeplinkManager Instance();

        // -(void)getAndTrackDeeplink:(NSURL *)webpageURL callbackBlock:(ITEActionBlock)callbackBlock;
        [Export("getAndTrackDeeplink:callbackBlock:")]
        void GetAndTrackDeeplink(NSUrl webpageURL, ITEActionBlock callbackBlock);
    }

    // @interface IterableFullScreenViewController : IterableInAppBaseViewController
    [BaseType(typeof(IterableInAppBaseViewController))]
    interface IterableFullScreenViewController
    {
        // -(void)ITESetData:(NSDictionary *)jsonPayload;
        [Export("ITESetData:")]
        void ITESetData(NSDictionary jsonPayload);
    }

    // @interface IterableInAppHTMLViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface IterableInAppHTMLViewController
    {
        // -(IterableInAppHTMLViewController *)initWithData:(id)htmlString;
        [Export("initWithData:")]
        IntPtr Constructor(NSObject htmlString);

        // -(void)ITESetPadding:(UIEdgeInsets)insetPadding;
        [Export("ITESetPadding:")]
        void ITESetPadding(UIEdgeInsets insetPadding);

        // -(void)ITESetCallback:(ITEActionBlock)callbackBlock;
        [Export("ITESetCallback:")]
        void ITESetCallback(ITEActionBlock callbackBlock);

        // -(void)ITESetTrackParams:(IterableNotificationMetadata *)trackParams;
        [Export("ITESetTrackParams:")]
        void ITESetTrackParams(IterableNotificationMetadata trackParams);

        // -(NSString *)getHtml;
        [Export("getHtml")]
        string Html { get; }

        // +(INAPP_NOTIFICATION_TYPE)setLocation:(UIEdgeInsets)insetPadding;
        [Static]
        [Export("setLocation:")]
        InappNotificationType SetLocation(UIEdgeInsets insetPadding);
    }

    // @interface NSData_Conversion (NSData)
    [Category]
    [BaseType(typeof(NSData))]
    interface NSData_NSData_Conversion
    {
        // -(NSString *)ITEHexadecimalString;
        [Export("ITEHexadecimalString")]
        [Static]
        string ITEHexadecimalString { get; }
    }

    partial interface Constants
    {
        // extern double IterableSDKVersionNumber;
        [Field("IterableSDKVersionNumber", "__Internal")]
        double IterableSDKVersionNumber { get; }

        // extern const unsigned char [] IterableSDKVersionString;
        [Field("IterableSDKVersionString", "__Internal")]
        IntPtr IterableSDKVersionString { get; }
    }
}
