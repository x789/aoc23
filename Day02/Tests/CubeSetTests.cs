// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
public sealed class CubeSetTests
{
	[Theory]
	[InlineData("3 blue, 4 red", 4, 0, 3)]
	[InlineData("1 red, 2 green, 6 blue", 1, 2, 6)]
	[InlineData("2 green", 0, 2, 0)]
	public void Init(string input, uint expectedRed, uint expectedGreen, uint expectedBlue)
	{
		var sut = new CubeSet(input);

		Assert.Equal(expectedRed, sut.RedCubeCount);
		Assert.Equal(expectedGreen, sut.GreenCubeCount);
		Assert.Equal(expectedBlue, sut.BlueCubeCount);
	}

}
