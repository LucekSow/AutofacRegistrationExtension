using System;
using System.Collections.Generic;

namespace AutofacRegistrationExtension.Entity
{
    public class RegisterAsTypeEntity
    {
        public Type OriginType { get; set; }
        public IEnumerable<Type> RegisterType { get; set; }
    }
}