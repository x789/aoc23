// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
internal sealed class PuzzleSolver
{
	private readonly uint _availableRedCubes;
	private readonly uint _availableGreenCubes;
	private readonly uint _availableBlueCubes;

	public PuzzleSolver(uint availableRedCubes, uint availableGreenCubes, uint availableBlueCubes)
	{
		_availableRedCubes = availableRedCubes;
		_availableGreenCubes = availableGreenCubes;
		_availableBlueCubes = availableBlueCubes;
	}

	public void AddInput(string line)
	{
		var possibleGame = new PossibleGame(line, _availableRedCubes, _availableGreenCubes, _availableBlueCubes);
		if (possibleGame.IsValidGame)
			SumOfIDsOfValidGames += possibleGame.Id;
		SumOfPowers += possibleGame.PowerOfMinimalSet;
	}

	public uint SumOfIDsOfValidGames { get; private set; }
	public uint SumOfPowers { get; private set; }
}
