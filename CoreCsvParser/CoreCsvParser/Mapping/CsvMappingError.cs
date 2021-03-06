﻿// Copyright (c) Philipp Wagner and Joel Mueller. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.


namespace CoreCsvParser.Mapping
{
    public readonly struct CsvMappingError
    {
        public CsvMappingError(int colIndex, string message)
        {
            ColumnIndex = colIndex;
            Message = message;
        }

        public readonly int ColumnIndex;

        public readonly string Message;

        public override string ToString()
        {
            return $"CsvMappingError (ColumnIndex = {ColumnIndex}, Message = {Message})";
        }
    }
}
