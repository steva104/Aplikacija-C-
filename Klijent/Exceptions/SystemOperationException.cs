namespace Klijent.Exceptions
{
    [Serializable]
    internal class SystemOperationException : Exception
    {
        private object error;

        public SystemOperationException()
        {
        }

        public SystemOperationException(object error)
        {
            this.error = error;
        }

        public SystemOperationException(string? message) : base(message)
        {
        }

        public SystemOperationException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}