// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
internal sealed class GameRecord
{
	private readonly Maximum _redCubesMax = new();
	private readonly Maximum _greenCubesMax = new();
	private readonly Maximum _blueCubesMax = new();

	public GameRecord(string textRecord)
	{
		var (metadata, cubesets, _) = textRecord.Split(':');
		Id = uint.Parse(metadata!.Substring(5));

		foreach (var set in cubesets!.Split(';').Select(x => new CubeSet(x)))
		{
			_redCubesMax.Add(set.RedCubeCount);
			_greenCubesMax.Add(set.GreenCubeCount);
			_blueCubesMax.Add(set.BlueCubeCount);
		}
	}

	public uint Id { get; private init; }
	public uint BlueCubesMax => _blueCubesMax.Value;
	public uint GreenCubesMax => _greenCubesMax.Value;
	public uint RedCubesMax => _redCubesMax.Value;
}
