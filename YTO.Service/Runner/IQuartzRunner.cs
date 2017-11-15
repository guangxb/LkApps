using Quartz;


namespace YTO.Service.Runner
{
    public interface IQuartzRunner
    {
        string Name { get; }
        IScheduler Run();
    }
}
