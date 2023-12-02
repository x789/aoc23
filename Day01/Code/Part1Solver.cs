// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License

/// <summary>
/// Trebuchet?! - Part 1
/// </summary>
public sealed class Part1Solver
{
	private static readonly Dictionary<string, uint> s_mapping = new() { { "1", 1 }, { "one", 1}, { "2", 2 }, { "two", 2}, { "3", 3 }, { "three", 3}, { "4", 4 }, { "four", 4}, { "5", 5 }, { "five", 5}, { "6", 6 }, { "six", 6}, { "7", 7 }, { "seven", 7}, { "8", 8 }, { "eight", 8}, { "9", 9 }, { "nine", 9} };
	internal uint CalibrationValue { get; private set; } = 0;

	internal void AddInput(string line) => CalibrationValue += (line.First(char.IsDigit) - 48u) * 10u + (line.Last(char.IsDigit) - 48u);
}
