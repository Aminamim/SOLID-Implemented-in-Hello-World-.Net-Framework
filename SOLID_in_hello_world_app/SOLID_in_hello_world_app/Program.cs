using System;

namespace SOLID_in_hello_world_app
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessageReader messageReader = new MessageReader();
            IMessageWriter messageWriter = new MessageWriter();

            var app = new App(messageReader, messageWriter);
            app.Run();

        }
    }
}
