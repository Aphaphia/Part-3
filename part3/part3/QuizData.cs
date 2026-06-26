using System.Collections.Generic;

namespace Part3
{
    public static class QuizData
    {
        public static List<QuizQuestion> Questions = new List<QuizQuestion>()
        {
            new QuizQuestion()
            {
                Question = "What should you do if you receive an email asking for your password?",
                Options = new List<string>() { "A) Reply with your password", "B) Delete the email", "C) Report the email as phishing", "D) Ignore it" },
                CorrectAnswer = "C",
                Explanation = "Reporting phishing emails helps prevent scams and protects others.",
                IsMultipleChoice = true
            },
            new QuizQuestion()
            {
                Question = "TRUE or FALSE: Using the same password for all your accounts is safe.",
                Options = new List<string>() { "A) True", "B) False" },
                CorrectAnswer = "B",
                Explanation = "False! If one account is hacked, all your accounts become vulnerable. Use unique passwords.",
                IsMultipleChoice = false
            },
            new QuizQuestion()
            {
                Question = "What does HTTPS mean in a website address?",
                Options = new List<string>() { "A) The website is fast", "B) The connection is encrypted and secure", "C) The website is free", "D) The website is popular" },
                CorrectAnswer = "B",
                Explanation = "HTTPS means your connection to the website is encrypted, protecting your data.",
                IsMultipleChoice = true
            },
            new QuizQuestion()
            {
                Question = "TRUE or FALSE: Public Wi-Fi is always safe to use for online banking.",
                Options = new List<string>() { "A) True", "B) False" },
                CorrectAnswer = "B",
                Explanation = "False! Public Wi-Fi is risky. Hackers can intercept your data. Use a VPN on public networks.",
                IsMultipleChoice = false
            },
            new QuizQuestion()
            {
                Question = "What is phishing?",
                Options = new List<string>() { "A) A type of sport", "B) Attackers pretending to be trusted organisations to steal information", "C) A safe way to browse the internet", "D) A type of antivirus software" },
                CorrectAnswer = "B",
                Explanation = "Phishing is when criminals impersonate trusted organisations to trick you into giving personal information.",
                IsMultipleChoice = true
            },
            new QuizQuestion()
            {
                Question = "TRUE or FALSE: Two-factor authentication (2FA) makes your account more secure.",
                Options = new List<string>() { "A) True", "B) False" },
                CorrectAnswer = "A",
                Explanation = "True! 2FA adds an extra layer of security. Even if your password is stolen, attackers cannot log in without the second factor.",
                IsMultipleChoice = false
            },
            new QuizQuestion()
            {
                Question = "What is ransomware?",
                Options = new List<string>() { "A) Software that speeds up your computer", "B) Malware that encrypts your files and demands payment", "C) A type of antivirus", "D) A safe browser extension" },
                CorrectAnswer = "B",
                Explanation = "Ransomware locks your files and demands payment. Always back up your data to protect yourself.",
                IsMultipleChoice = true
            },
            new QuizQuestion()
            {
                Question = "TRUE or FALSE: You should share your OTP with someone who calls claiming to be from your bank.",
                Options = new List<string>() { "A) True", "B) False" },
                CorrectAnswer = "B",
                Explanation = "False! Your OTP is confidential. Legitimate banks will never ask for your OTP over the phone.",
                IsMultipleChoice = false
            },
            new QuizQuestion()
            {
                Question = "What is the safest way to create a strong password?",
                Options = new List<string>() { "A) Use your name and birthdate", "B) Use 'password123'", "C) Use at least 12 characters with uppercase, lowercase, numbers and symbols", "D) Use the same password you always use" },
                CorrectAnswer = "C",
                Explanation = "A strong password uses at least 12 characters with a mix of uppercase, lowercase, numbers, and special characters.",
                IsMultipleChoice = true
            },
            new QuizQuestion()
            {
                Question = "TRUE or FALSE: Clicking links in unsolicited emails is safe if the email looks legitimate.",
                Options = new List<string>() { "A) True", "B) False" },
                CorrectAnswer = "B",
                Explanation = "False! Always hover over links to check the URL before clicking. Phishing emails are designed to look legitimate.",
                IsMultipleChoice = false
            },
            new QuizQuestion()
            {
                Question = "What should you do to protect yourself from malware?",
                Options = new List<string>() { "A) Download software from any website", "B) Disable your antivirus to speed up your computer", "C) Keep antivirus software updated and avoid unknown downloads", "D) Open all email attachments" },
                CorrectAnswer = "C",
                Explanation = "Keeping antivirus software updated and avoiding unknown downloads are key ways to protect against malware.",
                IsMultipleChoice = true
            },
            new QuizQuestion()
            {
                Question = "TRUE or FALSE: Software updates should be installed as soon as possible.",
                Options = new List<string>() { "A) True", "B) False" },
                CorrectAnswer = "A",
                Explanation = "True! Updates patch security vulnerabilities. Many major attacks exploit systems that have not been updated.",
                IsMultipleChoice = false
            },
        };
    }

    public class QuizQuestion
    {
        public string Question { get; set; } = "";
        public List<string> Options { get; set; } = new List<string>();
        public string CorrectAnswer { get; set; } = "";
        public string Explanation { get; set; } = "";
        public bool IsMultipleChoice { get; set; } = true;
    }
}