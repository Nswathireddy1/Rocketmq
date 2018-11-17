using org.apache.rocketmq.client.consumer;
using org.apache.rocketmq.common.consumer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Consumer
    {
        static void Main(string[] args)
        {
            DefaultMQPushConsumer consumer = new DefaultMQPushConsumer("test");
            consumer.setConsumeFromWhere(ConsumeFromWhere.CONSUME_FROM_FIRST_OFFSET);
            consumer.setNamesrvAddr("192.168.100.3:9876");
            consumer.subscribe("defaulttopic", "*");
            consumer.registerMessageListener(new TestListener());
            consumer.start();
        }
    }
}
