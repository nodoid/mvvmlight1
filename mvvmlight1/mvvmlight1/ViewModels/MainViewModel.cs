using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Globalization;

namespace mvvmlight1
{

    public class MainViewModel : ViewModelBase
    {
        RelayCommand calculateAge;
        RelayCommand calculateDays;
        DateTime Now = DateTime.Now;
        DateTime dob;
        string firstName, lastName, fullName;
        string age;
        bool useYears;

        public MainViewModel()
        {
        }

        public bool UseYears
        {
            get
            {
                return useYears;
            }
            set
            {
                useYears = value;
            }
        }

        public string AgeUnits
        {
            get
            {
                return UseYears ? "years" : "days";
            }
        }


        public DateTime DOB
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }

        public string DateOfBirth
        {
            get
            {
                return dob.ToString();
            }
            set
            {
                var outstring = DateTime.Now;
                var format = "dd/mm/yyyy";
                if (DateTime.TryParseExact(value, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out outstring))
                    DOB = outstring;
            }
        }

        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                if (!string.IsNullOrEmpty(lastName))
                {
                    FullName = string.Format("{0} {1}", FirstName, LastName);
                }
            }
        }

        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
                RaisePropertyChanged(() => FullName);
            }
        }

        public RelayCommand CalculateAgeCommand
        {
            get
            {
                return calculateAge ??
                (calculateAge = new RelayCommand(
                    () =>
                    {
                        if (Now > DOB)
                        {
                            var age = Now.AddYears(-DOB.Year).Year;
                            Age = age.ToString();
                            UseYears = true;
                            RaisePropertyChanged(() => Age);
                            RaisePropertyChanged(() => AgeUnits);
                        }
                    }));
            }
        }

        public RelayCommand CalculateDaysCommand
        {
            get
            {
                return calculateDays ??
                (
                    calculateDays = new RelayCommand(
                        () =>
                    {
                        Age = ((int)(Now - DOB).TotalDays).ToString();
                        UseYears = false;
                        RaisePropertyChanged(() => Age);
                        RaisePropertyChanged(() => AgeUnits);
                    }));
            }
        }
    }
}