namespace ViewModelFun.Models
{
    public class User{
        public User(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
        }

        public string FirstName {get; set;}

        public string LastName {get;set;}
    }
}