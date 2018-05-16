Module _1_5
    Sub main()
        Dim a As Integer = 5
        Dim b As Integer = 3
        Dim c As Single = 2.3
        Dim d As Single = 3.2

        Console.WriteLine("suma entero:" & a + b & "resta de entero:" & a - b & "Prodcuto entero:" & a * b &
                      "Division de enteros:" & a / b)
        Console.WriteLine("suma flotante:" & c + d & "resta de flotante:" & c - d & "Prodcuto flotente:" & c * d &
                      "Division de flotante:" & c / d)
        Console.WriteLine("suma mixta:" & a + c & "Resta mixta:" & b - d & "Producto mixto:" & b * d & "Division mixta:" & a / c)
        Console.Read()
    End Sub
End Module
