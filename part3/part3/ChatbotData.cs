using System.Collections.Generic;

namespace CyberSecurityPart3
{
    public static class ChatbotData
    {
        public static Dictionary<string, string> Responses = new Dictionary<string, string>()
        {
            { "how are you",               "I am doing great and staying cyber-safe! How can I help you today?" },
            { "purpose",                   "My purpose is to educate South African citizens about cybersecurity threats and how to stay safe online." },
            { "what can i ask",            "You can ask me about: passwords, phishing, malware, ransomware, VPN, Wi-Fi, 2FA, identity theft, firewalls, backups, updates, and more. You can also type 'start quiz', 'show tasks', or 'show activity log'." },
            { "hello",                     "Hello! Great to see you taking cybersecurity seriously. What would you like to learn about?" },
            { "hi",                        "Hi there! I am your Cybersecurity Awareness Assistant. Ask me anything about staying safe online!" },
            { "password",                  "Use at least 12 characters, mix uppercase, lowercase, numbers and symbols. Never reuse passwords across different sites." },
            { "strong password",           "A strong password is at least 12 characters long and uses uppercase, lowercase, numbers, and special characters. Avoid your name or birthdate." },
            { "password manager",          "A password manager stores your passwords securely. Recommended options: Bitwarden, LastPass, or KeePass." },
            { "phishing",                  "Phishing is when attackers pretend to be a trusted organisation to steal your information. Never click links in suspicious emails." },
            { "phishing email",            "Check the sender email address carefully, hover over links before clicking, and be suspicious of urgent requests for personal info." },
            { "spear phishing",            "Spear phishing is a targeted phishing attack using your personal details to appear more credible. Always verify unexpected requests." },
            { "smishing",                  "Smishing is phishing via SMS. Be cautious of texts asking you to click links, especially from SARS or banks." },
            { "vishing",                   "Vishing is voice phishing. Scammers call pretending to be your bank. Never give your PIN or OTP over the phone." },
            { "malware",                   "Malware is malicious software including viruses, trojans, ransomware, and spyware. Keep antivirus software updated." },
            { "virus",                     "A computer virus attaches to files and spreads when shared. Keep antivirus software updated and avoid unknown downloads." },
            { "trojan",                    "A trojan disguises itself as legitimate software. Once installed it can steal data or create backdoors." },
            { "spyware",                   "Spyware secretly monitors your activity and steals passwords. Use reputable antivirus software." },
            { "ransomware",                "Ransomware encrypts your files and demands payment. Back up data regularly and never pay the ransom. Call 086 001 0111." },
            { "safe browsing",             "Look for HTTPS in the address bar, avoid suspicious websites, do not click pop-up ads, and keep your browser updated." },
            { "https",                     "HTTPS means your connection to the website is encrypted. Always check for the padlock icon before entering personal information." },
            { "vpn",                       "A VPN encrypts your internet traffic and protects your data on public Wi-Fi. Recommended: ProtonVPN or Mullvad." },
            { "wifi",                      "At home use WPA2 or WPA3 encryption and a strong password. On public Wi-Fi avoid banking or sensitive accounts." },
            { "public wifi",               "Public Wi-Fi is risky. Hackers can intercept your traffic. Avoid banking on public networks and use a VPN." },
            { "two factor authentication", "2FA adds a second verification step after your password. Use an authenticator app like Google Authenticator." },
            { "2fa",                       "Enable 2FA on all important accounts. Even if your password is stolen, attackers cannot log in without the second factor." },
            { "social engineering",        "Social engineering manipulates people into revealing information. Always verify anyone requesting sensitive data." },
            { "pretexting",                "Pretexting creates a fake scenario to extract information. Legitimate IT staff will never ask for your password." },
            { "baiting",                   "Baiting lures victims with something tempting like a free USB drive. Never plug in unknown USB devices." },
            { "identity theft",            "Monitor your bank statements, use strong passwords, and shred sensitive documents. Report to SAFPS: 0860 101 248." },
            { "personal information",      "Limit what you share on social media. Oversharing helps criminals craft personalised phishing attacks." },
            { "firewall",                  "A firewall monitors and controls network traffic. Keep Windows Defender Firewall enabled at all times." },
            { "updates",                   "Updates patch security vulnerabilities. Enable automatic updates for your OS, browser, and antivirus software." },
            { "software update",           "Always install software updates promptly. Many major attacks exploit unpatched systems." },
            { "backup",                    "Follow the 3-2-1 rule: 3 copies of data, 2 different storage types, 1 offsite copy." },
            { "mobile security",           "Use a PIN or biometric lock, only install apps from official stores, and keep your OS updated." },
            { "app permissions",           "Before installing an app check what permissions it requests. A calculator does not need your contacts." },
            { "public computer",           "Browse in incognito mode, do not save passwords, and log out of all accounts when done." },
            { "privacy",                   "Review privacy settings on social media, limit data shared with apps, and use DuckDuckGo." },
            { "popia",                     "POPIA is South Africa's data privacy law. It gives you the right to know how your personal data is used." },
            { "report cybercrime",         "SAPS: 10111. SA Cybercrime Hotline: 086 001 0111. Banking fraud: www.sabric.co.za." },
            { "cybercrime",                "Common cybercrimes include phishing, online fraud, identity theft, and ransomware. Report to SAPS or call 086 001 0111." },
            { "encryption",                "Encryption converts data into a coded format. Use apps with end-to-end encryption like Signal for sensitive communication." },
            { "antivirus",                 "Install reputable antivirus software such as Avast, Kaspersky, or Windows Defender and keep it updated." },
            { "data breach",               "A data breach is when your information is accessed without authorisation. Change your passwords immediately." },
            { "email security",            "Do not open attachments from unknown senders and report suspicious emails to your IT department." },
            { "hack",                      "Hacking is unauthorised access to a system. Protect yourself with strong passwords, 2FA, and a firewall." },
            { "otp",                       "Your OTP is confidential. Never share it with anyone, including people claiming to be from your bank." },
            { "scam",                      "If something sounds too good to be true, it probably is. Be wary of prize notifications or requests for gift cards." },
            { "social media",              "Review your privacy settings and be careful about who you accept friend requests from." },
            { "online shopping",           "Only shop on websites with HTTPS and use a credit card for better fraud protection." },
        };

