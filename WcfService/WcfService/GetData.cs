using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GetData" in both code and config file together.
    public class GetData : IGetData
    {
        private Model1 db = new Model1();
        public Student GetStudent(int id)
        {
            return db.Students.FirstOrDefault(x=>x.ID == id) ;
        }

        public List<Student> GetAllStudents()
        {
            return db.Students.ToList();
        }
    }
}
