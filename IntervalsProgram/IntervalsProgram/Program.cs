using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace IntervalsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            testclass tt = new testclass();
            IList<Interval> lst = new List<Interval>();
            Console.WriteLine("Enter No.of Includes");
            int noofIncludes = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i< noofIncludes;i++)
            {
                int start = 0;
                int end = 0;
                Console.WriteLine("Enter the Interval Start Value");
                start =  Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Interval End Value");
                end = Convert.ToInt32(Console.ReadLine());
                lst.Add(new Interval(start, end));
            }
            
            //lst.Add(new Interval(5, 13));
            //lst.Add(new Interval(2, 8));
            //lst.Add(new Interval(400, 500));
            IList<Interval> exclst = new List<Interval>();
            //Interval testInterval1 = new Interval(1, 2);
            //exclst.Add(new Interval(4, 10));
            //exclst.Add(new Interval(5, 11));
            Console.WriteLine("Enter No.of Excludes");
            int noofExcludes = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < noofExcludes; i++)
            {
                int start = 0;
                int end = 0;
                Console.WriteLine("Enter the Interval Start Value");
                start = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Interval End Value");
                end = Convert.ToInt32(Console.ReadLine());
                exclst.Add(new Interval(start, end));
            }
            IList<Interval> outputList = tt.Merge(lst);
            IList<Interval> finalList = tt.Exclude(outputList, exclst);
            Console.WriteLine("Output:");
            for (int i = 0; i < finalList.Count; i++)
            {
                Console.WriteLine("{0}-{1}", finalList.ElementAt(i).start, finalList.ElementAt(i).end);
            }

            Console.ReadLine();

        }
        
    }
   
    public class Interval
    {
        public Interval(int s, int e)
        {
            start = s;
            end = e;
        }
        public int start;
        public int end;
    }
    public class testclass
    {
        public IList<Interval> Merge(IList<Interval> intervals)
        {
            var outVal = new SortedSet<Interval>(intervals, new IntervalComparer());
            for (int i = 0; i < outVal.Count - 1; i++)
            {
                Interval curr = outVal.ElementAt(i);
                Interval next = outVal.ElementAt(i + 1);
                if (next.start - curr.end < 1)
                {
                    curr.end = Math.Max(curr.end, next.end);
                    outVal.Remove(next);
                    i--;
                }
            }
            return outVal.ToList();
        }
        public class IntervalComparer : IComparer<Interval>
        {
            public int Compare(Interval lhs, Interval rhs)
            {
                if (lhs.start == rhs.start)
                {
                    return lhs.end.CompareTo(rhs.end);
                }
                return lhs.start.CompareTo(rhs.start);
            }
        }

        public IList<Interval> Exclude(IList<Interval> mergedIntervals,IList<Interval> intervals)
        {
            var excludeVal = new SortedSet<Interval>(intervals, new IntervalComparer());
            excludeVal.ToList();
            //IList<Interval> outlst = new List<Interval>();
            for (int i=0;i< mergedIntervals.Count;i++)
            {
                for (int j = 0; j < excludeVal.Count; j++)
                {
                    Interval exc = excludeVal.ElementAt(j);
                    Interval merg = mergedIntervals.ElementAt(i);
                    if (exc.start < merg.end && exc.start >merg.start)
                    {
                        Interval newint1 = new Interval(merg.start, exc.start - 1);
                        mergedIntervals.Add(newint1);
                        if (merg.end > exc.end)
                        {
                            Interval newint2 = new Interval(exc.end + 1, merg.end);
                            mergedIntervals.Add(newint2);
                        }
                        mergedIntervals.Remove(merg);
                        mergedIntervals = new SortedSet<Interval>(mergedIntervals, new IntervalComparer()).ToList();
                    }
                    else if(merg.start > exc.start && exc.end >= merg.start && exc.end < merg.end)

                    {
                        Interval newint1 = new Interval( exc.end + 1,merg.end);
                        mergedIntervals.Add(newint1);
                        mergedIntervals.Remove(merg);
                        mergedIntervals = new SortedSet<Interval>(mergedIntervals, new IntervalComparer()).ToList();
                    }

                }

            }

            var  outVal = new SortedSet<Interval>(mergedIntervals, new IntervalComparer());
            return outVal.ToList();
        }

    }
}
