# Introduction 
Implementation of a MsTestContext configuration provider for Microsft extensions configuration

If you are using MsTests with runsettings files in your test projects, 
It is nice to load the settings into the Microsoft extensions configuration abstractions. 
So you can get the configuration from IConfiguration.

# Getting Started
- Install the package in your test project
- Create the runsettings file
- Select the runsettings file as your tests settings file in the test explorer windows (VS2019)
- Create the configuration root object loading data from the test context: ".AddMsTestContext(context)""
- Use the configuration interface

# Build and Test
I was using VS2019 to build the solution and there are some tests to show how could be used.
So you can run the tests locally and follow the code. Just remember to select you tests settings file.

