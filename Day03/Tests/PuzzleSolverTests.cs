// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License

/// <summary>
/// Tests that solve the puzzles. Expected values were redacted for fairness.
/// </summary>
public sealed class PuzzleSolverTests
{
	[Fact]
	public void Example()
	{
		var input = new string[]
		{
			"467..114..",
			"...*......",
			"..35..633.",
			"......#...",
			"617*......",
			".....+.58.",
			"..592.....",
			"......755.",
			"...$.*....",
			".664.598.."
		};
		var solver = new PuzzleSolver(input);

		Assert.Equal(4361, solver.SumOfPartNumbers);
		Assert.Equal(467835, solver.SumOfGearRatios);
	}

	[Fact]
	public void Part1()
	{
		var solver = new PuzzleSolver(InputReader.ReadFile("Input.txt"));

		Assert.Equal(0, solver.SumOfPartNumbers);
	}

	[Fact]
	public void Part2()
	{
		var solver = new PuzzleSolver(InputReader.ReadFile("Input.txt"));

		Assert.Equal(0, solver.SumOfGearRatios);
	}
}
