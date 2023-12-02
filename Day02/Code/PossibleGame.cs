// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
internal sealed class PossibleGame
{
	public PossibleGame(string record, uint availableRedCubes, uint availableGreenCubes, uint availableBlueCubes)
	{
		Record = new GameRecord(record);
		AvailableRedCubes = availableRedCubes;
		AvailableGreenCubes = availableGreenCubes;
		AvailableBlueCubes = availableBlueCubes;
	}

	public uint Id => Record.Id;
	public uint AvailableRedCubes { get; private init; }
	public uint AvailableGreenCubes { get; private init; }
	public uint AvailableBlueCubes { get; private init; }
	public GameRecord Record { get; private init; }
	public bool IsValidGame
	{
		get
		{
			return AvailableRedCubes >= Record.RedCubesMax
				&& AvailableGreenCubes >= Record.GreenCubesMax
				&& AvailableBlueCubes >= Record.BlueCubesMax;
		}
	}
	public uint PowerOfMinimalSet
	{
		get
		{
			return Record.RedCubesMax * Record.GreenCubesMax * Record.BlueCubesMax;
		}
	}
}
