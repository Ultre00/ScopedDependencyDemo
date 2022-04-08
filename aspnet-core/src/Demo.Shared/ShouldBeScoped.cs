using Volo.Abp.DependencyInjection;

namespace Demo.Shared
{
    public class ShouldBeScoped : IScopedDependency
    {
        private readonly Guid Test;

        public ShouldBeScoped()
        {
            Test = Guid.NewGuid();
        }
    }
}