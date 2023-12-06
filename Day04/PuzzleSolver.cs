
// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
internal sealed class PuzzleSolver
{
	internal int CalculateTotalPoints(IEnumerable<string> input)
	{
		return GetMatchingNumbers(input).Sum(x => (int)Math.Pow(2, x-1));
	}

	internal int CalculateNumberOfScratchCards(IEnumerable<string> input)
	{
		var numberOfCards = 0;
		var cards = GetMatchingNumbers(input).Select(x => (Count: 1, MatchingNumbers: x)).ToArray();
		for (int i = 0; i < cards.Length; i++)
		{
			var card = cards[i];
			numberOfCards += card.Count;
			if (card.MatchingNumbers > 0)
				for (int j = i+1; j < i + card.MatchingNumbers + 1; j++)
					cards[j].Count += cards[i].Count;
		}
		return numberOfCards;
	}

	private int[] GetMatchingNumbers(IEnumerable<string> input)
	{
		var matchingNumbers = new List<int>();
		foreach (var card in input)
		{
			var (left, right, _) = card.Split("|");
			var winningNumbers = left.Split(":").Last().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => uint.Parse(x));
			var myNumbers = right.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => uint.Parse(x));
			var matchingNumbersOnCard = winningNumbers.Intersect(myNumbers).Count();
			matchingNumbers.Add(matchingNumbersOnCard);
		}
		return matchingNumbers.ToArray();
	}
}
