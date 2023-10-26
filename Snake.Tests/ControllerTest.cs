using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Snake.Controller;

namespace Snake.Tests
{
    [TestClass]
    public class ControllerTest
    {
        [TestMethod]
        public void EmptyControllerTest()
        {
            var controller = new KeyReader();
            var action = controller.GetAction();

            action.Should().Be(Action.None);
        }
    }
}
