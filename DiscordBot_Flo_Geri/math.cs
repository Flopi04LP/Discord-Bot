// --------------------------------------------
// Datei:			Discord Bot
// Datum:			18.02.2020 
// Ersteller:		Florian Büchi, Gergö Szijarto
// Version:		    1.0
// Änderungen:		
// 					
// Beschreibung:
// Hier sind die Mathematik Commands

// --------------------------------------------

using Discord.Commands;
using System;
using System.Threading.Tasks;

namespace Bot.Modules

{
    public class minus : ModuleBase
    {
        [Command("subtract")]
        public async Task Minus(double zahl1, double zahl2)
        {

            double antw = zahl1 - zahl2;

            string antwort = Convert.ToString(antw);

            await ReplyAsync(antwort);

            if (antw == 69)
            {
                await ReplyAsync("nice");
            }
        }
    }
    public class plus : ModuleBase
    {
        [Command("add")]
        public async Task pluuus(double zahl1, double zahl2)
        {

            double antw = zahl1 + zahl2;

            string antwort = Convert.ToString(antw);

            await ReplyAsync(antwort);

            if (antw == 69)
            {
                await ReplyAsync("nice");
            }
        }
    }
    public class multi : ModuleBase
    {
        [Command("multiply")]
        public async Task Mulstiii(double zahl1, double zahl2)
        {

            double antw = zahl1 * zahl2;

            string antwort = Convert.ToString(antw);

            await ReplyAsync(antwort);

            if (antw == 69)
            {
                await ReplyAsync("nice");
            }
        }
    }

    public class divide : ModuleBase
    {
        [Command("divide")]
        public async Task diviii(double zahl1, double zahl2)
        {

            double antw = zahl1 / zahl2;

            string antwort = Convert.ToString(antw);

            await ReplyAsync(antwort);

            if (antw == 69)
            {
                await ReplyAsync("nice");
            }
        }
    }
    public class zählen : ModuleBase
    {
        [Command("count")]
        public async Task counter(string uwu)
        {

            int length = uwu.Length;

            string antwort = Convert.ToString(length);

            await ReplyAsync(antwort);


        }
    }
}