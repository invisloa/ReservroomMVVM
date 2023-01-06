using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservroom.Models
{

	public class Hotel
	{
		private readonly ReservationBook _reservationBook;

		public string Name { get; }

		public Hotel()
		{
			_reservationBook = new ReservationBook();
		}
	}
}
