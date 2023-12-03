
// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
internal sealed class EngineSchema
{
	private readonly List<List<char>> _map = new();

	public int NumberOfRows => _map.Count;
	public int NumberOfColumns => _map.Count > 0 ? _map[0].Count : 0;

	public void Add(char c) => _map[_map.Count-1].Add(c);

	public void AddLine() => _map.Add(new());

	public bool IsSymbolAt(Point position) => !char.IsDigit(_map[position.Y][position.X]) && _map[position.Y][position.X] != '.';
}