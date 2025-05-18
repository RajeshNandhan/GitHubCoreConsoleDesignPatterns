using Newtonsoft.Json;
using System.Text;

namespace Algorithms.Extensions
{
    public class SerializationExtension
    {
        public static void TestMethod()
        {
            var myObject = new MyObject();
            myObject.Name = "Test";
            myObject.Id = 1;

            //STEP 1
            var message = MessageToBase64JsonString(myObject, "MyObject", "INSERT", default);

            Console.WriteLine(message);

            //STEP 2

            var messageObject1 = Base64JsonStringToMessageContractBase(message);

            var messageObject2 = Base64JsonStringToMessageContrac<MyObject>(message);


            Console.ReadKey();
        }
        private static string MessageToBase64JsonString<T>(T valueObject, string messageType, string messageAction, CancellationToken cancellationToken)
        {
            MessageContract<T> messageContract = new()
            {
                Contract = valueObject,
                MessageType = messageType,
                MessageAction = messageAction,
            };

            //1. Serialize the object to JSON
            string json = JsonConvert.SerializeObject(messageContract);

            //2. Encodes it as a UTF-8 byte array
            //3. Converts that byte array into a Base64 string
            string base64Json = Convert.ToBase64String(Encoding.UTF8.GetBytes(json));

            return base64Json;
        }

        private static MessageContractBase Base64JsonStringToMessageContractBase(string message)
        {
            //Decode the Base64 string into byte array
            //Decode byte array into UTF-8 JSON string.
            string json = Encoding.UTF8.GetString(Convert.FromBase64String(message));

            //Deserialize the JSON string back into the MessageContractBase
            MessageContractBase result = JsonConvert.DeserializeObject<MessageContractBase>(json);

            return result;
        }

        private static T Base64JsonStringToMessageContrac<T>(string message)
        {
            //Decode the Base64 string into byte array
            //Decode byte array into UTF-8 JSON string.
            string jsonString = Encoding.UTF8.GetString(Convert.FromBase64String(message));

            //Deserialize the JSON string back into the MessageContract<T> T- Type of Message object 
            MessageContract<T> messageContract = JsonConvert.DeserializeObject<MessageContract<T>>(jsonString);

            return messageContract.Contract;
        }
    }

    internal class MessageContractBase
    {
        public string MessageType
        {
            get;
            set;
        }

        public string MessageAction
        {
            get;
            set;
        }
    }

    internal sealed class MessageContract<TContract> : MessageContractBase
    {
        public TContract Contract
        {
            get;
            set;
        }
    }
}
