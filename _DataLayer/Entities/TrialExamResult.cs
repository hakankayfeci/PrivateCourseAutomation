//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _DataLayer.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrialExamResult
    {
        public int TrialExamResultId { get; set; }
        public Nullable<int> Notu { get; set; }
        public Nullable<int> TrialExamId { get; set; }
        public Nullable<int> StudentId { get; set; }
        public Nullable<int> CharacterNoteId { get; set; }
    
        public virtual CharacterNote CharacterNote { get; set; }
        public virtual Student Student { get; set; }
        public virtual TrialExam TrialExam { get; set; }
    }
}
