//********** CONVERSION DE TIPOS **********
//*****************************************
//*****************************************
//1 - convertir número entero a decimal
int CTEnt_1num1;
decimal CTDeci_1num1;
Console.WriteLine("- - - Convertir número de entero a decimal - - -\n");
try
{
    Console.WriteLine("Escriba un numero Entero");
    CTEnt_1num1 = Convert.ToInt16(Console.ReadLine());
    CTDeci_1num1 = Convert.ToDecimal(CTEnt_1num1);
    Console.WriteLine("\nEl número ingresado en Decimal es: " + CTDeci_1num1);
}
catch (Exception ex)
{
    Console.WriteLine("\n¡Error!, Ingrese solo números enteros:" + ex.Message);
}

//2 - Convertir número decimal a flotante
decimal CTDeci2_num1;
float CTFlo_2num1;
Console.WriteLine("\n- - - Convertir número decimal a flotante - - -\n");
try
{
    Console.WriteLine("Escriba un número decimal: ");
    CTDeci2_num1 = Convert.ToDecimal(Console.ReadLine());
    CTFlo_2num1 = Convert.ToSingle(CTDeci2_num1);
    Console.WriteLine("\nEl número ingresado en Flotante es: " + CTFlo_2num1);
}
catch (Exception ex)
{
    Console.WriteLine("\n¡Error! Solo número decimal: " + ex.Message);
}

//3 - Convertir número flotante a entero
float CTFlo_3num1;
int CTEnt_3num1;
Console.WriteLine("\n- - - Convertir número flotante a entero - - -\n");
try
{
    Console.WriteLine("Escribe un número flotante");
    CTFlo_3num1 = Convert.ToSingle(Console.ReadLine());
    CTEnt_3num1 = Convert.ToInt16(CTFlo_3num1);
    Console.WriteLine("\nEl número ingresado a entero es: " + CTEnt_3num1);
}
catch (Exception ex)
{
    Console.WriteLine("\n¡Error! Solo número flotante " + ex.Message);
}

//4 - Convertir caracter a enteros
char CTCha_4num1;
int CTEnt_4num1;
Console.WriteLine("\n- - - Convertir caracter a numeros enteros - - -\n");
try
{
    Console.WriteLine("Escriba una letra:");
    CTCha_4num1 = Console.ReadKey().KeyChar;
    CTEnt_4num1 = CTCha_4num1;

    Console.WriteLine("\nLa letra ingresada a número es: " + CTEnt_4num1);
}
catch (Exception ex)
{
    Console.WriteLine("\n¡Error! Solo caracter " + ex.Message);
}

//5 - Convertir entero a caracter
int CTEnt_5num1;
char CTCha_5num1;
Console.WriteLine("\n- - - Convertir entero a caracter - - -\n");
try
{
    Console.WriteLine("Por favor, ingresa un numero:");
    CTEnt_5num1 = Convert.ToInt16(Console.ReadLine());
    CTCha_5num1 = (char)CTEnt_5num1;
    Console.WriteLine("\nEl numero entero a caracter es: " + CTCha_5num1);
    Console.WriteLine("*** Haga click a Enter");
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine("\n¡Error! solo caracter: " + ex.Message);
    Console.WriteLine("*** Haga click a Enter");
    Console.ReadKey();
}

//********** OPERACIONES CON TIPOS DE DATOS **********

//1 - Suma de dos números enteros
int OTDEnt_1num1 = 25,
    OTDEnt_1num2 = 25,
    OTDEnt_1suma1;
Console.WriteLine("\n- - - Suma de números enteros - - -\n");
OTDEnt_1suma1 = OTDEnt_1num1 + OTDEnt_1num2;
Console.WriteLine($"la suma de {OTDEnt_1num1} y {OTDEnt_1num2} es: {OTDEnt_1suma1}");
Console.WriteLine("*** Haga click a Enter");
Console.ReadKey();

//2 - Resta de dos números decimales
decimal OTD_2_num1 = 10.49m,
        OTD_2num2 = 5.50m,
        OTD_2resta1;
Console.WriteLine("\n- - - Resta de números decimales - - -\n");
OTD_2resta1 = OTD_2_num1 - OTD_2num2;
Console.WriteLine($"La Resta de {OTD_2_num1} y  {OTD_2num2} es: {OTD_2resta1}");
Console.WriteLine("*** Haga click a Enter");
Console.ReadKey();

//3 - Multiplicación de dos números flotantes
float OTD_3Flo1 = -5.509f,
      OTD_3Flo2 = -2.20f,
      OTD_3Multi_1;
