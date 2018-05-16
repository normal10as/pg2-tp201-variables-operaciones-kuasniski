Module _1_7
    Sub mian()
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Dim r As Single

        Console.WriteLine("ingrese un numero:")
        a = Console.ReadLine()
        Console.WriteLine("ingrese otro numero:")
        b = Console.ReadLine()
        Console.WriteLine("ingrese otro numero:")
        c = Console.ReadLine()
        Console.WriteLine("ingrese un numero mas:")
        d = Console.ReadLine()
        r = a + b + c + d
        Console.WriteLine("Suma:" & r)
        Console.WriteLine("Media:" & r / 4)
        Console.Read()
    End Sub
End Module
