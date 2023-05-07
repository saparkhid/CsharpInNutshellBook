// See https://aka.ms/new-console-template for more information
using Ch_4._1._6_InterfaceAndDelegate;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
int[] values = { 1, 2, 3 };
UtilityD.TransformAll(values, TransformerSquare);
UtilityD.TransformAll(values, TransformerCuber);


UtilityI.TransformAll(values, new CuberTransform());
UtilityI.TransformAll(values, new SquareTransformer());

UtilitySeyedMostafa.TransformAll(values, new TransformerSeyedMostafa(), true);
UtilitySeyedMostafa.TransformAll(values, new TransformerSeyedMostafa());

foreach (int item in values)
{
    Console.WriteLine(item);
}  
int TransformerSquare(int x)
{
    return x * x;
}
int TransformerCuber(int x)
{
    return x * x *x;
}