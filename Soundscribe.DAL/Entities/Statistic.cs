using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soundscribe.DAL.Entities
{
    public class Statistic
    {
        public int Id { get; set; }

        public User? User { get; set; }

        public int UserId {  get; set; }

        public int TestsTaken { get; set; }

        public double AverageGrade { get; set; }

        public double MinGrade { get; set; }

        public double MaxGrade { get; set; }
    }
}
