using System;
using System.IO;
using System.Media;

namespace CyberSecurityPart3
{
    public static class VoiceGreeting
    {
        public static void Play()
        {
            PlayGreeting("greeting.wav");
        }

        public static void PlayGreeting(string filepath)
        {
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filepath);
            if (File.Exists(fullPath))
            {
                SoundPlayer player = new SoundPlayer(fullPath);
                player.Play();
            }
        }
    }
}s