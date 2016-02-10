// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace mvvmlight1.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton btnCalcAge { get; set; }

		[Outlet]
		UIKit.UIButton btnCalcAgeDays { get; set; }

		[Outlet]
		UIKit.UILabel lblAgeResults { get; set; }

		[Outlet]
		UIKit.UILabel lblAgeUnits { get; set; }

		[Outlet]
		UIKit.UILabel lblFullName { get; set; }

		[Outlet]
		UIKit.UITextField txtDateOfBirth { get; set; }

		[Outlet]
		UIKit.UITextField txtFirstName { get; set; }

		[Outlet]
		UIKit.UITextField txtLastName { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (txtFirstName != null) {
				txtFirstName.Dispose ();
				txtFirstName = null;
			}

			if (txtLastName != null) {
				txtLastName.Dispose ();
				txtLastName = null;
			}

			if (txtDateOfBirth != null) {
				txtDateOfBirth.Dispose ();
				txtDateOfBirth = null;
			}

			if (btnCalcAge != null) {
				btnCalcAge.Dispose ();
				btnCalcAge = null;
			}

			if (btnCalcAgeDays != null) {
				btnCalcAgeDays.Dispose ();
				btnCalcAgeDays = null;
			}

			if (lblFullName != null) {
				lblFullName.Dispose ();
				lblFullName = null;
			}

			if (lblAgeResults != null) {
				lblAgeResults.Dispose ();
				lblAgeResults = null;
			}

			if (lblAgeUnits != null) {
				lblAgeUnits.Dispose ();
				lblAgeUnits = null;
			}
		}
	}
}
