// --------------------------------------------
// Datei:			Discord Bot
// Datum:			18.02.2020 
// Ersteller:		Florian Büchi, Gergö Szijarto
// Version:		    1.0
// Änderungen:		
// 					
// Beschreibung:
// Dieses Programm soll, wenn man auf Discord einen Command eingibt auf den jeweiligen Command reagieren.

// --------------------------------------------


using Discord.Commands;
using System;
using System.Threading.Tasks;

namespace Bot.Modules
{
    public class ping : ModuleBase
    {
        [Command("bot")]
        public async Task PingAsync()
        {
            await ReplyAsync("Hey, it's me, the Chimp-Bot! I was made by Flo. (⁎❛ᴗ❛⁎)" + Environment.NewLine + "I can do many things, like show you some memes or play rock paper scissors.");
        }

    }
    public class hi : ModuleBase
    {
        [Command("buy")]
        public async Task PingAsync()
        {
            await ReplyAsync("https://cdn.discordapp.com/attachments/804493212747038741/804544853341372426/BUY_CHIMP.png");

            await ReplyAsync("====================================" + Environment.NewLine + "Price of Chimp" + Environment.NewLine + "PayPal: €14($17)" + Environment.NewLine + "Cryptocurrency: $15" + Environment.NewLine + "Must convert to Euros" + Environment.NewLine + "=================" +
            Environment.NewLine + "Do not open the ticket unless you're going to buy. (This will result in a warning, doing it multiple times will result into a permanent ban)" + Environment.NewLine + "=================================================================================================" + Environment.NewLine + "Read #chimp before opening a ticket.");

        }

    }

    public class Status : ModuleBase<SocketCommandContext>
    {
        [Command("status")]
        public async Task TestAsync()
        {
            await Context.Client.SetGameAsync("Fortnite with Simon");

            await Task.CompletedTask;
        }
    }

    public class uwwwwwu : ModuleBase<SocketCommandContext>
    {
        [Command("ownstatus")]
        public async Task TestAsync(string status)
        {
            await Context.Client.SetGameAsync(status);

            await Task.CompletedTask;
        }
    }




    public class kiss : ModuleBase
    {
        [Command("kiss")]
        public async Task PingAsync()
        {
            await ReplyAsync("（*＾3＾）/～♡");
        }

    }

    public class sad : ModuleBase
    {
        [Command("sad")]
        public async Task PingAsync()
        {
            await ReplyAsync("ಥ╭╮ಥ");
        }

    }

    public class happy : ModuleBase
    {
        [Command("happy")]
        public async Task PingAsync()
        {
            await ReplyAsync("{´◕ ◡ ◕｀}");
        }

    }

    public class help : ModuleBase
    {
        [Command("help")]
        public async Task PingAsync()
        {
            await ReplyAsync("These are all the commands I can handle at the moment:"
                + Environment.NewLine + "$bot = tells you some details about this bot."
                + Environment.NewLine + "$hi = infos about bot"
                + Environment.NewLine + "$meme = shows a randmom meme from my meme database!"
                + Environment.NewLine + "$shibe = cute image of shiba inus"
                + Environment.NewLine + "$sad, $happy, $kiss = shows ascii emojis"
                + Environment.NewLine + "$dab = sends a dab gif"
                + Environment.NewLine + "$owo = OwO"
                + Environment.NewLine + "$rpsgame = rules + rock paper scissors game :)"
                + Environment.NewLine + "$watch + streamer = sends the twitch channel link to the streamer"
                + Environment.NewLine + "$searchtwitch + term = searches on twitch for the entered term"
                + Environment.NewLine + "$owstats + pc/console + username + battletag (pc user 2341)= shows your overwatch stats (only if your profile is public) "
                + Environment.NewLine + "$add, $subtract, $multiply, $divide = enter 2 numbers behind the operations and you'll get the answer (+ easter egg :p)"
                + Environment.NewLine + "$count = counts all characters which are typed in after the commmand"
                + Environment.NewLine + "$status = displays a defined status for the bot, can be changed in the code"
                + Environment.NewLine + "$ownstatus + string = sets 1 (1) string as the current playing status");

        }


    }


