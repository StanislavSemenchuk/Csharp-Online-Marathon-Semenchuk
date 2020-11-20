using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker w = new Worker("Anna", 700, new Department("Mechanics", 1, new Worker("Tom", 600, null)));
            Console.WriteLine(w.Serialize());
        }

        public class Department 
        {
            public string Name { get; set; }
            public int Id { get; set; }
            public Worker Manager { get; set; }
            public Department(string Name, int Id, Worker Manager)
            {
                this.Name = Name;
                this.Id = Id;
                this.Manager = Manager;
            }
            public Department()
            {

            }
        }
        public class Worker
        {
            [JsonIgnore]
            public int Id { get; set; }
            [JsonPropertyName("Full name")]
            public string Name { get; set; }
            public decimal Salary { get; set; }
            public  Department Department { get; set; }
            public Worker(string name, decimal salary, Department department)
            {
                Name = name;
                Salary = salary;
                Department = department;
            }
            public Worker()
            {

            }

            public string Serialize()
            {
                Worker worker = this;
                var options = new JsonSerializerOptions
                {
                    IgnoreNullValues = true,
                    WriteIndented = true
                };
                return JsonSerializer.Serialize(worker, options);
            }

            public static Worker Deserialize(string serializedWorker) 
            {
                var options = new JsonSerializerOptions
                {
                    IgnoreNullValues = true,
                    WriteIndented = true
                };
                Worker deserializetedWorker = JsonSerializer.Deserialize<Worker>(serializedWorker, options);
                return deserializetedWorker;
            }
        }
    }
}
