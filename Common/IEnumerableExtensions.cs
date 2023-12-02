// Copyright (c) 2023 - TillW
// Licensed to you under the MIT License
public static class IEnumerableExtensions
{
	public static void Deconstruct<T>(this IEnumerable<T> source, out T? first, out T? second, out IEnumerable<T> rest)
	{
		first = source.FirstOrDefault();
		second = source.Skip(1).FirstOrDefault();
		rest = source.Skip(2);
	}
}
