using System;
using System.Collections.Generic;
using OrangeBricks.Web.Models;

namespace OrangeBricks.Web.Controllers.Property.Commands
{
    public class BookAppointmentCommandHandler
    {
        private readonly IOrangeBricksContext _context;

        public BookAppointmentCommandHandler(IOrangeBricksContext context)
        {
            _context = context;
        }

        public void Handle(BookAppointmentCommand command)
        {
            var property = _context.Properties.Find(command.PropertyId);

            var offer = new Offer
            {
                Amount = command.Offer,
                Status = OfferStatus.Pending,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                BuyerUserId = command.BuyerUserId,
                AppointmentInfo = command.AppointmentInfo
            };

            if (property.Offers == null)
            {
                property.Offers = new List<Offer>();
            }

            property.Offers.Add(offer);

            _context.SaveChanges();
        }
    }
}