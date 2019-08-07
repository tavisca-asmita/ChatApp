using System;
using ChatBox;
using Xunit;

namespace XUnitChatAppTestProject
{
    public class UnitTestDisplay
    {
        [Fact]
        public void TestSentDisplay()
        {
            Display display;

            display = new Display();
                     
            Assert.Equal("   hey", display.DisplayMessage("hey", ""));
            
        }

        [Fact]
        public void TestRecievedDisplay()
        {
            Display display;

            display = new Display();
            
            Assert.Equal("   hey", display.DisplayMessage("", "   hey"));
        }
    }
}
