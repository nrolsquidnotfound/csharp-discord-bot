using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

public class Program
{
    private DiscordSocketClient _client;

    public static void Main(string[] args)
        => new Program().MainAsync().GetAwaiter().GetResult();

    public async Task MainAsync()
    {
        _client = new DiscordSocketClient();

        _client.Log += Log;

        string token = "MTExNjM2OTI2ODA2NjUwNDc3NA.GSZ9QI.WPP5_hVwwl16s_n5F6rZG3-DOYYHaYOXj6smV0";

        await _client.LoginAsync(TokenType.Bot, token);
        await _client.StartAsync();

        _client.MessageReceived += MessageReceived;

        await Task.Delay(-1);
    }

    private Task Log(LogMessage msg)
    {
        Console.WriteLine(msg.ToString());
        return Task.CompletedTask;
    }

    private async Task MessageReceived(SocketMessage message)
    {
        if (message.Content.ToLower() == "!ping")
        {
            await message.Channel.SendMessageAsync("Pong!");
        }
    }
} 

```csharp
using System;
using System.Drawing;
using Accord.Neuro;

```csharp
using Discord;
using Discord.Commands;
using System.Collections.Generic;

dotnet add package Discord.Net --version 3.10.0