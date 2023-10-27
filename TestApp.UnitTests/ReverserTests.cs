using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        CollectionAssert.IsEmpty(result);
    }

    // TODO: finish test
    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange
        string[] input = new[] { "Hello" };

        // Act
        string[] result = Reverser.ReverseStrings(input);
        // Assert
        CollectionAssert.AreEqual(result, new[] { "olleH" });
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        // Arrange
        string[] input = new[] { "Hello", "World" };

        // Act
        string[] result = Reverser.ReverseStrings(input);
        // Assert
        CollectionAssert.AreEqual(result, new[] { "olleH", "dlroW" });
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        // Arrange
        string[] input = new[] { "/*-@$%" };

        // Act
        string[] result = Reverser.ReverseStrings(input);
        // Assert
        CollectionAssert.AreEqual(result, new[] { "%$@-*/" });
    }
}
