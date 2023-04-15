using Rezervation.API.Infrastructure;
using Rezervation.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervation.API.Service
{
	public class ReservationService : IReservation
	{
		public ReservationDTO GetResByBkgNumber(int bkgNumber)
		{
			return new ReservationDTO {
				Id = (new Random().Next(100)),
				Amount = (new Random().Next(1000)),
				CheckinDate = DateTime.Now.Date.AddDays(30),
				CheckoutDate = DateTime.Now.Date.AddDays(37),
				BkgDate = DateTime.Now.Date,
				BkgNumber = bkgNumber 

			};
		}
	}
}
