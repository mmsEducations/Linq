

using System.Diagnostics.CodeAnalysis;

IList<NewStudent> studentList1 = new List<NewStudent>() {
        new NewStudent() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new NewStudent() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
        new NewStudent() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new NewStudent() { StudentID = 5, StudentName = "Ron" , Age = 19 },
        new NewStudent() { StudentID = 6, StudentName = "isamil haniyye" , Age = 75 },

    };

IList<NewStudent> studentList2 = new List<NewStudent>() {
    new NewStudent() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
    new NewStudent() { StudentID = 5, StudentName = "Ron" , Age = 19 },

};

var exceptList = studentList1.Except(studentList2, new StudentComparer()).ToList();

var intersectList = studentList1.Intersect(studentList2, new StudentComparer()).ToList();

var unionList = studentList1.Union(studentList2, new StudentComparer()).ToList();


studentList1.Skip(2).Take(1);

int num = 12;
public class NewStudent
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}


public class StudentComparer : IEqualityComparer<NewStudent>
{
    public bool Equals(NewStudent? x, NewStudent? y)
    {
        if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
        {
            return true;
        }

        return false;
    }

    public int GetHashCode([DisallowNull] NewStudent obj)
    {
        return obj.StudentID.GetHashCode();
    }
}
