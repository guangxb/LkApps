using Microsoft.Practices.Unity;



namespace Apps.Core
{

    public partial class DependencyRegisterType
    {
        public static void ContainerPartial(UnityContainer container)
        {
            container.RegisterType<Apps.IRepository.IDBSession, Apps.Repository.DBSession>();
            container.RegisterType<Apps.IRepository.SCV.ISCVDBSession, Apps.Repository.SCV.SCVDBSession>();
            container.RegisterType<Apps.IService.IServiceSession, Apps.Service.ServiceSession>();
            container.RegisterType<Apps.IService.SCV.ISCVServiceSession, Apps.Service.SCV.SCVServiceSession>();
        }
    }
}