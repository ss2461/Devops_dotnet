﻿using System.Runtime.Serialization;

namespace ca2237
{
    //<snippet1>
    // [SerializableAttribute]
    public class BaseType : ISerializable
    {
        int baseValue;

        public BaseType()
        {
            baseValue = 3;
        }

        protected BaseType(
           SerializationInfo info, StreamingContext context)
        {
            baseValue = info.GetInt32("baseValue");
        }

        public virtual void GetObjectData(
           SerializationInfo info, StreamingContext context)
        {
            info.AddValue("baseValue", baseValue);
        }
    }
    //</snippet1>
}
