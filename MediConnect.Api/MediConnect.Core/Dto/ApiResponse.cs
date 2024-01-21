using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediConnect.Core.Dto
{
    public class ApiResponse
    {
        public bool Succeseded { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public object Data { get; set; }

        public ApiResponse( string message = null)
        {
            Succeseded = true;
            Message = message;
        }

        public static ApiResponse Success(object data)
        {
            return new ApiResponse
            {
                Message = "success",
                Data = data
            };
        }

        public static ApiResponse Failed(object data, string Message = "Failure", List<string> errors = null)
        {
            return new ApiResponse
            {
                Succeseded = false,
                Data = data,
                Message = Message,
                Errors = errors
            };
        }
    }

    public class ApiResponse<T> : ApiResponse
    {
        public T Data { get; set; }

        public ApiResponse()
        {
            
        }

        public static ApiResponse Success(T data, string message)
        {
            return new ApiResponse<T>
            {
                Succeseded = true,
                Data = data,
                Message = message
            };
        }

        public static ApiResponse Failed(T data, string message = null, List<string> errors = null)
        {
            return new ApiResponse
            {
                Succeseded = false,
                Data = data,
                Message = message,
                Errors = errors
            };
        }

        public ApiResponse(T data, string message = null)
        {
            Succeseded = true;
            message = message;
            Data = data;
        }
    }
}
