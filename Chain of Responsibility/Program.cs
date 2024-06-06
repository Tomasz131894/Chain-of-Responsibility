using Chain_of_Responsibility;

class Program
{
    static void Main(string[] args)
    {
        // Tworzenie instancji handlerów
        var technicalHandler = new TechnicalProblemHandler();
        var billingHandler = new BillingInquiryHandler();
        var generalHandler = new GeneralInquiryHandler();

        // Konfiguracja łańcucha handlerów
        technicalHandler.SetSuccessor(billingHandler);
        billingHandler.SetSuccessor(generalHandler);

        // Generowanie różnych typów biletów i przekazywanie ich przez łańcuch
        var tickets = new Ticket[]
        {
            new Ticket("Technical Problem", "Brak dostępu do internetu"),
            new Ticket("Billing Inquiry", "Prośba o wyjaśnienie faktury"),
            new Ticket("General Inquiry", "Godziny otwarcia serwisu")
        };

        foreach (var ticket in tickets)
        {
            technicalHandler.HandleTicket(ticket);
        }
    }
}