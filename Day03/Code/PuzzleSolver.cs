// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
internal sealed class PuzzleSolver
{
	private readonly IEnumerable<Number> _numbers;
	private readonly IEnumerable<Asterisk> _asterisks;
	private readonly EngineSchema _schema;
	public PuzzleSolver(IEnumerable<string> input)
	{
		(_numbers, _asterisks, _schema) = new EngineSchemaFileParser().Parse(input);
	}

	public int SumOfPartNumbers
	{
		get
		{
			var finder = new PartNumberFinder(_schema);
			var partNumbers = finder.DeterminePartNumbers(_numbers);
			return partNumbers.Sum(n => n.Value);
		}
	}

	public int SumOfGearRatios
	{
		get
		{
			var gears = new GearFactory(_schema).CreateGears(_numbers, _asterisks);
			return gears.Sum(g => g.Ratio.Value);
		}
	}
}