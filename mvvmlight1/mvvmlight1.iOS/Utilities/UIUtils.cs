using System;
using UIKit;
using CoreGraphics;

namespace mvvmlight1.iOS
{
    public static class UIUtils
    {
        public static void UiSetKeyboardEditorWithCloseButton(this UITextField txt, UIKeyboardType keyboardType)
        {
            var toolbar = new UIToolbar
            {
                BarStyle = UIBarStyle.Black,
                Translucent = true,
            };
            txt.KeyboardType = keyboardType;
            toolbar.SizeToFit();

            var text = new UITextView(new CGRect(0, 0, 200, 32))
            {
                ContentInset = UIEdgeInsets.Zero,
                KeyboardType = keyboardType,
                Text = txt.Text,
                UserInteractionEnabled = true
            };
            text.Layer.CornerRadius = 4f;
            text.BecomeFirstResponder();

            var doneButton = new UIBarButtonItem("Done", UIBarButtonItemStyle.Done,
                                 (s, e) =>
                {
                    text.ResignFirstResponder();
                    txt.ResignFirstResponder();
                });

            toolbar.UserInteractionEnabled = true;
            toolbar.SetItems(new UIBarButtonItem[] { doneButton }, true);

            txt.InputAccessoryView = toolbar;
        }
    }
}

