using HelloWorld;
using System;
using System.IO;
using Xunit;

namespace Test
{
    public class ProgramTest
    {
        [Fact]
        public void Main_OutputHelloWorld()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.Main();
                Assert.Equal($"Hello World!{Environment.NewLine}", sw.ToString());
            }
        }
    }
}