Console.WriteLine("\n- - - Multiplicación de dos números flotantes - - -\n");
OTD_3Multi_1 = OTD_3Flo1 * OTD_3Flo2;
Console.WriteLine($"La Multiplicación de {OTD_3Flo1} y {OTD_3Flo2} es: {OTD_3Multi_1}");
Console.WriteLine("*** Haga click a Enter");
Console.ReadKey();

//4 - Divición de dos números enteros
int OTDEnt_4num1 = 10,
    OTDEnt_4num2 = 5,
    OTDEnt_4div1;
Console.WriteLine("\n- - - División de números enteros - - -\n");
OTDEnt_4div1 = OTDEnt_4num1 / OTDEnt_4num2;
Console.WriteLine($"La División de {OTDEnt_4num1} y {OTDEnt_4num2} es: {OTDEnt_4div1}");
Console.WriteLine("*** Haga click a Enter");
Console.ReadKey();

//5 - Módulo de dos números enteros
int OTDEnt_5num1 = 10,
    OTDEnt_5num2 = 5,
    OTDEnt_5mod1;
Console.WriteLine("\n- - - Módulo de dos números enteros - - -\n");
OTDEnt_5mod1 = OTDEnt_5num1 % OTDEnt_5num2;
Console.WriteLine($"El módulo de {OTDEnt_5num1} y {OTDEnt_5num2}  es: {OTDEnt_5mod1}");
Console.WriteLine("*** Haga click a Enter");
Console.ReadKey();

//********** USO DE CHAR Y STRING **********

//1 - Imprimir cadena de texto a Mayúscula
string UCSStr_1num1;
Console.WriteLine("\n- - - Imprimir cadena de texto a Mayúscula - - -\n");
UCSStr_1num1 = "Hoy es un lindo día para aprender";
Console.WriteLine($"Texto en mayúsculas: {UCSStr_1num1.ToUpper()}");
Console.WriteLine("*** Haga click a Enter");
Console.ReadKey();

//2 - Imprimir cadena de texto a minúscula

string UCSStr_2num1;
Console.WriteLine("\n- - - Imprimir cadena de texto a Mayúscula - - -\n");
UCSStr_2num1 = "Hoy es un lindo día para Aprender";
Console.WriteLine($"Texto en minúsculas: {UCSStr_2num1.ToLower()}");
Console.WriteLine("*** Haga click a Enter");
Console.ReadKey();

//3 - Imprimir cadena de texto al revés

string UCSStr_3num1;
Console.WriteLine("\n- - - Imprimir cadena de texto al revés - - -\n");
Console.WriteLine("Escriba una cadena de texto");
UCSStr_3num1 = Console.ReadLine()!;
for (int i = UCSStr_3num1.Length - 1; i >= 0; i--)
{
    Console.Write(UCSStr_3num1[i]);
}
Console.WriteLine("\n*** Haga click a Enter");
Console.ReadKey();

//4 - Leer y Buscar una palabra de cadena de texto
string texto1, buscar;
Console.WriteLine("\n- - - Leer y Buscar una palabra de cadena de texto - - -\n");
Console.WriteLine("Ingrese una cadena de texto: ");
texto1 = Console.ReadLine()!;
Console.WriteLine("Ingrese la palabra a buscar: ");
buscar = Console.ReadLine()!;
if (texto1.Contains(buscar))
{
    Console.WriteLine($"La palabra: {buscar} fue encontrada con ¡exito!");
    Console.WriteLine("\n*** Haga click a Enter");
    Console.ReadKey();
}
else
{
    Console.WriteLine($"La palabra {buscar} no fue entontrada");
    Console.WriteLine("\n*** Haga click a Enter");
    Console.ReadKey();
}

//5 - leer cadena de texto y contar número de vocales
string UCSStr_5num1;
int UCSStr_5vol1s = 0;
Console.WriteLine("\n- - - Leer cadena de texto y contar número de vocales - - -\n");
Console.WriteLine("Ingrese una cadena de texto: ");
UCSStr_5num1 = Console.ReadLine()!;
foreach (char busqueda in UCSStr_5num1)
{
    if ("aeiouAEIOU".Contains(busqueda))
    {
        UCSStr_5vol1s++;
    }
}
Console.WriteLine("El numero de vocales encontradas son: " + UCSStr_5vol1s);
Console.WriteLine("\n*** Haga click a Enter");
Console.ReadKey();

