using PaymentContext.Shared.ValueObject;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public string Adrress { get; set; }

        public Email(string adrress)
        {
            Adrress = adrress;
        }
    }
}