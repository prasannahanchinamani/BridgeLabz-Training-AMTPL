using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.ADONEt
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public static void Main(string[] args)
        {
            //StudnetRepo repo=new StudnetRepo();
            //StudnetRepo.CreateTable();
            Student studnet = new Student()
            {
                Id=3,
                Name="Prasanna",
                Email="Prasannagoto@gmail.com"
            };
            //StudnetRepo.InsertValues(studnet);
            StudnetRepo.UpdateValues(1, "Prasanna", "prasannahanchinamani.15@gmail.com");
            //StudnetRepo.DeleteValues(3);
            StudnetRepo.DisplayStudents();
        }

    }
}
