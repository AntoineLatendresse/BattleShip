using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Battleship_Client
{
    namespace ConnexionUtility
    {
        public class ClientUtility
        {
            public static void SerializeAndSend(NetworkStream ns, object o)
            {
                if (o.GetType().IsSerializable)
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(ns, o);
                }
            }

            public static object ReadAndDeserialize(NetworkStream ns)
            {
                IFormatter formatter = new BinaryFormatter();
                try
                {
                    return formatter.Deserialize(ns);
                }
                catch (Exception Exc)
                {
                    Trace.TraceError(Exc.ToString());
                }
                return null;
            }
        }
    }
}
