﻿namespace SharpDomain.Errors
{
    public class AuthorizationError : ErrorBase
    {
        public AuthorizationError(string message)
        {
            Message = message;
        }

        public override string Message { get; }
    }
}