        public static List<string> Keywords = new List<string>()
        {
            "how are you", "what can i ask",
            "strong password", "password manager", "password",
            "phishing email", "spear phishing", "smishing", "vishing", "phishing",
            "malware", "virus", "trojan", "spyware", "ransomware",
            "safe browsing", "https", "vpn",
            "public wifi", "wifi",
            "two factor authentication", "2fa",
            "social engineering", "pretexting", "baiting",
            "identity theft", "personal information",
            "firewall", "software update", "updates",
            "backup", "mobile security", "app permissions",
            "public computer", "privacy", "popia",
            "report cybercrime", "cybercrime", "encryption",
            "antivirus", "data breach", "email security",
            "hack", "otp", "scam", "social media", "online shopping",
            "purpose", "hello", "hi"
        };

        public static List<string> PhishingTips = new List<string>()
        {
            "Be cautious of emails asking for personal information. Scammers often disguise themselves as trusted organisations.",
            "Always hover over links before clicking. If the URL looks strange, do not click it.",
            "Legitimate banks will never ask for your password or PIN via email or SMS.",
            "Check the sender email address carefully. Scammers use addresses like 'support@paypa1.com'.",
            "If an email creates urgency like 'Act now or your account will be closed', it is likely phishing.",
        };

        public static List<string> PasswordTips = new List<string>()
        {
            "Use a different password for every account. If one is hacked, the others stay safe.",
            "A passphrase like 'PurpleCar!RainyDay7' is strong and easier to remember.",
            "Never share your password with anyone, including IT support staff.",
            "Change your passwords immediately if you suspect your account has been compromised.",
            "Use a password manager to generate and store strong, unique passwords automatically.",
        };

        public static List<string> ScamTips = new List<string>()
        {
            "If someone asks for gift cards as payment, it is always a scam.",
            "SARS will never call you demanding immediate payment. Verify through the official SARS website.",
            "Be suspicious of job offers that require you to pay upfront fees.",
            "Prize notifications saying you won something you never entered are always scams.",
            "Never send money to someone you have only met online.",
        };
    }
}