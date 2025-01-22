using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp;

/// <summary>
/// Compare objects for descending order
/// </summary>
/// <typeparam name="T"></typeparam>
public class DescendingComparer<T> : IComparer<T>
{
    public int Compare(T? x, T? y)
    {
        if (x == null) return -1;
        if (y == null) return 1;
        return Comparer<T>.Default.Compare(y, x);
    }
}
