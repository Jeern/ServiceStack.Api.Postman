﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServiceStack.Api.Postman.Types
{
    public class PostmanRequest
    {
        public string CollectionId { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Url { get; set; }

        public string Method { get; set; }

        public string Headers { get; set; }

        public string DataMode { get; set; }

        public long Timestamp { get; set; }

        public long Time { get; set; }

        public int Version { get; set; }

        public PostmanData[] Data { get; set; }

        public Dictionary<string, string> PathVariables { get; set; }

        public string[] Responses { get; set; }

        [IgnoreDataMember]
        public string Folder { get; set; }
    }
}