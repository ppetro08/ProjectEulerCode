using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    class GradeBook {
        public List<double> Scores { get { return scores; } }
        private string filename;
        private List<double> scores = new List<double>();

        public GradeBook(string file) {
            string line;
            filename = file;
            StreamReader sr = new StreamReader(filename);
            while ((line = sr.ReadLine()) != null)
            {
                scores.Add(double.Parse(line));
            }
            sr.Close();
        }
        public GradeBook(GradeBook that)
        {
            scores = that.Scores;
        }
        public void addScore(double score) 
        {
            scores.Add(score);
        }
        public double getScoreAt(int i)
        {
            return scores.ElementAt(i);
        }
        public int getCount()
        {
            return scores.Count();
        }
        public string getSourceFile()
        {
            return filename;
        }
        public double getMean()
        {
            return scores.Average();
        }
        public double getMin()
        {
            double min = 100;
            for (int i = 0; i < this.getCount(); i++)
            {
                if (this.getScoreAt(i) < min)
                {
                    min = scores[i];
                }
            }
            return min;
        }
        public double getMax()
        {
            double max = 0;
            for (int i = 0; i < this.getCount(); i++)
            {
                if (this.getScoreAt(i) > max)
                {
                    max = scores[i];
                }
            }
            return max;
        }
        public double getMedian()
        {
            double median = 0;
            scores.Sort();
            if (scores.Count() % 2 == 0)
            {
                int half = scores.Count() / 2;
                median = scores[half - 1];
                median += scores[half];
                return median / 2;
            }
            else
            {
                return scores[scores.Count() / 2];
            }
        }
        public double getStdDev()
        {
            double mean = this.getMean();
            int total = 0;
            for (int i = 0; i < this.getCount(); i++)
            {
                total += (int)Math.Pow(Math.Abs(scores[i]-mean), 2);
            }
            return Math.Sqrt(total);
        }
        public int scoresInRange(int low, int high)
        {
            int count = 0;
            for (int i = 0; i < this.getCount(); i++)
            {
                if (scores[i] < high && scores[i] >= low)
                {
                    count++;
                }
            }
            return count;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter(@"C:\debug.txt");
            Random rnd = new Random();
            int rand = rnd.Next(0, 101);
            writer.WriteLine(rand);
            /*GradeBook gb = new GradeBook(@"C:\grades.txt");            
            
            Console.WriteLine("Number of grades: " + gb.getCount());
            Console.WriteLine("Min: " + gb.getMin());
            Console.WriteLine("Max: " + gb.getMax());
            Console.WriteLine("Mean: " + gb.getMean());
            Console.WriteLine("Count: " + gb.getCount());
            Console.WriteLine("Filename: " + gb.getSourceFile());
            Console.WriteLine("GetScoresAt: " + gb.getScoreAt(0));
            Console.WriteLine("Median: " + gb.getMedian());
            Console.WriteLine("Range: " + gb.scoresInRange(85,95));
            Console.WriteLine("Standard Deviation: " + gb.getStdDev());
            gb.addScore(76);
            Console.WriteLine("Added Score: " + gb.getScoreAt(gb.getCount()-1));*/

            /*Console.WriteLine("");
            GradeBook copyGB = new GradeBook(gb);
            copyGB.addScore(100);
            Console.WriteLine("Added Score: " + gb.getScoreAt(gb.getCount() - 1));
            copyGB.addScore(91);
            Console.WriteLine("Added Score: " + gb.getScoreAt(gb.getCount() - 1));
            Console.WriteLine("Number of grades: " + copyGB.getCount());
            Console.WriteLine("Min: " + copyGB.getMin());
            Console.WriteLine("Max: " + copyGB.getMax());
            Console.WriteLine("Mean: " + copyGB.getMean());
            Console.WriteLine("Count: " + copyGB.getCount());
            Console.WriteLine("Filename: " + copyGB.getSourceFile());
            Console.WriteLine("GetScoresAt: " + copyGB.getScoreAt(0));
            Console.WriteLine("Median: " + copyGB.getMedian());
            Console.WriteLine("Range: " + copyGB.scoresInRange(85, 95));
            Console.WriteLine("Standard Deviation: " + copyGB.getStdDev());*/
            Console.ReadLine();
        }
    }
}
