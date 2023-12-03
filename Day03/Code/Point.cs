// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
internal sealed record Point(int X, int Y)
{
	public IEnumerable<Point> Neighbours
	{
		get
		{
			return new Point[]
			{
				new(X-1, Y-1),
				new(X, Y-1),
				new(X+1, Y-1),
				new(X-1, Y),
				new(X+1, Y),
				new(X-1, Y+1),
				new(X, Y+1),
				new(X+1, Y+1)
			};
		}
	}
}