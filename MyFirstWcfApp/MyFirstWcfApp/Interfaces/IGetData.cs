 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyFirstWcfApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGetData" in both code and config file together.
    [ServiceContract]
    public interface IGetData
    {
        [OperationContract]
        List<Student> GetStudents() ;

        [OperationContract]
        Student GetById(int id);

        [OperationContract]
        Student GetByName(string name);

        [OperationContract]
        List<Exam> GetExams();

        [OperationContract]
        Exam GetExamByName(string name);

        [OperationContract]
        void GetNum(int id);
    }
}
