﻿using System.Collections.Generic;
using System.Linq;
using MediatR;

namespace MySample.Core.Events
{
    public class ModelChanged<T> : INotification
    {
        public ModelChanged(T model, IEnumerable<string> propertiesChanged)
        {
            Model = model;
            PropertiesChanged = propertiesChanged as IReadOnlyList<string> ?? propertiesChanged.ToList();
        }
        
        public T Model { get; }
        public IReadOnlyList<string> PropertiesChanged;
    }
}