using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyFirstWcfApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPostData" in both code and config file together.
    [ServiceContract]
    public interface IPostData
    {
        [OperationContract]
        void UpdateName(Student std);

        [OperationContract]
        void AddStudent(Student std);

        [OperationContract]
        void AddExam(Exam exam);
    }
}