    public class rpsgame : ModuleBase
    {
        [Command("rpsgame")]
        public async Task rockpaperscissors()
        {
            await ReplyAsync($"This is how you can play rock paper scissors against me:" + Environment.NewLine + $"Type $rps + 'rock', 'paper' or 'scissors' to make your choice and start the game. q(≧▽≦q)" + Environment.NewLine + $"example: $rps paper");

        }
    }

    public class owo : ModuleBase
    {
        [Command("owo")]
        public async Task owowo()
        {
            await ReplyAsync($"**OwO**");

        }
    }

    public class meme : ModuleBase
    {
        [Command("meme")]
        public async Task MemeAnimeAsync()
        {
            string user = " Here! Have one of the freshest memes! ";

            int part1 = new Random().Next(0, 9);

            switch (part1)
            {
                case 0:
                    user += " https://i.redd.it/ix4p3x722ls21.png ";
                    break;
                case 1:
                    user += " https://preview.redd.it/d4suwlts1y221.png?width=640&crop=smart&auto=webp&s=989c68f2e5ca7c5b527da30fb17f9716bd40e600 ";
                    break;
                case 2:
                    user += " https://preview.redd.it/oze99o5m7c631.jpg?width=640&crop=smart&auto=webp&s=ab7e68f401d41e4e46a4183f59c8efc81127c07c ";
                    break;
                case 3:
                    user += " https://preview.redd.it/f2l3r8blvo331.jpg?width=640&crop=smart&auto=webp&s=0c2158f03f8426a8bd503d82ded66875e5765c3a ";
                    break;
                case 4:
                    user += " https://preview.redd.it/q9o1awxiae031.jpg?width=640&crop=smart&auto=webp&s=1440586fe50027500f7a1860470b5efe14e11253 ";
                    break;
                case 5:
                    user += " https://preview.redd.it/aqpcj84wsbe21.png?width=640&crop=smart&auto=webp&s=d0a133153e9f1bd2ee7e562550307dd7c0836f57 ";
                    break;
                case 6:
                    user += " https://preview.redd.it/o2j2g8fpixj21.jpg?width=640&crop=smart&auto=webp&s=7dc4dee69df5e5991b4d6ed6d7582f314682606b ";
                    break;
                case 7:
                    user += " https://preview.redd.it/kntra7bvg1a21.png?width=640&crop=smart&auto=webp&s=626b693d3cfbd038841259af9bfe8579438c0341 ";
                    break;
                case 8:
                    user += " https://external-preview.redd.it/mDuWePyqkleZA0x2LIxzhkZy_VvTfLR4rsyExK2TiAo.png?width=640&crop=smart&auto=webp&s=efd892572968705570fa137c612f53877e08d2b7 ";
                    break;
                case 9:
                    user += " https://i.ytimg.com/vi/hNfA7bAPZxA/maxresdefault.jpg ";
                    break;
            }
            await ReplyAsync(user + "");
        }
    }
    public class Dab : ModuleBase
    {
        [Command("dab")]
        public async Task DabAsync()
        {
            string user = "You do a *dab*!\n";

            int part1 = new Random().Next(0, 7);

            switch (part1)
            {
                case 0:
                    user += "https://media.giphy.com/media/A4R8sdUG7G9TG/giphy.gif"; ;
                    break;
                case 1:
                    user += "https://media1.tenor.com/images/d81af8d4f0a919c7b40e050de47e6eaf/tenor.gif";
                    break;
                case 2:
                    user += "https://media1.tenor.com/images/9b2147e6ad5a8c7f0ae0f39d37230a56/tenor.gif";
                    break;
                case 3:
                    user += "https://static.wixstatic.com/media/391e8b_2048ba790e294870b96bcbee5c846910~mv2.gif";
                    break;
                case 4:
                    user += "https://66.media.tumblr.com/85d88d04cdb4a46f6bfbdce34e80e357/tumblr_pjvtxi09Ik1w0433po1_400.gif";
                    break;
                case 5:
                    user += "https://media1.tenor.com/images/d13c16a8853e3b309db0ec7e573c4c94/tenor.gif";
                    break;
                case 6:
                    user += "http://pa1.narvii.com/6292/502cb42cc86c3dfe7502149466d2978859e3b6ca_00.gif";
                    break;
                case 7:
                    user += "https://media.tenor.com/images/d68b5deb35e8c7ffad2efd182e0d4122/tenor.gif";
                    break;
            }
            await ReplyAsync(user + "");

        }

    }
    public class RPS : ModuleBase
    {


