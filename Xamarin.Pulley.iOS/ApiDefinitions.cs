using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Xamarin.Pulley.iOS {
    // @protocol PulleyDelegate
    [Protocol]
    [BaseType(typeof(NSObject), Name = "_TtP6Pulley14PulleyDelegate_")]
    interface PulleyDelegate {
        // @optional -(void)drawerPositionDidChangeWithDrawer:(PulleyViewController * _Nonnull)drawer;
        [Export("drawerPositionDidChangeWithDrawer:")]
        void DrawerPositionDidChangeWithDrawer(PulleyViewController drawer);

        // @optional -(void)makeUIAdjustmentsForFullscreenWithProgress:(CGFloat)progress;
        [Export("makeUIAdjustmentsForFullscreenWithProgress:")]
        void MakeUIAdjustmentsForFullscreenWithProgress(nfloat progress);

        // @optional -(void)drawerChangedDistanceFromBottomWithDrawer:(PulleyViewController * _Nonnull)drawer distance:(CGFloat)distance;
        [Export("drawerChangedDistanceFromBottomWithDrawer:distance:")]
        void DrawerChangedDistanceFromBottomWithDrawer(PulleyViewController drawer, nfloat distance);
    }

    // @protocol PulleyDrawerViewControllerDelegate <PulleyDelegate>
    [Protocol]
    [BaseType(typeof(NSObject), Name = "_TtP6Pulley34PulleyDrawerViewControllerDelegate_")]
    interface PulleyDrawerViewControllerDelegate : PulleyDelegate {
        // @required -(CGFloat)collapsedDrawerHeight __attribute__((warn_unused_result));
        [Abstract]
        [Export("collapsedDrawerHeight")]
        nfloat CollapsedDrawerHeight { get; }

        // @required -(CGFloat)partialRevealDrawerHeight __attribute__((warn_unused_result));
        [Abstract]
        [Export("partialRevealDrawerHeight")]
        nfloat PartialRevealDrawerHeight { get; }

        // @required -(NSArray<NSNumber *> * _Nonnull)supportedDrawerPositions __attribute__((warn_unused_result));
        [Abstract]
        [Export("supportedDrawerPositions")]
        NSNumber[] SupportedDrawerPositions { get; }
    }

    // @protocol PulleyPrimaryContentControllerDelegate <PulleyDelegate>
    [Protocol]
    [BaseType(typeof(NSObject), Name = "_TtP6Pulley38PulleyPrimaryContentControllerDelegate_")]
    interface PulleyPrimaryContentControllerDelegate : PulleyDelegate {
    }

    // @interface PulleyViewController : UIViewController
    [BaseType(typeof(UIViewController), Name = "_TtC6Pulley20PulleyViewController")]
    interface PulleyViewController {
        // @property (nonatomic, strong) UIView * _Null_unspecified primaryContentContainerView __attribute__((iboutlet));
        [Export("primaryContentContainerView", ArgumentSemantic.Strong)]
        UIView PrimaryContentContainerView { get; set; }

        // @property (nonatomic, strong) UIView * _Null_unspecified drawerContentContainerView __attribute__((iboutlet));
        [Export("drawerContentContainerView", ArgumentSemantic.Strong)]
        UIView DrawerContentContainerView { get; set; }

        // @property (readonly, nonatomic, strong) UIViewController * _Null_unspecified primaryContentViewController;
        [Export("primaryContentViewController", ArgumentSemantic.Strong)]
        UIViewController PrimaryContentViewController { get; }

        // @property (readonly, nonatomic, strong) UIViewController * _Null_unspecified drawerContentViewController;
        [Export("drawerContentViewController", ArgumentSemantic.Strong)]
        UIViewController DrawerContentViewController { get; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        PulleyDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<PulleyDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic) enum PulleyPosition drawerPosition;
        [Export("drawerPosition")]
        PulleyPosition DrawerPosition { get; }

        // @property (readonly, nonatomic) CGFloat visibleDrawerHeight;
        [Export("visibleDrawerHeight")]
        nfloat VisibleDrawerHeight { get; }

        // @property (nonatomic, strong) UIVisualEffectView * _Nullable drawerBackgroundVisualEffectView;
        [NullAllowed, Export("drawerBackgroundVisualEffectView", ArgumentSemantic.Strong)]
        UIVisualEffectView DrawerBackgroundVisualEffectView { get; set; }

        // @property (nonatomic) CGFloat topInset;
        [Export("topInset")]
        nfloat TopInset { get; set; }

        // @property (nonatomic) CGFloat drawerCornerRadius;
        [Export("drawerCornerRadius")]
        nfloat DrawerCornerRadius { get; set; }

        // @property (nonatomic) float shadowOpacity;
        [Export("shadowOpacity")]
        float ShadowOpacity { get; set; }

        // @property (nonatomic) CGFloat shadowRadius;
        [Export("shadowRadius")]
        nfloat ShadowRadius { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull backgroundDimmingColor;
        [Export("backgroundDimmingColor", ArgumentSemantic.Strong)]
        UIColor BackgroundDimmingColor { get; set; }

        // @property (nonatomic) CGFloat backgroundDimmingOpacity;
        [Export("backgroundDimmingOpacity")]
        nfloat BackgroundDimmingOpacity { get; set; }

        // @property (nonatomic) enum PulleyPosition initialDrawerPosition;
        [Export("initialDrawerPosition", ArgumentSemantic.Assign)]
        PulleyPosition InitialDrawerPosition { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable initialDrawerPositionFromIB;
        [NullAllowed, Export("initialDrawerPositionFromIB")]
        string InitialDrawerPositionFromIB { get; set; }

        // @property (nonatomic) BOOL allowsUserDrawerPositionChange;
        [Export("allowsUserDrawerPositionChange")]
        bool AllowsUserDrawerPositionChange { get; set; }

        // -(instancetype _Nonnull)initWithContentViewController:(UIViewController * _Nonnull)contentViewController drawerViewController:(UIViewController * _Nonnull)drawerViewController __attribute__((objc_designated_initializer));
        [Export("initWithContentViewController:drawerViewController:")]
        [DesignatedInitializer]
        IntPtr Constructor(UIViewController contentViewController, UIViewController drawerViewController);

        // -(void)loadView;
        [Export("loadView")]
        void LoadView();

        // -(void)viewDidLoad;
        [Export("viewDidLoad")]
        void ViewDidLoad();

        // -(void)viewDidAppear:(BOOL)animated;
        [Export("viewDidAppear:")]
        void ViewDidAppear(bool animated);

        // -(void)viewDidLayoutSubviews;
        [Export("viewDidLayoutSubviews")]
        void ViewDidLayoutSubviews();

        // -(void)didReceiveMemoryWarning;
        [Export("didReceiveMemoryWarning")]
        void DidReceiveMemoryWarning();

        // -(void)setDrawerPositionWithPosition:(enum PulleyPosition)position animated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
        [Export("setDrawerPositionWithPosition:animated:completion:")]
        void SetDrawerPositionWithPosition(PulleyPosition position, bool animated, [NullAllowed] Action<bool> completion);

        // -(void)setDrawerPositionWithPosition:(enum PulleyPosition)position;
        [Export("setDrawerPositionWithPosition:")]
        void SetDrawerPositionWithPosition(PulleyPosition position);

        // -(void)setPrimaryContentViewControllerWithController:(UIViewController * _Nonnull)controller animated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
        [Export("setPrimaryContentViewControllerWithController:animated:completion:")]
        void SetPrimaryContentViewControllerWithController(UIViewController controller, bool animated, [NullAllowed] Action<bool> completion);

        // -(void)setPrimaryContentViewControllerWithController:(UIViewController * _Nonnull)controller animated:(BOOL)animated;
        [Export("setPrimaryContentViewControllerWithController:animated:")]
        void SetPrimaryContentViewControllerWithController(UIViewController controller, bool animated);

        // -(void)setDrawerContentViewControllerWithController:(UIViewController * _Nonnull)controller animated:(BOOL)animated completion:(void (^ _Nullable)(BOOL))completion;
        [Export("setDrawerContentViewControllerWithController:animated:completion:")]
        void SetDrawerContentViewControllerWithController(UIViewController controller, bool animated, [NullAllowed] Action<bool> completion);

        // -(void)setDrawerContentViewControllerWithController:(UIViewController * _Nonnull)controller animated:(BOOL)animated;
        [Export("setDrawerContentViewControllerWithController:animated:")]
        void SetDrawerContentViewControllerWithController(UIViewController controller, bool animated);

        // -(void)setNeedsSupportedDrawerPositionsUpdate;
        [Export("setNeedsSupportedDrawerPositionsUpdate")]
        void SetNeedsSupportedDrawerPositionsUpdate();

        // @property (readonly, nonatomic, strong) UIViewController * _Nullable childViewControllerForStatusBarStyle;
        [NullAllowed, Export("childViewControllerForStatusBarStyle", ArgumentSemantic.Strong)]
        UIViewController ChildViewControllerForStatusBarStyle { get; }

        // @property (readonly, nonatomic, strong) UIViewController * _Nullable childViewControllerForStatusBarHidden;
        [NullAllowed, Export("childViewControllerForStatusBarHidden", ArgumentSemantic.Strong)]
        UIViewController ChildViewControllerForStatusBarHidden { get; }

        // -(void)scrollViewDidEndDragging:(UIScrollView * _Nonnull)scrollView willDecelerate:(BOOL)decelerate;
        [Export("scrollViewDidEndDragging:willDecelerate:")]
        void ScrollViewDidEndDragging(UIScrollView scrollView, bool decelerate);

        // -(void)scrollViewWillEndDragging:(UIScrollView * _Nonnull)scrollView withVelocity:(CGPoint)velocity targetContentOffset:(CGPoint * _Nonnull)targetContentOffset;
        [Export("scrollViewWillEndDragging:withVelocity:targetContentOffset:")]
        unsafe void ScrollViewWillEndDragging(UIScrollView scrollView, CGPoint velocity, CGPoint targetContentOffset);

        // -(void)scrollViewDidScroll:(UIScrollView * _Nonnull)scrollView;
        [Export("scrollViewDidScroll:")]
        void ScrollViewDidScroll(UIScrollView scrollView);

        // -(CGFloat)collapsedDrawerHeight __attribute__((warn_unused_result));
        [Export("collapsedDrawerHeight")]
        nfloat CollapsedDrawerHeight { get; }

        // -(CGFloat)partialRevealDrawerHeight __attribute__((warn_unused_result));
        [Export("partialRevealDrawerHeight")]
        nfloat PartialRevealDrawerHeight { get; }

        // -(NSArray<NSNumber *> * _Nonnull)supportedDrawerPositions __attribute__((warn_unused_result));
        [Export("supportedDrawerPositions")]
        NSNumber[] SupportedDrawerPositions { get; }

        // -(void)drawerPositionDidChangeWithDrawer:(PulleyViewController * _Nonnull)drawer;
        [Export("drawerPositionDidChangeWithDrawer:")]
        void DrawerPositionDidChangeWithDrawer(PulleyViewController drawer);

        // -(void)makeUIAdjustmentsForFullscreenWithProgress:(CGFloat)progress;
        [Export("makeUIAdjustmentsForFullscreenWithProgress:")]
        void MakeUIAdjustmentsForFullscreenWithProgress(nfloat progress);

        // -(void)drawerChangedDistanceFromBottomWithDrawer:(PulleyViewController * _Nonnull)drawer distance:(CGFloat)distance;
        [Export("drawerChangedDistanceFromBottomWithDrawer:distance:")]
        void DrawerChangedDistanceFromBottomWithDrawer(PulleyViewController drawer, nfloat distance);
    }

}

