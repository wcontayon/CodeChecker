// Copyright (c) HADEM. All rights reserved.

namespace CodeChecker.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    /// <summary>
    /// Argument checker test.
    /// </summary>
    public class ArgumentTest
    {
        private const string PARAMNAME = "FakeParam";

        private string s = string.Empty;
        private object? obj = null;
        private FakeClass fake = null;

        /// <summary>
        /// Fact.
        /// </summary>
        [Fact]
        public void Argument_Check_NotNull_Should_Throw_Exception_When_Null()
        {
            // Assert
            Assert.Throws<ArgumentNullException>(() => Argument.Require.NotNull<FakeClass>(null!, PARAMNAME));
            Assert.Throws<ArgumentNullException>(() => Argument.Require.NotNull<FakeClass>(this.fake, PARAMNAME));
            Assert.Throws<ArgumentNullException>(() => Argument.Require.NotNull(this.obj, PARAMNAME));
            Assert.Throws<ArgumentNullException>(() => Argument.Require.NotNullOrEmpty(this.s, PARAMNAME));

            Assert.Throws<ArgumentNullException>(() => Argument.Require.NotNullOrEmpty<FakeClass>(Enumerable.Empty<FakeClass>()));
            Assert.Throws<ArgumentNullException>(() => Argument.Require.NotNullOrEmpty<FakeClass>(null!));

            Assert.Throws<ArgumentNullException>(() => Argument.Require.NotNullOrEmpty(new List<FakeClass>()));

            Assert.ThrowsAny<Exception>(() => Argument.Assume.NotNull<FakeClass>(null!, PARAMNAME));
            Assert.ThrowsAny<Exception>(() => Argument.Assume.NotNull<FakeClass>(this.fake, PARAMNAME));
            Assert.ThrowsAny<Exception>(() => Argument.Assume.NotNull(this.obj, PARAMNAME));
            Assert.ThrowsAny<Exception>(() => Argument.Assume.NotNullOrEmpty(this.s, PARAMNAME));

            Assert.ThrowsAny<Exception>(() => Argument.Assume.NotNullOrEmpty<FakeClass>(Enumerable.Empty<FakeClass>()));
            Assert.ThrowsAny<Exception>(() => Argument.Assume.NotNullOrEmpty<FakeClass>(null!));

            Assert.ThrowsAny<Exception>(() => Argument.Assume.NotNullOrEmpty(new List<FakeClass>()));
        }

        /// <summary>
        /// Fact.
        /// </summary>
        [Fact]
        public void Argument_Check_NotNull_Should_Not_Throws_Exception()
        {
            // Arrange
            this.obj = new { Fake = "em" };

            // Act
            var value = Argument.Require.NotNull<FakeClass>(new FakeClass(), PARAMNAME);
            var objval = Argument.Require.NotNull(this.obj, PARAMNAME);

            Argument.Require.NotNullOrEmpty("dedek", PARAMNAME);
            Argument.Require.NotNullOrEmpty("depdeinde\0", PARAMNAME);

            IEnumerable<FakeClass> col = new List<FakeClass>() { new FakeClass() };

            Argument.Require.NotNullOrEmpty(col.AsEnumerable());
            Argument.Require.NotNullOrEmpty(col.ToList());

            Assert.Equal(this.obj, objval);
            Assert.NotNull(value);
        }

        /// <summary>
        /// Fact.
        /// </summary>
        [Fact]
        public void Argument_Check_Null_Should_Throw_Exception_When_NotNull()
        {
            // Assert
            Assert.Throws<ArgumentException>(() => Argument.Require.Null<FakeClass>(new FakeClass(), PARAMNAME));
            Assert.Throws<ArgumentException>(() => Argument.Require.Null(this.obj = new object(), PARAMNAME));
            Assert.Throws<ArgumentException>(() => Argument.Require.NullOrEmpty("dkenldke", PARAMNAME));
            Assert.Throws<ArgumentException>(() => Argument.Require.NullOrEmpty("zkndlknlek\0", PARAMNAME));

            IEnumerable<FakeClass> col = new List<FakeClass>() { new FakeClass() };

            Assert.Throws<ArgumentException>(() => Argument.Require.NullOrEmpty<FakeClass>(col.AsEnumerable()));
            Assert.Throws<ArgumentException>(() => Argument.Require.NullOrEmpty<FakeClass>(col.ToList()));

            Assert.ThrowsAny<Exception>(() => Argument.Assume.Null<FakeClass>(new FakeClass(), PARAMNAME));
            Assert.ThrowsAny<Exception>(() => Argument.Assume.Null(this.obj = new object(), PARAMNAME));
            Assert.ThrowsAny<Exception>(() => Argument.Assume.NullOrEmpty("dkenldke", PARAMNAME));
            Assert.ThrowsAny<Exception>(() => Argument.Assume.NullOrEmpty("zkndlknlek\0", PARAMNAME));

            Assert.ThrowsAny<Exception>(() => Argument.Assume.NullOrEmpty<FakeClass>(col.AsEnumerable()));
            Assert.ThrowsAny<Exception>(() => Argument.Assume.NullOrEmpty<FakeClass>(col.ToList()));
        }

        /// <summary>
        /// Fact.
        /// </summary>
        [Fact]
        public void Argument_Check_Null_Should_Not_ThrowException_When_Null()
        {
            Argument.Require.Null<FakeClass>(null!, PARAMNAME);
            Argument.Require.Null<FakeClass>(this.fake, PARAMNAME);
            Argument.Require.Null(this.obj, PARAMNAME);
            Argument.Require.NullOrEmpty(this.s, PARAMNAME);

            Argument.Require.NullOrEmpty<FakeClass>(Enumerable.Empty<FakeClass>());
            Argument.Require.NullOrEmpty<FakeClass>(null!);

            Argument.Require.NullOrEmpty(new List<FakeClass>());

            Argument.Assume.Null<FakeClass>(null!, PARAMNAME);
            Argument.Assume.Null<FakeClass>(this.fake, PARAMNAME);
            Argument.Assume.Null(this.obj, PARAMNAME);
            Argument.Assume.NullOrEmpty(this.s, PARAMNAME);

            Argument.Assume.NullOrEmpty<FakeClass>(Enumerable.Empty<FakeClass>());
            Argument.Assume.NullOrEmpty<FakeClass>(null!);

            Argument.Assume.NullOrEmpty(new List<FakeClass>());
        }
    }
}
