#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#define DEBUG 1
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <CloudKit/CloudKit.h>
#import <QuartzCore/QuartzCore.h>
#import <Intents/Intents.h>
#import <CoreGraphics/CoreGraphics.h>

@class UIKit_UIControlEventProxy;
@class __MonoMac_NSActionDispatcher;
@class __MonoMac_NSAsyncActionDispatcher;
@class AppDelegate;
@class ViewController;
@class ListadeCompras_ProductoTableViewController_MyDataSource;
@class ProductoTableViewController;
@class __NSObject_Disposer;
@class UIKit_UIScrollView__UIScrollViewDelegate;

@interface AppDelegate : NSObject<UIApplicationDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIWindow *) window;
	-(void) setWindow:(UIWindow *)p0;
	-(BOOL) application:(UIApplication *)p0 didFinishLaunchingWithOptions:(NSDictionary *)p1;
	-(void) applicationWillResignActive:(UIApplication *)p0;
	-(void) applicationDidEnterBackground:(UIApplication *)p0;
	-(void) applicationWillEnterForeground:(UIApplication *)p0;
	-(void) applicationDidBecomeActive:(UIApplication *)p0;
	-(void) applicationWillTerminate:(UIApplication *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface ViewController : UIViewController {
}
	@property (nonatomic, assign) UIButton * btnAgregar;
	@property (nonatomic, assign) UITextField * txtCantidad;
	@property (nonatomic, assign) UITextField * txtProducto;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(UIButton *) btnAgregar;
	-(void) setBtnAgregar:(UIButton *)p0;
	-(UITextField *) txtCantidad;
	-(void) setTxtCantidad:(UITextField *)p0;
	-(UITextField *) txtProducto;
	-(void) setTxtProducto:(UITextField *)p0;
	-(void) viewDidLoad;
	-(void) didReceiveMemoryWarning;
	-(void) prepareForSegue:(UIStoryboardSegue *)p0 sender:(NSObject *)p1;
	-(void) agregarProducto:(UIButton *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface ProductoTableViewController : UITableViewController {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end


