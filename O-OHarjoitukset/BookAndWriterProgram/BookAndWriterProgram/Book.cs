﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookAndWriterProgram
{
    class Kirja
    {
        public string name;
        public string author;
        public string publisher;
        public double price;
        public static string theme;

        public Kirja()
        {
            this.name = "";
            this.author = "";
            this.publisher = "";
            this.price = 0;
        }

        public Kirja(string name, string author, string publisher, double price, string theme)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.price = price;
        }

        public void HaeKirja(string name)
        {
            if (this.name != name)
            {
                Console.WriteLine("Kirjaa ei löytynyt");
                Environment.Exit(1);
            }
        }

        public void VaihdaTeema()
        {
            theme = "Jotain";
            Console.WriteLine($"Kirja: {this.name}\nKirjailija: {this.author}\n" +
                    $"Julkaisija: {this.publisher}\nHinta: {this.price:C}\nTeema: {theme}");
        }

        public double Price
        {
            get{ return price; }

            set{if(price > 30)
                 {
                    Console.WriteLine($"Kirjan uusi hinta on {price * 0.9} €");
                 }     
            }
        }
    }
}
