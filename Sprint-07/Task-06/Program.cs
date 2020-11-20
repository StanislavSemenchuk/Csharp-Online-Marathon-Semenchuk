using System;
using System.Text;
using System.Text.Json;
using System.Linq;
using System.Collections.Generic;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateGroups(new List<Student>() { new Student() { Name = "Denys", Rating = 84.2, GroupName = "Huilaki" }, new Student() { Name = "Stas", Rating = 84.2, GroupName = "Huilaki" }, new Student() { Name = "NeDenys", Rating = 84.2, GroupName = "NeHuilaki" } },
                new List<Group>() { new Group() { Name = "Huilaki", Description = "Huilaki", Popularity = 2 }, new Group() { Name = "NeHuilaki", Description = "NeHuilaki", Popularity = 1 } }));
        }

        public static string CreateGroups(List<Student> students, List<Group> groups)
        {
            var options = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                WriteIndented = true
            };

            return JsonSerializer.Serialize(groups.GroupJoin(students,
                g => g.Name,
                st => st.GroupName,
                (gr, stud) => new
                {
                    group = gr.Name,
                    description = gr.Description,
                    rating = stud.Average(s => s.Rating),
                    students = stud.Select(s => new { FullName = s.Name, AvgMark = s.Rating })
                }), options);
        }
    }
    class Student
    {
        public string Name { get; set; }
        public double Rating { get; set; }
        public string GroupName { get; set; }
    }

    class Group
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Popularity { get; set; }
    }


}
