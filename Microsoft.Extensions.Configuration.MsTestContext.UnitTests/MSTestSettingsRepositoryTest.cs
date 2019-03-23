using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Microsoft.Extensions.Configuration.MsTestContext.UnitTest
{
    [TestClass]
    public class MSTestSettingsRepositoryTest
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
        public void When_Call_GetSettingInt_ReturnExpectedValue()
        {
            var value = _configurationRoot.GetValue<int>("SettingInt");
            Assert.AreEqual(345, value);
        }

        [TestMethod]
        public void When_Call_GetSettingNotExistsInt_ReturnDefaultValue()
        {
            var value = _configurationRoot.GetValue("SettingIntNotExists", 456);
            Assert.AreEqual(456, value);
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
            var value = _configurationRoot.GetValue<string>("SettingString");
            Assert.AreEqual("SettingStringValue", value);
        }

        [TestMethod]
        public void When_Call_GetSettingBoolean_ReturnExpectedValue()
        {
            var value = _configurationRoot.GetValue<bool>("SettingBoolean");
            Assert.AreEqual(true, value);
        }

        [TestMethod]
        public void When_Call_GetSettingNotExistsBoolean_ReturnDefaultValue()
        {
            var value = _configurationRoot.GetValue("SettingBooleanNotExists", false);
            Assert.AreEqual(false, value);
        }
    }
}
