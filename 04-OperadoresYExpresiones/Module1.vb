Module Module1

    'Los operadores nos permiten establecer operaciones matemáticas, comparaciones y
    'condiciones, los operadores que utilizaremos en este curso son los aritméticos, los
    'relacionales y los lógicos.

    Sub Main()

        'operadores aritmeticos

        Dim suma As Double = 8 + 2

        Dim resta As Double = 5 - 2

        Dim multiplicacion As Double = 10 * 2

        Dim divicion As Double = 8 / 3

        Dim residuo As Double = 8 Mod 3

        Console.WriteLine(residuo)



        'operador de incremento

        suma += 2 'suma = suma + 2

        Console.WriteLine(suma) '12



        'operador de decremento

        suma -= 2 'suma = suma - 2

        Console.WriteLine(suma) '10



        'operadores relacionales

        Dim mayorQue As Boolean = -12 > 2 'false

        Dim menorQue As Boolean = -12 < 2 'true

        Dim mayorIgualQue As Boolean = 2 >= 2 'true

        Dim manorIgualQue As Boolean = 3 <= 2 'false

        Dim distintoQue As Boolean = 2 <> 2 'false

        Dim igualQue As Boolean = 2 = 2 'true

        Console.WriteLine(igualQue)



        'operadores logicos

        Dim condicionUno As Boolean = 2 < 3 And 4 = 4 'true

        Dim condicionDos As Boolean = 7 > 4 And 3 > 4 'false

        Dim condicionTres As Boolean = 7 > 4 Or 3 > 4 'true

        Dim condicionCuatro As Boolean = 7 < 4 Or 3 > 4 'false

        Dim negacion As Boolean = Not 7 > 4 'false

        Console.WriteLine(negacion)


    End Sub

End Module
