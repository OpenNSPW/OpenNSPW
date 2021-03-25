using FluentAssertions;
using Xunit;

namespace OpenNspw.Tests
{
	// Code from: https://github.com/dotnet/runtime/blob/9319b6fbe0200625aa58ae37bbc1425e1479c3be/src/libraries/System.Drawing.Primitives/tests/PointTests.cs#L10
	public class WPosTests
	{
		[Fact]
		public void DefaultConstructorTest()
		{
			new WPos().Should().Be(WPos.Zero);
		}

		[Theory]
		[InlineData(float.MaxValue, float.MinValue)]
		[InlineData(float.MinValue, float.MinValue)]
		[InlineData(float.MaxValue, float.MaxValue)]
		[InlineData(0, 0)]
		public void NonDefaultConstructorTest(float x, float y)
		{
			var p1 = new WPos(x, y);
			var p2 = new WPos(x, y);

			p2.Should().Be(p1);
		}

		[Theory]
		[InlineData(float.MaxValue, float.MinValue)]
		[InlineData(float.MinValue, float.MinValue)]
		[InlineData(float.MaxValue, float.MaxValue)]
		[InlineData(0, 0)]
		public void CoordinatesTest(float x, float y)
		{
			var p = new WPos(x, y);
			p.X.Should().Be(x);
			p.Y.Should().Be(y);
		}

		[Theory]
		[InlineData(float.MaxValue, float.MinValue)]
		[InlineData(float.MinValue, float.MinValue)]
		[InlineData(float.MaxValue, float.MaxValue)]
		[InlineData(0, 0)]
		public void ArithmeticTest(float x, float y)
		{
			var p1 = new WPos(x, y);
			var v = new WVec(y, x);
			var p2 = new WPos(y, x);
			var addExpected = new WPos(x + y, y + x);
			var subExpected = new WVec(x - y, y - x);

			(p1 + v).Should().Be(addExpected);
			(p1 - p2).Should().Be(subExpected);
		}

		[Theory]
		[InlineData(float.MaxValue, float.MinValue)]
		[InlineData(float.MinValue, float.MinValue)]
		[InlineData(float.MaxValue, float.MaxValue)]
		[InlineData(0, 0)]
		public void EqualityTest(float x, float y)
		{
			var p1 = new WPos(x, y);
			var p2 = new WPos(x / 2 - 1, y / 2 - 1);
			var p3 = new WPos(x, y);

			(p1 == p3).Should().BeTrue();
			(p1 != p2).Should().BeTrue();
			(p2 != p3).Should().BeTrue();

			p1.Equals(p3).Should().BeTrue();
			p1.Equals(p2).Should().BeFalse();
			p2.Equals(p3).Should().BeFalse();

			p1.Equals((object)p3).Should().BeTrue();
			p1.Equals((object)p2).Should().BeFalse();
			p2.Equals((object)p3).Should().BeFalse();

			p3.GetHashCode().Should().Be(p1.GetHashCode());
		}

		[Fact]
		public void EqualityTest_NotWPos()
		{
			var position = new WPos(0, 0);
			position.Equals(null).Should().BeFalse();
			position.Equals(0).Should().BeFalse();
		}

		[Fact]
		public void GetHashCodeTest()
		{
			var position = new WPos(10, 10);
			new WPos(10, 10).GetHashCode().Should().Be(position.GetHashCode());
			new WPos(20, 20).GetHashCode().Should().NotBe(position.GetHashCode());
			new WPos(10, 20).GetHashCode().Should().NotBe(position.GetHashCode());
		}

		[Theory]
		[InlineData(0, 0)]
		[InlineData(5, -5)]
		public void ToStringTest(float x, float y)
		{
			var p = new WPos(x, y);
			p.ToString().Should().Be($"({p.X}, {p.Y})");
		}
	}
}
