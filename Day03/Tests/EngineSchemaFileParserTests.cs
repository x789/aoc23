// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
public sealed class EngineSchemaFileParserTests
{
	[Fact]
	public void Parse()
	{
		var sut = new EngineSchemaFileParser();
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

		var (numbers, asterisks, map) = sut.Parse(input);

		Assert.Equal(10, numbers.Count());
		Assert.Equal(new(467, new(0, 0), 3), numbers.ElementAt(0));
		Assert.Equal(new(114, new(5, 0), 3), numbers.ElementAt(1));
		Assert.Equal(new(35, new(2, 2), 2), numbers.ElementAt(2));
		Assert.Equal(new(633, new(6, 2), 3), numbers.ElementAt(3));
		Assert.Equal(new(617, new(0, 4), 3), numbers.ElementAt(4));
		Assert.Equal(new(58, new(7, 5), 2), numbers.ElementAt(5));
		Assert.Equal(new(592, new(2, 6), 3), numbers.ElementAt(6));
		Assert.Equal(new(755, new(6, 7), 3), numbers.ElementAt(7));
		Assert.Equal(new(664, new(1, 9), 3), numbers.ElementAt(8));
		Assert.Equal(new(598, new(5, 9), 3), numbers.ElementAt(9));

		Assert.Equal(3, asterisks.Count());
		Assert.Equal(new(new(3, 1)), asterisks.First());
		Assert.Equal(new(new(3, 4)), asterisks.ElementAt(1));
		Assert.Equal(new(new(5, 8)), asterisks.Last());

		Assert.Equal(10, map.NumberOfColumns);
		Assert.Equal(10, map.NumberOfRows);
	}

	[Fact]
	public void Parse_NumberAtEnd()
	{
		var sut = new EngineSchemaFileParser();
		var input = new string[]
		{
			"467..114.5"
		};

		var (numbers, _, map) = sut.Parse(input);

		Assert.Equal(3, numbers.Count());
		Assert.Equal(new(467, new(0, 0), 3), numbers.ElementAt(0));
		Assert.Equal(new(114, new(5, 0), 3), numbers.ElementAt(1));
		Assert.Equal(new(5, new(9, 0), 1), numbers.ElementAt(2));
	}
}