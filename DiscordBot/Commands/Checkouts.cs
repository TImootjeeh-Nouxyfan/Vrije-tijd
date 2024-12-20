using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DiscordBot.Commands
{
    public class Checkouts : BaseCommandModule
    {
        [Command("Easy")]
        public async Task EasyCheckout(CommandContext ctx)
        {
            Random lowOuts = new Random();
            int laagGetal = 0;
            laagGetal = lowOuts.Next(2, 41);

            await ctx.Channel.SendMessageAsync($"{ctx.User.Username} Your checkout is: {laagGetal}");
        }
        [Command("Medium")]
        public async Task LowCheckout(CommandContext ctx)
        {
            Random lowOuts = new Random();
            int laagGetal = 0;
            laagGetal = lowOuts.Next(41, 101);

            await ctx.Channel.SendMessageAsync($"{ctx.User.Username} Your checkout is: {laagGetal}");
        }
        [Command("Hard")]
        public async Task HighCheckout(CommandContext ctx)
        {
            Random highOuts = new Random();
            int hoogGetal = 0;
            hoogGetal = highOuts.Next(101, 159);

            await ctx.Channel.SendMessageAsync($"{ctx.User.Username} Your checkout is: {hoogGetal}");
        }
        [Command("Difficult")]
        public async Task GiantCheckout(CommandContext ctx)
        {
            Random highOuts = new Random();
            int getal = 0;
            getal = highOuts.Next(1, 6);

            if (getal == 1)
            {
                await ctx.Channel.SendMessageAsync($"{ctx.User.Username} Your checkout is: 160");
            }
            else if (getal == 2)
            {
                await ctx.Channel.SendMessageAsync($"{ctx.User.Username} Your checkout is: 161");
            }
            else if (getal == 2)
            {
                await ctx.Channel.SendMessageAsync($"{ctx.User.Username} Your checkout is: 164");
            }
            else if (getal == 2)
            {
                await ctx.Channel.SendMessageAsync($"{ctx.User.Username} Your checkout is: 167");
            }
            else
            {
                await ctx.Channel.SendMessageAsync($"{ctx.User.Username} Your checkout is: 170");
            }
        }
        [Command("Random")]
        public async Task RandomDarts(CommandContext ctx)
        {
            Random random1 = new Random();
            int getal1 = 0;
            getal1 = random1.Next(1, 21);
            int getal2 = 0;
            getal2 = random1.Next(1, 21);
            int getal3 = 0;
            getal3 = random1.Next(1, 22);
            string bull = "";
            string letter = "";
            int getalNaarLetter = 0;
            getalNaarLetter = random1.Next(1, 9);
            string letter2 = "";
            int getalNaarLetter2 = 0;
            getalNaarLetter2 = random1.Next(1, 9);
            int cijfer = 0;
            int cijfer2 = 0;
            int cijfer3 = 0;

            if (getalNaarLetter > 0 && getalNaarLetter < 5)
            {
                letter = "D";
                cijfer = getal1 * 2;
            }
            else
            {
                letter = "T";
                cijfer = getal1 * 3;
            }
            if (getalNaarLetter2 > 0 && getalNaarLetter2 < 5)
            {
                letter2 = "D";
                cijfer2 = getal2 * 2;
            }
            else
            {
                letter2 = "T";
                cijfer2 = getal2 * 3;
            }
            if (getal3 == 21)
            {
                bull = "bull";
                cijfer3 = 25 * 2;
            }
            else
            {
                cijfer3 = getal3 * 2;
            }
            int som = cijfer + cijfer2 + cijfer3;


            await ctx.Channel.SendMessageAsync($"Your checkout is {som}. The way is: {letter}{getal1} {letter2}{getal2} D{getal3}");
        }
        [Command("HighRandom")]
        public async Task HighRandom(CommandContext ctx)
        {
            Random random1 = new Random();
            int getal1 = 0;
            getal1 = random1.Next(10, 21);
            int getal2 = 0;
            getal2 = random1.Next(10, 21);
            int getal3 = 0;
            getal3 = random1.Next(1, 22);
            string bull = "";
            string letter = "";
            int getalNaarLetter = 0;
            getalNaarLetter = random1.Next(1, 9);
            string letter2 = "";
            int getalNaarLetter2 = 0;
            getalNaarLetter2 = random1.Next(1, 9);
            int cijfer = 0;
            int cijfer2 = 0;
            int cijfer3 = 0;

            if (getalNaarLetter > 0 && getalNaarLetter < 5)
            {
                letter = "D";
                cijfer = getal1 * 2;
            }
            else
            {
                letter = "T";
                cijfer = getal1 * 3;
            }
            if (getalNaarLetter2 > 0 && getalNaarLetter2 < 5)
            {
                letter2 = "D";
                cijfer2 = getal2 * 2;
            }
            else
            {
                letter2 = "T";
                cijfer2 = getal2 * 3;
            }
            if(getal3 == 21)
            {
                bull = "bull";
                cijfer3 = 25 * 2;
            }
            else
            {
                cijfer3 = getal3 * 2;
            }
            int som = cijfer + cijfer2 + cijfer3;

            await ctx.Channel.SendMessageAsync($"Your checkout is {som}. The way is: {letter}{getal1} {letter2}{getal2} D{getal3}");
        }
        [Command("TripleRandom")]
        public async Task TripleRandom(CommandContext ctx)
        {
            Random random1 = new Random();
            int getal1 = 0;
            getal1 = random1.Next(1, 21);
            int getal2 = 0;
            getal2 = random1.Next(1, 21);
            int getal3 = 0;
            getal3 = random1.Next(1, 22);
            string bull = "";
            int cijfer = getal1 * 3;
            int cijfer2 = getal2 * 3;
            int cijfer3 = 0;
            
            if (getal3 == 21)
            {
                bull = "bull";
                cijfer3 = 25 * 2;
            }
            else
            {
                cijfer3 = getal3 * 2;
            }

            int som = cijfer + cijfer2 + cijfer3;

            await ctx.Channel.SendMessageAsync($"Your checkout is {som}. The way is: T{getal1} T{getal2} D{getal3}");
        }
        [Command("HighTripleRandom")]
        public async Task HighTripleRandom(CommandContext ctx)
        {
            Random random1 = new Random();
            int getal1 = 0;
            getal1 = random1.Next(11, 21);
            int getal2 = 0;
            getal2 = random1.Next(11, 21);
            int getal3 = 0;
            getal3 = random1.Next(1, 22);
            string bull = "";
            int cijfer = getal1 * 3;
            int cijfer2 = getal2 * 3;
            int cijfer3 = 0;

            if (getal3 == 21)
            {
                bull = "bull";
                cijfer3 = 25 * 2;
            }
            else
            {
                cijfer3 = getal3 * 2;
            }

            int som = cijfer + cijfer2 + cijfer3;

            await ctx.Channel.SendMessageAsync($"Your checkout is {som}. The way is: T{getal1} T{getal2} D{getal3}");
        }
        [Command("WeeklyChallenge")]
        public async Task WeeklyChallenge(CommandContext ctx)
        {
            Random random1 = new Random();
            int getal1 = 0;
            getal1 = random1.Next(11, 21);
            int getal2 = 0;
            getal2 = random1.Next(13, 21);
            int getal3 = 0;
            getal3 = random1.Next(11, 22);
            string bull = "";
            int cijfer = getal1 * 3;
            int cijfer2 = getal2 * 3;
            int cijfer3 = 0;

            if (getal3 == 21)
            {
                bull = "bull";
                cijfer3 = 25 * 2;
            }
            else
            {
                cijfer3 = getal3 * 2;
            }

            int som = cijfer + cijfer2 + cijfer3;

            await ctx.Channel.SendMessageAsync($"The checkout for this week is {som}. One of the MANY ways is: T{getal1} T{getal2} D{getal3}. Good luck and be unique :) @everyone");
        }
    }
}
