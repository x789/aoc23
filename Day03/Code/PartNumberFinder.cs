// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
internal sealed class PartNumberFinder
{
	private readonly EngineSchema _engine;

	public PartNumberFinder(EngineSchema schema) => _engine = schema;

	internal IEnumerable<Number> DeterminePartNumbers(IEnumerable<Number> numbers)
	{
		var partNumbers = new List<Number>();
		foreach (var number in numbers)
			if (IsPartNumber(number))
				partNumbers.Add(number);

		return partNumbers;
	}

	private bool IsPartNumber(Number number)
	{
		var neighbours = GetNeighbours(number);
		foreach (var neighbour in neighbours)
		{
			var foo = _engine.IsSymbolAt(neighbour);
		}
		return neighbours.Where(p => _engine.IsSymbolAt(p)).Any();
	}

	private IEnumerable<Point> GetNeighbours(Number number)
	{
		var neighbours = new List<Point>();
		for (var x = number.Position.X -1; x <= number.Position.X + number.Length; x++)
			neighbours.AddRange(new Point[] { new(x, number.Position.Y - 1), new(x, number.Position.Y + 1) });
		neighbours.Add(new(number.Position.X - 1, number.Position.Y));
		neighbours.Add(new(number.Position.X + number.Length, number.Position.Y));

		return neighbours.Where(p => p.X >= 0 && p.X < _engine.NumberOfColumns && p.Y >= 0 && p.Y < _engine.NumberOfRows);
	}
}