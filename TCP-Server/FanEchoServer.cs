using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using FanOutPut2;
using Newtonsoft.Json;

namespace TCP_Server
{
    class FanEchoServer
    {

        private static List<FanOutPut> Data = new List<FanOutPut>()
        {
            new FanOutPut(1, "bo", 24, 40),
            new FanOutPut(2, "nick", 25, 45)
        };

        public static void Start()
        {


            //opretter
            TcpListener serverSocket = new TcpListener(IPAddress.Loopback, port: 4646);
            //starter server
            serverSocket.Start();
            TcpClient connectionSocket = serverSocket.AcceptTcpClient();
            Console.WriteLine("server activated");

            while (true)
            {
                TcpClient clientSocket = serverSocket.AcceptTcpClient();
                Console.WriteLine("client found");
                Task.Run(() =>
                {
                    TcpClient tempsocket = clientSocket;
                    DoClient(tempsocket);

                });
            }

            static void DoClient(TcpClient socket)
            {
                using (socket)
                {
                    Stream ns = socket.GetStream();
                    StreamReader sr = new StreamReader(ns);
                    StreamWriter sw = new StreamWriter(ns);
                    sw.AutoFlush = true; // enable automatic flushing 

                    string line = sr.ReadLine();
                    Console.WriteLine(line);

                    switch (line)
                    {
                        case"HentAlle":
                            var json = JsonConvert.SerializeObject(Data);
                            sw.WriteLine(json);
                            break;
                        case "Hent":
                            Console.WriteLine("hvilken id");
                            string id = sr.ReadLine();
                            int ConvertId = Int32.Parse(id);
                            var json2 = JsonConvert.SerializeObject(Data.Find(i => ConvertId == i.Id));
                            sw.WriteLine(json2);
                            Console.WriteLine($"Data hentet ud fra det ønskede Id" + json2);
                            break;

                            case "Gem":
                            Console.WriteLine("indtast Id, Name, Temp og Fugt");
                            string input = sr.ReadLine();
                            FanOutPut fanOutPut = new FanOutPut(Convert.ToInt32(input.Split(" ")[0])Convert.ToString(input.Split(" ")[1])Convert.ToInt32(input.Split(" ")[2]) Convert.ToInt32(input.Split(" ")[3]));
                            FanOutPut newFanOutPut = fanOutPut;
                            Data.Add(newFanOutPut);
                            break;
                    }


                }




            }
        }
    }
}
    

