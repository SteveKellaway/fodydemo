using Xunit;

namespace Spike.Fody.Tests
{
    public class DemoTests
    {
        [Fact]
        public void Raised()
        {
            var raised = false;
            var argle = new ViewModel();
            argle.PropertyChanged += (s, e) =>
            {
                Assert.Equal(nameof(ViewModel.LastName), e.PropertyName);
                raised = true;
            };

            Assert.False(raised);
            argle.LastName = "Test";
            Assert.True(raised);
        }


        [Fact]
        public void RaisedWhenNotEqual()
        {
            var raised = 0;
            var argle = new ViewModel();
            argle.PropertyChanged += (s, e) =>
            {
                Assert.Equal(nameof(ViewModel.LastName), e.PropertyName);
                ++raised;
            };

            Assert.Equal(0, raised);
            argle.LastName = "Test";
            argle.LastName = "Test";
            Assert.Equal(1, raised);

            argle.LastName = "Test1";
            Assert.Equal(2, raised);
        }
    }
}
