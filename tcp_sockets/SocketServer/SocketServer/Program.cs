using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Globalization;

namespace SocketServer
{
    class Program
    {
        public static void Main()
        {
            DateTime now;
            String strDateLine;
            Encoding ASCII = Encoding.ASCII;

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            try
            {
                TcpListener tcpl = new TcpListener(13); // listen on port 13

                tcpl.Start();

                Console.WriteLine("Waiting for clients to connect");
                Console.WriteLine("Press Ctrl+c to Quit...");

                while (true)
                {
                    // Accept will block until someone connects
                    Socket s = tcpl.AcceptSocket();

                    // Get the current date and time then concatenate it
                    // into a string
                    now = DateTime.Now;
                    strDateLine = now.ToShortDateString() + " " + now.ToLongTimeString();

                    // Convert the string to a Byte Array and send it
                    Byte[] byteDateLine = ASCII.GetBytes(strDateLine.ToCharArray());
                    s.Send(byteDateLine, byteDateLine.Length, 0);
                    s.Close();
                    Console.WriteLine("Sent {0}", strDateLine);
                }
            }
            catch (SocketException socketError)
            {
                if (socketError.ErrorCode == 10048)
                {
                    Console.WriteLine("Connection to this port failed.  There is another server is listening on this port.");
                }
            }
        }

    }
}
