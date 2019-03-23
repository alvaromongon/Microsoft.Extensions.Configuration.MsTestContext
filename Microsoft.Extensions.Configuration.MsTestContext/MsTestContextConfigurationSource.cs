using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Microsoft.Extensions.Configuration.MsTestContext
{
    public class MsTestContextConfigurationSource : IConfigurationSource
    {
        private readonly MsTestContextConfigurationProvider _configurationProvider;

        public MsTestContextConfigurationSource(TestContext testContext)
        {
            if (testContext == null)
            {
                throw new ArgumentNullException(nameof(testContext));
            }

            _configurationProvider = new MsTestContextConfigurationProvider(testContext);
        }

        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return _configurationProvider;
        }
    }
}
