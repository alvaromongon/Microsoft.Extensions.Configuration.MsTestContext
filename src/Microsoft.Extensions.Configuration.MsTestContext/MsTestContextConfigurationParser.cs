using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Microsoft.Extensions.Configuration.MsTestContext
{
    public class MsTestContextConfigurationParser
    {
        internal IDictionary<string, string> Parse(TestContext testContext)
        {
            IDictionary<string, string> result = new Dictionary<string, string>();

            foreach (string propertyKey in testContext.Properties.Keys)
            {
                result.Add(propertyKey, testContext.Properties[propertyKey].ToString());
            }

            return result;
        }
    }
}
