// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

namespace QosmosUI.Icons.Generator.Extensions;

/// <summary>
/// Provides extension methods for string manipulation.
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Converts a string to PascalCase.
    /// </summary>
    /// <param name="value">The input string to convert.</param>
    /// <returns>
    /// A new string in PascalCase format, where each word is capitalized and concatenated.
    /// Words are split based on '-', '_', or ' ' (space) characters.
    /// </returns>
    public static string ToPascalCase(this string value)
    {
        return value
            .Split(['-', '_', ' '], StringSplitOptions.RemoveEmptyEntries)
            .Where(static t => t.Length > 0)
            .Aggregate(string.Empty, (current, t) => current + (char.ToUpper(t[0]) + t[1..]));
    }
}
