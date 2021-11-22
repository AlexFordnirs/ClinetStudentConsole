using System;
using System.Net.Http;
using Lib;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ClinetStudentConsole
{
    class Program
    {
        private static readonly HttpClient HttpClient;
        public class StudentsB
        {
            public int iD { get; set; }
            public string firs_Name { get; set; }
            public string last_name { get; set; }
            public int age { get; set; }
        }
        public class StudentGroupsB
        {
            public int id { get; set; }
            public string name_Group { get; set; }
            public string specialiZ_GROUP { get; set; }
            public int studenT_ID { get; set; }
        }
        public class StudentsHomeVorksB
        {
            public int id { get; set; }
            public int grouP_STUDENT_ID { get; set; }
            public string nazvaniE_HOMEVORK { get; set; }
            public string zadanie { get; set; }
        }
        public class StudentsRaspisaniesB
        {
            public int id { get; set; }
            public string datE_SI_VORK_STUDENT { get; set; }
            public string nazvaniE_PREDMETA { get; set; }
            public int grouP_STUDENT_ID { get; set; }
        }
        static void Main(string[] args)
        {

            StudentsB name = new StudentsB();
            StudentGroupsB name2 = new StudentGroupsB();
            StudentsHomeVorksB name3 = new StudentsHomeVorksB();
            StudentsRaspisaniesB name4 = new StudentsRaspisaniesB();
            Console.WriteLine("Hello World!");
           
            var clinet = new Client { BaseUrl = "https://localhost:44375"};

            Console.WriteLine("Добро пожаловать в Майстат");
            Console.WriteLine("Выберите над кем хотите провести операцию: \n1) Студенты \n2) Группы студентов \n3) Домашнее задание студентов \n4) Расписание студентов ");
            try
            {
                int tors = Convert.ToInt32(Console.ReadLine());

                switch (tors)
                {
                    case 1:
                        Console.WriteLine("Выберите над кем хотите провести операцию: \n1) Вывести всех студентов \n2) Добавить студента \n3) обновить студента \n4) вывести студента по ip \n5) Удалить студента ");
                        int st = Convert.ToInt32(Console.ReadLine());
                        if (st == 1) { clinet.StudentAllAsync();}
                        else if (st == 2)
                        {
                            Console.WriteLine("Введите id");
                            int iD = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите имя");
                            string firs_Name = Console.ReadLine();
                            Console.WriteLine("Введите фамилию");
                            string last_name = Console.ReadLine();
                            Console.WriteLine("Введите возраст");
                            int age = Convert.ToInt32(Console.ReadLine());
                            name = new StudentsB { iD = iD, firs_Name = firs_Name, last_name = last_name, age = age };
                            string json = JsonSerializer.Serialize<StudentsB>(name);
                            clinet.StudentPOSTAsync(json);
                        }
                        else if(st == 3)
                        {

                            Console.WriteLine("Введите id");
                            int iD = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите имя");
                            string firs_Name = Console.ReadLine();
                            Console.WriteLine("Введите фамилию");
                            string last_name = Console.ReadLine();
                            Console.WriteLine("Введите возраст");
                            int age = Convert.ToInt32(Console.ReadLine());
                            name = new StudentsB { iD = iD, firs_Name = firs_Name, last_name = last_name, age = age };
                            string json = JsonSerializer.Serialize<StudentsB>(name);
                            clinet.StudentPUTAsync(iD,json);
                        }
                        else if(st == 4) { clinet.StudentAllAsync(); }
                        else if(st == 5) {
                            Console.WriteLine("Введите id");
                            int iD = Convert.ToInt32(Console.ReadLine());
                            clinet.StudentDELETEAsync(iD); }
                        else { Console.WriteLine("Incorect VVod"); }
                        break;

                    case 2:
                        Console.WriteLine("Выберите над кем хотите провести операцию: \n1) Вывести все группы \n2) Добавить группу \n3) обновить грпууу \n4) вывести группу по ip \n5) Удалить грпуппу ");
                        int st1 = Convert.ToInt32(Console.ReadLine());
                        if (st1 == 1) { clinet.StudentGroupAllAsync(); }
                        else if (st1 == 2) {
                            Console.WriteLine("Введите id");
                            int iD = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите название");
                            string firs_Name = Console.ReadLine();
                            Console.WriteLine("Введите специальность");
                            string last_name = Console.ReadLine();
                            Console.WriteLine("Введите ид ученика");
                            int age = Convert.ToInt32(Console.ReadLine());
                            name2 = new StudentGroupsB { id = iD, name_Group = firs_Name, specialiZ_GROUP = last_name, studenT_ID = age };
                            string json = JsonSerializer.Serialize<StudentGroupsB>(name2);
                            clinet.StudentGroupPOSTAsync( json);
                        }
                        else if (st1 == 3) {
                            Console.WriteLine("Введите id");
                            int iD = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите название");
                            string firs_Name = Console.ReadLine();
                            Console.WriteLine("Введите специальность");
                            string last_name = Console.ReadLine();
                            Console.WriteLine("Введите ид ученика");
                            int age = Convert.ToInt32(Console.ReadLine());
                            name2 = new StudentGroupsB { id = iD, name_Group = firs_Name, specialiZ_GROUP = last_name, studenT_ID = age };
                            string json = JsonSerializer.Serialize<StudentGroupsB>(name2);
                            clinet.StudentGroupPUTAsync(iD, json);
                        }
                        else if (st1 == 4)
                        {
                            Console.WriteLine("Введите id");
                            int iD = Convert.ToInt32(Console.ReadLine()); 
                            clinet.StudentGroupGETAsync(iD); }
                        else if (st1 == 5) {
                            Console.WriteLine("Введите id");
                            int iD = Convert.ToInt32(Console.ReadLine());
                            clinet.StudentDELETEAsync(iD);
                        }
                        else { Console.WriteLine("Incorect VVod"); }
                        break;

                    case 3:
                        Console.WriteLine("Выберите над кем хотите провести операцию: \n1) Вывести все домашки \n2) Добавить домашки \n3) обновить домашки \n4) вывести домашку по ip \n5) Удалить домашку ");
                        int st2 = Convert.ToInt32(Console.ReadLine());
                        if (st2 == 1) { clinet.StudentsHomeVorkAllAsync(); }
                        else if (st2 == 2) {
                            Console.WriteLine("Введите id");
                            int iD = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите id студента");
                            int grouP_STUDENT_ID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите название");
                            string last_name = Console.ReadLine();
                            Console.WriteLine("Введите задание");
                            string age = Console.ReadLine();
                            name3 = new StudentsHomeVorksB { id = iD, grouP_STUDENT_ID = grouP_STUDENT_ID, nazvaniE_HOMEVORK = last_name, zadanie = age };
                            string json = JsonSerializer.Serialize<StudentsHomeVorksB>(name3);
                            clinet.StudentsHomeVorkPOSTAsync(json); }
                        else if (st2 == 3) {
                            Console.WriteLine("Введите id");
                            int iD = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите id студента");
                            int grouP_STUDENT_ID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите название");
                            string last_name = Console.ReadLine();
                            Console.WriteLine("Введите задание");
                            string age = Console.ReadLine();
                            name3 = new StudentsHomeVorksB { id = iD, grouP_STUDENT_ID = grouP_STUDENT_ID, nazvaniE_HOMEVORK = last_name, zadanie = age };
                            string json = JsonSerializer.Serialize<StudentsHomeVorksB>(name3);
                            clinet.StudentsHomeVorkPUTAsync(iD, json); }
                        else if (st2 == 4) {
                            Console.WriteLine("Введите id");
                            int iD = Convert.ToInt32(Console.ReadLine());
                            clinet.StudentsHomeVorkGETAsync(iD); }
                        else if (st2 == 5) {
                            Console.WriteLine("Введите id");
                            int iD = Convert.ToInt32(Console.ReadLine());
                            clinet.StudentsHomeVorkDELETEAsync(iD); }
                        else { Console.WriteLine("Incorect VVod"); }
                        break;

                    case 4:
                        Console.WriteLine("Выберите над кем хотите провести операцию: \n1) Вывести расписание \n2) Добавить расписание \n3) обновить расписание \n4) вывести расписание по ip \n5) Удалить расписание ");
                        int st3 = Convert.ToInt32(Console.ReadLine());
                        if (st3 == 1) { clinet.StudentsRaspisanieAllAsync(); }
                        else if (st3 == 2) {
                            Console.WriteLine("Введите id");
                            int iD = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите дату");
                            string grouP_STUDENT_ID = Console.ReadLine();
                            Console.WriteLine("Введите название");
                            string last_name = Console.ReadLine();
                            Console.WriteLine("Введите id студента");
                            int age = Convert.ToInt32(Console.ReadLine());
                            name4 = new StudentsRaspisaniesB { id = iD, datE_SI_VORK_STUDENT = grouP_STUDENT_ID, nazvaniE_PREDMETA = last_name, grouP_STUDENT_ID = age };
                            string json = JsonSerializer.Serialize<StudentsRaspisaniesB>(name4);
                            clinet.StudentsRaspisaniePOSTAsync(json);
                        }
                        else if (st3 == 3) {
                            Console.WriteLine("Введите id");
                            int iD = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите дату");
                            string grouP_STUDENT_ID = Console.ReadLine();
                            Console.WriteLine("Введите название");
                            string last_name = Console.ReadLine();
                            Console.WriteLine("Введите id студента");
                            int age = Convert.ToInt32(Console.ReadLine());
                            name4 = new StudentsRaspisaniesB { id = iD, datE_SI_VORK_STUDENT = grouP_STUDENT_ID, nazvaniE_PREDMETA = last_name, grouP_STUDENT_ID = age };
                            string json = JsonSerializer.Serialize<StudentsRaspisaniesB>(name4);
                            clinet.StudentsHomeVorkPUTAsync(iD, json); }
                        
                        else if (st3 == 4)
                        {
                            Console.WriteLine("Введите id");
                            int iD = Convert.ToInt32(Console.ReadLine());
                            clinet.StudentsRaspisanieGETAsync(iD); }
                        else if (st3 == 5)
                        {
                            Console.WriteLine("Введите id");
                            int iD = Convert.ToInt32(Console.ReadLine());
                            clinet.StudentsRaspisanieDELETEAsync(iD); }
                        else { Console.WriteLine("Incorect VVod"); }
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
