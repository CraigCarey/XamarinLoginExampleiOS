using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Login01
{
	partial class MainViewController : UIViewController
	{
        UIViewController pinkViewController;

		public MainViewController (IntPtr handle) : base (handle)
		{
		}

        // Called when loaded from xib or storyboard.
        public override void AwakeFromNib()
        {
            this.Initialize();
        }

        public void Initialize()
        {
            // Instatiating View Controller with Storyboard ID 'PinkViewController'
            //pinkViewController = Storyboard.InstantiateViewController("PinkViewController") as PinkViewController;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // When we push the button, we will push the pinkViewController onto our current Navigation Stack
            //LoginButton.TouchUpInside += (o, e) =>
            //{
            //    this.NavigationController.PushViewController(pinkViewController, true);
            //};
        }

        public override bool ShouldPerformSegue(string segueIdentifier, NSObject sender)
        {

            if (segueIdentifier == "SegueToPink")
            {
                if (PasswordTextField.Text == "password")
                {
                    PasswordTextField.ResignFirstResponder();
                    return true;
                }
                else
                {
                    ErrorText.Hidden = false;
                    return false;
                }
            }
            return base.ShouldPerformSegue(segueIdentifier, sender);
        }
	}
}
