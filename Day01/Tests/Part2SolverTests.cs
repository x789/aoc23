// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
public sealed class Part2SolverTests
{
	[Theory]
	[InlineData("two1nine", 29)]
	[InlineData("eightwothree", 83)]
	[InlineData("abcone2threexyz", 13)]
	[InlineData("xtwone3four", 24)]
	[InlineData("4nineeightseven2", 42)]
	[InlineData("zoneight234", 14)]
	[InlineData("7pqrstsixteen", 76)]
	[InlineData("1abc2", 12)]
	[InlineData("pqr3stu8vwx", 38)]
	[InlineData("a1b2c3d4e5f", 15)]
	[InlineData("treb7uchet", 77)]
	[InlineData("6sbzfqfdm", 66)]
	public void Examples(string input, uint expected)
	{
		var solver = new Part2Solver();
		solver.AddInput(input);

		var actual = solver.CalibrationValue;

		Assert.Equal(expected, actual);
	}

	[Theory]
	[InlineData(new string[] { "two1nine", "eightwothree", "abcone2threexyz", "xtwone3four", "4nineeightseven2", "zoneight234", "7pqrstsixteen" }, 281)]
	public void Example(string[] input, uint expected)
	{
		var solver = new Part2Solver();
		foreach (var line in input)
			solver.AddInput(line);

		var actual = solver.CalibrationValue;

		Assert.Equal(expected, actual);
	}

	[Fact]
	public void Puzzle()
	{
		var solver = new Part2Solver();
		foreach (var line in InputReader.ReadFile("Input.txt"))
			solver.AddInput(line);

		var actual = solver.CalibrationValue;

		Assert.Equal(0u, actual);
	}
}