using System;

using System.Diagnostics.Tracing;
using GalaSoft.MvvmLight.Helpers;
using UIKit;

namespace mvvmlight1.iOS
{
	public partial class ViewController : UIViewController
	{
        public MainViewModel ViewModel => Application.Locator.Main;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
            SetCommands();

            BindLabels();

            BindTextFields();

            SetupKeyboard();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}

        void BindLabels()
        {
            this.SetBinding(
                () => ViewModel.FullName,
                () => lblFullName.Text,
                BindingMode.TwoWay);

            this.SetBinding(
                ()=> ViewModel.Age,
                ()=> lblAgeResults.Text,
            BindingMode.TwoWay);

            this.SetBinding(
                ()=> ViewModel.AgeUnits,
                ()=>lblAgeUnits.Text,
            BindingMode.TwoWay);
        }

        void BindTextFields()
        {
            this.SetBinding(
                ()=>txtDateOfBirth.Text).UpdateSourceTrigger(Events.EditingChanged).WhenSourceChanges(()=>ViewModel.DateOfBirth = txtDateOfBirth.Text);

            this.SetBinding(
                ()=>txtFirstName.Text).UpdateSourceTrigger(Events.EditingChanged).WhenSourceChanges(()=>ViewModel.FirstName = txtFirstName.Text);

            this.SetBinding(
                ()=>txtLastName.Text).UpdateSourceTrigger(Events.EditingChanged).WhenSourceChanges(()=>ViewModel.LastName = txtLastName.Text);
        }

        void SetCommands()
        {
            btnCalcAge.SetCommand(
               Events.TouchUpInside,
                ViewModel.CalculateAgeCommand);

            btnCalcAgeDays.SetCommand(
                Events.TouchUpInside,
                ViewModel.CalculateDaysCommand);
        }

        void SetupKeyboard()
        {
            txtDateOfBirth.UiSetKeyboardEditorWithCloseButton(UIKeyboardType.Default);
            txtFirstName.UiSetKeyboardEditorWithCloseButton(UIKeyboardType.Default);
            txtLastName.UiSetKeyboardEditorWithCloseButton(UIKeyboardType.Default);
        }
	}
}

