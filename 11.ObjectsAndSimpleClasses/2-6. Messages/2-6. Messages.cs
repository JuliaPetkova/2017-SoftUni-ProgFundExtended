using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Messages
{
    class User
    {
        public string Username { get; set; }
        public List<Message> Messages { get; set; }

        public User(string username)
        {
            this.Username = username;
            this.Messages = new List<Message>();
        }
    }

    class Message
    {
        public User Sender { get; set; }
        public string Content { get; set; }

        public Message(User sender, string content)
        {
            this.Sender = sender;
            this.Content = content;
        }
    }


    class Messages
    {
        static void Main()
        {
            var users = new Dictionary<string, User>();
            string input = Console.ReadLine();

            string username;

            string sender;
            string recipient;
            string content;

            while (input != "exit")
            {
                var param = input.Split(' ').ToArray();

                if (param[0] == "register")
                {
                    username = param[1];
                    users.Add(username, new User(username));
                }
                else
                {
                    sender = param[0];
                    recipient = param[2];
                    content = param[3];

                    if (users.ContainsKey(sender) &&
                        users.ContainsKey(recipient))
                    {
                        Message message = new Message(users[sender], content);
                        users[recipient].Messages.Add(message);
                    }
                }

                input = Console.ReadLine();
            }

            string[] chat = Console.ReadLine().Split(' ');

            sender = chat[0];
            recipient = chat[1];

            Message[] senderMessages = users[recipient].Messages
                .Where(m => m.Sender.Username == sender)
                .ToArray();

            Message[] recipientMessages = users[sender].Messages
                .Where(m => m.Sender.Username == recipient)
                .ToArray();

            if (senderMessages.Length == 0 &&
                recipientMessages.Length == 0)
            {
                Console.WriteLine("No messages");
            }

            int firstIndex = 0;
            int secondIndex = 0;
            while (firstIndex < senderMessages.Length &&
                   secondIndex < recipientMessages.Length)
            {
                Message senderMessage = senderMessages[firstIndex];
                Message recipientMessage = recipientMessages[secondIndex];

                Console.WriteLine("{0}: {1}",
                    senderMessage.Sender.Username,
                    senderMessage.Content);

                Console.WriteLine("{0} :{1}",
                    recipientMessage.Content,
                    recipientMessage.Sender.Username);

                firstIndex++;
                secondIndex++;
            }

            while (firstIndex < senderMessages.Length)
            {
                Message senderMessage = senderMessages[firstIndex];

                Console.WriteLine("{0}: {1}",
                    senderMessage.Sender.Username,
                    senderMessage.Content);

                firstIndex++;
            }

            while (secondIndex < recipientMessages.Length)
            {
                Message recipientMessage = recipientMessages[secondIndex];

                Console.WriteLine("{0} :{1}",
                    recipientMessage.Content,
                    recipientMessage.Sender.Username);

                secondIndex++;
            }
        }
    }
}