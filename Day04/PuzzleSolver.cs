
// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
internal sealed class PuzzleSolver
{
	internal int CalculateTotalPoints(IEnumerable<string> input)
	{
		var points = 0;
		foreach (var card in input)
		{
			var (left, right, _) = card.Split("|");
			var winningNumbers = left.Split(":").Last().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => uint.Parse(x));
			var myNumbers = right.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => uint.Parse(x));
			var countOfWinningNumbers = winningNumbers.Intersect(myNumbers).Count();
			points += (int)Math.Pow(2, countOfWinningNumbers - 1);
		}
		return points;
	}
}
