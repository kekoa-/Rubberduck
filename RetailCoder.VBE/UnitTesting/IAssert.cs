﻿using System.Runtime.InteropServices;

// The parameters on RD's public interfaces are following VBA conventions not C# conventions to stop the
// obnoxious "Can I haz all identifiers with the same casing" behavior of the VBE.
// ReSharper disable InconsistentNaming

namespace Rubberduck.UnitTesting
{
    [ComVisible(true)]
    [Guid(RubberduckGuid.IAssertGuid)]
    public interface IAssert
    {
        /// <summary>
        /// Verifies that the specified condition is <c>true</c>. The assertion fails if the condition is <c>false</c>.
        /// </summary>
        /// <param name="Condition">Any Boolean value or expression.</param>
        /// <param name="Message">An optional message to display if the assertion fails.</param>
        [DispId(1)]
        void IsTrue(bool Condition, string Message = "");

        /// <summary>
        /// Verifies that the specified condition is <c>false</c>. The assertion fails if the condition is <c>true</c>.
        /// </summary>
        /// <param name="Condition">Any Boolean value or expression.</param>
        /// <param name="Message">An optional message to display if the assertion fails.</param>
        [DispId(2)]
        void IsFalse(bool Condition, string Message = "");

        /// <summary>
        /// Indicates that the assertion cannot be verified.
        /// </summary>
        /// <param name="Message">An optional message to display.</param>
        [DispId(3)]
        void Inconclusive(string Message = "");

        /// <summary>
        /// Fails the assertion without checking any conditions.
        /// </summary>
        /// <param name="Message">An optional message to display.</param>
        [DispId(4)]
        void Fail(string Message = "");

        /// <summary>
        /// Passes the assertion without checking any conditions.
        /// </summary>
        [DispId(5)]
        void Succeed();

        /// <summary>
        /// Verifies that the specified object is <c>Nothing</c>. The assertion fails if it is not <c>Nothing</c>.
        /// </summary>
        /// <param name="Value">The object to verify.</param>
        /// <param name="Message">An optional message to display if the assertion fails.</param>
        [DispId(6)]
        void IsNothing(object Value, string Message = "");

        /// <summary>
        /// Verifies that the specified object is not <c>Nothing</c>. The assertion fails if it is <c>Nothing</c>.
        /// </summary>
        /// <param name="Value">The object to verify.</param>
        /// <param name="Message">An optional message to display if the assertion fails.</param>
        [DispId(7)]
        void IsNotNothing(object Value, string Message = "");

        /// <summary>
        /// Verifies that two specified objects are equal. The assertion fails if the objects are not equal.
        /// </summary>
        /// <param name="Expected">The expected value.</param>
        /// <param name="Actual">The actual value.</param>
        /// <param name="Message">An optional message to display if the assertion fails.</param>
        /// <remarks>
        /// <paramref name="Expected"/> and <paramref name="Actual"/> must be the same type.
        /// </remarks>
        [DispId(8)]
        void AreEqual(object Expected, object Actual, string Message = "");

        /// <summary>
        /// Verifies that two specified objects are not equal. The assertion fails if the objects are equal.
        /// </summary>
        /// <param name="Expected">The expected value.</param>
        /// <param name="Actual">The actual value.</param>
        /// <param name="Message">An optional message to display if the assertion fails.</param>
        /// <remarks>
        /// <paramref name="Expected"/> and <paramref name="Actual"/> must be the same type.
        /// </remarks>
        [DispId(9)]
        void AreNotEqual(object Expected, object Actual, string Message = "");

        /// <summary>
        /// Verifies that two specified object variables refer to the same object. The assertion fails if they refer to different objects.
        /// </summary>
        /// <param name="Expected">The expected reference.</param>
        /// <param name="Actual">The actual reference.</param>
        /// <param name="Message">An optional message to display if the assertion fails.</param>
        [DispId(10)]
        void AreSame(object Expected, object Actual, string Message = "");

        /// <summary>
        /// Verifies that two specified object variables refer to different objects. The assertion fails if they refer to the same object.
        /// </summary>
        /// <param name="Expected">The expected reference.</param>
        /// <param name="Actual">The actual reference.</param>
        /// <param name="Message">An optional message to display if the assertion fails.</param>
        [DispId(11)]
        void AreNotSame(object Expected, object Actual, string Message = "");

        /// <summary>
        /// Verifies that all of the items in 2 arrays are equal. The assertion fails if any items is different, if either the lower 
        /// bounds or upper bounds are different, or if the ranks (number of dimensions) differ.  This can be used for arrays of arbitrary 
        /// dimensions and arbitrary bounds.
        /// </summary>
        /// <param name="Expected">The expected sequence.</param>
        /// <param name="Actual">The actual sequence.</param>
        /// <param name="Message">An optional message to display if the assertion fails.</param>
        [DispId(12)]
        void SequenceEquals(object Expected, object Actual, string Message = "");

        /// <summary>
        /// Verifies that at least one of the items in 2 arrays differs at any give index. The assertion fails if all of the items are the same, if 
        /// the lower bounds and upper bounds are the same, and the ranks (number of dimensions) are the same.  This can be used for arrays of arbitrary 
        /// dimensions and arbitrary bounds.
        /// </summary>
        /// <param name="Expected">The expected sequence.</param>
        /// <param name="Actual">The actual sequence.</param>
        /// <param name="Message">An optional message to display if the assertion fails.</param>
        [DispId(13)]
        void NotSequenceEquals(object Expected, object Actual, string Message = "");
    }
}
