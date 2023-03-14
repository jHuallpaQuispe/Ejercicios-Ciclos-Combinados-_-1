using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una compañía de electricidad necesita calcular anualmente el consumo que ha
            // registrado cada uno de sus usuarios y el monto pagado por cada uno de ellos.
            // Para ello tiene un lote de registros por cada uno de los usuarios con los
            // siguientes datos:
            // • Zona (numérico entero).
            // • Número de cliente (número de cuatro dígitos no correlativos).
            // • Cantidad de kilovatios consumidos en el periodo.
            // El lote se encuentra agrupado (no ordenado) por zona y finaliza con un registro
            // con zona igual a cero.
            // Se pide generar un listado con el siguiente formato:
            // Zona: XX
            // Cantidad de usuarios de la zona: XX
            // Total facturado en la zona: XX
            // Zona: XX
            // Cantidad de usuarios de la zona: XX
            // Total facturado en la zona: XX
            // El precio es escalonado según la siguiente escala:
            // • $ 0.10 por kv por los primeros 100 kv de consumo.
            // • $ 0.12 por kv por el consumo de 101 a 200 kvs.
            // • $ 0.15 por kv por el consumo de 201 kvs en adelante.

            int zona, numCliente, zonaActual,contador;
            float Kilovatios, precio, precioFinal = 0;

            Console.WriteLine("INGRESE LA ZONA(NÚMERO ENTERO):");
            zona = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE EL NUMERO DE CLIENTE(4 DIGITOS): ");
            numCliente = int.Parse(Console.ReadLine());

            Console.WriteLine("INGRESE LA CANTIDAD DE KILOVATIOS CONSUMIDOS: ");
            Kilovatios= float.Parse(Console.ReadLine());

            while (zona != 0) {
                
                contador = 0; // para el numero de personas


                zonaActual = zona;

                while(zona == zonaActual){
                    contador++;

                    precioFinal = 0;

                    if(Kilovatios > 200)
                        precio = Kilovatios * 0.15f;
                    else if(Kilovatios> 100)
                        precio = Kilovatios * 0.12f;
                    else
                        precio = Kilovatios * 0.10f;

                    precioFinal += precio;

                    Console.WriteLine("INGRESE LA ZONA");
                    zona = int.Parse(Console.ReadLine());

                    Console.WriteLine("INGRESE EL NUMERO DE CLIENTE(4 DIGITOS)): ");
                    numCliente = int.Parse(Console.ReadLine());

                    Console.WriteLine("INGRESE LA CANTIDAD DE KILOVATIOS CONSUMIDOS: ");
                    Kilovatios= float.Parse(Console.ReadLine());
                }

                Console.WriteLine("ZONA: "+ zonaActual);
                Console.WriteLine("CANTIDAD DE USUARIOS DE LA ZONA: "+ contador);
                Console.WriteLine("TOTAL FACTURADO EN LA ZONA: "+ precioFinal);
                
            }
        }

    }
}
