﻿namespace Gu.PaftaBulucu.Bot.Models.Telegram
{
    public class CallbackQuery
    {
        public string Id { get; set; }
        public Message Message { get; set; }
        public string Data { get; set; }
    }
}
