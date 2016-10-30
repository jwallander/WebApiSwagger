﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v6.17.6146.29531 (NJsonSchema v5.7.6142.39228) (http://NSwag.org)
// </auto-generated>
//----------------------

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace WebApiSwaggerClient
{
#pragma warning disable // Disable all warnings

    [GeneratedCode("NSwag", "6.17.6146.29531")]
    public partial class StudentsClient
    {
        public StudentsClient() : this("http://localhost:12159") { }

        public StudentsClient(string baseUrl)
        {
            BaseUrl = baseUrl;
        }

        partial void PrepareRequest(HttpClient request, ref string url);

        partial void ProcessResponse(HttpClient request, HttpResponseMessage response);

        public string BaseUrl { get; set; }

        /// <summary>Get all students</summary>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task<ObservableCollection<Student>> GetAllAsync()
        {
            return GetAllAsync(CancellationToken.None);
        }

        /// <summary>Get all students</summary>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task<ObservableCollection<Student>> GetAllAsync(CancellationToken cancellationToken)
        {
            var url_ = string.Format("{0}/{1}", BaseUrl, "api/Students");

            var client_ = new HttpClient();
            var request_ = new HttpRequestMessage();
            PrepareRequest(client_, ref url_);
            request_.Method = new HttpMethod("GET");
            request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
            var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseContentRead, cancellationToken).ConfigureAwait(false);
            ProcessResponse(client_, response_);

            var responseData_ = await response_.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
            var status_ = ((int)response_.StatusCode).ToString();

            if (status_ == "200")
            {
                var result_ = default(ObservableCollection<Student>);
                try
                {
                    if (responseData_.Length > 0)
                        result_ = JsonConvert.DeserializeObject<ObservableCollection<Student>>(Encoding.UTF8.GetString(responseData_, 0, responseData_.Length));
                    return result_;
                }
                catch (Exception exception)
                {
                    throw new SwaggerException("Could not deserialize the response body.", status_, responseData_, exception);
                }
            }
            else
            if (status_ == "500")
            {
                throw new SwaggerException("Internal Server Error", status_, responseData_, null);
            }
            else
            {
            }

            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", status_, responseData_, null);
        }

        /// <summary>Add new student</summary>
        /// <param name="student">Student Model</param>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task PostAsync(Student student)
        {
            return PostAsync(student, CancellationToken.None);
        }

        /// <summary>Add new student</summary>
        /// <param name="student">Student Model</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task PostAsync(Student student, CancellationToken cancellationToken)
        {
            var url_ = string.Format("{0}/{1}", BaseUrl, "api/Students");

            var client_ = new HttpClient();
            var request_ = new HttpRequestMessage();
            PrepareRequest(client_, ref url_);
            var content_ = new StringContent(JsonConvert.SerializeObject(student));
            content_.Headers.ContentType.MediaType = "application/json";
            request_.Content = content_;
            request_.Method = new HttpMethod("POST");
            request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
            var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseContentRead, cancellationToken).ConfigureAwait(false);
            ProcessResponse(client_, response_);

            var responseData_ = await response_.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
            var status_ = ((int)response_.StatusCode).ToString();

            if (status_ == "400")
            {
                throw new SwaggerException("Bad request", status_, responseData_, null);
            }
            else
            if (status_ == "500")
            {
                throw new SwaggerException("Internal Server Error", status_, responseData_, null);
            }
            else
            {
            }

            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", status_, responseData_, null);
        }

        /// <summary>Get student</summary>
        /// <param name="userName">Unique username</param>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task GetAsync(string userName)
        {
            return GetAsync(userName, CancellationToken.None);
        }

        /// <summary>Get student</summary>
        /// <param name="userName">Unique username</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task GetAsync(string userName, CancellationToken cancellationToken)
        {
            var url_ = string.Format("{0}/{1}", BaseUrl, "api/Students/{userName}");

            if (userName == null)
                throw new ArgumentNullException("userName");
            url_ = url_.Replace("{userName}", Uri.EscapeDataString(userName.ToString()));

            var client_ = new HttpClient();
            var request_ = new HttpRequestMessage();
            PrepareRequest(client_, ref url_);
            request_.Method = new HttpMethod("GET");
            request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
            var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseContentRead, cancellationToken).ConfigureAwait(false);
            ProcessResponse(client_, response_);

            var responseData_ = await response_.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
            var status_ = ((int)response_.StatusCode).ToString();

            if (status_ == "404")
            {
                throw new SwaggerException("Not found", status_, responseData_, null);
            }
            else
            if (status_ == "500")
            {
                throw new SwaggerException("Internal Server Error", status_, responseData_, null);
            }
            else
            {
            }

            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", status_, responseData_, null);
        }

        /// <summary>Delete student</summary>
        /// <param name="userName">Unique username</param>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public Task DeleteAsync(string userName)
        {
            return DeleteAsync(userName, CancellationToken.None);
        }

        /// <summary>Delete student</summary>
        /// <param name="userName">Unique username</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <exception cref="SwaggerException">A server side error occurred.</exception>
        public async Task DeleteAsync(string userName, CancellationToken cancellationToken)
        {
            var url_ = string.Format("{0}/{1}", BaseUrl, "api/Students/{userName}");

            if (userName == null)
                throw new ArgumentNullException("userName");
            url_ = url_.Replace("{userName}", Uri.EscapeDataString(userName.ToString()));

            var client_ = new HttpClient();
            var request_ = new HttpRequestMessage();
            PrepareRequest(client_, ref url_);
            request_.Method = new HttpMethod("DELETE");
            request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);
            var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseContentRead, cancellationToken).ConfigureAwait(false);
            ProcessResponse(client_, response_);

            var responseData_ = await response_.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
            var status_ = ((int)response_.StatusCode).ToString();

            if (status_ == "404")
            {
                throw new SwaggerException("Not found", status_, responseData_, null);
            }
            else
            if (status_ == "500")
            {
                throw new SwaggerException("Internal Server Error", status_, responseData_, null);
            }
            else
            {
            }

            throw new SwaggerException("The HTTP status code of the response was not expected (" + (int)response_.StatusCode + ").", status_, responseData_, null);
        }

    }



    /// <summary>Student Model</summary>
    [JsonObject(MemberSerialization.OptIn)]
    [GeneratedCode("NJsonSchema", "5.7.6142.39228")]
    public partial class Student : INotifyPropertyChanged
    {
        private string _userName;
        private string _firstName;
        private string _lastName;
        private string _email;
        private DateTime? _dateOfBirth;

        /// <summary>Username</summary>
        [JsonProperty("userName", Required = Required.Always)]
        [Required]
        public string UserName
        {
            get { return _userName; }
            set
            {
                if (_userName != value)
                {
                    _userName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>First Name</summary>
        [JsonProperty("firstName", Required = Required.Always)]
        [Required]
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Last Name (Surname)</summary>
        [JsonProperty("lastName", Required = Required.Always)]
        [Required]
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Email</summary>
        [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>Birth Date</summary>
        [JsonProperty("dateOfBirth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateOfBirth
        {
            get { return _dateOfBirth; }
            set
            {
                if (_dateOfBirth != value)
                {
                    _dateOfBirth = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public static Student FromJson(string data)
        {
            return JsonConvert.DeserializeObject<Student>(data);
        }

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [GeneratedCode("NSwag", "6.17.6146.29531")]
    public class SwaggerException : Exception
    {
        public string StatusCode { get; private set; }

        public byte[] ResponseData { get; private set; }

        public SwaggerException(string message, string statusCode, byte[] responseData, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
            ResponseData = responseData;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: n{0}n{1}", Encoding.UTF8.GetString(ResponseData, 0, ResponseData.Length), base.ToString());
        }
    }

    [GeneratedCode("NSwag", "6.17.6146.29531")]
    public class SwaggerException<TResponse> : SwaggerException
    {
        public TResponse Response { get; private set; }

        public SwaggerException(string message, string statusCode, byte[] responseData, TResponse response, Exception innerException)
            : base(message, statusCode, responseData, innerException)
        {
            Response = response;
        }
    }

}