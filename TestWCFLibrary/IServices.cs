using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestWCFLibrary
{
    [ServiceContract]
    interface IServices
    {
        [OperationContract]
        string GetData();
        [OperationContract]
        string GetMessage(string name);
        [OperationContract]
        int[] GetSorted(int [] numbers);
        [OperationContract]
        string GetResult(string name, int mark1,int mark2, int mark3);
        [OperationContract]
        Student GetTopper(List<Student> students);
        [OperationContract]
        List<DeviceUsers> GetUsers();
    }
    [DataContract]
    public class DeviceUsers
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string userName { get; set; }
    }
}
