namespace MyFirstWcfApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("Exam")]
    [DataContract]
    public partial class Exam
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataMember]
        public int ID { get; set; }

        [StringLength(50)]
        [DataMember]
        public string CourseName { get; set; }
    }
}