//********** USO DE TIPOS DE DATOS NUMÉRICOS **********

//1 - Calcular área de un triángulo

string UDN_1baseTriangulo, UDN_1alturaTriangulo;
double UDN_1alturaTrianguloNumero, UDN_1areaTriangulo, UDN_1basetrianguloNumero;
Console.WriteLine("\n- - - Calcular área de un triángulo - - -\n");
try
{
    Console.WriteLine("Escriba la base del triangulo");
    UDN_1baseTriangulo = Console.ReadLine()!;

    Console.WriteLine("Escriba la altura del triangulo");
    UDN_1alturaTriangulo = Console.ReadLine()!;

    UDN_1basetrianguloNumero = Convert.ToDouble(UDN_1baseTriangulo);
    UDN_1alturaTrianguloNumero = Convert.ToDouble(UDN_1alturaTriangulo);

    UDN_1areaTriangulo = UDN_1basetrianguloNumero * UDN_1alturaTrianguloNumero / 2;
    Console.WriteLine($"Area de Triangulo es: {UDN_1areaTriangulo}");
    Console.WriteLine("\n*** Haga click a Enter");
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine("¡Error! Algo salio mal" + ex.Message);
    Console.WriteLine("\n*** Haga click a Enter");
    Console.ReadKey();
}

//2 - Calcular volumen de una esfera
double UDN_2radioesfera, UDN_2volumenesfera;
Console.WriteLine("\n- - - Calcular el volumen de una esfera - - -\n");
try
{
    Console.WriteLine("Ingrese el radio de la esfera: ");
    UDN_2radioesfera = Convert.ToDouble(Console.ReadLine());

    UDN_2volumenesfera = (4.0 / 3.0) * Math.PI * Math.Pow(UDN_2radioesfera, 3);

    Console.WriteLine($"El volumen de la esfera es: {UDN_2volumenesfera}");
    Console.WriteLine("\n*** Haga click a Enter");
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine("¡Error! Algo salio mal" + ex.Message);
    Console.WriteLine("\n*** Haga click a Enter");
    Console.ReadKey();
}

//3 - Calcular distancia entre dos puntos
double x1, x2, y1, y2, UDN_3distancia;
Console.WriteLine("\n- - - Calcular distancia entre dos puntos - - -\n");
try
{
    Console.WriteLine("Ingrese la coordenada para x1: ");
    x1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese la coordenada para y1: ");
    y1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingrese la coordenada para x2: ");
    x2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese la coordenada para y2: ");
    y2 = Convert.ToDouble(Console.ReadLine());

    UDN_3distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    Console.WriteLine("La distancia entre los puntos es: " + UDN_3distancia);
    Console.WriteLine("\n*** Haga click a Enter");
    Console.ReadKey();
}
catch (Exception ex)
{

    Console.WriteLine("¡Error! Algo salio mal" + ex.Message);
    Console.WriteLine("\n*** Haga click a Enter");
    Console.ReadKey();

}

//4 - Calcular temperatura en grados Fahrenheit a partir de los grados Celsius


double UDN_4celsius, UDN_4fahrenheit;
Console.WriteLine("\n- - - Calcular temperatura en grados Fahrenheit a partir de los grados Celsius - - -\n");
try
{
    Console.WriteLine("Ingrese la temperatura en grados Celsius:");
    UDN_4celsius = Convert.ToDouble(Console.ReadLine());
    UDN_4fahrenheit = (UDN_4celsius * 9 / 5) + 32;
    Console.WriteLine($"La temperatura en grados Fahrenheit es: {UDN_4fahrenheit}");
    Console.WriteLine("\n*** Haga click a Enter");
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine("¡Error! Algo salio mal" + ex.Message);
    Console.WriteLine("\n*** Haga click a Enter");
    Console.ReadKey();
}

//5 - Calcular temperatura en grados Celsius a partir de la temperatura en grados Fahrenheit

double UDN_5fahrenheit, UDN_5celsius;
try
{
    Console.WriteLine("Ingrese la temperatura en grados Fahrenheit: ");
    UDN_5fahrenheit = Convert.ToDouble(Console.ReadLine());
    UDN_5celsius = (UDN_5fahrenheit - 32) * 5 / 9;
    Console.WriteLine("La temperatura en grados Celsius es:" + UDN_5celsius);
    Console.WriteLine("\n*** Haga click a Enter");
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine("¡Error! Algo salio mal" + ex.Message);
    Console.WriteLine("\n*** Haga click a Enter");
    Console.ReadKey();
}
