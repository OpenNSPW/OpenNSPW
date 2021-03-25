using FluentAssertions;
using Xunit;

namespace OpenNspw.Tests
{
	public class WAngleTests
	{
		[Fact]
		public void DefaultConstructorTest()
		{
			new WAngle().Should().Be(WAngle.Zero);
		}

		[Theory]
		[InlineData(float.MaxValue)]
		[InlineData(float.MinValue)]
		[InlineData(0)]
		public void NonDefaultConstructorTest(float degrees)
		{
			var a1 = new WAngle(degrees);
			var a2 = new WAngle(degrees);

			a2.Should().Be(a1);
		}

		[Fact]
		public void EqualityTest_NotWAngle()
		{
			var angle = new WAngle(0);
			angle.Equals(null).Should().BeFalse();
			angle.Equals(0).Should().BeFalse();
		}

		[Fact]
		public void GetHashCodeTest()
		{
			var angle = new WAngle(10);
			new WAngle(10).GetHashCode().Should().Be(angle.GetHashCode());
			new WAngle(20).GetHashCode().Should().NotBe(angle.GetHashCode());
		}

		[Theory]
		[InlineData(0)]
		[InlineData(5)]
		public void ToStringTest(float degrees)
		{
			var a = new WAngle(degrees);
			a.ToString().Should().Be($"{a.Degrees}");
		}
	}
}
