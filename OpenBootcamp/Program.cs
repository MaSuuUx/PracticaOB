//Array
int[] numbers = new int[10] { 1,2,3,4,5,6,7,8,9,10 };
string[] nombres = { "Juan", "María", "Carlos", "Laura", "Pedro" };


//Llamar al metodo 
EscribirNombres(nombres);

//Obtener datos de la consulta
var pares =
    from numero in numbers
    where (numero % 2) == 0
    select numero;
var impares =
    from numero in numbers
    where (numero % 2) != 0
    select numero;


//Imprimir los datos
foreach(var num in pares)
{
    Console.WriteLine(num + " ");
}
foreach (var num in impares)
{
    Console.WriteLine(num + " ");
}

void EscribirNombres(string[] nombres)
{
    foreach (var nom in nombres)
    {
        Console.WriteLine(nom);
    }
}