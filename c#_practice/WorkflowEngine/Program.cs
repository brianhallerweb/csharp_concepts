using System;
using System.Collections.Generic;

namespace WorkflowEngine
{ 
    public interface IActivity
    {
        void Execute();
    }

    public class MyActivity1: IActivity
    {
        public void Execute(){
             System.Console.WriteLine("my activity 1");
        }
    }

    public class MyActivity2: IActivity
    {
        public void Execute(){
             System.Console.WriteLine("my activity 2");
        }
    }

    public class Workflow
    {
        private readonly List<IActivity> _activities;
        public Workflow(){
            _activities = new List<IActivity>();
        }
        public void RegisterActivity(IActivity activity){
            _activities.Add(activity);
        }
        public void run(){
            foreach(var activity in _activities){
                activity.Execute();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.RegisterActivity(new MyActivity1());
            workflow.RegisterActivity(new MyActivity2());
            workflow.run();
        }
    }
}
