// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
using System.Reflection;
public static class InputReader
{
	public static IEnumerable<string> ReadFile(string filename)
	{
		var assembly = Assembly.GetCallingAssembly();
		var inputFile = assembly.GetManifestResourceNames().Single(str => str.EndsWith(filename));
		using var inputStream = assembly.GetManifestResourceStream(inputFile)!;
		using var reader = new StreamReader(inputStream);
		for (var line = reader.ReadLine(); line != null; line = reader.ReadLine())
			yield return line;
	}
}
