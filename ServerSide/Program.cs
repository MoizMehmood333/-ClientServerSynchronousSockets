using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;

namespace ServerSide
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4000);
            //serverSocket.Bind(endPoint);
            //serverSocket.Listen(6);
            //Console.WriteLine("Started Listning at 127.0.0.1 at 4000\n\n");

            ////accepts client connection
            //Socket clientConnected = serverSocket.Accept();
            //byte[] bufferSend = Encoding.Default.GetBytes("Message from the server that connection has been made sucessfully");
            //int nBytesSent = 0;
            //while (nBytesSent < bufferSend.Length)
            //{
            //    nBytesSent += clientConnected.Send(bufferSend, nBytesSent, bufferSend.Length, SocketFlags.None);
            //}

            //byte[] bufferRecieve = new byte[256];
            //char[] recievedCharacters = new char[256];

            //while (true)
            //{
            //    int bytesReceived = clientConnected.Receive(bufferRecieve);
            //    if (bytesReceived == 0) break;
            //    //Array.Resize(ref bufferRecieve, bytesReceived);
            //    int charCounts = Encoding.ASCII.GetChars(bufferRecieve, 0, bytesReceived, recievedCharacters, 0);
            //    Console.WriteLine(recievedCharacters, 0, charCounts);
            //}
            //serverSocket.Close();
            //clientConnected.Close();


            //
            //sending and reciving texts, string. 
            //

            //Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4000);
            //serverSocket.Bind(endPoint);
            //serverSocket.Listen(0);

            //Console.WriteLine("Started Listning at 127.0.0.1 at 4000\n\n");
            //Socket clientConnected;
            //while (true) {
            //    clientConnected = serverSocket.Accept();
            //    byte[] bufferSend = Encoding.Default.GetBytes("Message from the server that connection has been made sucessfully");
            //    int nBytesSent = 0;
            //    while (nBytesSent < bufferSend.Length)
            //    {
            //        nBytesSent += clientConnected.Send(bufferSend, nBytesSent, bufferSend.Length, SocketFlags.None);
            //    }

            //    byte[] bufferRecieve = new byte[256];
            //    char[] recievedCharacters = new char[256];

            //    while (true)
            //    {
            //        int bytesReceived = clientConnected.Receive(bufferRecieve);
            //        if (bytesReceived == 0) break;
            //        //Array.Resize(ref bufferRecieve, bytesReceived);
            //        int charCounts = Encoding.ASCII.GetChars(bufferRecieve, 0, bytesReceived, recievedCharacters, 0);
            //        Console.WriteLine(recievedCharacters, 0, charCounts);
            //    }
            //    clientConnected.Close();
            //}
            ////accepts client connection

            //serverSocket.Close();



            //
            //sending and reciving files. 
            //

            //Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4000);
            //serverSocket.Bind(endPoint);
            //serverSocket.Listen(0);
            //Console.WriteLine("Started Listning at 127.0.0.1 at 4000\n\n");

            //string path = @"C:\Users\mmoiz\Desktop\VehiclePurchaseSystem\Cars.xml";

            //byte[] bufferSend = new byte[1024 * 1024];
            //using (FileStream fs = File.OpenRead(path))
            //{
            //    UTF8Encoding temp = new UTF8Encoding(true);
            //    int nReadLength;
            //    nReadLength = fs.Read(bufferSend, 0, bufferSend.Length);
            //}

            //Socket clientConnected = serverSocket.Accept();
            //int nBytesSent = 0;
            //while (nBytesSent < bufferSend.Length)
            //{
            //    nBytesSent += clientConnected.Send(bufferSend, nBytesSent, bufferSend.Length, SocketFlags.None);
            //}

            ////
            //byte[] bufferRecieve = new byte[256];
            //char[] recievedCharacters = new char[256];

            //while (true)
            //{
            //    int bytesReceived = clientConnected.Receive(bufferRecieve);
            //    if (bytesReceived == 0) break;
            //    int charCounts = Encoding.ASCII.GetChars(bufferRecieve, 0, bytesReceived, recievedCharacters, 0);
            //    Console.WriteLine(recievedCharacters, 0, charCounts);
            //}
            //clientConnected.Close();
            //serverSocket.Close();












            //Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4000);
            //serverSocket.Bind(endPoint);
            //serverSocket.Listen(0);
            //Console.WriteLine("Started Listning at 127.0.0.1 at 4000\n\n");

            //List<Cars> lstCars = new List<Cars>();
            //lstCars.Add(new Cars { CarID = 1 });
            //lstCars.Add(new Cars { CarID = 2 });
            //lstCars.Add(new Cars { CarID = 3 });
            //lstCars.Add(new Cars { CarID = 4 });

            //var bin = new BinaryFormatter();
            //byte[] bufferSend;

            //String JsonFormat = JsonSerializer.Serialize(lstCars);
            //bufferSend = Encoding.UTF8.GetBytes(JsonFormat);

            //Socket clientConnected = serverSocket.Accept();
            //int nBytesSent = 0;
            //while (nBytesSent < bufferSend.Length)
            //{
            //    nBytesSent += clientConnected.Send(bufferSend, nBytesSent, bufferSend.Length, SocketFlags.None);
            //}


            ////
            //byte[] bufferRecieve = new byte[256];
            //char[] recievedCharacters = new char[256];

            //while (true)
            //{
            //    int bytesReceived = clientConnected.Receive(bufferRecieve);
            //    if (bytesReceived == 0) break;
            //    int charCounts = Encoding.ASCII.GetChars(bufferRecieve, 0, bytesReceived, recievedCharacters, 0);
            //    Console.WriteLine(recievedCharacters, 0, charCounts);
            //}
            //clientConnected.Close();
            //serverSocket.Close();



            //Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4000);
            //serverSocket.Bind(endPoint);
            //serverSocket.Listen(10);
            //Console.WriteLine("Started Listning at 127.0.0.1 at 4000\n\n");

            //List<Cars> lstCars = new List<Cars>();
            //lstCars.Add(new Cars { CarID = 1 });
            //lstCars.Add(new Cars { CarID = 2 });
            //lstCars.Add(new Cars { CarID = 3 });
            //lstCars.Add(new Cars { CarID = 4 });

            //byte[] bufferSend;

            //string JsonFormat = JsonSerializer.Serialize(lstCars);
            //bufferSend = Encoding.UTF8.GetBytes(JsonFormat);

            //while (true) { 
            //        Socket clientConnected = serverSocket.Accept();
            //    Console.WriteLine("Accepted Connection frin the Client\n\n");
            //    int nBytesSent = 0;
            //    while (nBytesSent < bufferSend.Length)
            //    {
            //        nBytesSent += clientConnected.Send(bufferSend, nBytesSent, bufferSend.Length, SocketFlags.None);

            //        byte[] bufferRecieve = new byte[256];
            //        char[] recievedCharacters = new char[256];
            //        int bytesReceived = clientConnected.Receive(bufferRecieve);
            //        if (bytesReceived == 0) break;
            //        int charCounts = Encoding.ASCII.GetChars(bufferRecieve, 0, bytesReceived, recievedCharacters, 0);
            //        Console.WriteLine(recievedCharacters, 0, charCounts);
            //        clientConnected.Shutdown(SocketShutdown.Both);
            //        clientConnected.Close();
            //    }
            //}


            //Socket serverSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4000);
            //serverSock.Bind(endpoint);
            //serverSock.Listen(0  );
            //Console.WriteLine("Server has started \n\n");

            //Socket clientSock = serverSock.Accept();
            //Console.WriteLine("Server has accepted the request from the client: " + clientSock + "\n\n\n");

            //byte[] sendbuffer = Encoding.ASCII.GetBytes("Message from the Server Side");

            //clientSock.Send(sendbuffer, 0, sendbuffer.Length, 0);
            //sendbuffer = new byte[1024 * 1024];
            //int receive = clientSock.Receive(sendbuffer);
            //Array.Resize(ref sendbuffer, receive);

            //Console.WriteLine("\nReceived text is: " + Encoding.ASCII.GetString(sendbuffer));
            //clientSock.Close();
            //serverSock.Close();
            //Console.ReadKey();



            //learning threads

            //Thread thread1 = new Thread(Print1);
            //thread1.Start();
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.Write(0);
            //}

            //sleep

            //int num = 1;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i+1);
            //    Thread.Sleep(1000);
            //}
            //Console.WriteLine("Thread Ends");


            //lock
            //BankAccount acc = new BankAccount(20);
            //Thread[] threads = new Thread[15];

            //Thread.CurrentThread.Name = "main";

            //for (int i = 0; i < 15; i++)
            //{
            //    Thread t = new Thread(new ThreadStart(acc.IssueWithdraw));
            //    t.Name = i.ToString();
            //    threads[i] = t;
            //}

            //for (int i = 0; i < 15; i++) {
            //    Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);
            //    threads[i].Start();
            //    Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive); 
            //};

            //Console.WriteLine("Current Priority {0}",Thread.CurrentThread.Priority);
            //Console.WriteLine("Thread {0} Ending", Thread.CurrentThread.Name);
            //Console.ReadKey();



            /// handling disconnections


            Socket serverSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4000);
            serverSock.Bind(endpoint);
            serverSock.Listen(0);
            Console.WriteLine("Server has started \n\n");

            Socket clientSock = serverSock.Accept();
            Console.WriteLine("Server has accepted the request from the client: " + clientSock + "\n\n\n");

            byte[] sendbuffer = Encoding.ASCII.GetBytes("Message from the Server Side");

            clientSock.Send(sendbuffer, 0, sendbuffer.Length, 0);
            sendbuffer = new byte[1024 * 1024];
            int receive = clientSock.Receive(sendbuffer);
            Array.Resize(ref sendbuffer, receive);

            Console.WriteLine("\nReceived text is: " + Encoding.ASCII.GetString(sendbuffer));
            clientSock.Close();
            serverSock.Close();
            Console.ReadKey();



            //Async Await.
            //Task task1 = CleanRoom();
            // CleanClothes();
            //Task task3 = DoTheDishes();

            //await Task.WhenAll(task1, task3);


        }

        public async static Task CleanRoom()
        {
            Console.WriteLine("Task Clean Room Begin");
            await Task.Delay(2000);
            Console.WriteLine("Task Clean Room End");

        }
        public async static Task CleanClothes()
        {
            Console.WriteLine("Task Clean Clothes Begin");

            await Task.Delay(4000);
            Console.WriteLine("Task Clean Clothes Close");

        }
        public async static Task DoTheDishes()
        {
            Console.WriteLine("Task Do the dishes Begin");

            await Task.Delay(3000);

            Console.WriteLine("Task Do the dishes closed");

        }

        //class BankAccount {

        //    private Object accLock = new object();
        //    double Balance { get; set; }
        //    public BankAccount( double balance)
        //    {
        //        Balance = balance;
        //    }
        //    public double Withdraw(double amt) {
        //        if ((Balance - amt) < 0) {
        //            Console.WriteLine($"Sorry ${Balance} in Account");
        //            return Balance;
        //        }
        //        Console.WriteLine("Removed {0} and {1} left in Account", amt, (Balance - amt));
        //        return Balance;
        //        lock (accLock)
        //        {
        //            if (Balance >= amt)
        //            {
        //                Console.WriteLine("Removed {0} and {1} left in Account", amt, (Balance - amt));
        //                Balance -= amt;
        //            }
        //            return Balance;
        //        }
        //    }

        //    public void IssueWithdraw() {
        //        Withdraw(1);    
        //    }

        //}
    }
}










