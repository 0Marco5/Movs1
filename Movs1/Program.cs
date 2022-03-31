using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

using Newtonsoft.Json;

namespace the_Cryptocurrencies_bot_Movs
{
    public class API
    {
        static async Task Main(string[] args)
        {
            Mensaje m = new Mensaje();
            await m.Check1INCHAsync();
            await m.CheckAAVEAsync();
            await m.CheckAKROAsync();
            await m.CheckANTAsync();
            await m.CheckADAAsync();
            await m.CheckALGOAsync();
            await m.CheckAPI3Async();
            await m.CheckATOMAsync();
            await m.CheckAXSAsync();
            await m.CheckBCHAsync();
            await m.CheckBLOKAsync();
            await m.CheckBNBAsync();
            await m.CheckBOAAsync();
            await m.CheckBTTAsync();
        }
    }
}