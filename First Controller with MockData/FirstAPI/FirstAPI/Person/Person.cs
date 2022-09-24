using System.Collections.Generic;

namespace FirstAPI.Controllers
{
    public class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Address Address { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public CurrentStatus CurrentStatus { get; set; }

        public IEnumerable<AdditionInfo> AdditionInfos { get; set; }
        public IEnumerable<WorkExperience> WorkExperiences { get; set; }
        public IEnumerable<Certificate> Certificates { get; set; }
        public IEnumerable<Skill> Skills { get; set; }
        public IEnumerable<Language> Languages { get; set; }
        public IEnumerable<Attachment> Attachments { get; set; }
        public IEnumerable<Education> Educations { get; set; }
    }
}
