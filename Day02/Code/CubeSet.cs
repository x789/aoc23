// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
internal sealed record CubeSet
{
	private readonly Dictionary<string, uint> _data = new() { { "red", 0 }, { "green", 0 }, { "blue", 0 } };

	public CubeSet(string text)
	{
		var parts = text.Split(',').Select(x => x.Trim());
		foreach (var part in parts)
		{
			var (count, color, _) = part.Split(' ');
			_data[color!] = uint.Parse(count!);
		}
	}

	public uint BlueCubeCount => _data["blue"];
	public uint GreenCubeCount => _data["green"];
	public uint RedCubeCount => _data["red"];
}
