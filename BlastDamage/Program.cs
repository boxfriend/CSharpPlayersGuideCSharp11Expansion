using System.Numerics;

Console.WriteLine(ComputeDamage(16.0d, 10.25d));
Console.WriteLine(ComputeDamage(20f, 18f));
Console.WriteLine(ComputeDamage(4.20m, 6.9m));

static T ComputeDamage<T> (T initialDamage, T distance) where T : IMultiplyOperators<T, T, T>, IDivisionOperators<T, T, T> => initialDamage / (distance * distance);