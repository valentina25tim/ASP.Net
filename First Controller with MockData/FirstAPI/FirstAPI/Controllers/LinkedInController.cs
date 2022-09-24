using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Controllers
{
    
    [Route("[controller]")]
    [ApiController]

    public class LinkedInController : ControllerBase
    {
        // этоt текст только для теста ->
        
        private readonly string[]
            _workPeriod = { " 1 m 2010 - 2 a 2001, ", " 3 m 2012 - 2 a 2004, ", " 5 m 2016 - 2 a 2006, " },
            _nameCompany = { "Google", "Apple", "jjkj" },
            _urlCompany = { "google.com", "apple.com", "aghk.com" },
            _urlPersinSite = { "https://mysite", "https://mysite_2" };


        //это фиксированные в линкедине листы ->
        
        private List<string> _sectorJob = new List<string>
        {"Software development", "IT services and IT consulting","Technology, media and the Internet","etc." };
        private List<string> _role = new List<string>
        { "iOS developer","C# Developer","etc."};
        private List<string> _issuedBy = new List<string>
        { "Flipkart", "Microsoft", "McDonald's","etc."};

        //это фиксированные в линкедине листы + можно что-то своё написать ->
        
        private List<string> _nameEstabl = new List<string>
        {"Parul University","The London School of Economics and Political Science (LSE)" };
        private List<string> _degree = new List<string>
        { "Bachelor of Laws - LLB", "Doctor's Degree","etc."};


        [HttpGet]
        public Person GetPerson()
        {
            return new Person
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = "Timur",
                LastName = "Rustamov",

                Address = new Address
                {
                    Id = Guid.NewGuid().ToString(),
                    Country = "Ukraine",
                    City = "Kyiv",
                },

                ContactInfo = new ContactInfo
                {
                    Id = Guid.NewGuid().ToString(),
                    UrlProfileLinkedIn = "https://www.linkedin.com/",
                    EMail = "person@gmail.com",
                    PhoneNumber = "+380961234567"
                },

                CurrentStatus = new CurrentStatus
                {
                    Id = Guid.NewGuid().ToString(),
                    WaitOffer = false,
                    SectorJob = _sectorJob.ElementAt(1),
                    Role = _role.ElementAt(1),
                    TypeJob = TypeJob.Full_time.ToString(),
                },
                AdditionInfos = additionInfos(),
                WorkExperiences = workExperiences(),
                Certificates = certificates(),
                Skills = skills(),
                Languages = languages(),
                Attachments = attachments(),
                Educations = educations(),
            };
        }
     
        private IEnumerable<AdditionInfo> additionInfos()
        {
            List<AdditionInfo> ai = new List<AdditionInfo>();

            for (var i = 0; i < _urlPersinSite.Length; i++)
            {
                AdditionInfo additionInfo = new AdditionInfo
                {
                    Id = Guid.NewGuid().ToString(),
                    UrlPersonSite = _urlPersinSite[i],
                    TypePersonSite = TypePersonSite.Personal.ToString(),
                };
                ai.Add(additionInfo);
            }
            return ai;
        }
        private IEnumerable<WorkExperience> workExperiences()
        {
            List<WorkExperience> we = new List<WorkExperience>();

            for (var i = 0; i < 3; i++)
            {
                WorkExperience workExperience = new WorkExperience()
                {
                    Id = Guid.NewGuid().ToString(),
                    NameCompany = _nameCompany[i],
                    UrlCompany = $"http://{_urlCompany[i]}",
                    Role = _role[i],
                    TypeJob = TypeJob.Full_time.ToString(),
                    Started = DateTime.Now,//not now))
                    Unemployed = DateTime.Now,
                    Duration = i
                };
                we.Add(workExperience); 
            }
            return we;
        }
        private IEnumerable<Certificate> certificates()
        {
            List<Certificate> c = new List<Certificate>();

            for (var i = 0; i<2; i++)
            {
                Certificate certificate = new Certificate()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = $"sms -{i}",
                    IssuedBy = _issuedBy.ElementAt(i),
                    Date = DateTime.Now
                };
                c.Add(certificate);
            }
            return c;
        }
        private IEnumerable<Skill> skills()
        {
            List <Skill> s = new List<Skill>();

            for (var i = 0; i<3; i++)
            {
                Skill skill = new Skill()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = $"something - {i}",
                    CountFullConfirm = 2*i
                };
                s.Add(skill);
            }
            return s;
        }
        private IEnumerable<Language> languages()
        {
            List<Language> l = new List<Language>();

            for(var i = 0; i<2; i++)
            {
                Language language = new Language()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = $"Language !!!Something - {i}",
                    Level = Level.Advance.ToString()
                };
                l.Add(language);
            }
            return l;
        }
        private IEnumerable<Attachment> attachments()
        {
            List<Attachment> a = new List<Attachment>();

            for (var i = 4; i<4; i++)
            {
                Attachment attachment = new Attachment()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = $" - >Alina  - {i}",
                };
                a.Add(attachment);
            }
            return a;
        }
        private IEnumerable<Education> educations()
        {
            List<Education> e = new List<Education>();

            for (var i = 0; i< 2; i++)
            {
                Education education = new Education()
                {
                    Id = Guid.NewGuid().ToString(),
                    NameEstablishment = _nameEstabl.ElementAt(i),
                    Speciality = $"Speciality !!! Something - {i}",
                    Degree = _degree.ElementAt(i),
                    StudyBegin = DateTime.Now,
                    StudyFinish = DateTime.Now,
                };
                e.Add(education);
            }
            return e;
        }
    }
}
