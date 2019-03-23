using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Extensions.Configuration.MsTestContext
{
    public class MsTestContextConfigurationProvider : ConfigurationProvider
    {
        public MsTestContextConfigurationProvider(TestContext testContext)
        {            
            var parser = new MsTestContextConfigurationParser();

            Data = parser.Parse(testContext);
        }
    }
}
