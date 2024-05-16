Module Module1

    'Los ámbitos de las variables nos indican el espacio de la variable y que alcance tiene esta
    'cuando es declarada, es decir una variable puede tener un ámbito local, y un ámbito Global.

    'Las variables de ámbito local, son aquellas que se declaran dentro de una función,
    'procedimiento, método, condicional, bucle entre otros. Por ejemplo, si una variable se
    'declara dentro de una función o método, y esta se quiere utilizar dentro de otra función,
    'ocurriría un Error,

    'Las variables de ámbito global, son aquellas que una vez declarada pueden ser utilizadas
    'desde cualquier parte del programa, estas son comúnmente utilizadas en las clases y los
    'módulos, y en programas sencillos

    Dim variableGlobal As Integer = 60 'esta variable es de ambito global dentro del modulo


    Sub Main()

        Dim variableLocal As Integer = 12

        variableLocal = 24 'podemos aceder a ella porque esta dentro del metodo "Main()"

    End Sub

    Sub OtroMetodo()

        'aqui no se puede acceder a "variableLocal" salta un error

        variableGlobal = 38 'podemos acceder a ella porque esta declarado dentro del modulo

    End Sub

End Module
