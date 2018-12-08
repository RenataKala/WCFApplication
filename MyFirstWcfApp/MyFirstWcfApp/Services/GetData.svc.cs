using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyFirstWcfApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GetData" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GetData.svc or GetData.svc.cs at the Solution Explorer and start debugging.
   
    public class GetData : IGetData
    {
        private Entities db = new Entities();

        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        public Student GetById(int id)
        {
            return db.Students.FirstOrDefault(x => x.ID == id);
        }
        public Student GetByName(string name)
        {
            return db.Students.FirstOrDefault(x => x.FullName == name);
        }

        public List<Exam> GetExams()
        {
            return db.Exams.ToList();
        }
    }
}
