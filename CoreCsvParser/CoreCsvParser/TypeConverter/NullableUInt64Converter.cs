﻿// Copyright (c) Philipp Wagner and Joel Mueller. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Globalization;

namespace CoreCsvParser.TypeConverter
{
    public class NullableUInt64Converter : NullableInnerConverter<UInt64>
    {
        public NullableUInt64Converter()
            : base(new UInt64Converter())

        {
        }

        public NullableUInt64Converter(IFormatProvider formatProvider)
            : base(new UInt64Converter(formatProvider))
        {
        }

        public NullableUInt64Converter(IFormatProvider formatProvider, NumberStyles numberStyles)
            : base(new UInt64Converter(formatProvider, numberStyles))
        {
        }
    }
}
