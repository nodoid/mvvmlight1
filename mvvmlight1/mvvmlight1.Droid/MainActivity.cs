using Android.App;
using Android.OS;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight.Helpers;

namespace mvvmlight1.Droid
{
    [Activity(Label = "mvvmlight1.Droid", MainLauncher = true, Icon = "@drawable/icon")]
    public partial class MainActivity : ActivityBase
    {
        public MainViewModel ViewModel => App.Locator.Main;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            SetCommands();

            BindTextViews();

            BindEditViews();
        }

        void SetCommands()
        {
            BtnCalculateAge.SetCommand
            (
                Events.Click,
                ViewModel.CalculateAgeCommand
            );

            BtnCalculateDays.SetCommand
            (
                Events.Click, 
                ViewModel.CalculateDaysCommand
            );
        }

        void BindTextViews()
        {
            this.SetBinding(
                () => ViewModel.AgeUnits,
                () => TxtUnits.Text,
                BindingMode.TwoWay);

            this.SetBinding(
                () => ViewModel.Age,
                () => TxtAge.Text,
                BindingMode.TwoWay);

            this.SetBinding(
                () => ViewModel.FullName,
                () => TxtName.Text,
                BindingMode.TwoWay);
        }

        void BindEditViews()
        {
            this.SetBinding(
                () => ViewModel.FirstName,
                () => EditFirstName.Text,
                BindingMode.TwoWay);

            this.SetBinding(
                () => ViewModel.LastName,
                () => EditLastName.Text,
                BindingMode.TwoWay);

            this.SetBinding(
                () => ViewModel.DateOfBirth,
                () => EditDOB.Text,
                BindingMode.TwoWay);
        }
    }
}


