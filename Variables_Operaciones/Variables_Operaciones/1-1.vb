Module _1_1
    Sub main()
        Dim nombre As String
        Dim tipo_documento As String
        Dim num_documento As UInteger
        Dim localidad As String
        Dim fecha_nacimiento As Date
        Dim altura_corporal As Single
        Dim estado_civil As String
        Dim es_argentino As Boolean
        Dim edad As Byte

        nombre = "Fabricio"
        tipo_documento = "DNI"
        num_documento = 34971203
        localidad = "Posadas"
        fecha_nacimiento = "16/02/1990"
        altura_corporal = 1.78
        estado_civil = "Soltero"
        es_argentino = True
        edad = 23
        Console.WriteLine("Nombre: " & nombre)
        Console.WriteLine("Tipo de Documento: " & tipo_documento)
        Console.WriteLine("Nro de documento: " & num_documento)
        Console.WriteLine("Localidad: " & localidad)
        Console.WriteLine("Fecha de Nacimiento: " & fecha_nacimiento)
        Console.WriteLine("Altura corpotral: " & altura_corporal)
        Console.WriteLine("Estado civil: " & estado_civil)
        Console.WriteLine("Es argentino: " & es_argentino)
        Console.WriteLine("Edad: " & edad)
        Console.ReadKey()

    End Sub
End Module
