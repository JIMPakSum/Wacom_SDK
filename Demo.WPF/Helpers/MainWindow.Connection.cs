using System;
using System.Windows.Media;

namespace Demo.WPF
{
	public class Connection
	{
		private readonly Wacom.Devices.IInkDeviceInfo _inkDeviceInfo;
		private DeviceWindow _deviceWindow;

		//Newly added
		private MainPage _mainPage;

		public string Id => _inkDeviceInfo.Id;
		public ImageSource TransportImage => App.TransportImage(_inkDeviceInfo.TransportProtocol);
		public string DeviceName => _inkDeviceInfo.DeviceName;

		public Connection(Wacom.Devices.IInkDeviceInfo inkDeviceInfo)
		{
			_inkDeviceInfo = inkDeviceInfo;
			_deviceWindow = null;
		}

		public void Close()
		{
			if (_deviceWindow != null)
			{
				_deviceWindow.Close();
				_deviceWindow = null;
			}
		}

		public void ConnectOrBringToFront()
		{
			if (_deviceWindow == null)
			{
				_deviceWindow = new DeviceWindow(_inkDeviceInfo);
				_deviceWindow.Closed += (o,e) => _deviceWindow = null;
				_deviceWindow.Show();
			}
			else
			{
				_deviceWindow.Activate();
			}
		}

        public void ConnectToMainPage()
        {
            if (_mainPage == null)
            {
                _mainPage = new MainPage(_inkDeviceInfo);
                _mainPage.Closed += (o, e) => _mainPage = null;
                _mainPage.Show();
            }
            else
            {
                _mainPage.Activate();
            }
        }
    }
}