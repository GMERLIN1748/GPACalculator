using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACalculator1
{
    internal class GPACalculator
    {
        private double gpa_sum;
        private int n;
        private double maxGPA;
        private double minGPA;

        public GPACalculator()
        {
            gpa_sum = 0.0;
            n = 0;
            maxGPA = double.MinValue;
            minGPA = double.MaxValue;
        }

        public void SetGPA(double gpa)
        {
            gpa_sum += gpa;
            n++;
            if (gpa > maxGPA) maxGPA = gpa;
            if (gpa < minGPA) minGPA = gpa;
        }

        public double GetGPAx()
        {
            return n == 0 ? 0 : gpa_sum / n;
        }

        public double GetMaxGPA()
        {
            return maxGPA;
        }

        public double GetMinGPA()
        {
            return minGPA;
        }

        public int GetStudentCount()
        {
            return n;
        }

        internal object GetGPAListCount()
        {
            throw new NotImplementedException();
        }
    }

}
