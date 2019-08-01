using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Extensions.Configuration.MsTestContext
{
    public static class MsTestContextConfigurationExtensions
    {
        public static IConfigurationBuilder AddMsTestContext(this IConfigurationBuilder builder, TestContext testContext)
        {
            var source = new MsTestContextConfigurationSource(testContext);
            builder.Add(source);
            return builder;
        }

    }
}
