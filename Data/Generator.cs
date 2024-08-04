namespace Data
{
    public static class Generator
    {
        public static IList<Student> Students()
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() { SchoolId=1,  StudentID = 1, StudentName = "John eflek", Age = 101, City = "Adana", Gender = "Male" },
                new Student() { SchoolId=4,  StudentID = 2, StudentName = "Steve", Age = 15, City = "Adana", Gender = "Male" },
                new Student() { SchoolId=4,  StudentID = 3, StudentName = "Zelal", Age = 25, City = "Adana", Gender = "Female" },
                new Student() { SchoolId=4,  StudentID = 4, StudentName = "Ram", Age = 20, City = "Ankara", Gender = "Male" },
                new Student() { SchoolId=4,  StudentID = 5, StudentName = "Ron", Age = 19, City = "Ankara", Gender = "Male" },
                new Student() { SchoolId=5,  StudentID = 6, StudentName = "Mike", Age = 20, City = "Ankara", Gender = "Male" },
                new Student() { SchoolId=2,  StudentID = 7, StudentName = "Chris", Age = 21, City = "Ankara", Gender = "Male" },
                new Student() { SchoolId=3,  StudentID = 8, StudentName = "Paul", Age = 24, City = "Ankara", Gender = "Male" },
                new Student() { SchoolId=1,  StudentID = 9, StudentName = "Tom eflek", Age = 23, City = "Ankara", Gender = "Male" },
                new Student() { SchoolId=1,  StudentID = 10, StudentName = "Jerry", Age = 17, City = "Diyarbakır", Gender = "Male" },
                new Student() { SchoolId=2,  StudentID = 11, StudentName = "Nick", Age = 16, City = "Diyarbakır", Gender = "Male" },
                new Student() { SchoolId=1,  StudentID = 12, StudentName = "James", Age = 20, City = "Diyarbakır", Gender = "Male" },
                new Student() { SchoolId=4,  StudentID = 13, StudentName = "David", Age = 18, City = "Diyarbakır", Gender = "Male" },
                new Student() { SchoolId=4,  StudentID = 14, StudentName = "Robert", Age = 20, City = "Muğla", Gender = "Male" },
                new Student() { SchoolId=2,  StudentID = 15, StudentName = "Michael", Age = 21, City = "Muğla", Gender = "Male" },
                new Student() { SchoolId=5,  StudentID = 16, StudentName = "William", Age = 19, City = "Gazi Antep", Gender = "Male" },
                new Student() { SchoolId=3,  StudentID = 17, StudentName = "Joseph", Age = 25, City = "Gazi Antep", Gender = "Male" },
                new Student() { SchoolId=2,  StudentID = 18, StudentName = "Richard", Age = 23, City = "Gazi Antep", Gender = "Male" },
                new Student() { SchoolId=1,  StudentID = 19, StudentName = "Charles", Age = 24, City = "Gazi Antep", Gender = "Male" },
                new Student() { SchoolId=1,  StudentID = 20, StudentName = "Thomas", Age = 20, City = "Gazi Antep", Gender = "Male" },
                new Student() { SchoolId=3,  StudentID = 21, StudentName = "Daniel", Age = 22, City = "Gazi Antep", Gender = "Male" },
                new Student() { SchoolId=3,  StudentID = 22, StudentName = "Matthew", Age = 20, City = "Kayseri", Gender = "Male" },
                new Student() { SchoolId=3,  StudentID = 23, StudentName = "Anthony eflek", Age = 10, City = "Kayseri", Gender = "Male" },
                new Student() { SchoolId=3,  StudentID = 24, StudentName = "Donald", Age = 21, City = "Kayseri", Gender = "Male" },
                new Student() { SchoolId=3,  StudentID = 25, StudentName = "Mark", Age = 19, City = "Kayseri", Gender = "Male" },
                new Student() { SchoolId=2,  StudentID = 26, StudentName = "Paul", Age = 10, City = "Kayseri", Gender = "Male" },
                new Student() { SchoolId=2,  StudentID = 27, StudentName = "George", Age = 23, City = "Kayseri", Gender = "Male" },
                new Student() { SchoolId=2,  StudentID = 28, StudentName = "Kenneth", Age = 20, City = "Kayseri", Gender = "Male" },
                new Student() { SchoolId=2,  StudentID = 29, StudentName = "Steven", Age = 25, City = "Rize", Gender = "Male" },
                new Student() { SchoolId=2,  StudentID = 30, StudentName = "Edward", Age = 4, City = "Rize", Gender = "Male" },
                new Student() { SchoolId=2,  StudentID = 31, StudentName = "Brian", Age = 20, City = "Rize", Gender = "Male" },
                new Student() { SchoolId=2,  StudentID = 32, StudentName = "Ronald", Age = 8, City = "Rize", Gender = "Male" },
                new Student() { SchoolId=4,  StudentID = 33, StudentName = "Timothy", Age = 3, City = "Rize", Gender = "Male" },
                new Student() { SchoolId=4,  StudentID = 34, StudentName = "Jason", Age = 17, City = "Rize", Gender = "Male" },
                new Student() { SchoolId=4,  StudentID = 35, StudentName = "Jeffrey", Age = 3, City = "Ordu", Gender = "Male" },
                new Student() { SchoolId=4,  StudentID = 36, StudentName = "Ryan", Age = 2, City = "Ordu", Gender = "Male" },
                new Student() { SchoolId=4,  StudentID = 37, StudentName = "Jacob", Age = 19, City = "Ordu", Gender = "Male" },
                new Student() { SchoolId=1,  StudentID = 38, StudentName = "Gary", Age = 25, City = "Artvin", Gender = "Male" },
                new Student() { SchoolId=1,  StudentID = 39, StudentName = "Nicholas", Age = 10, City = "Artvin", Gender = "Male" },
                new Student() { SchoolId=1,  StudentID = 40, StudentName = "Aylin can ", Age = 1, City = "Artvin", Gender = "Female" },
                new Student() { SchoolId=5,  StudentID = 41, StudentName = "Aylin ala", Age = 21, City = "İstnabul", Gender = "Female" },
                new Student() { SchoolId=5,  StudentID = 42, StudentName = "Aylin data", Age = 7, City = "İstnabul", Gender = "Female" },
                new Student() { SchoolId=5,  StudentID = 43, StudentName = "Nicholas", Age = 1, City = "İstnabul", Gender = "Male" },
             };

            return studentList;
        }

        public static IList<School> Schools()
        {
            IList<School> schools = new List<School>()
            {
                new School() { SchoolId = 1, Schoolname = "Fen Lisesi",},
                new School() { SchoolId = 2, Schoolname = "Anadolo Lisesi",},
                new School() { SchoolId = 3, Schoolname = "Süper Lise",},
                new School() { SchoolId = 4, Schoolname = "Meslek Lisesi",},
                new School() { SchoolId = 5, Schoolname = "Düz Lise",},

             };

            return schools;
        }
    }
}
