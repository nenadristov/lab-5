using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public struct PerformanceLevel
    {
        // Private fields.
        private int ranking;
        private int total_score;

        // Helper functions.
        public PerformanceLevel(int ranking = 1, int score = 0)
        {
            this.ranking = ranking;
            this.total_score = score;
        }

        public override string ToString()
        {
            Console.WriteLine($"Rankings: {ranking}, Total: {total_score}, Effective Average: {EffectiveAverageScore}\n\n");
            return $"Rankings: {ranking}, Total: {total_score}, Effective Average: {EffectiveAverageScore}";
        }

        public int EffectiveAverageScore
        {
            get { return total_score / ranking; }
        }

        // Operators.
        public static PerformanceLevel operator +(PerformanceLevel perform, int score)
        {
            return new PerformanceLevel(perform.ranking + 1, perform.total_score + score);
        }

        public static bool operator ==(PerformanceLevel p1, PerformanceLevel p2)
        {
            return p1.EffectiveAverageScore == p2.EffectiveAverageScore;
        }

        public static bool operator !=(PerformanceLevel p1, PerformanceLevel p2)
        {
            return p1.EffectiveAverageScore != p2.EffectiveAverageScore;
        }

        public static bool operator ==(PerformanceLevel p1, int otherScore)
        {
            return p1.EffectiveAverageScore == otherScore;
        }

        public static bool operator !=(PerformanceLevel p1, int otherScore)
        {
            return p1.EffectiveAverageScore != otherScore;
        }

        public static bool operator >(PerformanceLevel p1, PerformanceLevel p2)
        {
            return p1.EffectiveAverageScore > p2.EffectiveAverageScore;
        }

        public static bool operator <(PerformanceLevel p1, PerformanceLevel p2)
        {
            return p1.EffectiveAverageScore < p2.EffectiveAverageScore;
        }

        public static bool operator >(PerformanceLevel p1, int otherScore)
        {
            return p1.EffectiveAverageScore > otherScore;
        }

        public static bool operator <(PerformanceLevel p1, int otherScore)
        {
            return p1.EffectiveAverageScore < otherScore;
        }
    }
}
