//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Niit.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class An
    {
        public int AnsID { get; set; }
        public int QuestionID { get; set; }
        [Required(ErrorMessage = "please Enter Your Answer")]
        public string Answer { get; set; }
    
        public virtual Task1 Task1 { get; set; }
    }
}