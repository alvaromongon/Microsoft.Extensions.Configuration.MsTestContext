using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Extensions.Configuration.MsTestContext.UnitTest
{
    [TestClass]
    public class MSTestConnectionSettingsRepositoryTest
    {
        private static IConfigurationRoot _configurationRoot;

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            _configurationRoot = new ConfigurationBuilder()
                    .AddMsTestContext(context)
                    .Build();
        }

        [TestMethod]
        public void When_GetConnectionString_ReturnExpectedValue()
        {
            var value = _configurationRoot.GetConnectionString("SettingString");
            Assert.AreEqual("SettingStringValue", value);
        }

        [TestMethod]
        public void When_GetConnectionString_And_DoesNotExit_ReturnNull()
        {
            var value = _configurationRoot.GetConnectionString("SettingStringNotExists");
            Assert.IsNull(value);
        }        
    }
}