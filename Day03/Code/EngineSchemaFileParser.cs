// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
internal sealed class EngineSchemaFileParser
{
	public (IEnumerable<Number> PartNumbers, IEnumerable<Asterisk> Asterisks, EngineSchema Map) Parse(IEnumerable<string> lines)
	{
		var map = new EngineSchema();
		var numbers = new List<Number>();
		var asterisks = new List<Asterisk>();
		var y = 0;
		foreach (var line in lines)
		{
			var x = 0;
			map.AddLine();
			var number = string.Empty;
			Point? numberPosition = default;
			foreach (var c in line)
			{
				map.Add(c);
				if (c == '*') asterisks.Add(new(new(x, y)));
				if (char.IsDigit(c))
				{
					if (number.Length == 0)
						numberPosition = new(x, y);
					number += c;
				}
				else if (number.Length > 0)
				{
					numbers.Add(new(int.Parse(number), numberPosition!, number.Length));
					number = string.Empty;
				}
				x++;
			}

			if (number.Length != 0)
				numbers.Add(new(int.Parse(number), numberPosition!, number.Length));

			y++;
		}

		return (numbers, asterisks, map);
	}
}