using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Xml.Serialization;
using System.IO;

namespace ClientSide
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4000);
            //sock.Connect(endPoint);
            //Console.WriteLine("Connection has been established. \n\n");
            //Console.WriteLine("Enter the Message");
            //string message = Console.ReadLine();
            //byte[] msgBuffer = Encoding.ASCII.GetBytes(message);
            //int nBytesSent = 0;
            //while (nBytesSent < msgBuffer.Length)
            //{
            //    nBytesSent += sock.Send(msgBuffer, nBytesSent, msgBuffer.Length, SocketFlags.None);
            //}
            //byte[] bufferResponse = new byte[456];
            //char[] recievedCharacters = new char[256];

            //while (true)
            //{
            //    int bytesReceived = sock.Receive(bufferResponse);
            //    if (bytesReceived == 0) break;
            //    //Array.Resize(ref bufferResponse, bytesReceived);
            //    int charCounts = Encoding.ASCII.GetChars(bufferResponse, 0, bytesReceived, recievedCharacters, 0);
            //    Console.WriteLine(recievedCharacters, 0, charCounts);
            //}

            //Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4000);
            //sock.Connect(endPoint);
            //Console.WriteLine("Connection has been established. \n\n");
            //byte[] bufferResponse = new byte[1024 * 1024];
            //int bytesReceived;
            //Console.WriteLine("Enter the Message");
            //string message = Console.ReadLine();
            //byte[] msgBuffer = Encoding.ASCII.GetBytes(message);
            //int nBytesSent = 0;
            //while (nBytesSent < msgBuffer.Length)
            //{
            //    nBytesSent += sock.Send(msgBuffer, nBytesSent, msgBuffer.Length, SocketFlags.None);
            //}
            //bytesReceived = sock.Receive(bufferResponse);
            //;
            //UTF8Encoding temp = new UTF8Encoding(true);
            //var xml = temp.GetString(bufferResponse, 0, bytesReceived);
            //Console.WriteLine(cleanMessage(xml));
            //var xmlSerializer = new XmlSerializer(typeof(List<Cars>));
            //List<Cars> lstCars = new List<Cars>();
            //using (TextReader reader = new StringReader(xml))
            //{
            //    lstCars = (List<Cars>)xmlSerializer.Deserialize(reader);
            //}

            //foreach (var car in lstCars) {
            //    Console.WriteLine(car.CarID + " " +  car.SupplierName + " " + car.Manufacturer);
            //}
            //Console.Read();








            //Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.255.0.1"), 4000);
            //sock.Connect(endPoint);
            //Console.WriteLine("Connection has been established. \n\n");
            //byte[] bufferResponse = new byte[1024 * 1024];
            //int bytesReceived;
            //Console.WriteLine("Enter the Message");
            //string message = Console.ReadLine();
            //byte[] msgBuffer = Encoding.ASCII.GetBytes(message);
            //int nBytesSent = 0;
            //while (nBytesSent < msgBuffer.Length)
            //{
            //    nBytesSent += sock.Send(msgBuffer, nBytesSent, msgBuffer.Length, SocketFlags.None);
            //}
            //bytesReceived = sock.Receive(bufferResponse);
            //;
            //string json = Encoding.UTF8.GetString(bufferResponse);

            //Console.WriteLine(cleanMessage(json));
            //Console.Read();


            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4000);
            sock.Connect(endPoint);
            Console.WriteLine("Connection has been established. \n\n");
            Console.WriteLine("Enter a message:");
            string message = Console.ReadLine();
            byte[] sendingBuffer = Encoding.ASCII.GetBytes(message);
            sock.Send(sendingBuffer, 0 , sendingBuffer.Length, 0);
            byte[] responseBuffer= new byte[1024*1024];
            
            int recivedBytes = sock.Receive(responseBuffer);
            Array.Resize(ref responseBuffer, recivedBytes);
            Console.WriteLine("The received text from the server is: " + Encoding.ASCII.GetString(responseBuffer));
            Console.ReadKey();
        }
     
        public class Cars
        {
            private uint m_carID;
            private string m_manufacturer;
            private string m_model;
            private uint m_supplierId;
            private DateTime m_purchasedOn;
            private uint m_carPrice;
            private bool m_isSold = false;
            private bool m_isDeleted = false;
            private string m_supplierName;

            public uint CarID
            {
                get { return m_carID; }
                set { m_carID = value; }
            }
            public string Manufacturer
            {
                get { return m_manufacturer; }
                set { m_manufacturer = value; }
            }

            public string Model
            {
                get { return m_model; }
                set { m_model = value; }
            }

            public uint SupplierId
            {
                get { return m_supplierId; }
                set { m_supplierId = value; }
            }

            public DateTime PurchasedOn
            {
                get { return m_purchasedOn; }
                set { m_purchasedOn = value; }
            }
            public uint CarPrice
            {
                get { return m_carPrice; }
                set { m_carPrice = value; }
            }

            public bool IsSold
            {
                get { return m_isSold; }
                set { m_isSold = value; }
            }
            public bool IsDeleted
            {
                get { return m_isDeleted; }
                set { m_isDeleted = value; }
            }
            public string SupplierName
            {
                get { return m_supplierName; }
                set { m_supplierName = value; }
            }
        }
    }
}
