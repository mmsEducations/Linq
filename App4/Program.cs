using Data;
using System.Diagnostics.CodeAnalysis;

IList<Student> studentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
    new Student() { StudentID = 6, StudentName = "Steve",  Age = 15 } ,
    new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
    new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
    new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 },
    new Student() { StudentID = 6, StudentName = "ismail" , Age = 80 ,LastName="haniyye" },
    new Student() { StudentID = 6, StudentName = "ismail" , Age = 80 ,LastName="haniyye" },
};

var enumumarableList = studentList.Any(s => s.StudentID == 6 && s.StudentName == "ismail");


var listCount = studentList.Count;

int ageMax = studentList.Max(s => s.Age);
int ageMin = studentList.Min(s => s.Age);
int ageSum = studentList.Sum(s => s.Age);
double ageAverage = studentList.Average(s => s.Age);


Student stdSearch = new Student() { StudentID = 6, StudentName = "ismail" };


var enumumarableListCompareMethodResult = studentList.Contains(stdSearch, new StudentComparer());


var result = studentList.Where(s => s.StudentName == "ismail").Count();

//var getfirst = studentList.Where(s => s.StudentID == 6 && s.StudentName == "ismailov")
//                                   .First();


//var getlast = studentList.Where(s => s.StudentID == 6 && s.StudentName == "ismailov")
//                                   .Last();


var getfirstor = studentList.Where(s => s.StudentID == 6 && s.StudentName == "ismailov")
                                   .FirstOrDefault();

var getlastOrDefault = studentList.Where(s => s.StudentID == 6 && s.StudentName == "ismailov")
                                   .LastOrDefault();



Console.ReadLine();




public class StudentComparer : IEqualityComparer<Student>
{
    public bool Equals(Student? x, Student? y)
    {
        if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
        {
            return true;
        }

        return false;
    }

    public int GetHashCode([DisallowNull] Student obj)
    {
        return obj.GetHashCode();
    }
}

