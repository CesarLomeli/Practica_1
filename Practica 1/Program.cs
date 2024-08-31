using Practica_1;
//Ruta donde se encuentra archivo a leer
string ruta = "C:\\Users\\cesar\\OneDrive\\Documentos\\School\\Seminario de sistemas operativos\\Practica 1\\prueba2.txt";
string rutaSalida = "C:\\Users\\cesar\\OneDrive\\Documentos\\School\\Seminario de sistemas operativos\\Practica 1\\salida.txt";
Archivo file = new Archivo(ruta, rutaSalida);

//Lista para llenar con cada cadena
List<string> cadenas = new List<string>();

//Lista de objetos ya separados por ,
List<Cadenas> objetos = new List<Cadenas>();

//Separamos la cadena y se guarda en la lista por renglon
foreach (string cadena in file.leerArchivo().Split("\n"))
{
    if(cadena != String.Empty)
        cadenas.Add(cadena);
}
//Recorremos la lista con todas las cadenas separadas por renglon
foreach (string cadena in cadenas)
{
    //Separamos cada cadena de la lista por comas
    string[] separador_aux = cadena.Split(",");
    //Llenamos objeto cadenas
    Cadenas aux = new Cadenas();
    aux.ip6 = separador_aux[0];
    aux.cadena1 = separador_aux[1];
    aux.cadena2 = separador_aux[2];
    aux.cadena3 = separador_aux[3];
    aux.cadena4 = separador_aux[4];
    aux.ip4 = separador_aux[5];
    //Agregamos a lista de objetos
    objetos.Add(aux);
}

//Recorremos la lista de objetos para procesarlos y escribir nuevo archivo
foreach (Cadenas cadena in objetos)
{
    TratamientoCadenas tc = new TratamientoCadenas();
    cadena.ip6 = tc.getIpv6(cadena.ip6);//Regresa numeros decimales
    cadena.ip4 = tc.getIpv4(cadena.ip4);//Regresa hexadecimales
    file.escribirArchivo(cadena.cadena2 + " : " + cadena.ip6 + " : " + cadena.ip4);   
}
