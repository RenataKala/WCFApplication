namespace MyFirstWcfApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("Student")]
    [DataContract]
    public partial class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataMember]
        public int ID { get; set; }

        [StringLength(50)]
        [DataMember]
        public string FullName { get; set; }
    }
}
