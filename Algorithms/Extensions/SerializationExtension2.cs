using System.Text;
using System.Text.Json;

namespace Algorithms.Extensions
{
    public class SerializationExtension2
    {
        public static async void TestMethod()
        {
            var myObject = new MyObject();
            myObject.Name = "Test";
            myObject.Id = 1;

            //STEP 1
            var message = await JsonSerializerObject(myObject, "MyObject", "INSERT", default).ConfigureAwait(false);

            Console.WriteLine(message);

            //STEP 2

            var messageObject1 = JsonDeSerializerObjectToMessageContractBase(message);

            var messageObject2 = JsonDeSerializerObjectToMessageContrac<MyObject>(message);


            Console.ReadKey();
        }
        private static async Task<byte[]> JsonSerializerObject<T>(T valueObject, string messageType, string messageAction, CancellationToken cancellationToken)
        {
            JsonSerializerOptions jsonSerializerOptions = new();

            MessageContract<T> messageContract = new MessageContract<T>
            {
                Contract = valueObject,
                MessageType = messageType,
                MessageAction = messageAction,
            };

            /*"using var" keyword reflects "using(stream){}"*/
            using var stream = new MemoryStream();
            await JsonSerializer.SerializeAsync(stream, messageContract, jsonSerializerOptions, cancellationToken).ConfigureAwait(false);

            return stream.ToArray();
        }

        private static MessageContractBase JsonDeSerializerObjectToMessageContractBase(byte[] message)
        {
            var notificationMessage = Encoding.UTF8.GetString(message);

            MessageContractBase messageContract = JsonSerializer.Deserialize<MessageContractBase>(notificationMessage);

            return messageContract;
        }

        private static T JsonDeSerializerObjectToMessageContrac<T>(byte[] message)
        {
            var notificationMessage = Encoding.UTF8.GetString(message);

            MessageContract<T> messageContract = JsonSerializer.Deserialize<MessageContract<T>>(message);

            return messageContract.Contract;
        }
    }

    internal class MessageContractBase2
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

    internal sealed class MessageContract2<TContract> : MessageContractBase2
    {
        public TContract Contract
        {
            get;
            set;
        }
    }
}
