using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyFirstWcfApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PostData" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PostData.svc or PostData.svc.cs at the Solution Explorer and start debugging.
    public class PostData : IPostData
    {
        private Entities db = new Entities();

        public void AddExam(Exam exam)
        {
            if (exam == null) return;
            db.Exams.Add(exam);
            db.SaveChanges();
        }

        public void AddStudent(Student std)
        {
            if (std == null) return;
            db.Students.Add(std);
            db.SaveChanges(); 
        }

        public void UpdateName(Student std)
        {
            var updatedStudent = db.Students.FirstOrDefault(x => x.ID == std.ID);
            updatedStudent.FullName = std.FullName;
            db.SaveChanges();
        }

        
    }
}
