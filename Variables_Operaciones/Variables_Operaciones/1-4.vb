Module _1_4
    Sub main()
        Dim nombre_empresa As String = "City Salud"
        Dim nombre_calle As String = "3 de Febrero"
        Dim altura_calle As UInt16 = 1988
        Dim fecha_inicioActividades As Date = Now

        Console.Write(nombre_empresa & nombre_calle & altura_calle & fecha_inicioActividades)
        Console.Write(nombre_empresa + nombre_calle + Convert.ToString(altura_calle) + Convert.ToString(fecha_inicioActividades))
        Console.Read()
    End Sub
End Module
