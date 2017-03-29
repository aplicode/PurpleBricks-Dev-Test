namespace OrangeBricks.Web.Controllers.Property.Commands
{
    public class BookAppointmentCommand
    {
        public int PropertyId { get; set; }

        public int Offer { get; set; }

        public string BuyerUserId { get; set; }

        public string AppointmentInfo { get; set; }
    }
}