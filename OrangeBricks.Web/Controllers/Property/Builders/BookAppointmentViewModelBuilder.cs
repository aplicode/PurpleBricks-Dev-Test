using OrangeBricks.Web.Controllers.Property.ViewModels;
using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Property.Builders
{
    public class BookAppointmentViewModelBuilder
    {
        private readonly IOrangeBricksContext _context;

        public BookAppointmentViewModelBuilder(IOrangeBricksContext context)
        {
            _context = context;
        }

        public BookAppointmentViewModel Build(int id, string buyerUserId, string appointmentInfo)
        {
            var property = _context.Properties.Find(id);

            return new BookAppointmentViewModel
            {
                PropertyId = property.Id,
                PropertyType = property.PropertyType,
                StreetName = property.StreetName,
                Offer = 100000, // TODO: property.SuggestedAskingPrice
                BuyerUserId = buyerUserId,
                AppointmentInfo = appointmentInfo
            };
        }
    }
}