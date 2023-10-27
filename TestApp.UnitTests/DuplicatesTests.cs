using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        CollectionAssert.IsEmpty(result);
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] numbers = new int[] {1, 2, 3, 4, 5};

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        CollectionAssert.AreEqual(result, numbers);
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        int[] numbers = new int[] { 1, 1, 2, 2, 3, 4, 5, };

        int[] result = Duplicates.RemoveDuplicates(numbers);

        CollectionAssert.AreEqual(result, new int[] { 1, 2, 3, 4, 5 });
    
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        int[] numbers = new int[] { 1, 1, 1, 1, 1 };

        int[] result = Duplicates.RemoveDuplicates(numbers);

        CollectionAssert.AreEqual(result, new int[] { 1 });
    }
}
