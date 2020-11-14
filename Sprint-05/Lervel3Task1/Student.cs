using System;
using System.Collections.Generic;
using System.Linq;

namespace Lervel3Task1
{
    public class Student
    {
        public int Id { get; }
        public string Name { get; }

        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public static HashSet<Student> GetCommonStudents(List<Student> StudentsList1, List<Student> StudentsList2) 
        {
                var intersected = StudentsList1.Intersect(StudentsList2).ToList();
                return new HashSet<Student>(intersected);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Student)) return false;

            Student student = obj as Student;
            return (this.Id == student.Id) && (this.Name == student.Name);
        }
        public override int GetHashCode()
        {
            return this.Id.GetHashCode() + (this.Name ?? "").GetHashCode();
        }
    }
}
