using System.Runtime.Serialization;

namespace TestWCFLibrary
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int mark1 { get; set; }
        [DataMember]
        public int mark2 { get; set; }
        [DataMember]
        public int mark3 { get; set; }
    }
}