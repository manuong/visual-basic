Module Module1

    'Los condicionales permiten evaluar una o varias condiciones que si se cumplen o no definira el
    'flujo de nuestro programa

    Sub Main()

        Dim condicion As Boolean = True

        'sentencia if - else

        'sintaxis if


        If (condicion) Then

            'instrucciones si la condicion es true o se cumple

        End If

        'sintaxis if - else

        If (condicion) Then

            'instrucciones si la condicion es true o se cumple

        Else

            'instrucciones para un caso contrario

        End If



        'Ejemplo

        'Realiza un programa que muestre por consola si un estudiante con el dinero que tiene ahorrado puede 
        'pagar la universidad y estudiar, teniendo en cuenta que el semestre de la carrera que estudia tiene
        'un valor de 800 pesos

        Dim dineroAhorrado As Double

        Console.Write("Ingresa la cantidad de dinero que tienes ahorrado: $")

        dineroAhorrado = Console.ReadLine()


        If (dineroAhorrado < 800) Then

            Console.WriteLine("no puedes pagar el semestre con solo: $" & dineroAhorrado)

        Else

            Console.WriteLine("puedes continuar con el semestre")

        End If

    End Sub

End Module
