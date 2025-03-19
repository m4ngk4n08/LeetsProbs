
//**********
//*********
//********
//*******
//******
//*****
//****
//***
//**
//*

//for (int i = 0; i < 10; i++)
//{
//	for (int j = i; j < 10; j++)
//	{
//        Console.Write("*");
//	}
//    Console.WriteLine();
//}


//         *
//        **
//       ***
//      ****
//     *****
//    ******
//   *******
//  ********
// *********
//**********
//for (int i = 0; i < 10; i++)
//{
//	for (int j = i; j < 10; j++)
//	{
//		Console.Write(" ");
//	}
//	for (int q = 0; q <= i; q++)
//    {
//        Console.Write("*");
//    }
//	Console.WriteLine();
//}


//*
//**
//***
//****
//*****
//******
//*******
//********
//*********
//**********
//for (int i = 0; i < 10; i++)
//{
//    for (int j = 0; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}


//**********
// *********
//  ********
//   *******
//    ******
//     *****
//      ****
//       ***
//        **
//         *

for (int i = 0; i < 10; i++)
{
    for (int q = 0; q < i; q++)
    {
        Console.Write(" ");
    }
    for (int j = i; j < 10; j++)
	{
        Console.Write("*");
	}
    Console.WriteLine();
}