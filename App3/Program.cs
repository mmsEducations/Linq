// See https://aka.ms/new-console-template for more information
using Data;

Console.WriteLine("Hello, World!");

var students = Generator.Students();

var filteredStudents = from s in students
                       select new
                       {
                           Id = s.StudentID,
                           NameAndAge = s.StudentName + " " + s.Age + " yaşında",
                       };



//var filteredStudentsMethods = students.Select(s => s.StudentName + " " + s.Age + " yaşında");
var filteredStudentsMethods = students.Select(s => new { Id = s.StudentID, NameAndAge = s.StudentName + " " + s.Age + " yaşında" });


/*var objectName = new { id = "1", Name = "Halide" , LastName="Adıvar", Guid = Guid.NewGuid()};
var objectName2 = new { Guid_1 = Guid.NewGuid(), SchoolName = "çankırı fen edebiyat"};
*/

//All komutu 
bool allStudentTeenager = students.All(s => s.Age >= 0 && s.Age < 20);//false
bool allStudentTeenagerAll = students.All(s => s.Age >= 20);//false
bool allStudentTeenagerAny = students.Any(s => s.Age >= 20);//true

//Contains 
IEnumerable<int> age = students.Select(s => s.Age); //new{ age = s.Age}

List<int> ageList = students.Select(s => s.Age)
                        .ToList();

Student[] students_ = students.Where(s => s.StudentName.Contains("eflek"))
          .ToArray();

//
List<string> students2 = students.Where(s => s.StudentName.Contains("eflek"))
                              .Select(s => s.City)
                              .ToList();

students2.ForEach(s => Console.WriteLine(s));






















Console.ReadLine();

