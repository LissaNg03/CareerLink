using System;
using System.Collections.Generic;
using System.Linq;
using CareerLink.Models;
using CareerLink.Repositories;

namespace CareerLink.BusinessLogic
{
    
    public class SubjectService
    {
        public static readonly string[] GradeRanges = { "Grade 9", "Grades 9-12", "Grades 10-12" };

        private readonly SubjectsRepository repo = new SubjectsRepository();

        public List<Subject> GetAllSubjects()
        {
            return repo.GetAllSubjects();
        }

        public Subject GetSubject(int subjectid)
        {
            return repo.GetSubject(subjectid);
        }

        public List<string> GetSubjectNames()
        {
            return repo.GetAllSubjects().Select(s => s.SubjectName).ToList();
        }

        public List<string> GetCategories()
        {
            return repo.GetAllSubjects().Select(s => s.Category)
                       .Distinct().OrderBy(c => c).ToList();
        }

       
        public void Save(Subject subject)
        {
            subject.SubjectName = (subject.SubjectName ?? "").Trim();
            subject.Category = (subject.Category ?? "").Trim();
            subject.GradeRange = (subject.GradeRange ?? "").Trim();

            if (subject.SubjectName == "")
                throw new BusinessRuleException("Please enter the subject name.");
            if (subject.Category == "")
                throw new BusinessRuleException("Please enter or choose a category.");
            if (subject.GradeRange == "")
                throw new BusinessRuleException("Please choose the grade range.");

            
            if (repo.NameExists(subject.SubjectName, subject.SubjectId))
                throw new BusinessRuleException("A subject with this name already exists.");

            if (subject.SubjectId == 0)
                subject.SubjectId = repo.CreateSubject(subject);
            else
                repo.UpdateSubject(subject);
        }

        public void DeleteSubject(int subjectid)
        {
            repo.DeleteSubject(subjectid);
        }
    }
}
