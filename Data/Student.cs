namespace Data
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }

        public string GetStudentInfo
        {
            get
            {
                return StudentName + " " + Age + " Yaşında";
            }
        }

        public int SchoolId { get; set; }


        public string LastName { get; set; } = "Test";
    }
}
