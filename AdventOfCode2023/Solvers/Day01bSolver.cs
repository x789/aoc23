// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License

/// <summary>
/// Trebuchet?! - Part 2
/// </summary>
public sealed class Day01bSolver
{
	private static readonly Dictionary<string, uint> s_mapping = new() { { "1", 1 }, { "one", 1 }, { "2", 2 }, { "two", 2 }, { "3", 3 }, { "three", 3 }, { "4", 4 }, { "four", 4 }, { "5", 5 }, { "five", 5 }, { "6", 6 }, { "six", 6 }, { "7", 7 }, { "seven", 7 }, { "8", 8 }, { "eight", 8 }, { "9", 9 }, { "nine", 9 } };
	internal uint CalibrationValue { get; private set; } = 0;

	internal void AddInput(string line)
	{
		(int Index, uint Value) first = (line.Length, 0);
		(int Index, uint Value) last = (-1, 0);
		foreach (var kvp in s_mapping)
		{
			var ki = line.IndexOf(kvp.Key);
			if (ki != -1 && ki < first.Index)
				first = (ki, kvp.Value);

			var lki = line.LastIndexOf(kvp.Key);
			if (lki != -1 && lki > last.Index)
				last = (lki, kvp.Value);
		}
		CalibrationValue += first.Value * 10 + last.Value;
    }
}
