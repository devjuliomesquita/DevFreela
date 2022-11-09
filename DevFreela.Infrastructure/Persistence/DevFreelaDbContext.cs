using DevFreela.Core.Entities;
using DevFreela.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Meu projeto ASP .NET CORE 1", "Minhas descrições 1", 1, 1, 10000),
                new Project("Meu projeto ASP .NET CORE 2", "Minhas descrições 2", 1, 1, 20000),
                new Project("Meu projeto ASP .NET CORE 3", "Minhas descrições 3", 1, 1, 30000)
            };

            Users = new List<User>
            {
                new User("Júlio Cesar", "julio@mcamilo@gmail.com", new DateTime(1994,11,12)),
                new User("Amanda Maria", "AmandaMara@gmail.com", new DateTime(1994,1,4)),
            };

            Skills = new List<Skill>
            {
                new Skill(".NET CORE"),
                new Skill("C#"),
                new Skill("JAVASCRIPT"),
                new Skill("SQL"),
            };
        }

        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }

    }
}
