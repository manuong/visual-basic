Module Module1

    'los condicionales o sentencias anidadas nos van a permitir tener mas de una condicion
    'para poder evaluar y definir las instrucciones a realizar por cada candicion 

    Sub Main()

        'Ejemplo 

        'Un administrador de una empresa, quiere que le desarrollen un programa que
        'le permita realizar un cálculo en cuanto al pago individual de un trabajador en su desempeño
        'en el mes en la empresa, en el cual establece como sueldo base $ 930, además para realizar
        'el pago completo, es decir con bonificaciones en ventas, tiene los siguientes criterios

        'Si el trabajador en el mes tuvo un desempeño en ventas de más de $ 4500, se le
        'suma a su pago el 10% sobre su sueldo base.

        'Si el trabajador en el mes tuvo un desempeño en ventas de más de $ 6500, se le
        'suma a su pago el 20% sobre su sueldo base.

        'Si el trabajador en el mes tuvo un desempeño en ventas de más de $ 8000, se le
        'suma a su pago el 35% sobre su sueldo base.

        Dim sueldoBase As Double = 930.0

        Dim sueldoAPagar As Double

        Dim ventas As Double


        Console.Write("Ingresa la cantidad de dinero en ventas: $")

        ventas = Console.ReadLine()


        If ventas > 4500 And ventas <= 6500 Then

            sueldoAPagar = sueldoBase * 1.1

        ElseIf ventas > 6500 And ventas <= 8000 Then

            sueldoAPagar = sueldoBase * 1.2

        ElseIf ventas > 8000 Then

            sueldoAPagar = sueldoBase * 1.35

        Else

            sueldoAPagar = sueldoBase

        End If

        Console.WriteLine("El total a pagar son: $" & sueldoAPagar)

    End Sub

End Module
