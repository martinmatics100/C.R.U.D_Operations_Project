using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_CRUD_Operations.Core.Dto
{
    public class ApiResponse
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public object Data { get; set; }

        public ApiResponse(string message = null)
        {
            Succeeded = true;
            Message = message;
        }

        public static ApiResponse Success(object data)
        {
            return new ApiResponse
            {
                Message = "Success",
                Data = data
            };
        }

        public static ApiResponse Failed(Object data, string message = "failure", List<string> errors = null)
        {
            return new ApiResponse
            {
                Succeeded = false,
                Data = data,
                Message = message,
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
                Succeeded = true,
                Data = data,
                Message = message
            };
        }

        public static ApiResponse Failed(T data, string message = "failure", List<string> errors = null)
        {
            return new ApiResponse
            {
                Succeeded = false,
                Data = data,
                Message = message,
                Errors = errors
            };
        }

        public ApiResponse(T data, string message = null)
        {
            Succeeded = true;
            message = message;
            data = data;
        }
    }
}
