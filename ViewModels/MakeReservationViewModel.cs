using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reservroom.ViewModels
{
	public class MakeReservationViewModel : ViewModelBase
	{
		private string _username;
		private int _roomNumber;
		private int _floorNumber;
		public DateTime _startDate;
		public DateTime _endDate;


		public string Username
		{
			get
			{
				return _username;
			}
			set
			{
				_username = value;
				OnPropertyChanged(nameof(_username));
			}
		}
		public int RoomNumber
		{
			get
			{
				return _roomNumber;
			}
			set
			{
				_roomNumber = value;
				OnPropertyChanged(nameof(_roomNumber));
			}
		}
		public int FloorNumber
		{
			get
			{
				return _floorNumber;
			}
			set
			{
				_floorNumber = value;
				OnPropertyChanged(nameof(_floorNumber));
			}
		}
		public DateTime StartDate
		{
			get
			{
				return _startDate;
			}
			set
			{
				_startDate = value;
				OnPropertyChanged(nameof(_startDate));
			}
		}

		public DateTime EndDate
		{
			get
			{
				return _endDate;
			}
			set
			{
				_endDate = value;
				OnPropertyChanged(nameof(_endDate));
			}
		}

		public ICommand SubmitCommand { get; }
		public ICommand CancelCommand { get; }

		public MakeReservationViewModel()
		{

		}





	}
}
