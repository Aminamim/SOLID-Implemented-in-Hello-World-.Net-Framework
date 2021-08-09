using System;

namespace SOLID_in_hello_world_app
{
    public class MessageWriter : IMessageWriter
    {
        public MessageWriter()
        {
        }

        public void WriteMessage(string word)
        {
            Console.WriteLine(word);
        }
    }
}