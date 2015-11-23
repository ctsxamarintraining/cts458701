using System;
using System.ComponentModel;
namespace FormsApp2
{
	public class MyBaseViewModel : INotifyPropertyChanged
	{
		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		#endregion

		protected void RaisePropertyChanged(string propertyName)
		{
			if (PropertyChanged != null) {
				PropertyChanged.Invoke (this, new PropertyChangedEventArgs (propertyName));
			}

		}



		public MyBaseViewModel ()
		{
		}



	}
}

