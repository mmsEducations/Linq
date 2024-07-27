using App2;

Test8Join();
partial class Program
{

    public static void Test8Join()
    {
        var students = Generator.Students();
        var schools = Generator.Schools();

        var studentSchools = (from st in students //out
                              join sch in schools //inner 
                              on st.SchoolId equals sch.SchoolId //Key Selector
                              select new //Result Selector 
                              {
                                  st.StudentName,
                                  st.Gender,
                                  st.Age,
                                  sch.Schoolname
                              }).ToList();


        var studentSchoolsGroupedData = (from st in studentSchools
                                         group st by st.Schoolname)
                                         .ToList();

        foreach (var froupedData in studentSchoolsGroupedData)
        {

            Console.WriteLine($"Okul Adı:{froupedData.Key}");
            Console.WriteLine("--------------------------------------");
            foreach (var std in froupedData)
            {
                Console.WriteLine(string.Concat(std.StudentName, " ", std.Gender));
            }
        }
    }

}

//Not gruplama işlemlerinde key : gruplanmış veriyi temsil eder
partial class Program
{
    static void EX1()
    {
        var students = Generator.Students();

        //var orderStudents = (from student in students
        //                    orderby student.StudentName
        //                    select student).ToList();
        //foreach (var orderStudent in orderStudents)
        //{
        //    Console.WriteLine(orderStudent.GetStudentInfo);
        //}

        //Query Yöntemi 
        //order by asc
        Console.WriteLine("Adan Zye sıralama");
        (from student in students
         orderby student.StudentName, student.Age
         select student).ToList().ForEach(s => Console.WriteLine(s.GetStudentInfo));

        Console.WriteLine("Adan Zye sıralama");
        (from student in students
         orderby student.StudentName
         select student).ToList().ForEach(s => Console.WriteLine(s.GetStudentInfo));


        Console.WriteLine("Z Den A'ya sıralama");
        (from student in students
         orderby student.StudentName descending
         select student).ToList().ForEach(s => Console.WriteLine(s.GetStudentInfo));

        Console.Clear();

        students.OrderBy(s => s.StudentName);
        students.OrderByDescending(s => s.StudentName).ToList()
                 .ForEach(s => Console.WriteLine(s.GetStudentInfo));


        (from student in students
         orderby student.StudentName, student.Age
         select new { Name = student.StudentName, Age = student.Age, NameWithAge = student.StudentName + " " + student.Age }).ToList();

        Console.Clear();

        students.OrderBy(s => s.StudentName)
                .ThenBy(s => s.Age)
                .ToList()
                .ForEach(s => Console.WriteLine(s.GetStudentInfo));


        students.OrderBy(s => s.StudentName)
                .ThenByDescending(s => s.Age)
                .ToList()
                .ForEach(s => CallMethod(s.StudentName));



        Console.ReadLine();

        //new { }  -> istediğim formatta bir obje oluşturuyorum

        void CallMethod(string name)
        {

        }

        Console.Clear();
        //

        #region Case1

        Func<Student, bool> _isTeenAgerFunction = delegate (Student s)
        {
            return s.Age > 12 && s.Age < 20;
        };

        var resFunction = (from student in students
                           where _isTeenAgerFunction(student)
                           select student);
        #endregion


        #region Case2

        var resWhere = (from student in students
                        where isTeenAger(student)
                        select student);


        static bool isTeenAger(Student s)
        {
            return s.Age > 12 && s.Age < 20;
        }

        #endregion


        #region Case3
        var resWhere3 = (from student in students
                         where student.Age > 12 && student.Age < 20
                         select student);
        #endregion
    }
    public static void Test3()
    {
        var students = Generator.Students();

        var groupedByGenderStudents = (from s in students
                                       group s by s.Gender).ToList();

        foreach (var sgroupedGender in groupedByGenderStudents)
        {
            Console.WriteLine($"Cinsiyet Adı:{sgroupedGender.Key}");
            Console.WriteLine("--------------------------------------");
            foreach (Student std in sgroupedGender)
            {
                Console.WriteLine(std.GetStudentInfo);
            }
        }
    }
    public static void Test2()
    {
        var students = Generator.Students();

        var groupedStudents = (from s in students
                               group s by s.City).ToList();

        foreach (var sgrouped in groupedStudents)
        {
            Console.WriteLine($"Şehir Adı:{sgrouped.Key}");

            foreach (Student std in sgrouped)
            {
                Console.WriteLine(std.GetStudentInfo);
            }
        }
    }

    public static void Test5()
    {
        var students = Generator.Students();

        var groupedByGenderStudents = students.GroupBy(x => x.Gender).ToList();

        foreach (var sgroupedGender in groupedByGenderStudents)
        {
            Console.WriteLine($"Cinsiyet Adı:{sgroupedGender.Key}");
            Console.WriteLine("--------------------------------------");
            foreach (Student std in sgroupedGender)
            {
                Console.WriteLine(std.GetStudentInfo);
            }
        }
    }

    public static void Test6WithLookUp()
    {
        var students = Generator.Students();

        var groupedByGenderStudents = students.ToLookup(x => x.Gender).ToList();

        foreach (var sgroupedGender in groupedByGenderStudents)
        {
            Console.WriteLine($"Cinsiyet Adı:{sgroupedGender.Key}");
            Console.WriteLine("--------------------------------------");
            foreach (Student std in sgroupedGender)
            {
                Console.WriteLine(std.GetStudentInfo);
            }
        }
    }

    public static void Test7Join()
    {
        var students = Generator.Students();
        var schools = Generator.Schools();

        var studentSchools = (from st in students //out
                              join sch in schools //inner 
                              on st.SchoolId equals sch.SchoolId //Key Selector
                              select new //Result Selector 
                              {
                                  st.StudentName,
                                  st.Gender,
                                  st.Age,
                                  sch.Schoolname
                              }).ToList();
    }

}




/*
 Name        Gender 
 ali         erkek
 can         erkek
 mehmet      erkek
 aleyna      kadın
 Nursena     Kadın 

//gruplanan Kolon neyse key o olur : key Gender 

 
 */