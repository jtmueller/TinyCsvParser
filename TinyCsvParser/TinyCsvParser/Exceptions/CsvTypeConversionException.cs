﻿// Copyright (c) Philipp Wagner. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace TinyCsvParser.Exceptions
{
    [Serializable]
    public class CsvTypeConversionException : Exception
    {
        public CsvTypeConversionException()
            : base()
        {
        }

        public CsvTypeConversionException(string message)
            : base(message)
        {
        }

        public CsvTypeConversionException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected CsvTypeConversionException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}