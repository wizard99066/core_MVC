namespace HW_11.Models
{
    public class UserInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public Sex Sex { get; set; }
        public string InformationAboutYourself { get; set; }


    }
        public enum Sex
        {
            Man,
            Woman
        }

 }
