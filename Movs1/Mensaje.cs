using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Extensions.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

public class Mensaje
{
    public async Task Check1INCHAsync()
    {
        ConeccionAPI1INCH CRYPTO = new ConeccionAPI1INCH();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckAAVEAsync()
    {
        ConeccionAPIAAVE CRYPTO = new ConeccionAPIAAVE();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckADAAsync()
    {
        ConeccionAPIADA CRYPTO = new ConeccionAPIADA();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckAKROAsync()
    {
        ConeccionAPIAKRO CRYPTO = new ConeccionAPIAKRO();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckALGOAsync()
    {
        ConeccionAPIALGO CRYPTO = new ConeccionAPIALGO();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckANTAsync()
    {
        ConeccionAPIANT CRYPTO = new ConeccionAPIANT();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckAPI3Async()
    {
        ConeccionAPIAPI3 CRYPTO = new ConeccionAPIAPI3();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckATOMAsync()
    {
        ConeccionAPIATOM CRYPTO = new ConeccionAPIATOM();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckAXSAsync()
    {
        ConeccionAPIAXS CRYPTO = new ConeccionAPIAXS();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckBCHAsync()
    {
        ConeccionAPIBCH CRYPTO = new ConeccionAPIBCH();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckBLOKAsync()
    {
        ConeccionAPIBLOK CRYPTO = new ConeccionAPIBLOK();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckBNBAsync()
    {
        ConeccionAPIBNB CRYPTO = new ConeccionAPIBNB();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckBOAAsync()
    {
        ConeccionAPIBOA CRYPTO = new ConeccionAPIBOA();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task CheckBTTAsync()
    {
        ConeccionAPIBTT CRYPTO = new ConeccionAPIBTT();
        var chatId = "@CryptosWorldTrading";
        decimal A = decimal.Parse(await CRYPTO.ChangeRate());

        if (A >= 10 && A < 20)
        {
            await SendMessage10PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -10 && A > -20)
        {
            await SendMessage10NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 20 && A < 30)
        {
            await SendMessage20PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -20 && A > -30)
        {
            await SendMessage20NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A >= 30)
        {
            await SendMessage30PAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }

        else if (A <= -30)
        {
            await SendMessage30NAsync(chatId, await CRYPTO.Symbol(),
            await CRYPTO.Price(), await CRYPTO.ChangeRate(),
            await CRYPTO.Low(), await CRYPTO.High());
        }
    }

    public async Task SendMessage10PAsync(string chatID, string Sysmbol,
        string Price, string ChangeRate, string Low, string High)
    {
        var botClient = new TelegramBotClient("5138490742:AAFK7ZVo8CDaggoCYWc716c1llfqnJCx0zk");
        Message message = await botClient.SendTextMessageAsync(
            chatId: chatID,
            text:
            $"Buen movimiento 🙂\n" +
            "\n" +
            $"👉 {Sysmbol} ha subido {ChangeRate}%" +
            " en las ultimas 24h\n" +
            "\n" +
            $"Teniendo un Low 📉 de {Low} y un High 📈 de {High}" +
            "\n"+
            "\n"+
            $"✍️ Precio actual: {Price}");
    }

    public async Task SendMessage10NAsync(string chatID, string Sysmbol,
            string Price, string ChangeRate, string Low, string High)
    {
        var botClient = new TelegramBotClient("5138490742:AAFK7ZVo8CDaggoCYWc716c1llfqnJCx0zk");
        Message message = await botClient.SendTextMessageAsync(
            chatId: chatID,
            text:
            $"Esto se pone interesante 🙃\n" +
            "\n" +
            $"👉 {Sysmbol} bajado {ChangeRate}%" +
            " en las ultimas 24h\n" +
            "\n" +
            $"Teniendo un Low 📉 de {Low} y un High 📈 de {High}" +
            "\n" +
            "\n" +
            $"✍️ Precio actual: {Price}");
    }

    public async Task SendMessage20PAsync(string chatID, string Sysmbol,
        string Price, string ChangeRate, string Low, string High)
    {
        var botClient = new TelegramBotClient("5138490742:AAFK7ZVo8CDaggoCYWc716c1llfqnJCx0zk");
        Message message = await botClient.SendTextMessageAsync(
            chatId: chatID,
            text:
            $"Preparen los motores 😉\n" +
            "\n" +
            $"👉 {Sysmbol} ha subido {ChangeRate}%" +
            " en las ultimas 24h\n" +
            "\n" +
            $"Teniendo un Low 📉 de {Low} y un High 📈 de {High}" +
            "\n" +
            "\n" +
            $"✍️ Precio actual: {Price}");
    }

    public async Task SendMessage20NAsync(string chatID, string Sysmbol,
        string Price, string ChangeRate, string Low, string High)
    {
        var botClient = new TelegramBotClient("5138490742:AAFK7ZVo8CDaggoCYWc716c1llfqnJCx0zk");
        Message message = await botClient.SendTextMessageAsync(
            chatId: chatID,
            text:
            $"Corre que se te va el tren 😂\n" +
            "\n" +
            $"👉 {Sysmbol} ha bajado {ChangeRate}%" +
            " en las ultimas 24h\n" +
            "\n" +
            $"Teniendo un Low 📉 de {Low} y un High 📈 de {High}" +
            "\n" +
            "\n" +
            $"✍️ Precio actual: {Price}");
    }

    public async Task SendMessage30PAsync(string chatID, string Sysmbol,
        string Price, string ChangeRate, string Low, string High)
    {
        var botClient = new TelegramBotClient("5138490742:AAFK7ZVo8CDaggoCYWc716c1llfqnJCx0zk");
        Message message = await botClient.SendTextMessageAsync(
            chatId: chatID,
            text:
            $"To the Moon 🚀🚀\n" +
            "\n" +
            $"👉 {Sysmbol} ha subido {ChangeRate}%" +
            " en las ultimas 24h\n" +
            "\n" +
            $"Teniendo un Low 📉 de {Low} y un High 📈 de {High}" +
            "\n" +
            "\n" +
            $"✍️ Precio actual: {Price}");
    }

    public async Task SendMessage30NAsync(string chatID, string Sysmbol,
        string Price, string ChangeRate, string Low, string High)
    {
        var botClient = new TelegramBotClient("5138490742:AAFK7ZVo8CDaggoCYWc716c1llfqnJCx0zk");
        Message message = await botClient.SendTextMessageAsync(
            chatId: chatID,
            text:
            $"Nos fuimos loma abajo y sin frenos 😜🤪\n" +
            "\n" +
            $"👉 {Sysmbol} ha bajado {ChangeRate}%" +
            " en las ultimas 24h\n" +
            "\n" +
            $"Teniendo un Low 📉 de {Low} y un High 📈 de {High}" +
            "\n" +
            "\n" +
            $"✍️ Precio actual: {Price}");
    }
}