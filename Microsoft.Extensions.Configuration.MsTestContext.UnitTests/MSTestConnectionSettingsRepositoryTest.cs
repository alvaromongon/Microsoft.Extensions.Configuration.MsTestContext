using Microsoft.Extensions.Configuration;
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
        public void When_Call_GetSettingNotExistsString_ReturnDefaultValue()
        {
            var value = _configurationRoot.GetValue("SettingStringNotExists", "DefaultStringValue");
            Assert.AreEqual("DefaultStringValue", value);
        }

        [TestMethod]
        public void When_Call_GetSettingString_ReturnExpectedValue()
        {
            var value = _configurationRoot.GetConnectionString("SettingString");
            Assert.AreEqual("SettingStringValue", value);
        }
    }
}