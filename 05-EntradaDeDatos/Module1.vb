Module Module1

    'la entrada de datos por consola se refiere a que el programa le pide al usuario de la misma, que ingrese datos
    'que son fundamentales para que la aplicación funcione y solucionar el problema por el cual fue creada,

    'se realiza en tiempo de ejecución, es decir, cuando el programa se pone en marcha.

    Sub Main()

        'La sintaxis correcta para guardar datos que ingrese el usuario por teclado, es la siguiente

        'Dim datoIngresado As String = Console.ReadLine()



        'Ejemplo

        Dim miNombre As String

        Console.Write("Ingresa tu nombre: ")

        miNombre = Console.ReadLine()

        Console.WriteLine("Hola " & miNombre) ' "&" operador para concatenar valores


        'diferencia entre "Write" y "WriteLine"

        'Console.WriteLine() <--- muestra una salida de dato con un salto de linea

        'Console.Write() <--- muestra una salida de dato sin salto de linea

    End Sub

End Module
