using System;

namespace dotnet_cli_usage_class_lib
{
    public class Class1
    {
        public string Message {get; set;}

        public Class1() {
            this.Message = "Hello from class library 'Class1'!";
        }

        public string GetMessage() {
            return this.Message;
        }
    }
}
