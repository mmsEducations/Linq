// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

// string collection
IList<string> stringList = new List<string>() {
    "C# Tutorials",
    "VB.NET Tutorials",
    "Learn C++",
    "MVC Tutorials" ,
    "Java"
};

// LINQ Query Syntax
var result = from s in stringList
             where s.Contains("Tutorials")
             select s;


var resultV2 = stringList.Where(s => s.Contains("Tutorials"));

static void Ex8()
{
    XElement students = new XElement("students",
         new XElement("student",
            new XElement("id", 1),
            new XElement("name", "Burak"),
            new XElement("country", "Türkiye"),
            new XElement("age", 4)
           ),
         new XElement("student",
            new XElement("id", 2),
            new XElement("name", "Mehmet"),
            new XElement("country", "Türkiye"),
            new XElement("age", 24)
           ),
          new XElement("student",
            new XElement("id", 2),
            new XElement("name", "Ahmet"),
            new XElement("country", "Türkiye"),
            new XElement("age", 40)
           )
        );

    var filteredStudents = students.Elements("student").Where(x => (int)x.Element("age") > 20)
                                   .LastOrDefault();

    var filteredStudentsV2 = students.Elements("student").Where(x => (int)x.Element("id") == 2)
                                   .FirstOrDefault();
}

static void Ex6()
{
    string xmlData = @"
                         <students>
                           
                             <student>
                                   <id>1</id>
                                   <name>İsmail</name>
                                   <country>Filistin</country>
                                   <age>70</age>
                             </student>

                              <student>
                                   <id>2</id>
                                   <name>Mehmet</name>
                                   <country>Türkiye</country>
                                   <age>36</age>

                             </student>

                               <student>
                                   <id>3</id>
                                   <name>Down</name>
                                   <country>Almanya</country>
                                   <age>45</age>

                               </student>

 
                               <student>
                                   <id>4</id>
                                   <name>Katil Binyamin</name>
                                   <country>İsrail</country>
                                   <age>72</age>

                               </student>


 
                               <student>
                                   <id>5</id>
                                   <name>Katil Jo Biden</name>
                                   <country>ABD</country>
                                   <age>90</age>

                               </student>



                               <student>
                                   <id>6</id>
                                   <name>Katil Trump</name>
                                   <country>ABD</country>
                                   <age>80</age>

                               </student>


                              <student>
                                   <id>7</id>
                                   <name>Serdar Devrim</name>
                                   <country>Türkiye</country>
                                   <age>25</age>

                             </student>

                          </students>
                     ";

    XDocument document = XDocument.Parse(xmlData);

    var xmlDatas = from std in document.Descendants("student")
                   where (int)std.Element("age") > 50
                   select new
                   {
                       Age = (int)std.Element("age")
                   };

    foreach (var data in xmlDatas)
    {
        Console.WriteLine(data.Age);
    }

}

//new {}
static void Ex5()
{

    //Data Source
    List<Student> students = Student.GetStudents();

    //students.Where(x => x.)  = Student x = new Student();

    //linq Extensions
    List<Student> studentList = students.Where(x => x.Gender == Gender.Female)
                                        .ToList();

    //Write Console
    studentList.ForEach(student => Console.WriteLine(student.Name));

    Student[] studentsArray = students.Where(x => x.Gender == Gender.Female)
                                    .ToArray();

    Dictionary<int, string> studentDictionary = students.Where(x => x.Gender == Gender.Female)
                                    .ToDictionary(x => x.StudentId, x => x.Name + " " + x.LastName);

    foreach (var student in studentDictionary)
    {
        Console.WriteLine($"key:{student.Key} , value :{student.Value}");
    }


    var result = students.Where(s => s.City == "Diyarbakır" && s.Gender == Gender.Male)
             .ToList();
}

static void Ex4()
{

    //Data Source
    var students = Student.GetStudents();

    //linq query
    List<Student> studentList = (from s in students
                                 where s.Gender == Gender.Male
                                 select s).ToList();

    //Write Console
    studentList.ForEach(student => Console.WriteLine(student.Name));

}

static void Ex3()
{
    //Data Source
    List<int> numbers = new List<int>() { 123, 11, 21, 55, 44, 72, 16 };


    //linq query
    var evenNumbersArray = (from n in numbers where n % 2 == 0 select n)
                      .ToArray();


    //linq query
    var evenNumbersArrayV2 = (from n in numbers where n % 2 == 0 select n.ToString())
                  .ToArray<string>();


    //linq query
    var evenNumbersList = (from n in numbers where n % 2 == 0 select n)
                    .ToList();


    var evenNumbersListV2 = (from n in new List<int>() { 123, 11, 21, 55, 44, 72, 16 } where n % 2 == 0 select n)
                .ToList();

}


