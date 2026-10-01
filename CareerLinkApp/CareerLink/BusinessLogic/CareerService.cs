using System;
using System.Collections.Generic;
using System.Linq;
using CareerLink.Models;
using CareerLink.Repositories;

namespace CareerLink.BusinessLogic
{
   
    public class CareerService
    {
        private readonly CareersRepository repo = new CareersRepository();

        public List<Career> GetAllCareers()
        {
            return repo.GetAllCareers();
        }

        public Career GetCareer(int careerid)
        {
            return repo.GetCareer(careerid);
        }

        
        public Career FindCareer(string typedText)
        {
            typedText = (typedText ?? "").Trim();
            if (typedText == "")
                throw new BusinessRuleException("Please type the career you would like to pursue.");

            return repo.FindCareerByText(typedText);
        }

        
        public void Save(Career career)
        {
            career.Keyword = (career.Keyword ?? "").Trim();
            career.CareerName = (career.CareerName ?? "").Trim();

            if (career.Keyword == "")
                throw new BusinessRuleException("Please enter the keyword.");
            if (career.CareerName == "")
                throw new BusinessRuleException("Please enter the career name.");
            if (career.Subjects.Count == 0)
                throw new BusinessRuleException("Please enter at least one subject.");

            
            if (repo.KeywordExists(career.Keyword, career.CareerId))
                throw new BusinessRuleException("Another career already uses this keyword.");

            if (career.CareerId == 0)
                career.CareerId = repo.CreateCareer(career);
            else
                repo.UpdateCareer(career);
        }

        public void DeleteCareer(int careerid)
        {
            repo.DeleteCareer(careerid);
        }

     
        public static List<string> ParseSubjects(string text)
        {
            return (text ?? "")
                .Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(line => line.Trim())
                .Where(line => line != "")
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .ToList();
        }

        public static string SubjectsToText(List<string> subjects)
        {
            return string.Join(Environment.NewLine, subjects);
        }
    }
}
