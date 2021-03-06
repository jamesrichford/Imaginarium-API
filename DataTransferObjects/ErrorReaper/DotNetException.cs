﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ErrorReaper.DataTransferObjects
{
    [DataContract]
    public class DotNetException
    {
        [DataMember]
        public Guid Id;

        [DataMember]
        public string Message;

        [DataMember]
        public string StackTrace;

        [DataMember]
        public DotNetException InnerException;
    }
}
