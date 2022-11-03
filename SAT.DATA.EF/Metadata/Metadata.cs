using SAT.DATA.EF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF.Models
{
    //internal class Metadata
    //{}
        
        public class CourseMetadata
        {
            [Display(Name="Course Id")]
            public int CourseId { get; set; }

            [StringLength(50, ErrorMessage = "*Cannot Exceed 50 Characters")]
            [Display(Name ="Course Name")]
            [Required(ErrorMessage ="Course Name Required")]
            public string CourseName { get; set; } = null!;

            [StringLength(250, ErrorMessage = "*Cannot Exceed 250 Characters")]
            [Display(Name = "Course Description")]
            [Required(ErrorMessage = "Course Name Required")]
            [DataType(DataType.MultilineText)]
            public string CourseDescription { get; set; } = null!;

            [Required(ErrorMessage ="Credit Hours Required")]
            [Display(Name ="Credit Hours")]
            public byte CreditHours { get; set; }

            [StringLength(250, ErrorMessage = "*Cannot Exceed 250 Characters")]
            [Display(Name = "Curriculum")]
            [Required(ErrorMessage = "Curriculum Required")]
            [DataType(DataType.MultilineText)]
            public string Curriculum { get; set; } = null!;

            [StringLength(500, ErrorMessage = "*Cannot Exceed 500 Characters")]
            [Display(Name = "Notes")]
            [DataType(DataType.MultilineText)]
            public string? Notes { get; set; }
                        
            [Display(Name = "Is Active?")]
            [Required(ErrorMessage = "Is Active? Required")]
            public bool IsActive { get; set; }
        }

        public class EnrollmentMetadata
        {
            [Display(Name ="Enrollment Id")]
            public int EnrollmentId { get; set; }

            [Required(ErrorMessage ="Student Id Required")]
            [Display(Name = "Student Id")]
            public int StudentId { get; set; }

            [Required(ErrorMessage = "Scheduled Class Id Required")]
            [Display(Name = "Scheduled Class Id")]
            public int ScheduledClassId { get; set; }

            [DataType(DataType.DateTime)]
            [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="{0:d}")]
            [Required(ErrorMessage ="Enrollment Date Required")]
            public DateTime EnrollmentDate { get; set; }
        }

        public class ScheduledClassMetadata
        {
            [Display(Name ="Scheduled Class Id")]
            public int ScheduledClassId { get; set; }
                        
            [Display(Name = "Course Id")]
            [Required]
            public int CourseId { get; set; }

            [Display(Name = "Start Date")]
            [Required]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
            public DateTime StartDate { get; set; }

            [Display(Name = "End Date")]
            [Required]
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
            public DateTime EndDate { get; set; }

            [Display(Name = "Instructor Name")]
            [Required(ErrorMessage ="Instructor Name Required")]
            [StringLength(40, ErrorMessage ="Max 40 Characters")]
            public string InstructorName { get; set; } = null!;

            
            [Required(ErrorMessage = "Location Required")]
            [StringLength(20, ErrorMessage = "Max 20 Characters")]
            public string Location { get; set; } = null!;

            [Display(Name ="Scheduled Class Status Id")]
            public int Scsid { get; set; }
        }

        public class ScheduledClassStausMetadata
        {
            [Display(Name ="Scheduled Class Status Id")]
            public int Scsid { get; set; }

            [Required(ErrorMessage ="Status Name Required")]
            [StringLength(50, ErrorMessage ="Max 50 Characters")]
            public string Scsname { get; set; } = null!;

        }

        public class StudentMetadata
        {
            [Display(Name ="Student Id")]
            public int StudentId { get; set; }

            [StringLength(20, ErrorMessage = "*Cannot Exceed 20 Characters")]
            [Display(Name = "First Name")]
            [Required(ErrorMessage = "First Name Required")]
            public string FirstName { get; set; } = null!;

            [StringLength(20, ErrorMessage = "*Cannot Exceed 20 Characters")]
            [Display(Name = "Last Name")]
            [Required(ErrorMessage = "Last Name Required")]
            public string LastName { get; set; } = null!;

            [StringLength(15, ErrorMessage = "*Cannot Exceed 15 Characters")]
            [Display(Name = "Major")]            
            public string? Major { get; set; }

            [StringLength(50, ErrorMessage = "*Cannot Exceed 50 Characters")]
            [Display(Name = "Address")]
            public string? Address { get; set; }

            [StringLength(25, ErrorMessage = "*Cannot Exceed 25 Characters")]
            [Display(Name = "City")]
            public string? City { get; set; }

            [StringLength(2, ErrorMessage = "*Cannot Exceed 2 Characters")]
            [Display(Name = "State")]
            public string? State { get; set; }

            [StringLength(10, ErrorMessage = "*Cannot Exceed 10 Characters")]
            [Display(Name = "ZipCode")]
            [DataType(DataType.PostalCode)]
            public string? ZipCode { get; set; }

            [StringLength(13, ErrorMessage = "*Cannot Exceed 13 Characters")]
            [Display(Name = "Phone")]
            [DataType(DataType.PhoneNumber)]
            public string? Phone { get; set; }

            [StringLength(50, ErrorMessage = "*Cannot Exceed 50 Characters")]
            [Display(Name = "Email")]
            [Required(ErrorMessage ="Email Required")]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; } = null!;

            [StringLength(100, ErrorMessage = "*Cannot Exceed 100 Characters")]
            [Display(Name = "Phote URL")]
            public string? PhotoUrl { get; set; }

            [Display(Name ="Student Status Id")]
            public int Ssid { get; set; }
        }

        public class StudentStatusMetadata
        {
            [Display(Name ="Student Status Id")]
            public int Ssid { get; set; }

            [StringLength(30, ErrorMessage = "*Cannot Exceed 30 Characters")]
            [Display(Name = "Student Status")]
            [Required(ErrorMessage ="Student Status Required")]
            public string Ssname { get; set; } = null!;

            [StringLength(250, ErrorMessage = "*Cannot Exceed 250 Characters")]
            [Display(Name = "Student Status Description")]
            public string? Ssdescription { get; set; }
        }
    
}
