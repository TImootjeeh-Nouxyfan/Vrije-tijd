using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Threading.Tasks;

namespace DiscordBot.Commands
{
    public class Game : BaseCommandModule
    {
        [Command("Player1")]

        public async Task Player1(CommandContext ctx, int dart, int dart2, int dart3)
        {
            int thrown = dart + dart2 + dart3;
            bool hasReachedZero = false;

            if (dart == 23 || dart == 29 || dart == 31 || dart == 35 || dart == 37 || dart == 41 || dart == 43 || dart == 44 || dart == 46 || dart == 47 || dart == 49 || dart == 52
                || dart == 53 || dart == 55 || dart == 56 || dart == 58 || dart == 59 || dart > 60)
            {
                await ctx.Channel.SendMessageAsync($"Your 1st dart scored {dart} that is impossible");
            }
            else if (dart2 == 23 || dart2 == 29 || dart2 == 31 || dart2 == 35 || dart2 == 37 || dart2 == 41 || dart2 == 43 || dart2 == 44 || dart2 == 46 || dart2 == 47 || dart2 == 49 || dart2 == 52
                || dart2 == 53 || dart2 == 55 || dart2 == 56 || dart2 == 58 || dart2 == 59 || dart2 > 60)
            {
                await ctx.Channel.SendMessageAsync($"Your 2nd dart scored {dart2} that is impossible");
            }
            else if (dart3 == 23 || dart3 == 29 || dart3 == 31 || dart3 == 35 || dart3 == 37 || dart3 == 41 || dart3 == 43 || dart3 == 44 || dart3 == 46 || dart3 == 47 || dart3 == 49 || dart3 == 52
                || dart3 == 53 || dart3 == 55 || dart3 == 56 || dart3 == 58 || dart3 == 59 || dart3 > 60)
            {
                await ctx.Channel.SendMessageAsync($"Your 3rd dart scored {dart3} that is impossible");
            }
            else if (thrown == 163 || thrown == 166 || thrown == 169 || thrown == 172
                || thrown == 173 || thrown == 175 || thrown == 176 || thrown == 178 || thrown == 179 || thrown > 180)
            {
                await ctx.Channel.SendMessageAsync($"You cannot throw {thrown.ToString()}");
            }
            else
            {
                if ((Program.dartsScore - thrown) < 0 || (Program.dartsScore - thrown) == 1)
                {
                    await ctx.Channel.SendMessageAsync($"You have busted your score. You have {Program.dartsScore} remaining");
                    Program.visits++;
                }
                else
                {
                    Program.dartsScore -= thrown;
                    if(Program.dartsScore < 159 || Program.dartsScore == 160 || Program.dartsScore == 161 || Program.dartsScore == 164 || Program.dartsScore == 167 || Program.dartsScore == 170)
                    {
                        await ctx.Channel.SendMessageAsync($"{ctx.User.Username} You require {Program.dartsScore}");
                        Program.visits++;

                        if (Program.dartsScore == 0)
                        {
                            hasReachedZero = true;
                            await ctx.Channel.SendMessageAsync($"Game Shot and the match for {ctx.User.Username} in {Program.visits * 3} darts");
                            await ctx.Channel.SendMessageAsync($"Your average was {501 / Program.visits}");
                            Program.dartsScore = 501;
                            Program.visits = 0;
                        }
                    }
                    else
                    {
                        await ctx.Channel.SendMessageAsync($"{ctx.User.Username} you have {Program.dartsScore} remaining");
                        Program.visits++;
                    }
                }
            }
        }
        [Command("Player2")]

        public async Task Player2(CommandContext ctx, int dart, int dart2, int dart3)
        {
            int thrown2 = dart + dart2 + dart3;
            bool hasReachedZero2 = false;

            if (dart == 23 || dart == 29 || dart == 31 || dart == 35 || dart == 37 || dart == 41 || dart == 43 || dart == 44 || dart == 46 || dart == 47 || dart == 49 || dart == 52
                || dart == 53 || dart == 55 || dart == 56 || dart == 58 || dart == 59 || dart > 60)
            {
                await ctx.Channel.SendMessageAsync($"Your 1st dart scored {dart} that is impossible");
            }
            else if (dart2 == 23 || dart2 == 29 || dart2 == 31 || dart2 == 35 || dart2 == 37 || dart2 == 41 || dart2 == 43 || dart2 == 44 || dart2 == 46 || dart2 == 47 || dart2 == 49 || dart2 == 52
                || dart2 == 53 || dart2 == 55 || dart2 == 56 || dart2 == 58 || dart2 == 59 || dart2 > 60)
            {
                await ctx.Channel.SendMessageAsync($"Your 2nd dart scored {dart2} that is impossible");
            }
            else if (dart3 == 23 || dart3 == 29 || dart3 == 31 || dart3 == 35 || dart3 == 37 || dart3 == 41 || dart3 == 43 || dart3 == 44 || dart3 == 46 || dart3 == 47 || dart3 == 49 || dart3 == 52
                || dart3 == 53 || dart3 == 55 || dart3 == 56 || dart3 == 58 || dart3 == 59 || dart3 > 60)
            {
                await ctx.Channel.SendMessageAsync($"Your 3rd dart scored {dart3} that is impossible");
            }
            else if (thrown2 == 163 || thrown2 == 166 || thrown2 == 169 || thrown2 == 172
                || thrown2 == 173 || thrown2 == 175 || thrown2 == 176 || thrown2 == 178 || thrown2 == 179 || thrown2 > 180)
            {
                await ctx.Channel.SendMessageAsync($"You cannot throw {thrown2.ToString()}");
            }
            else
            {
                Program.dartsScore2 -= thrown2;
                if (Program.dartsScore2 < 159 || Program.dartsScore2 == 160 || Program.dartsScore2 == 161 || Program.dartsScore2 == 164 || Program.dartsScore2 == 167 || Program.dartsScore2 == 170)
                {
                    await ctx.Channel.SendMessageAsync($"{ctx.User.Username} You require {Program.dartsScore2}");
                    Program.visits2++;
                    if (Program.dartsScore2 == 0)
                    {
                        hasReachedZero2 = true;
                        await ctx.Channel.SendMessageAsync($"Game Shot and the match for {ctx.User.Username} in {Program.visits2 * 3} darts");
                        await ctx.Channel.SendMessageAsync($"Your average was {501 / Program.visits2}");
                        Program.dartsScore2 = 501;
                        Program.visits2 = 0;
                    }
                }
                else
                {
                    await ctx.Channel.SendMessageAsync($"{ctx.User.Username} you have {Program.dartsScore2} remaining");
                    Program.visits2++;
                }
            }
        }
    }
}
