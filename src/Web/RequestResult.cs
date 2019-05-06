using System;

namespace BattleMuffin.Web
{
    /// <summary>
    ///     Represents a request made to the Blizzard API.
    /// </summary>
    /// <typeparam name="T">The type of request made.</typeparam>
    public class RequestResult<T>
    {
        /// <summary>
        ///     The requested object value from the Blizzard API.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        ///     The request error response from the Blizzard API.
        /// </summary>
        public RequestError Error { get; set; }

        /// <summary>
        ///     Indicates if the HTTP request succeeded.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        ///     Initializes a request result with an object value.
        /// </summary>
        /// <param name="value">Instance of the Blizzard API request</param>
        public RequestResult(T value)
        {
            Value = value;
            Success = true;
        }

        /// <summary>
        ///     Initializes a request result with an error.
        /// </summary>
        /// <param name="error">The error received from the Blizzard API request</param>
        public RequestResult(RequestError error)
        {
            Error = error ?? throw new ArgumentNullException(nameof(error));
            Success = false;
        }

        /// <summary>
        ///     Implicit operator for initializing an object result with a value.
        /// </summary>
        /// <param name="value">Instance of the Blizzard API request</param>
        public static implicit operator RequestResult<T>(T value)
        {
            return new RequestResult<T>(value);
        }

        /// <summary>
        ///     Implicit operator for initializing an object result with an error.
        /// </summary>
        /// <param name="error">The error received from the Blizzard API request</param>
        public static implicit operator RequestResult<T>(RequestError error)
        {
            return new RequestResult<T>(error);
        }
    }
}
