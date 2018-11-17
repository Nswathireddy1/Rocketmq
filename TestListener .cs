using java.util;
using org.apache.rocketmq.client.consumer.listener;
using org.apache.rocketmq.common.message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class TestListener : MessageListenerConcurrently
    {
        static void Main(string[] args)
        {
            public ConsumeConcurrentlyStatus consumeMessage(List list, ConsumeConcurrentlyContext ccc)
            {
                for (int i = 0; i < list.size(); i++)
                {
                    var msg = list.get(i) as Message;
                    byte[] body = msg.getBody();
                    var str = Encoding.UTF8.GetString(body);
                    if (body.Length == 2 && body[0] == 0 && body[1] == 0)
                    {

                        //System.out.println("Got the end signal");
                        continue;
                    }

                }

                return ConsumeConcurrentlyStatus.CONSUME_SUCCESS;
            }
        }

        public ConsumeConcurrentlyStatus consumeMessage(List l, ConsumeConcurrentlyContext ccc)
        {
            throw new NotImplementedException();
        }
    }
}
