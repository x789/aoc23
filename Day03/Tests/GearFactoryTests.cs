// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
public sealed class GearFactoryTests
{
	[Fact]
	public void CreateGear()
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
		var (numbers, asterisks, schema) = new EngineSchemaFileParser().Parse(input);
		var sut = new GearFactory(schema);

		var gears = sut.CreateGears(numbers, asterisks);

		Assert.Equal(2, gears.Count());
		Assert.Equal(16345, gears.First().Ratio.Value);
		Assert.Equal(new(new(3, 1)), gears.First().Connector);
		Assert.Equal(451490, gears.Last().Ratio.Value);
		Assert.Equal(new(new(5, 8)), gears.Last().Connector);
	}
}
