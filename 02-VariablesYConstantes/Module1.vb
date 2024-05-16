Module Module1

    Sub Main()

        'Para declarar variables se utiliza la instruccion "Dim"
        'en vb.net se tiene que definir el tipo de la variable, y se tiene que respetar en todo el codigo

        Dim numero As Integer = 28
        'Esto quiere decir "dimenciona numero como entero" y se le asigna el valor = 12


        'otra forma de asignarle el valor a una variable seria 
        Dim otroNumero As Integer

        otroNumero = 19


        'para declarar constantes, una buena practica es nombrar las constantes en mayusculas
        'es obligatorio asignarle el valor en la misma linea
        Const PULGADA As Double = 2.54


        'otros tipos de variables

        Dim letra As Char = "a"

        Dim cadena As String = "esta es una cadena"

        Dim condicion As Boolean = True

        'nota: vb.net no es case sensitive lo que significa que no distinge entre mayusculas y minusculas, es lo mismo
        'ejemplo nombre y Nombre para vb.net son lo mismo

    End Sub

End Module
