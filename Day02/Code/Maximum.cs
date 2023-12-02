// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
internal sealed record Maximum
{
	public uint Value { get; set; }
	public uint MinValue { get; set; }

	public void Add(uint input)
	{
		Value = Value > input ? Value : input;
		MinValue = MinValue < input ? MinValue : input;
	}
}