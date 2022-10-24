using System;
namespace Project_01.Models
{
	public class User
	{
		public User()
		{

		}


        private string name;
        private string password;
        private bool registered;
        private string email;



        #region Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length >= 3)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Please enter at least 3 character!");
                }
            }
        }

        public string Surname { get; set; }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (value.Length >= 8 && value.Any(char.IsDigit))
                {
                    password = value;
                }
            }
        }
        public DateTime DayOfBirth { get; set; }
        #endregion


        public bool Login(string email, string password)
        {
            if(email == this.Email && password == this.Password)
            {
                Console.WriteLine("Loged-in");
                return true;
            }
            Console.WriteLine("Email and password is not matching");
            return false;
        }

        public void Register(string email, string name, string surname, string _password, string _password2 ,DateTime dayOfBirth)
        {
            this.Email = email;
            this.Name = name;
            this.Surname = surname;
            if(_password == _password2)
            {
                this.Password = password;
            }
            this.DayOfBirth = dayOfBirth;

            registered = true;
        }

        public bool ChangePassword(string _curPassword, string _newPassword1, string _newPassword2)
        {
            if (this.Password == _curPassword && _newPassword1 == _newPassword2)
            {
                this.Password = _newPassword1;
                return true;
            }
            return false;
        }

        public void CreateEvent()
        {

        }

        public void AttendEvent()
        {

        }


    }
}

