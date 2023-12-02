// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
public sealed class MaximumTests
{
	[Theory]
	[InlineData(new uint[] { 5, 4, 1, 7 }, 7)]
	[InlineData(new uint[] { 9, 4, 1, 2 }, 9)]
	[InlineData(new uint[] { 1, 4, 4, 2 }, 4)]
	public void Add(uint[] values, uint expectedMaxValue)
	{
		var sut = new Maximum();
		foreach (var value in values)
			sut.Add(value);

		Assert.Equal(expectedMaxValue, sut.Value);
	}
}
