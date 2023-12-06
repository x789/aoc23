// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
using Xunit;

public sealed class PuzzleSolverTests
{
	[Fact]
	public void Example1()
	{
		var input = new[]
		{
			"Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53",
			"Card 2: 13 32 20 16 61 | 61 30 68 82 17 32 24 19",
			"Card 3:  1 21 53 59 44 | 69 82 63 72 16 21 14  1",
			"Card 4: 41 92 73 84 69 | 59 84 76 51 58  5 54 83",
			"Card 5: 87 83 26 28 32 | 88 30 70 12 93 22 82 36",
			"Card 6: 31 18 13 56 72 | 74 77 10 23 35 67 36 11"
		};

		var solver = new PuzzleSolver();

		var points = solver.CalculateTotalPoints(input);

		Assert.Equal(13, points);
	}

	[Fact]
	public void Part1()
	{
		var solver = new PuzzleSolver();

		var points = solver.CalculateTotalPoints(InputReader.ReadFile("Input.txt"));

		Assert.Equal(0, points);
	}

	[Fact]
	public void Example2()
	{
		var input = new[]
		{
			"Card 1: 41 48 83 86 17 | 83 86  6 31 17  9 48 53",
			"Card 2: 13 32 20 16 61 | 61 30 68 82 17 32 24 19",
			"Card 3:  1 21 53 59 44 | 69 82 63 72 16 21 14  1",
			"Card 4: 41 92 73 84 69 | 59 84 76 51 58  5 54 83",
			"Card 5: 87 83 26 28 32 | 88 30 70 12 93 22 82 36",
			"Card 6: 31 18 13 56 72 | 74 77 10 23 35 67 36 11"
		};

		var solver = new PuzzleSolver();

		var points = solver.CalculateNumberOfScratchCards(input);

		Assert.Equal(30, points);
	}

	[Fact]
	public void Part2()
	{
		var solver = new PuzzleSolver();

		var points = solver.CalculateNumberOfScratchCards(InputReader.ReadFile("Input.txt"));

		Assert.Equal(0, points);
	}
}