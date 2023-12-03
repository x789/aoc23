// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
internal sealed record Number(int Value, Point Position, int Length)
{
	public IEnumerable<Point> OccupiedPoints
	{
		get
		{
			var points = new List<Point>();
			for (int x = Position.X; x < Position.X + Length; x++)
				points.Add(new(x, Position.Y));
			return points;
		}
	}
}
