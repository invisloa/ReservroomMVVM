using Reservroom.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reservroom.ViewModels
{
	public class ReservationListingViewModel : ViewModelBase
	{
		private readonly ObservableCollection<ReservationViewModel> _reservations;

		public ICommand MakeReservationCommand { get; }

		public ReservationListingViewModel()
		{
			_reservations= new ObservableCollection<ReservationViewModel>();
		}

	}
}
