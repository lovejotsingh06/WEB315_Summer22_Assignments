using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace journalism.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new journalismContext(
                serviceProvider.GetRequiredService<DbContextOptions<journalismContext>>()))
            {
                // Look for any journalism1.
                if (context.journalism1.Any())
                {
                    return;   // DB has been seeded
                }

                context.journalism1.AddRange(
                    new journalism1
                    {
                        Name = "Christiane Amanpour",
                        DateofBirth = new DateTime(1958, 1, 12),
                        Country = "United Kingdom",
                        Language = "English",
                        Award = "11 News and Documentary Emmy Awards, several Peabody Awards",
                        Stories = "Coverage of the Gulf War, Bosnian War, Rwanda genocide, Arab Spring, and interviews with world leaders."
                    },
                    new journalism1
                    {
                        Name = "Anderson Cooper",
                        DateofBirth = new DateTime(1967, 6, 3),
                        Country = "United States",
                        Language = "English",
                        Award = "Multiple Emmy Awards, Peabody Award",
                        Stories = "Reporting on Hurricane Katrina, conflicts in Iraq and Afghanistan, and hosting the CNN program 'Anderson Cooper 360°.'"
                    },
                    // Add the remaining journalism1 here
                    new journalism1
                    {
                        Name = "María Elena Salinas",
                        DateofBirth = new DateTime(1954, 12, 20),
                        Country = "United States",
                        Language = "English, Spanish",
                        Award = "Multiple Emmy Awards, Peabody Award, Edward R. Murrow Award",
                        Stories = "Coverage of immigration issues, presidential elections, and hosting the news program 'Noticiero Univision.'"
                    },
                    new journalism1
                    {
                        Name = "Gideon Levy",
                        DateofBirth = new DateTime(1953, 12, 27),
                        Country = "Israel",
                        Language = "Hebrew",
                        Award = "Olof Palme Prize, Peace and Justice Award of the Martin Luther King Jr. Memorial Center",
                        Stories = "Critically covering the Israeli-Palestinian conflict, human rights issues, and advocating for peace and justice."
                    },
                    new journalism1
                    {
                        Name = "Jineth Bedoya Lima",
                        DateofBirth = new DateTime(1974, 10, 14),
                        Country = "Colombia",
                        Language = "Spanish",
                        Award = "Courage in Journalism Award, International Women's Media Foundation Award",
                        Stories = "Investigative journalism on armed conflict, gender-based violence, and advocating for women's rights."
                    },
                    new journalism1
                    {
                        Name = "Rami Jarrah",
                        DateofBirth = new DateTime(1984, 9, 10),
                        Country = "Syria",
                        Language = "Arabic, English",
                        Award = "International Press Freedom Award, Index on Censorship Freedom of Expression Award",
                        Stories = "Reporting on the Syrian civil war, documenting the plight of refugees, and advocating for press freedom."
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
