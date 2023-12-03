// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
internal sealed class GearFactory
{
	private readonly EngineSchema _schema;
	public GearFactory(EngineSchema schema) => _schema = schema;

	internal IEnumerable<Gear> CreateGears(IEnumerable<Number> numbers, IEnumerable<Asterisk> asterisks)
	{
		var gears = new List<Gear>();
		foreach (var asterisk in asterisks)
		{
			var adjacentNumbers = FindAdjacentNumbers(asterisk, numbers);
			if (adjacentNumbers.Count() == 2)
				gears.Add(new(asterisk, new(adjacentNumbers.First(), adjacentNumbers.Last())));
		}
		return gears;
	}

	private IEnumerable<Number> FindAdjacentNumbers(Asterisk asterisk, IEnumerable<Number> numbers)
	{
		var adjacentNumbers = new List<Number>();
        foreach (var number in numbers)
			if (number.OccupiedPoints.Intersect(asterisk.Position.Neighbours).Any())
				adjacentNumbers.Add(number);
        return adjacentNumbers;
	}
}
