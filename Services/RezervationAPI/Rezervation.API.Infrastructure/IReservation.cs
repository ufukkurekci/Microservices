using Rezervation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rezervation.API.Infrastructure
{
	public interface IReservation
	{
		public ReservationDTO GetResByBkgNumber (int bkgNumber);
	}
}
