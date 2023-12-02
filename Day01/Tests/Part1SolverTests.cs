// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
public sealed class Part1SolverTests
{
	[Theory]
	[InlineData("1abc2", 12)]
	[InlineData("pqr3stu8vwx", 38)]
	[InlineData("a1b2c3d4e5f", 15)]
	[InlineData("treb7uchet", 77)]
	public void Examples(string input, uint expected)
	{
		var solver = new Part1Solver();
		solver.AddInput(input);

		var actual = solver.CalibrationValue;

		Assert.Equal(expected, actual);
	}

	[Theory]
	[InlineData(new string[] { "1abc2", "pqr3stu8vwx", "a1b2c3d4e5f", "treb7uchet" }, 142)]
	public void Example(string[] input, uint expected)
	{
		var solver = new Part1Solver();
		foreach (var line in input)
			solver.AddInput(line);

		var actual = solver.CalibrationValue;

		Assert.Equal(expected, actual);
	}

	[Fact]
	public void Puzzle()
	{
		var solver = new Part1Solver();
		foreach (var line in InputReader.ReadFile("Input.txt"))
			solver.AddInput(line);

		var actual = solver.CalibrationValue;

		Assert.Equal(0u, actual);
	}
}