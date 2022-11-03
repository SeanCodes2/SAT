using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace SAT.DATA.EF.Models
{
    //internal class Partials
    //{}


    [ModelMetadataType(typeof(CourseMetadata))]
    public partial class Course { }



    [ModelMetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment { }



    [ModelMetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass 
    {
        public string CourseDesc { get { return $"{StartDate} - {Course.CourseName} - {Location}"; } }
    
    }




    [ModelMetadataType(typeof(ScheduledClassStatusMetadata))]
    public partial class ScheduledClassStatus { }



    [ModelMetadataType(typeof(StudentMetadata))]
    public partial class Student
    {        
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        
    }



    [ModelMetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus { }



}


