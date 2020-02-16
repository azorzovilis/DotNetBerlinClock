namespace BerlinClock.IoC
{
    using Autofac;
    using BerlinClock.Classes;
    using BerlinClock.Classes.Interfaces;

    public class DependencyResolver
    {
        public static IContainer Initialize()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<BerlinClockContext>().As<IBerlinClockContext>();
            builder.RegisterType<BerlinClockFactory>().As<IBerlinClockFactory>();
            builder.RegisterType<TimeConverter>().As<ITimeConverter>();
            builder.RegisterType<TimeValidator>().As<ITimeValidator>();
            
            return builder.Build();
        }
    }
}