static void Ex2()
{
    //Data Source
    string[] names = { "Engin ağa", "Serdar", "Ali ağa", "Nursena", "Aleyna", "Mehmet ağa" };

    //linq query
    IEnumerable<string> newNames = (from name in names
                                    where name.Contains("ağa")
                                    select name);

    List<string> listNames = newNames.ToList(); //linq extension methods 

    Console.WriteLine();

    Console.ReadLine();
}



static void Ex1()
{
    //Data Source
    string[] names = { "Engin", "Serdar", "Ali", "Nursena", "Aleyna", "Mehmet" };

    //linq query
    var newNames = (from name in names     //names veri kaynağı
                    where name == "Nursena"
                    select name);

    Console.WriteLine(newNames.FirstOrDefault());

    Console.ReadLine();
}

static void Ex7()
{
    Console.WriteLine("Hello, World!");

    //Javascript object notation 
    string jsonData = @"
{
       'students' : [
        {
           'id' : 1, 'name' : 'Aliya izzetbegovic', 'age' : 90
        },
        {
          'id' : 2, 'name' : 'Serdar Devrimov', 'age' : 35
        },
        {
          'id' : 3, 'name' : 'Bilge kağan', 'age' : 300
        },
        {
         'id' : 4, 'name' : 'Vezir tonyukuk', 'age' : 305
        },
        {
         'id' : 5, 'name' : 'kamil', 'age' : 4
         },
         {
         'id' : 6, 'name' : 'zerda', 'age' : 6
         }
       ]  
   }";

    JObject json = JObject.Parse(jsonData);

    var youngStudents = json["students"].Where(st => (int)st["age"] < 15)
                        .Select(s => new
                        {
                            Id = (int)s["id"],
                            Name = (string)s["name"],
                        });

    var youngStudentsV2 = from st in json["students"]
                          where (int)st["age"] < 15
                          select new
                          {
                              Id = (int)st["id"],
                              Name = (string)st["name"],
                          };

    //nameler tek tırnak ile kullanılır , valueler de tipine göre 
}

//select name from names where names.name=="Nursena"

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public Gender Gender { get; set; }
    public string City { get; set; }

    public static List<Student> GetStudents()
    {
        var students = new List<Student>()
        {
             new Student() {  StudentId =1 , Name ="Burak Asaf", LastName = "Sincar", BirthDate = new DateTime(2020,4,12), City = "Diyarbakır" , Gender = Gender.Male},
             new Student() {  StudentId =2 , Name ="Yiğit Ali", LastName = "Sincar", BirthDate = new DateTime(2021,8,13), City = "Diyarbakır" , Gender = Gender.Male},
             new Student() {  StudentId =3 , Name ="Aleyna", LastName = "Tilki", BirthDate = new DateTime(1997,6,11), City = "İzmir" , Gender = Gender.Female},
             new Student() {  StudentId =4 , Name ="Hande", LastName = "Tilki", BirthDate = new DateTime(2000,7,8), City = "İzmir" , Gender = Gender.Female},
             new Student() {  StudentId =5 , Name ="Angelina", LastName = "Julie", BirthDate = new DateTime(1990,9,10), City = "Bermingem" , Gender = Gender.Female},
             new Student() {  StudentId =6 , Name ="Wanda", LastName = "Nara", BirthDate = new DateTime(1997,8,12), City = "Sapalo" , Gender = Gender.Female},
             new Student() {  StudentId =7 , Name ="Aleyna", LastName = "Tilki", BirthDate = new DateTime(1997,8,12), City = "Sapalo" , Gender = Gender.Female},
             new Student() {  StudentId =8 , Name ="Kenan", LastName = "Mirza", BirthDate = new DateTime(1970,8,12), City = "Ankara" , Gender = Gender.Male},
             new Student() {  StudentId =9 , Name ="Can", LastName = "Yıldız", BirthDate = new DateTime(1975,6,12), City = "Ankara" , Gender = Gender.Male},
             new Student() {  StudentId =10 , Name ="Halit", LastName = "Yıldız", BirthDate = new DateTime(1960,7,12), City = "Ankara" , Gender = Gender.Male},
             new Student() {  StudentId =11 , Name ="Aleyna", LastName = "Yıldız", BirthDate = new DateTime(1999,10,12), City = "İzmir" , Gender = Gender.Female},
             new Student() {  StudentId =12 , Name ="Arda", LastName = "Turan", BirthDate = new DateTime(2001,10,12), City = "İstanbul" , Gender = Gender.Male},
             new Student() {  StudentId =13 , Name ="Arda", LastName = "Bebe", BirthDate = new DateTime(2003,10,12), City = "İstanbul" , Gender = Gender.Male},

        };

        return students;
    }
}

public enum Gender
{
    Male = 1,
    Female = 0
}