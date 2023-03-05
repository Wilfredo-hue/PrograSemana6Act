using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadSemana6
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.menu();

        }
    }
}
public abstract class Catalogo
{
    public abstract void Catalog1();
    public abstract void Catalog2();

}

public class Shein : Catalogo
{
    public override void Catalog1()
    {
        Console.WriteLine("Marca                Color               Diseño              Precio\n");
        Console.WriteLine("1- Shein Dress        Gray               Gala                 $75.00\n");
        Console.WriteLine("2- Shein T-shirt       Red                Formal              $125.00\n");
    }

    public override void Catalog2()
    {
        Console.WriteLine("Marca                Color               Diseño              Precio\n");
        Console.WriteLine("1- Glotes            Yellow               Playero                 $75.00\n");
        Console.WriteLine("2- Shoes              White                Tacon              $125.00\n");
    }
}

public class Zara : Catalogo
{
    public override void Catalog1()
    {
        Console.WriteLine("Marca                Color               Diseño              Precio\n");
        Console.WriteLine("1- Zara Shoes       Black               Schoolstreet                 $80.00\n");
        Console.WriteLine("2- Zara shoes       Gold                Formal              $200.00\n");
    }

    public override void Catalog2()
    {
        Console.WriteLine("Marca                Color               Diseño              Precio\n");
        Console.WriteLine("1- Zara Dress        Gray               Gala                 $75.00\n");
        Console.WriteLine("2- Zara T-shirt       Red                Formal              $125.00\n");
    }
}

public class Menu
{
    public string Men1;
    public string Cat, Ped;


    public void menu()
    {
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-------------------- Menu --------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Escoja el numero que corresponda a una marca.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1- Shein ");
            Console.WriteLine("2- Zara ");
            Men1 = Console.ReadLine();
            Console.Clear();
            if (Men1 == "1")
            {
                Shein nk = new Shein();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------------------ Menu ------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Escriba el numero correspondiente a la categoria que desee. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1- Ropa Casual ");
                Console.WriteLine("2- Ropa Ocaciones Especiales");
                Cat = Console.ReadLine();
                Console.Clear();
                if (Cat == "1")
                {
                    Console.WriteLine("Escoja un producto a continuación.\n");
                    nk.Catalog1();
                    Ped = Console.ReadLine();
                    Console.Clear();
                    if (Ped == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Shein Dress        Gray               Gala                 $75.00");
                        Console.WriteLine("Total a pagar                        $75.00   -");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");
                    }
                    if (Ped == "2")
                    {

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Shein T-shirt       Red                Formal              $125.00");
                        Console.WriteLine("Total a pagar                        $125.00   -");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.ForegroundColor = ConsoleColor.White;

                    }

                }
                if (Cat == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Escoja un producto a continuación.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    nk.Catalog2();
                    Ped = Console.ReadLine();
                    Console.Clear();
                    if (Ped == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Glotes            Yellow               Playero                 $75.00-");
                        Console.WriteLine("Total a pagar                        $75.00   -");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                    if (Ped == "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Shoes              White                Tacon              $125.00-");
                        Console.WriteLine("Total a pagar                        $125.00   -");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }
            }
            if (Men1 == "2")
            {
                Zara ad = new Zara();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------------------ Menu ------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Escriba el numero correspondiente a la categoria que desee. ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1- Ropa Casual ");
                Console.WriteLine("2- Ocaciones Especiales ");
                Cat = Console.ReadLine();
                Console.Clear();
                if (Cat == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Escoja un producto a continuación.");
                    Console.ForegroundColor = ConsoleColor.White;
                    ad.Catalog2();
                    Ped = Console.ReadLine();
                    Console.Clear();
                    if (Ped == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Zara Shoes       Black               Schoolstreet                 $80.00-");
                        Console.WriteLine("Total a pagar                        $80.00   -");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (Ped == "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Zara shoes       Gold                Formal              $200.00-");
                        Console.WriteLine("Total a pagar                                   $200.00  -");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }
                if (Cat == "2")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Escoja un producto a continuación.");
                    Console.ForegroundColor = ConsoleColor.White;
                    ad.Catalog2();
                    Ped = Console.ReadLine();
                    Console.Clear();
                    if (Ped == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Zara Dress        Gray               Gala                 $75.00-");
                        Console.WriteLine("Total a pagar                             $75.00   -");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    if (Ped == "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Zara T-shirt       Red                Formal              $125.00-");
                        Console.WriteLine("Total a pagar                             $125.00  -");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

            }
        }
    }
}

