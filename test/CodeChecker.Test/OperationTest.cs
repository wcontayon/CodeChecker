// Copyright (c) HADEM. All rights reserved.

namespace CodeChecker.Test
{
    using System;
    using Xunit;

    /// <summary>
    /// Test class for <see cref="Operation"/>.
    /// </summary>
    public class OperationTest
    {
        private const string FALSE_MSG_EXCEPTION = "condition returned false";
        private const string TRUE_MSG_EXCEPTION = "condition return true";

        /// <summary>
        /// Fact.
        /// </summary>
        [Fact]
        public void Operation_Check_Should_Return_Without_ThrowException()
        {
            // Act
            // Should not throw exception.
            Operation.ThrowIf(1 < 0, FALSE_MSG_EXCEPTION);

            // Assert
            Assert.True(Operation.False(1 < 0, FALSE_MSG_EXCEPTION, false));
            Assert.True(Operation.False(() => false, FALSE_MSG_EXCEPTION, false));

            Assert.True(Operation.True(1 > 0, TRUE_MSG_EXCEPTION, false));
            Assert.True(Operation.True(() => true, TRUE_MSG_EXCEPTION, false));

            Assert.True(Operation.That(1 > 0, false, TRUE_MSG_EXCEPTION));
            Assert.False(Operation.That(1 < 0, false, FALSE_MSG_EXCEPTION));
        }

        /// <summary>
        /// Fact.
        /// </summary>
        [Fact]
        public void Operation_Check_Should_Throw_Exception_When_Condition_is_False()
        {
            // Assert
            Assert.Throws<InvalidOperationException>(() => Operation.ThrowIf(1 > 0, TRUE_MSG_EXCEPTION));
            Assert.Throws<InvalidOperationException>(() => Operation.False(1 > 0, FALSE_MSG_EXCEPTION, true));
            Assert.Throws<InvalidOperationException>(() => Operation.False(() => true, FALSE_MSG_EXCEPTION, true));

            Assert.Throws<InvalidOperationException>(() => Operation.True(1 < 0, FALSE_MSG_EXCEPTION, true));
            Assert.Throws<InvalidOperationException>(() => Operation.True(() => false, FALSE_MSG_EXCEPTION, true));

            Assert.Throws<InvalidOperationException>(() => Operation.That(1 < 0, true, FALSE_MSG_EXCEPTION));
            Assert.Throws<InvalidOperationException>(() => Operation.That(1 < 0, true, FALSE_MSG_EXCEPTION));
        }

        /// <summary>
        /// Fact.
        /// </summary>
        [Fact]
        public void Operation_Check_Should_Not_ThrowException_When_Condition_Is_False()
        {
            // Assert
            Assert.False(Operation.False(1 > 0, FALSE_MSG_EXCEPTION, false));
            Assert.True(Operation.False(() => false, FALSE_MSG_EXCEPTION, false));

            Assert.True(Operation.True(1 > 0, TRUE_MSG_EXCEPTION, false));
            Assert.True(Operation.True(() => true, TRUE_MSG_EXCEPTION, false));

            Assert.True(Operation.That(1 > 0, false, TRUE_MSG_EXCEPTION));
            Assert.False(Operation.That(1 < 0, false, FALSE_MSG_EXCEPTION));
        }
    }
}
