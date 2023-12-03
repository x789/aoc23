// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
public sealed class NumberTests
{
	[Fact]
	public void OccupiedPoints()
	{
		var sut = new Number(653, new(55, 3), 3);

		var occupiedPoints = sut.OccupiedPoints;

		Assert.Equal(3, occupiedPoints.Count());
		Assert.Equal(new(55, 3), occupiedPoints.ElementAt(0));
		Assert.Equal(new(56, 3), occupiedPoints.ElementAt(1));
		Assert.Equal(new(57, 3), occupiedPoints.ElementAt(2));
	}
}