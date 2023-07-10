﻿using System;
using System.Collections.Generic;
using System.Linq;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new []
            {
                new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
                new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
                new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
            };
            var allStudents = GetAllStudents(classes);
            
            Console.WriteLine(string.Join(" ", allStudents));
        }
        static string [] GetAllStudents( Classroom [] classes )
        {
            var result = classes.SelectMany(cls => cls.Students.Select(name=> name)).ToArray();
            return result;
        }
      
        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}