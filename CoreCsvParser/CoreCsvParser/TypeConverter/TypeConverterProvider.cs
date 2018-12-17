﻿// Copyright (c) Philipp Wagner and Joel Mueller. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using CoreCsvParser.Exceptions;

namespace CoreCsvParser.TypeConverter
{
    public class TypeConverterProvider : ITypeConverterProvider
    {
        private readonly IDictionary<Type, ITypeConverter> typeConverters;

        public TypeConverterProvider()
        {
            typeConverters = new Dictionary<Type, ITypeConverter>();

            Add(new BoolConverter());
            Add(new ByteConverter());
            Add(new DateTimeConverter());
            Add(new DecimalConverter());
            Add(new DoubleConverter());
            Add(new GuidConverter());
            Add(new Int16Converter());
            Add(new Int32Converter());
            Add(new Int64Converter());
            Add(new NullableBoolConverter());
            Add(new NullableByteConverter());
            Add(new NullableDateTimeConverter());
            Add(new NullableDecimalConverter());
            Add(new NullableDoubleConverter());
            Add(new NullableGuidConverter());
            Add(new NullableInt16Converter());
            Add(new NullableInt32Converter());
            Add(new NullableInt64Converter());
            Add(new NullableSByteConverter());
            Add(new NullableSingleConverter());
            Add(new NullableTimeSpanConverter());
            Add(new NullableUInt16Converter());
            Add(new NullableUInt32Converter());
            Add(new NullableUInt64Converter());
            Add(new SByteConverter());
            Add(new SingleConverter());
            Add(new StringConverter());
            Add(new TimeSpanConverter());
            Add(new UInt16Converter());
            Add(new UInt32Converter());
            Add(new UInt64Converter());
        }

        public TypeConverterProvider Add<TTargetType>(ITypeConverter<TTargetType> typeConverter)
        {
            if (!typeConverters.TryAdd(typeConverter.TargetType, typeConverter))
            {
                throw new CsvTypeConverterAlreadyRegisteredException($"Duplicate TypeConverter registration for Type {typeConverter.TargetType}.");
            }

            return this;
        }
        
        public ITypeConverter<TTargetType> Resolve<TTargetType>()
        {
            Type targetType = typeof(TTargetType);

            if (!typeConverters.TryGetValue(targetType, out ITypeConverter typeConverter))
            {
                throw new CsvTypeConverterNotRegisteredException($"No TypeConverter registered for Type {targetType}.");
            }

            return (ITypeConverter<TTargetType>)typeConverter;
        }
    }
}