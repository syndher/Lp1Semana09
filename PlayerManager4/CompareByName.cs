using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;
using System.Text;

namespace Players
{
    public class CompareByName : IComparer<Player>
    {
        private readonly bool _ascending;
    
    public CompareByName(bool ascending)
    {
        _ascending = ascending;
    }
    public int Compare(Player a, Player b)
    {
    if (a == null && b == null) return 0;
    if (a == null) return _ascending ? -1 : 1;
    if (b == null) return _ascending ? 1 : -1;

    int result = string.Compare(a.Name, b.Name);

    Console.WriteLine($"Comparing {a.Name} with {b.Name}: result {result}");

    return _ascending ? result : -result;
    }
 
    }
}
