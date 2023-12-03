// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
public sealed class PointTests
{
	[Fact]
	public void Neighbours()
	{
		var sut = new Point(5, 9);

		var neighbours = sut.Neighbours;

		Assert.Equal(new Point[] { new(4, 8), new(5, 8), new(6, 8), new(4, 9), new(6, 9), new(4, 10), new(5, 10), new(6, 10) }, neighbours);
	}
}