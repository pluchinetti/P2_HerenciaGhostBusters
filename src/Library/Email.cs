namespace Herencia
{
    public class Email
    {
        public string ToAddress {get;}
        public string FromAddress {get;}
        public string Subject {get;}
        public string Body {get; set;}

        public Email(string toAddress, string fromAddress, string subject)
        {
            this.ToAddress = toAddress;
            this.FromAddress = fromAddress;
            this.Subject = subject;
        }
    }
}