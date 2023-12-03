// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
internal sealed record Ratio(Number Factor1, Number Factor2)
{
	public int Value => Factor1.Value * Factor2.Value;
}