using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDiary
{
    public class Lesson
    {
        public string Subject { get; set; }
        public string Classroom { get; set; }
        public string Teacher { get; set; }
        public string Time { get; set; }

        public Lesson(string time, string subject, string classroom, string teacher)
        {
            Subject = subject;
            Classroom = classroom;
            Teacher = teacher;
            Time = time;
        }
    }
}
