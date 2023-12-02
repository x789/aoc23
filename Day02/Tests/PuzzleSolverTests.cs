// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License

/// <summary>
/// Tests that solve the puzzles. Expected values were redacted for fairness.
/// </summary>
public sealed class PuzzleSolverTests
{
	[Fact]
	public void Part1()
	{
		var solver = new PuzzleSolver(12, 13, 14);
		foreach (var line in InputReader.ReadFile("Input.txt"))
			solver.AddInput(line);

		Assert.Equal(0u, solver.SumOfIDsOfValidGames);
	}

	[Fact]
	public void Part2()
	{
		var solver = new PuzzleSolver(12, 13, 14);
		foreach (var line in InputReader.ReadFile("Input.txt"))
			solver.AddInput(line);

		Assert.Equal(0u, solver.SumOfPowers);
	}
}
