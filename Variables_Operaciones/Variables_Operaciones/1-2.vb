Module _1_2
    Public nombre As String
    Friend tipo_documento As String
    Friend num_documento As UInteger
    Private localidad As String
    Private fecha_nacimiento As Date
    Private altura_corporal As Single
    Private estado_civil As String
    Private es_argentino As Boolean
    Dim edad As Byte
    Sub main()
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
