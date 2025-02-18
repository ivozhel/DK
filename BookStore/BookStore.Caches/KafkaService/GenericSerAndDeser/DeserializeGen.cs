﻿using Confluent.Kafka;
using MessagePack;

namespace BookStore.Caches.KafkaService.GenericSerAndDeser
{
    public class DeserializeGen<T> : IDeserializer<T>
    {
        public T Deserialize(ReadOnlySpan<byte> data, bool isNull, SerializationContext context)
        {
            return MessagePackSerializer.Deserialize<T>(data.ToArray());
        }
    }
}
