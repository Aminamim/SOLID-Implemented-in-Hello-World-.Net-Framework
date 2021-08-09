using System;

namespace SOLID_in_hello_world_app
{
    public class MessageReader : IMessageReader
    {
        public MessageReader()
        {
        }

        public string ReadMessage()
        {
            return "Hello, world!";
        }
    }
}