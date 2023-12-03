// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
public sealed class PartNumberFinderTests
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
		var (numbers, _, schema) = new EngineSchemaFileParser().Parse(input);
		var sut = new PartNumberFinder(schema);

		var partNumbers = sut.DeterminePartNumbers(numbers);

		Assert.Equal(8, partNumbers.Count());
		Assert.Equal(467, partNumbers.ElementAt(0).Value);
		Assert.Equal(35, partNumbers.ElementAt(1).Value);
		Assert.Equal(633, partNumbers.ElementAt(2).Value);
		Assert.Equal(617, partNumbers.ElementAt(3).Value);
		Assert.Equal(592, partNumbers.ElementAt(4).Value);
		Assert.Equal(755, partNumbers.ElementAt(5).Value);
		Assert.Equal(664, partNumbers.ElementAt(6).Value);
		Assert.Equal(598, partNumbers.ElementAt(7).Value);
	}
}
