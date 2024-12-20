using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System;
using System.Threading.Tasks;

namespace DiscordBot.Commands
{
    public class Test : BaseCommandModule
    {
        
        [Command("add")]
        public async Task Add(CommandContext ctx, int dart, int dart2, int dart3)
        {
            int result = dart + dart2 + dart3;

            if(dart == 23 || dart == 29 || dart == 31 || dart == 35 || dart == 37 || dart == 41 || dart == 43 || dart == 44 || dart == 46 || dart == 47 || dart == 49 || dart == 52
                || dart == 53 || dart == 55 || dart == 56 || dart == 58 || dart == 59 || dart > 60)
            {
                await ctx.Channel.SendMessageAsync($"Your 1st dart scored {dart} that is impossible");
            }
            else if (dart2 == 23 || dart2 == 29 || dart2 == 31 || dart2 == 35 || dart2 == 37 || dart2 == 41 || dart2 == 43 || dart2 == 44 || dart2 == 46 || dart2 == 47 || dart2 == 49 || dart2 == 52
                || dart2 == 53 || dart2 == 55 || dart2 == 56 || dart2 == 58 || dart2 == 59 || dart2 >  60)
            {
                await ctx.Channel.SendMessageAsync($"Your 2nd dart scored {dart2} that is impossible");
            }
            else if (dart3 == 23 || dart3 == 29 || dart3 == 31 || dart3 == 35 || dart3 == 37 || dart3 == 41 || dart3 == 43 || dart3 == 44 || dart3 == 46 || dart3 == 47 || dart3 == 49 || dart3 == 52
                || dart3 == 53 || dart3 == 55 || dart3 == 56 || dart3 == 58 || dart3 == 59 || dart3 > 60)
            {
                await ctx.Channel.SendMessageAsync($"Your 3rd dart scored {dart3} that is impossible");
            }
            else
            {
                if (result == 163 || result == 166 || result == 169 || result == 172
                || result == 173 || result == 175 || result == 176 || result == 178 || result == 179 || result > 180)
                {
                    await ctx.Channel.SendMessageAsync($"You cannot throw {result.ToString()}");
                }
                else if (result == 180)
                {
                    await ctx.Channel.SendMessageAsync($"You threw: ONEHUNDREDANDEIGHTYYYYYYYYYYYYYY");
                }
                else
                {
                    await ctx.Channel.SendMessageAsync($"You threw: {result.ToString()}");
                }
            }
        }
    }
}
