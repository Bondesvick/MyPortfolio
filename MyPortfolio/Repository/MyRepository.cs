using MyPortfolio.Models;

namespace MyPortfolio.Repository
{
    public class MyRepository : IRepository
    {
        /// <summary>
        /// Returns an object of the user details
        /// </summary>
        /// <returns>The user details object</returns>
        public MyDetails GetAllData()
        {
            return new MyDetails()
            {
                FirstName = "Victor",
                SecondName = "Nwike",
                School1 = "Nnamdi Azikiwe University",
                School1Major = "Industrial Physics",
                School1Details = "Geological Physics of the Earth, Electronic & Computational Physics, and Nuclear Physics.",
                School2 = "Decagon",
                School2Major = "Agile Software Engineering",
                School2Details = "C# and .Net technologies Software development with Agile methodologies.",
                Skills = "C#, ASP.NET, MSSQLServer, Entity Framework, Winforms, WPF and UWP",
                Occupation = "Software Engineer",
                YearsOfExperience = 2,
                Introduction1 = "Hi, if you need any .Net project done for you on C#, ASP.NET Core, MMSQLServer, Entity Framework, WPF, WInforms and etc, I am available to help you with that. If you need a landing page or Website design within a day? then you can tell me, I'm here to help you. I can design any kind of web App.",
                Introduction2 = "If you need  PSD template, landing page or Website design within a day? then you can tell me, I'm here to help you. I can design any kind of PSD template. Check my portfolio.",
                Email = "bondesvick@gmail.com",
                ResumeLink = "https://drive.google.com/file/d/1-FVHmQ__yg6fd04A_LW4RamnniGpvDNm/view?usp=sharing",
                Facebook = "https://www.facebook.com/bondesvick",
                Twitter = "https://twitter.com/bondesvick",
                Instagram = "https://www.instagram.com/bondesvick/",
                LinkedIn = "https://www.linkedin.com/in/nwike-victor/",
                GitHub = "https://github.com/Bondesvick",
                ProfileImage1 = "../ThemeDoc/images/blog/WebPortfolio.png",
                ProfileImage2 = "../ThemeDoc/images/blog/hire.png",
                Porfolio1 = "https://github.com/Bondesvick/MyPortfolio",
                Porfolio2 = "https://github.com/Bondesvick/Hotel-Management-System",
                Porfolio3 = "https://bondesvick.github.io/FirstUI/",
                Porfolio4 = "https://matchbooksocial.netlify.app/",
                Porfolio5 = "https://fe-dashboard.netlify.app/",
                GitRepos = "https://github.com/Bondesvick?tab=repositories",
                Porfolio1Image = "../ThemeDoc/images/blog/thistemp.png",
                Porfolio2Image = "../ThemeDoc/images/blog/htl.png",
                Porfolio3Image = "../ThemeDoc/images/blog/gitpag.png",
                Porfolio4Image = "../ThemeDoc/images/blog/matchbook.png",
                Porfolio5Image = "../ThemeDoc/images/blog/fe-dash.png"
            };
        }
    }
}