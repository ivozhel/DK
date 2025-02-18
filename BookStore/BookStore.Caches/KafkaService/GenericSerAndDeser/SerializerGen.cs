﻿using Confluent.Kafka;
using MessagePack;

namespace BookStore.Caches.KafkaService.GenericSerAndDeser
{
    public class SerializerGen<T> : ISerializer<T>
    {
        public byte[] Serialize(T data, SerializationContext context)
        {
            return MessagePackSerializer.Serialize(data);
        }
    }
}
