// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;
Assembly a = Assembly.LoadFrom("SP2_3cw.dll");
Module m = a.GetModule("SP2_3cw.dll");
foreach (Type t in m.GetTypes())
{
    Console.Write(t);
}

