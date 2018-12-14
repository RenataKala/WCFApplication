using NLog;
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
    public class PostData : IPostData,IDisposable
    {
        private Entities db = new Entities();
        static Logger logger = LogManager.GetLogger("fileLogger");

        public void AddExam(Exam exam)
        {                        
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
            if(updatedStudent == null)
            {
                logger.Error("No student found"); return;
            }
            updatedStudent.FullName = std.FullName;
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public void UpdateExamName(Exam exam)
        {
            var updatedExam = db.Exams.FirstOrDefault(x => x.ID == exam.ID);
            updatedExam.CourseName = exam.CourseName;
            db.SaveChanges();
        }


    }
}
