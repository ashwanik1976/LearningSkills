using SampleModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace SampleModule.ViewModels
{
    public class SampleViewModel : ViewModelBase
    {
        // Prepare data
        private IList<User> _UsersList;
        public IList<User> Users
        {
            get
            {
                return _UsersList;
            }
            set { _UsersList = value; }
        }

        public SampleViewModel()
        {
            _UsersList = new List<User>
            {
                new User{UserId = 1,FirstName="Raj",LastName="Beniwal",City="Delhi",State="DEL",Country="INDIA"},
                new User{UserId=2,FirstName="Mark",LastName="henry",City="New York", State="NY", Country="USA"},
                new User{UserId=3,FirstName="Mahesh",LastName="Chand",City="Philadelphia", State="PHL", Country="USA"},
                new User{UserId=4,FirstName="Vikash",LastName="Nanda",City="Noida", State="UP", Country="INDIA"},
                new User{UserId=5,FirstName="Harsh",LastName="Kumar",City="Ghaziabad", State="UP", Country="INDIA"},
                new User{UserId=6,FirstName="Reetesh",LastName="Tomar",City="Mumbai", State="MP", Country="INDIA"},
                new User{UserId=7,FirstName="Deven",LastName="Verma",City="Palwal", State="HP", Country="INDIA"},
                new User{UserId=8,FirstName="Ravi",LastName="Taneja",City="Delhi", State="DEL", Country="INDIA"}
            };

        }

        private int _number1;
        public int Number1
        {
            get { return _number1; }
            set
            {
                _number1 = value;
                NotifyPropertyChanged("Number1");
            }
        }


        private int _number2;
        public int Number2
        {
            get
            {
                return _number2;
            }
            set
            {
                _number2 = value;
                NotifyPropertyChanged("Number2"); 
            }
        }


        private int nubersum;

        public int NumberSum {
            get { return nubersum; }
            set
            {
                nubersum = value;
                NotifyPropertyChanged("NumberSum");
            }
        }
       
            //get
            //{
            //    return nubersum = Number1 + Number2;
            //}
            //set
            //{
            //    nubersum = value;
            //    NotifyPropertyChanged("NumberSum");
            //}
        

        //Prepare Command 
        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new RelayCommand(param => this.Submit(),
                        null);

                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }

        private ICommand _SubmitCommand;
        public ICommand SubmitCommand
        {
            get
            {
                if (_SubmitCommand == null)
                {
                    _SubmitCommand = new RelayCommand(param => this.Submit(),
                        null);
                }
                return _SubmitCommand;
            }
        }
        private void Submit()
        {
            //Student.JoiningDate = DateTime.Today.Date;
            //Students.Add(Student);
            //Student = new Student();
            Number1 = 10;
            Number2 = 20;
            NumberSum = Number1 + Number2;
        }
        //private class Updater : ICommand
        //{
        //    #region ICommand Members
        //    public event EventHandler CanExecuteChanged;
        //    public bool CanExecute(object parameter)
        //    {
        //        return true;
        //    }
        //    public void Execute(object parameter)
        //    {
        //    }
        //    #endregion
        //}

       
    }
}
