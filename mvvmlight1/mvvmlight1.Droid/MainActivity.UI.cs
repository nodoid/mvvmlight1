using Android.Widget;

namespace mvvmlight1.Droid
{
    public partial class MainActivity
    {
        Button btnCalculateAge,btnCalculateDays;
        EditText editDOB,editFirstName,editLastName;
        TextView txtAge,txtName,txtUnits;

        public Button BtnCalculateAge => btnCalculateAge ?? (btnCalculateAge = FindViewById<Button>(Resource.Id.btnCalculateAge));
        public Button BtnCalculateDays => btnCalculateDays ?? (btnCalculateDays = FindViewById<Button>(Resource.Id.btnCalculateDays));

        public EditText EditDOB => editDOB ?? (editDOB = FindViewById<EditText>(Resource.Id.editDOB));
        public EditText EditFirstName => editFirstName ?? (editFirstName = FindViewById<EditText>(Resource.Id.editFirstName));
        public EditText EditLastName => editLastName ?? (editLastName = FindViewById<EditText>(Resource.Id.editLastName));

        public TextView TxtAge => txtAge ?? (txtAge = FindViewById<TextView>(Resource.Id.txtAge));
        public TextView TxtName => txtName ?? (txtName = FindViewById<TextView>(Resource.Id.txtName));
        public TextView TxtUnits => txtUnits ?? (txtUnits = FindViewById<TextView>(Resource.Id.txtUnits));
    }
}

