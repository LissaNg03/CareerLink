using System;
using System.Collections.Generic;
using System.Linq;
using CareerLink.Models;
using CareerLink.Repositories;

namespace CareerLink.BusinessLogic
{
    
    public class StreamService
    {
        private readonly StreamsRepository streamsRepo = new StreamsRepository();
        private readonly FieldsRepository fieldsRepo = new FieldsRepository();
        private readonly SubjectsRepository subjectsRepo = new SubjectsRepository();

        public List<Field> GetFields()
        {
            return fieldsRepo.GetAllFields();
        }

        public List<StudyStream> GetAllStreams()
        {
            return streamsRepo.GetAllStreams();
        }

        public StudyStream GetStream(int streamid)
        {
            return streamsRepo.GetStream(streamid);
        }

      
        public List<StudyStream> GetQualifiedStreams(int fieldid, Dictionary<string, int> marks)
        {
            var qualified = new List<StudyStream>();

            foreach (StudyStream stream in streamsRepo.GetStreamsForField(fieldid))
            {
                bool meetsAll = true;
                foreach (StreamRequirement req in stream.Requirements)
                {
                    if (!MeetsRequirement(marks, req))
                    {
                        meetsAll = false;
                        break;
                    }
                }
                if (meetsAll) qualified.Add(stream);
            }
            return qualified;
        }

      
        private static bool MeetsRequirement(Dictionary<string, int> marks, StreamRequirement req)
        {
            foreach (var mark in marks)
            {
                bool sameSubject =
                    string.Equals(mark.Key, req.SubjectName, StringComparison.OrdinalIgnoreCase) ||
                    mark.Key.StartsWith(req.SubjectName + " (", StringComparison.OrdinalIgnoreCase);

                if (sameSubject && mark.Value >= req.MinPercent)
                    return true;
            }
            return false;
        }

    
        public void Save(StudyStream stream)
        {
            stream.StreamName = (stream.StreamName ?? "").Trim();

            if (stream.FieldId <= 0)
                throw new BusinessRuleException("Please choose a field.");
            if (stream.StreamName == "")
                throw new BusinessRuleException("Please enter the stream name.");

           
            List<string> subjectNames = subjectsRepo.GetAllSubjects().Select(s => s.SubjectName).ToList();
            foreach (StreamRequirement req in stream.Requirements)
            {
                bool known = subjectNames.Any(n =>
                    string.Equals(n, req.SubjectName, StringComparison.OrdinalIgnoreCase) ||
                    n.StartsWith(req.SubjectName + " (", StringComparison.OrdinalIgnoreCase));

                if (!known)
                    throw new BusinessRuleException("\"" + req.SubjectName +
                        "\" is not a known subject. Check the spelling or add it under Manage Subjects.");
            }

           
            if (streamsRepo.StreamExists(stream.FieldId, stream.StreamName, stream.StreamId))
                throw new BusinessRuleException("This field already has a stream with that name.");

            if (stream.StreamId == 0)
                stream.StreamId = streamsRepo.CreateStream(stream);
            else
                streamsRepo.UpdateStream(stream);
        }

        public void DeleteStream(int streamid)
        {
            streamsRepo.DeleteStream(streamid);
        }

     
        public static List<StreamRequirement> ParseRequirements(string text)
        {
            var list = new List<StreamRequirement>();

            foreach (string rawLine in (text ?? "").Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
            {
                string line = rawLine.Trim();
                if (line == "") continue;

                int colon = line.LastIndexOf(':');
                string subject = colon > 0 ? line.Substring(0, colon).Trim() : "";
                string percentText = colon > 0 ? line.Substring(colon + 1).Trim().TrimEnd('%').Trim() : "";

                int percent;
                if (subject == "" || !int.TryParse(percentText, out percent) || percent < 0 || percent > 100)
                    throw new BusinessRuleException("Please write each requirement like this: Mathematics: 60\n(problem line: " + line + ")");

                if (list.Any(r => string.Equals(r.SubjectName, subject, StringComparison.OrdinalIgnoreCase)))
                    throw new BusinessRuleException("\"" + subject + "\" is listed twice.");

                list.Add(new StreamRequirement { SubjectName = subject, MinPercent = percent });
            }
            return list;
        }

        public static string RequirementsToText(List<StreamRequirement> requirements)
        {
            return string.Join(Environment.NewLine, requirements.Select(r => r.SubjectName + ": " + r.MinPercent));
        }

     
        public static string RequirementsSummary(List<StreamRequirement> requirements)
        {
            return string.Join(", ", requirements.Select(r => r.SubjectName + " " + r.MinPercent + "%"));
        }
    }
}