        [Command("RPS")]
        public async Task RockRPS(string choice)
        {
            if (choice.Contains("paper") || choice.Contains("scissors") || choice.Contains("rock"))
            {
                int winner = new Random().Next(1, 4);
                if (winner == 1)
                {
                    await ReplyAsync($"You win! ヽ(✿ﾟ▽ﾟ)");

                }
                else
                {
                    await ReplyAsync($"You lost （；´д｀）ゞ");
                }
            }
            else if (choice.Contains("stone"))
            {
                await ReplyAsync("*Cheat Mode activated*");

            }
            else
            {
                await ReplyAsync("Please select 'rock', 'paper' or 'scissors'. （︶^︶）");
            }
        }


    }





    public class shibe : ModuleBase
    {
        [Command("shibe")]
        public async Task ShibeAsync()
        {
            string user = "Here, take a shibe! \n";

            int part2 = new Random().Next(0, 15);

            switch (part2)
            {
                case 0:
                    user += "https://i.pinimg.com/originals/7a/32/e9/7a32e9d943bbd2466c4c4ec0f791147e.jpg"; ;
                    break;
                case 1:
                    user += "https://i.pinimg.com/564x/22/3d/7c/223d7c2ae077490392c2afa6fa74d66b.jpg";
                    break;
                case 2:
                    user += "https://i.pinimg.com/564x/7a/6a/61/7a6a61e86a6a69db68b207a244a21932.jpg";
                    break;
                case 3:
                    user += "https://i.pinimg.com/564x/9b/e1/91/9be19136f25d1cd650952da6c6acc669.jpg";
                    break;
                case 4:
                    user += "https://i.pinimg.com/564x/fd/fa/13/fdfa1350f31cd4a07fdf64fb7028f620.jpg";
                    break;
                case 5:
                    user += "https://i.pinimg.com/564x/c0/ee/06/c0ee06323c6b8260a0ac597f9feb7ead.jpg";
                    break;
                case 6:
                    user += "https://i.pinimg.com/564x/2b/8d/29/2b8d29c19ca209b35b14e91ef60e9100.jpg";
                    break;
                case 7:
                    user += "https://i.pinimg.com/564x/83/9b/e7/839be7137187cdaccc66d6b393ab74cf.jpg";
                    break;
                case 8:
                    user += "https://i.pinimg.com/564x/53/ce/8d/53ce8dd9c97cfd2e3d56e9c998a37f64.jpg";
                    break;
                case 9:
                    user += "https://i.pinimg.com/564x/39/26/a9/3926a9b5e4021c1aaae9456f7e35f65e.jpg";
                    break;
                case 10:
                    user += "https://i.pinimg.com/564x/51/9f/50/519f50912129de745c2229e43f82ca85.jpg";
                    break;
                case 11:
                    user += "https://i.pinimg.com/564x/7c/68/14/7c681455ad5117a796e36f60812385d7.jpg";
                    break;
                case 12:
                    user += "https://i.pinimg.com/564x/b1/71/36/b171364006e07f52f3fa37a400d5a3e4.jpg";
                    break;
                case 13:
                    user += "https://i.pinimg.com/564x/28/8e/e0/288ee026f8140db4cf70e27c953fadf8.jpg";
                    break;
                case 14:
                    user += "https://i.pinimg.com/564x/10/5f/db/105fdb83dd25d8ebcfb7b3719ca4e1a8.jpg";
                    break;
            }
            await ReplyAsync(user + "");

        }

    }

    public class Lara : ModuleBase
    {
        [Command("Lara")]
        public async Task PingAsync()
        {
            await ReplyAsync("I love you Gergö <3");
            await ReplyAsync("https://media.giphy.com/media/26BRv0ThflsHCqDrG/giphy.gif");
        }

    }





}










