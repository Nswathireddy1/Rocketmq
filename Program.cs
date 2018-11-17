using org.apache.rocketmq.client.producer;
using org.apache.rocketmq.common.message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            DefaultMQProducer p = new DefaultMQProducer("test");
            p.setNamesrvAddr("localhost:9876");
            p.start();
            var data = Encoding.UTF8.GetBytes("swathi");
            //  com.alibaba.rocketmq.common.message.Message m = new com.alibaba.rocketmq.common.message.Message("defaulttopic1", data);
            Message msg = new Message("", "", "dkey_01", data);
            p.send(msg);
            p.shutdown();
        }
    }
}
