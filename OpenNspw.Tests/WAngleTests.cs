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
			var a1 = WAngle.FromDegrees(degrees);
			var a2 = WAngle.FromDegrees(degrees);

			a2.Should().Be(a1);
		}

		[Fact]
		public void EqualityTest_NotWAngle()
		{
			var angle = WAngle.FromDegrees(0);
			angle.Equals(null).Should().BeFalse();
			angle.Equals(0).Should().BeFalse();
		}

		[Fact]
		public void GetHashCodeTest()
		{
			var angle = WAngle.FromDegrees(10);
			WAngle.FromDegrees(10).GetHashCode().Should().Be(angle.GetHashCode());
			WAngle.FromDegrees(20).GetHashCode().Should().NotBe(angle.GetHashCode());
		}

		[Theory]
		[InlineData(0)]
		[InlineData(5)]
		public void ToStringTest(float degrees)
		{
			var a = WAngle.FromDegrees(degrees);
			a.ToString().Should().Be($"{a.Degrees}");
		}
	}
}
