namespace GenericList
{
    using System;

    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Class | AttributeTargets.Interface |
        AttributeTargets.Enum | AttributeTargets.Method,
    AllowMultiple = true)]

    public class Version : System.Attribute
    {
        public int Major { get; set; }
        public int Minor { get; set; }

        public Version(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }
    }
}
