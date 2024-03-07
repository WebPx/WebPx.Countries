using System.ComponentModel;

// ReSharper disable once CheckNamespace
namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Class that allows to use the C# 9.0 init only setters in previous versions of C#
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class IsExternalInit { }
}