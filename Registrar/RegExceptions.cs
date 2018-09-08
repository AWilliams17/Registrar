﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Registrar
{
    public class RegistryNotSetException : Exception
    {
        public RegistryNotSetException(string message) : base(message) {}
    }

    public class RegistryLoadException : Exception
    {
        public RegistryLoadException(string message) : base(message) { }
    }

    public class RegistryOptionException : Exception
    {
        public RegistryOptionException(string message) : base(message) { }
    }
}