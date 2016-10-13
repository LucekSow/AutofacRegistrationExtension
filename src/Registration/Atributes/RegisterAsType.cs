using System;

namespace AutofacRegistrationExtension.Atributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class RegisterAsType : Attribute
    {
        public RegisterAsType(Type registerType)
        {
            Type = registerType;
        }

        public Type Type { get; }
    }
}