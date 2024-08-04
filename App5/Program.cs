using System.Diagnostics.CodeAnalysis;

IList<string> strList = new List<string>() { "One", "Two", "Two", "Two", "One" };

IList<int> intList = new List<int>() { 1, 2, 3, 1, 2, 3, 4, 3, 4, 101, 101 };

//distinct : koleksiyon içerisindeki elementleri tekilleştirip getirir


List<string> distinctRes = strList.Distinct().ToList();//One,Two
List<int> distinctResInt = intList.Distinct().ToList();




IList<NewStudent> studentList = new List<NewStudent>() {
        new NewStudent() { StudentID = 1, StudentName = "John", Age = 18 } ,
        new NewStudent() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
        new NewStudent() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new NewStudent() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new NewStudent() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new NewStudent() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
        new NewStudent() { StudentID = 5, StudentName = "Ron" , Age = 19 }
};

var distinctStudents = studentList.Distinct(new StudentComparer()).ToList();


IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

var except1 = strList1.Except(strList2);//One,Two,Three


IList<int> intNumbers = new List<int> { 1, 2, 3, 100 };
IList<int> intNumbers2 = new List<int> { 1, 12, 25, 3 };

var rsExcept = intNumbers.Except(intNumbers2);//2,100

Console.ReadLine();
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

public class NewStudent
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}
