﻿namespace DTO.Common
{
    public class HttpResponseDto
    {
        public dynamic? Data { get; set; }
        public string Error { get; set; }
        public dynamic? Token { get; set; }
    }
}
