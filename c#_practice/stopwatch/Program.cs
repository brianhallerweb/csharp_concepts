using System;

namespace stopwatch
{
  class Watch
  {
    private DateTime _startTime;
    private DateTime _endTime;

    public void Start()
    {
      _startTime = DateTime.Now;
    }

    public TimeSpan End()
    {
      _endTime = DateTime.Now;
      return _endTime.Subtract(_startTime);
    }
  }
  
  class Program
  {
    static void Main(string[] args)
    {
      while(true)
      {
        System.Console.WriteLine("Type 'start' to start the stopwatch or 'q' to quit");
        var startInput = Console.ReadLine().Trim();
        if (startInput == "q")
          break;
        if (startInput != "start")
          throw new InvalidOperationException("you must enter 'start'");
         
        var stopWatch = new Watch();
        stopWatch.Start();
        System.Console.WriteLine("Type 'end' to end the stopwatch");
        var endInput = Console.ReadLine().Trim();
        if (endInput != "end")
          throw new InvalidOperationException("you must enter 'end'");

        System.Console.WriteLine("total time: {0}", stopWatch.End());
      };
    }
      
  }
}
