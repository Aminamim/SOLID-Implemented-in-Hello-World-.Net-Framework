using System;

namespace SOLID_in_hello_world_app
{
    internal class App
    {
        public IMessageReader _messageReader;
        public IMessageWriter _messageWriter;

        public App(IMessageReader messageReader, IMessageWriter messageWriter)
        {
            _messageReader = messageReader;
            _messageWriter = messageWriter;
        }

        internal void Run()
        {
            _messageWriter.WriteMessage(_messageReader.ReadMessage());
        }
    }
}