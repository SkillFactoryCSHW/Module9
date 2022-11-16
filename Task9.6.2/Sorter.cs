﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
public class Sorter
{
    //
    public List<string> List;
    public ConsoleKeyInfo key;

    public delegate void SortAsc(List<string> list);
    public event SortAsc Ascsort;

    public delegate List<String> SortDesc(List<string> list);
    public event SortDesc Descsort;

    public Sorter(List<string> list, ConsoleKeyInfo key)
    {
        list = List;
        this.key = key;
    }

    public void SortingAscend(List<string> List)
    {

        List.Sort();
        foreach (var item in List)
        {
            Console.WriteLine(item);
        }
    }

    public void MethodSort(ConsoleKeyInfo key)
    {
        if (key.Key == ConsoleKey.D1)
        {
            Ascsort(List);
        }
    }
}