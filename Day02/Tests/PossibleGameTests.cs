// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
public sealed class PossibleGameTests
{
	[Theory]
	[InlineData("Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green", 1, 48)]
	[InlineData("Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue", 2, 12)]
	[InlineData("Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green", 5, 36)]

	public void Init_ValidGame(string textRecord, uint expectedId, uint expectedPowerOfMinimalSet)
	{
		var sut = new PossibleGame(textRecord, 12, 13, 14);
		
		Assert.Equal(expectedId, sut.Id);
		Assert.Equal(12u, sut.AvailableRedCubes);
		Assert.Equal(13u, sut.AvailableGreenCubes);
		Assert.Equal(14u, sut.AvailableBlueCubes);
		Assert.True(sut.IsValidGame);
		Assert.Equal(expectedPowerOfMinimalSet, sut.PowerOfMinimalSet);
	}

	[Theory]
	[InlineData("Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red", 3, 1560)]
	[InlineData("Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red", 4, 630)]
	public void Init_InvalidGame(string textRecord, uint expectedId, uint expectedPowerOfMinimalSet)
	{
		var sut = new PossibleGame(textRecord, 12, 13, 14);

		Assert.Equal(expectedId, sut.Id);
		Assert.Equal(12u, sut.AvailableRedCubes);
		Assert.Equal(13u, sut.AvailableGreenCubes);
		Assert.Equal(14u, sut.AvailableBlueCubes);
		Assert.False(sut.IsValidGame);
		Assert.Equal(expectedPowerOfMinimalSet, sut.PowerOfMinimalSet);
	}
}
