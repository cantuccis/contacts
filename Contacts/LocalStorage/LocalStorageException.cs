using System;
using System.Runtime.Serialization;

namespace LocalStorage
{
    [Serializable]
    public class LocalStorageException : Exception
    {
        public LocalStorageException()
        {
        }

        public LocalStorageException(string message) : base(message)
        {
        }

        public LocalStorageException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected LocalStorageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}