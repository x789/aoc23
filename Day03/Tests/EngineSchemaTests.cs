// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
public sealed class EngineSchemaTests
{
	[Fact]
	public void Init()
	{
		var sut = new EngineSchema();

		Assert.Equal(0, sut.NumberOfRows);
		Assert.Equal(0, sut.NumberOfColumns);
	}

	[Fact]
	public void NumberOfRows()
	{
		var sut = new EngineSchema();

		sut.AddLine();
		sut.AddLine();
		sut.AddLine();

		Assert.Equal(3, sut.NumberOfRows);
	}

	[Fact]
	public void NumberOfColumns()
	{
		var sut = new EngineSchema();

		sut.AddLine();
		for (int j = 0; j < 5; j++)
			sut.Add('.');

		Assert.Equal(5, sut.NumberOfColumns);
	}

	[Theory]
	[InlineData(0, 0, false)]
	[InlineData(1, 0, true)]
	[InlineData(0, 1, false)]
	[InlineData(1, 1, true)]
	public void IsSymbolAt(int x, int y, bool expected)
	{
		var sut = new EngineSchema();
		sut.AddLine();
		sut.Add('5');
		sut.Add('/');
		sut.AddLine();
		sut.Add('.');
		sut.Add('$');

		var actual = sut.IsSymbolAt(new(x, y));

		Assert.Equal(expected, actual);
	}
}