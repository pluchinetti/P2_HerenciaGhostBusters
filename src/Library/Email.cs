namespace Herencia
{
    public class Email
    {
        public Person To {get;}
        public string FromAddress {get;}
        public string Subject {get;}
        public string Body {get; set;}

        public Email(Person to, string fromAddress, string subject)
        {
            this.To = to;
            this.FromAddress = fromAddress;
            this.Subject = subject;
        }
    }
}