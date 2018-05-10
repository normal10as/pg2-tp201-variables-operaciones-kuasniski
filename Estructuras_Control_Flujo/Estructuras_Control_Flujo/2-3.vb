Module _2_3
    Sub main()
        Dim a, b, c, d, e As Int16

        Console.Write("Ingrese un numero:")
        a = Console.ReadLine
        Console.Write("Ingrese el segundo numero:")
        b = Console.ReadLine
        Console.Write("Ingrese el tercer numero:")
        c = Console.ReadLine
        Console.Write("Ingrese el cuarto numero:")
        d = Console.ReadLine
        Console.Write("Ingrese el tercer numero:")
        e = Console.ReadLine

        If a > b And a > c And a > d And a > e Then
            Console.Write("El primer numero es el de mayor valor")
        ElseIf b > c And b > d And b > e Then
            Console.Write("El segundo numero es el de mayor valor")
        ElseIf c > d And c > e Then
            Console.Write("El tecer numero es el de mayor valor")
        ElseIf d > e Then
            Console.Write("El cuarto numero es el de mayor valor")
        Else
            Console.Write("El quinto numero es el de mayor valor")
        End If
        Console.ReadKey()
    End Sub
End Module
