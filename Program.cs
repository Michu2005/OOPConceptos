//// Tipos de datos
//int myint = 5;
//double mydouble = 3.4;
//float myfloat = 4.56f;
//decimal mydecimal = 4.56m;

//string mystring = "Michelle";

//bool mybool = true;

//var myVar = 23.4;


//Console.WriteLine($"Mi valor entero es..: {myint, 20:N2}");
//Console.WriteLine($"Mi valor doble es..: {mydouble, 20:N2}");
//Console.WriteLine($"Mi valor float es..: {myfloat, 20:P2}");
//Console.WriteLine($"Mi valor decimal es: {mydecimal, 20:C2}");
//Console.WriteLine($"Mi nombre es.......: {mystring}");
//Console.WriteLine($"Mi boolean es......: {(mybool ? "Correcto": "Incorrecto")}");  //if en una sola linea o tenrnarios


using OOPConceptos.Logica;
try
{
    var fecha1 = new Date()
    {
        Yaer = 2023,
        Month = 2,
        Day = 28
    };
    Console.WriteLine(fecha1);
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}