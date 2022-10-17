namespace OpenNspw.Tests;

// Code from: https://github.com/dotnet/runtime/blob/9319b6fbe0200625aa58ae37bbc1425e1479c3be/src/libraries/System.Drawing.Primitives/tests/PointTests.cs#L10
public class CPosTests
{
	[Fact]
	public void DefaultConstructorTest()
	{
		new CPos().Should().Be(CPos.Zero);
	}

	[Theory]
	[InlineData(int.MaxValue, int.MinValue)]
	[InlineData(int.MinValue, int.MinValue)]
	[InlineData(int.MaxValue, int.MaxValue)]
	[InlineData(0, 0)]
	public void NonDefaultConstructorTest(int x, int y)
	{
		var p1 = new CPos(x, y);
		var p2 = new CPos(x, y);

		p2.Should().Be(p1);
	}

	[Theory]
	[InlineData(int.MaxValue, int.MinValue)]
	[InlineData(int.MinValue, int.MinValue)]
	[InlineData(int.MaxValue, int.MaxValue)]
	[InlineData(0, 0)]
	public void CoordinatesTest(int x, int y)
	{
		var p = new CPos(x, y);
		p.X.Should().Be(x);
		p.Y.Should().Be(y);
	}

	[Theory]
	[InlineData(int.MaxValue, int.MinValue)]
	[InlineData(int.MinValue, int.MinValue)]
	[InlineData(int.MaxValue, int.MaxValue)]
	[InlineData(0, 0)]
	public void EqualityTest(int x, int y)
	{
		var p1 = new CPos(x, y);
		var p2 = new CPos(x / 2 - 1, y / 2 - 1);
		var p3 = new CPos(x, y);

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
	public void EqualityTest_NotCPos()
	{
		var position = new CPos(0, 0);
		position.Equals(null).Should().BeFalse();
		position.Equals(0).Should().BeFalse();
	}

	[Fact]
	public void GetHashCodeTest()
	{
		var position = new CPos(10, 10);
		new CPos(10, 10).GetHashCode().Should().Be(position.GetHashCode());
		new CPos(20, 20).GetHashCode().Should().NotBe(position.GetHashCode());
		new CPos(10, 20).GetHashCode().Should().NotBe(position.GetHashCode());
	}

	[Theory]
	[InlineData(0, 0)]
	[InlineData(5, -5)]
	public void ToStringTest(int x, int y)
	{
		var p = new CPos(x, y);
		p.ToString().Should().Be($"({p.X}, {p.Y})");
	}
}
