using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesManagement.Services.Exceptions;
using System;
using System.Net;

namespace MoviesManagement.API.Global_Exceptions
{
    public class ApiExceptionHandling : ProblemDetails
    {
        private HttpContext _context;
        private Exception _exception;

        public string TraceId 
        {
            get
            {
                if (Extensions.TryGetValue("TraceId", out var traceId))
                    return (string)traceId;

                return string.Empty;
            }

            set => Extensions["TraceId"] = value;
        }

        public string Code { get; set; } = string.Empty;

        public ApiExceptionHandling(HttpContext context, Exception exception)
        {
            _context = context;
            _exception = exception;

            TraceId = context.TraceIdentifier;
            Title = exception.Message;
            HandleException((dynamic)exception);
        }

        private void HandleException(TicketDoesNotExistException exception)
        {
            Status = (int)HttpStatusCode.NotFound;
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.4";
            Title = exception.Message;
            Code = exception.Code;
        }

        private void HandleException(YouAlreadyHaveTicketException exception)
        {
            Status = (int)HttpStatusCode.Conflict;
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.8";
            Title = exception.Message;
            Code = exception.Code;
        }

        private void HandleException(UserDoesNotExist exception)
        {
            Status = (int)HttpStatusCode.NotFound;
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.4";
            Title = exception.Message;
            Code = exception.Code;
        }

        private void HandleException(AllTicketSoldOutException exception)
        {
            Status = (int)HttpStatusCode.Conflict;
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.4";
            Title = exception.Message;
            Code = exception.Code;
        }

        private void HandleException(InvalidLoginAttemptException exception)
        {
            Status = (int)HttpStatusCode.Forbidden;
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.3";
            Title = exception.Message;
            Code = exception.Code;
        }

        private void HandleException(MovieIsNotAvailableAtCinema exception)
        {
            Status = (int)HttpStatusCode.BadRequest;
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.1";
            Title = exception.Message;
            Code = exception.Code;
        }

        private void HandleException(Exception exception)
        {
            Status = (int)HttpStatusCode.InternalServerError;
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.1";
            Title = exception.Message;
            Code = "Something unexpectable occured";
        }

    }
}
