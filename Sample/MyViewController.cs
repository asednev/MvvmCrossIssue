using System;
using MonoTouch.UIKit;
using System.Drawing;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Views;
using Cirrious.MvvmCross.Dialog.Touch;
using CrossUI.Touch.Dialog.Elements;

namespace Sample
{
    public class MyViewController : MvxTouchDialogViewController<SampleViewModel>
    {

        public MyViewController(MvxShowViewModelRequest request) : base(request)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Section sec = new Section();

            Root = new RootElement("Test")
            {
                sec
            };
            Root.UnevenRows = true;

            sec.Add(new MessageElement() { Subject = "A", Body = "B", Caption = "C", Sender = "D", Date = DateTime.Now, MessageCount = 5 });
            sec.Add(new MessageElement() { Subject = "E", Body = "F", Caption = "G", Sender = "H", Date = DateTime.Now, MessageCount = 5 });
            sec.Add(new MessageElement() { Subject = "I", Body = "J", Caption = "K", Sender = "L", Date = DateTime.Now, MessageCount = 5 });
            sec.Add(new MessageElement() { Subject = "M", Body = "N", Caption = "O", Sender = "P", Date = DateTime.Now, MessageCount = 5 });
        }

    }
}

