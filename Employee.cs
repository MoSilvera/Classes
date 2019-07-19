using System;
namespace classes {
    public class Employee {
        public Employee (string FirstName, string LastName){
            _firstName = FirstName;
            _lastName = LastName;
        }
        private string _firstName  { get; set;}
        private string _lastName {get; set;}

        private DateTime _hiredOn {get; set;}

        public string Title {get; set;}

        public void setEmployeeTitle (string title){
            Title = title;
        }

        public void Hire (){
            _hiredOn = DateTime.Now;
        }

        public DateTime getHireDate () {
            return _hiredOn;
        }

        public string getName(){
            string  fullName = $"{_firstName} {_lastName}";
            return fullName;
        }





    }
}
