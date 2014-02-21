namespace CrystallBallGame
{
    using System;
    public class ImproperlyDefinedCreatureException : ApplicationException
    {

        public ImproperlyDefinedCreatureException(string msg)
            : base(msg)
        {
        }

        public ImproperlyDefinedCreatureException(string msg, Exception innerEx)
            : base(msg, innerEx)
        {
        }
    }
}
