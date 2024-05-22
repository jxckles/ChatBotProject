using AIMLbot;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ChatBotProject
{
    static class Program
    {
        // Static list to store recent chats
        public static List<string> RecentChats { get; } = new List<string>();

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of Form1
            Form1 form1 = new Form1();

            // Create an instance of FirstPage and pass the reference to Form1
            FirstPage firstPage = new FirstPage(form1);

            // Show FirstPage
            Application.Run(firstPage);
        }
    }
    public class ChatBot
    {
        const string UserId = "defaultuser";
        private Bot AimlBot;
        private User myUser;

        public ChatBot()
        {
            AimlBot = new Bot();
            myUser = new User(UserId, AimlBot);
            Initialize();
        }

        // Loads all the AIML files in the \AIML folder         
        public void Initialize()
        {
            AimlBot.loadSettings();
            AimlBot.isAcceptingUserInput = false;
            AimlBot.loadAIMLFromFiles();
            AimlBot.isAcceptingUserInput = true;
        }

        // Given an input string, finds a response using AIMLbot lib
        public String getOutput(String input)
        {
            Request r = new Request(input, myUser, AimlBot);
            Result res = AimlBot.Chat(r);
            return (res.Output);
        }
    }

}
