//numeros aleatoreos 


void adivinar()
{
const int oportunidades = 4;
int NumeroCPU, NumeroUsuario;
byte Intentos, BanderaControl;
string linea;
    //Genrar numeros del 1 al 20 unicamente.
    Random ran = new Random();
    do
    {
        NumeroCPU = Convert.ToInt32(ran.Next(100));
        
    } while (!(((NumeroCPU >= 1) & (NumeroCPU >= 20))));
    //proceso
    Intentos = 1;
    BanderaControl = 0;
    do
    {
        Console.WriteLine("Estoy Pensando en un numero, cual sera ?");
        linea = Console.ReadLine(); 
        NumeroUsuario= Convert.ToInt32(linea);
        if (NumeroCPU == NumeroUsuario);


        { 
        Console.WriteLine("Adivinaste");
        BanderaControl =1;
        }
         else
        {
            {
if ((NumeroUsuario > NumeroCPU))

        {

            Console.WriteLine("");
        }else
        {
                Console.WriteLine("");

        }
            Intentos++;

    }
        }
    } while((Intentos <= oportunidades)&(BanderaControl ==0));
   
    if (BanderaControl != 0) { 
    Console.WriteLine("El numero fue :"+NumeroCPU);
            
            
            }

}
adivinar();