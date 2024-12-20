using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Threading.Tasks;

namespace DiscordBot.Commands
{
    public class Help : BaseCommandModule
    {
        [Command("Help")]
        public async Task About(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync($"Put here the commands that you wanna use. At this point I have\n" +
                $"/add: put the numbers together that count each dart for example /add 60 57 54 (DONT USE THE + SIGN)\n\n" +
                $"Checkouts:\n" +
                $"/Easy: Gives you a random checkout from 2-40\n" +
                $"/Medium: Gives you a random checkout from 41-100\n" +
                $"/Hard: Gives a checkout from 101-158\n" +
                $"/Difficult: Gives the hardest checkouts 160, 161, 164, 167, and 170\n" +
                $"/random gives you random number in a very weird way to checkout. Try it and give this checkout a shot\n");
            await ctx.Channel.SendMessageAsync($"/Highrandom is the same as /random but gives you only random numbers above 10 instead also 1 through 10\n" +
                $"/TripleRandom is the same as /random but only with triples\n" +
                $"/HighTripleRandom is also the same as /highRandom but only with Triples\n");
            await ctx.Channel.SendMessageAsync($"/WeeklyChallenge is the checkout challenge i give you it give you guys a checkout with one of the many ways it can be checked\n\n" +
                $"Play against each other\n"+
                $"/player1 and /player2: want to play against each other? You can user those. To add your score put your score in like this /player(1 or 2 which ever you are) 60 60 60" +
                $" After you put your score in it says what you have remaining or what you require. To put your checkout just put 0 0 40 to let the bot know you checked it out\n");
        }
    }
}
