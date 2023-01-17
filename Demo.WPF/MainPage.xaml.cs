using Demo.WPF.db;
using Microsoft.Win32;
using MyScript.IInk;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Printing;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Wacom.Devices;

namespace Demo.WPF
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    /// 


    public partial class MainPage : Window, INotifyPropertyChanged
    {


        //wacom's variable for connection

        private readonly Wacom.Devices.IInkDeviceInfo _inkDeviceInfo;
        private readonly SynchronizationContext _synchronizationContext;
        private readonly CancellationTokenSource _cancellationToken = new();

        private Wacom.Devices.IDigitalInkDevice _digitalInkDevice;
        private Wacom.Devices.IRealTimeInkService _realTimeInkService;

        private Wacom.Devices.IInkDeviceNotification<Wacom.Devices.BatteryStateChangedEventArgs> _batteryStatedChangedNotification;

        public MainPage(Wacom.Devices.IInkDeviceInfo inkDeviceInfo)
        {
            _inkDeviceInfo = inkDeviceInfo;
            _synchronizationContext = SynchronizationContext.Current;
            InitializeComponent();


            Title = Title + " - " + inkDeviceInfo.DeviceName;

            Loaded += (s, e) => Task.Run(async () => await ConnectAsync().ConfigureAwait(continueOnCapturedContext: false), _cancellationToken.Token);
            Unloaded += (s, e) => Disconnect();
            Closed += (s, e) => Disconnect();

            //Database init


            Debug.WriteLine("abd");
            Engine engine = Engine.Create(MyScript.Certificate.MyCertificate.Bytes);
            //RealTimeInk_StartStop = true;
        }

        //wacom

        private async Task ConnectAsync()
        {
            try
            {
                DeviceStatus = _inkDeviceInfo.TransportProtocol == Wacom.Devices.TransportProtocol.BLE ? "Loading (you may need to press the device's centre button)..." : "Loading...";
                _digitalInkDevice = await Wacom.Devices.InkDeviceFactory.Instance.CreateDeviceAsync(_inkDeviceInfo, App.AppId, true, false, OnDeviceStatusChanged, PairingModeEnabledCallback).ConfigureAwait(continueOnCapturedContext: false);
                DeviceStatus = "Connected";

                //_synchronizationContext.Post(o => tabProperties.Visibility = Visibility.Visible, null);

                GetNotifications();
                await GetServicesAsync().ConfigureAwait(continueOnCapturedContext: false);
                await QueryDevicePropertiesAsync().ConfigureAwait(continueOnCapturedContext: false);

                async Task GetServicesAsync()
                {
                  

                    try
                    {
                        _realTimeInkService = _digitalInkDevice.GetService(Wacom.Devices.InkDeviceService.RealTimeInk) as Wacom.Devices.IRealTimeInkService;
                        if (_realTimeInkService != null)
                        {
                            //_synchronizationContext.Post(o => tabRealTimeInk.Visibility = Visibility.Visible, null);
                            Initialize_RealTimeInk();
                        }
                    }
                    catch (Wacom.Devices.LicensingException)
                    {
                    }

                }

                void GetNotifications()
                {
                    _batteryStatedChangedNotification = _digitalInkDevice.GetNotification<Wacom.Devices.BatteryStateChangedEventArgs>(Wacom.Devices.Notification.Device.BatteryStateChanged);
                    if (_batteryStatedChangedNotification != null)
                    {
                        _batteryStatedChangedNotification.Notification += OnBatteryStatedChanged_Notification;
                    }
                }

            }
            catch (Exception ex)
            {
                DeviceStatus = $"Connect failed: {ex.Message}";
            }
        }

        private async Task<bool> PairingModeEnabledCallback(bool isAuthorized)
        {
            return await Task.Run(() =>
            {
                SynchronizationContext.SetSynchronizationContext(_synchronizationContext);
                var result = MessageBox.Show(messageBoxText: $"PairingModeEnabled.isAuthorized={isAuthorized}. Return true=yes, false=no", caption: "Pairing Mode", button: MessageBoxButton.YesNo);
                return result == MessageBoxResult.Yes;
            }, _cancellationToken.Token).ConfigureAwait(continueOnCapturedContext: false);
        }

        private void Disconnect()
        {
            _cancellationToken.Cancel();

            if (_batteryStatedChangedNotification != null)
            {
                _batteryStatedChangedNotification.Notification -= OnBatteryStatedChanged_Notification;
                _batteryStatedChangedNotification = null;
            }

            if (_digitalInkDevice != null)
            {
                try
                {
                    _digitalInkDevice.Close();
                }
                finally
                {
                    _digitalInkDevice.Dispose();
                    _digitalInkDevice = null;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChangedSync(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnPropertyChanged(string propertyName)
        {
            _synchronizationContext.Post(o => OnPropertyChangedSync(propertyName), null);
        }

        #region Notification Handling
        private void OnBatteryStatedChanged_Notification(object sender, Wacom.Devices.BatteryStateChangedEventArgs e)
        {
        }
        #endregion

        #region DeviceWindow (Status)

        private string _deviceStatus;
        public string DeviceStatus
        {
            get => _deviceStatus;
            private set
            {
                _deviceStatus = value;
                OnPropertyChanged(nameof(DeviceStatus));
            }
        }

        private void OnDeviceStatusChanged(object sender, Wacom.Devices.DeviceStatusChangedEventArgs e)
        {
            DeviceStatus = e.Status.ToString();
        }
        #endregion

        #region DeviceProperties Tab

        private ObservableCollection<DevicePropertyValue> _deviceProperties = new();

        public ObservableCollection<DevicePropertyValue> DeviceWindow_DeviceProperties => _deviceProperties;

        private void Initialize_DeviceProperties()
        {
            foreach (var i in DeviceProperties.Device) _deviceProperties.Add(new DevicePropertyValue(i));
            foreach (var i in DeviceProperties.Digitizer) _deviceProperties.Add(new DevicePropertyValue(i));
            foreach (var i in DeviceProperties.Screen) _deviceProperties.Add(new DevicePropertyValue(i));
            foreach (var i in DeviceProperties.STU) _deviceProperties.Add(new DevicePropertyValue(i));
            foreach (var i in DeviceProperties.SmartPad) _deviceProperties.Add(new DevicePropertyValue(i));
            foreach (var i in DeviceProperties.WacomDriver) _deviceProperties.Add(new DevicePropertyValue(i));
        }


        private async Task QueryDevicePropertiesAsync()
        {
            foreach (var i in _deviceProperties)
            {
                _cancellationToken.Token.ThrowIfCancellationRequested();
                try
                {
                    i.SetValue(await _digitalInkDevice.GetPropertyAsync(i.Name, _cancellationToken.Token).ConfigureAwait(continueOnCapturedContext: false));
                }
                catch
                {
                }
            }
        }

        #endregion

        #region RealTimeInk Tab

        private void Initialize_RealTimeInk()
        {
            _synchronizationContext.Post(RealTimeInk_InitializeSync, null);

            void RealTimeInk_InitializeSync(object _)
            {
                OnPropertyChangedSync(nameof(RealTimeInk_IsStarted));
                OnPropertyChangedSync(nameof(RealTimeInk_Transform_M11));
                OnPropertyChangedSync(nameof(RealTimeInk_Transform_M12));
                OnPropertyChangedSync(nameof(RealTimeInk_Transform_M21));
                OnPropertyChangedSync(nameof(RealTimeInk_Transform_M22));
                OnPropertyChangedSync(nameof(RealTimeInk_Transform_M31));
                OnPropertyChangedSync(nameof(RealTimeInk_Transform_M32));
            }

        }

        private List<Wacom.Devices.RealTimePointReceivedEventArgs> _realTimeInk_PenData = new();
        private Wacom.Devices.RealTimePointReceivedEventArgs _realTimeInk_PenData_Last;

        public bool RealTimeInk_StartStop
        {
            get => _realTimeInkService?.IsStarted ?? false;
            set
            {
                Task.Run(async () =>
                {
                    if (value)
                    {
                        _realTimeInk_PenData.Clear();
                        _realTimeInk_PenData_Last = null;
                        _realTimeInkService.PointReceived += _realTimeInkService_PointReceived;
                        await _realTimeInkService.StartAsync(_cancellationToken.Token).ConfigureAwait(continueOnCapturedContext: false);
                    }
                    else
                    {
                        _realTimeInk_PenData_Last = null;
                        await _realTimeInkService.StopAsync(_cancellationToken.Token).ConfigureAwait(continueOnCapturedContext: false);
                        _realTimeInkService.PointReceived -= _realTimeInkService_PointReceived;
                    }
                    OnPropertyChanged(nameof(RealTimeInk_StartStop));
                    OnPropertyChanged(nameof(RealTimeInk_IsStarted));
                    OnPenDataPropertyChanged();
                }, _cancellationToken.Token);
            }
        }

        public string RealTimeInk_IsStarted => (_realTimeInkService?.IsStarted ?? false) ? "YES" : "NO";

        private void OnPenDataPropertyChanged()
        {
            _synchronizationContext.Post(OnPenDataPropertyChangedSync, null);

            void OnPenDataPropertyChangedSync(object _) // This must be called on the UI thread.
            {
                var last = _realTimeInk_PenData_Last;

                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(RealTimeInk_Count)));

                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(RealTimeInk_Timestamp)));
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(RealTimeInk_Point)));
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(RealTimeInk_Phase)));

                    Debug.WriteLine("ABC");
                    /*
                    OnPenDataPropertyChangedSyncItem(tbRealTimeInk_Pressure, last?.Pressure, nameof(RealTimeInk_Pressure));
                    OnPenDataPropertyChangedSyncItem(tbRealTimeInk_PointRaw, last?.PointRaw, nameof(RealTimeInk_PointRaw));
                    OnPenDataPropertyChangedSyncItem(tbRealTimeInk_PressureRaw, last?.PressureRaw, nameof(RealTimeInk_PressureRaw));
                    OnPenDataPropertyChangedSyncItem(tbRealTimeInk_TimestampRaw, last?.TimestampRaw, nameof(RealTimeInk_TimestampRaw));
                    OnPenDataPropertyChangedSyncItem(tbRealTimeInk_Sequence, last?.Sequence, nameof(RealTimeInk_Sequence));
                    OnPenDataPropertyChangedSyncItem(tbRealTimeInk_Rotation, last?.Rotation, nameof(RealTimeInk_Rotation));
                    OnPenDataPropertyChangedSyncItem(tbRealTimeInk_Azimuth, last?.Azimuth, nameof(RealTimeInk_Azimuth));
                    OnPenDataPropertyChangedSyncItem(tbRealTimeInk_Altitude, last?.Altitude, nameof(RealTimeInk_Altitude));
                    OnPenDataPropertyChangedSyncItem(tbRealTimeInk_Tilt, last?.Tilt, nameof(RealTimeInk_Tilt));
                    OnPenDataPropertyChangedSyncItem(tbRealTimeInk_PenId, last?.PenId, nameof(RealTimeInk_PenId));
                    */
                }

                void OnPenDataPropertyChangedSyncItem<T>(TextBlock textBlock, T? value, string name) where T : struct
                {
                    bool hasValue = value != null && value.HasValue;
                    if (textBlock.IsEnabled || hasValue)
                    {
                        textBlock.IsEnabled = hasValue;
                        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
                    }
                }
            }
        }

        public float RealTimeInk_Transform_M11
        {
            get => _realTimeInkService?.PointTransform.M11 ?? float.NaN;
            set { var v = _realTimeInkService.PointTransform; v.M11 = value; _realTimeInkService.PointTransform = v; OnPropertyChanged(nameof(RealTimeInk_Transform_M11)); }
        }

        public float RealTimeInk_Transform_M12
        {
            get => _realTimeInkService?.PointTransform.M12 ?? float.NaN;
            set { var v = _realTimeInkService.PointTransform; v.M12 = value; _realTimeInkService.PointTransform = v; OnPropertyChanged(nameof(RealTimeInk_Transform_M12)); }
        }
        public float RealTimeInk_Transform_M21
        {
            get => _realTimeInkService?.PointTransform.M21 ?? float.NaN;
            set { var v = _realTimeInkService.PointTransform; v.M21 = value; _realTimeInkService.PointTransform = v; OnPropertyChanged(nameof(RealTimeInk_Transform_M21)); }
        }
        public float RealTimeInk_Transform_M22
        {
            get => _realTimeInkService?.PointTransform.M22 ?? float.NaN;
            set { var v = _realTimeInkService.PointTransform; v.M22 = value; _realTimeInkService.PointTransform = v; OnPropertyChanged(nameof(RealTimeInk_Transform_M22)); }
        }
        public float RealTimeInk_Transform_M31
        {
            get => _realTimeInkService?.PointTransform.M31 ?? float.NaN;
            set { var v = _realTimeInkService.PointTransform; v.M31 = value; _realTimeInkService.PointTransform = v; OnPropertyChanged(nameof(RealTimeInk_Transform_M31)); }
        }
        public float RealTimeInk_Transform_M32
        {
            get => _realTimeInkService?.PointTransform.M32 ?? float.NaN;
            set { var v = _realTimeInkService.PointTransform; v.M32 = value; _realTimeInkService.PointTransform = v; OnPropertyChanged(nameof(RealTimeInk_Transform_M32)); }
        }

        private void _realTimeInkService_PointReceived(object sender, Wacom.Devices.RealTimePointReceivedEventArgs e)
        {
            _realTimeInk_PenData_Last = e;
            _realTimeInk_PenData.Add(_realTimeInk_PenData_Last);
            OnPenDataPropertyChanged();
        }

        public int RealTimeInk_Count => _realTimeInk_PenData.Count;

        private void RealTimeInk_PenData_Clear(object sender, RoutedEventArgs e)
        {
            _realTimeInk_PenData_Last = null;
            _realTimeInk_PenData.Clear();
            OnPenDataPropertyChanged();
        }

        private void RealTimeInk_SavePenData(string fileName)
        {
            try
            {
                using var stream = File.CreateText(fileName);
                stream.WriteLine("Timestamp,PointX,PointY,Phase,Pressure,PointDisplayX,PointDisplayY,PointRawX,PointRawY,PressureRaw,TimestampRaw,Sequence,Rotation,Azimuth,Altitude,TiltX,TiltY,PenId");

                StringBuilder sb = new();
                foreach (var item in _realTimeInk_PenData)
                {
                    sb.Append($"{item.Timestamp.ToString("O")},{item.Point.X,6},{item.Point.Y,6},{item.Phase.ToString(),-11}");
                    sb.Append(item.Pressure.HasValue ? $",{item.Pressure.Value,9}" : ",");

                    sb.Append(item.PointDisplay.HasValue ? $",{item.PointDisplay.Value.X,6},{item.PointDisplay.Value.Y,6}" : ",,");
                    sb.Append(item.PointRaw.HasValue ? $",{item.PointRaw.Value.X,6},{item.PointRaw.Value.Y,6}" : ",,");
                    sb.Append(item.PressureRaw.HasValue ? $",{item.PressureRaw.Value,6}" : ",");
                    sb.Append(item.TimestampRaw.HasValue ? $",{item.TimestampRaw.Value,8}" : ",");
                    sb.Append(item.Sequence.HasValue ? $",{item.Sequence.Value,8}" : ",");
                    sb.Append(item.Rotation.HasValue ? $",{item.Rotation.Value,9}" : ",");
                    sb.Append(item.Azimuth.HasValue ? $",{item.Azimuth.Value,9}" : ",");
                    sb.Append(item.Altitude.HasValue ? $",{item.Altitude.Value,9}" : ",");
                    sb.Append(item.Tilt.HasValue ? $",{item.Tilt.Value.X,9},{item.Tilt.Value.Y,9}" : ",,");
                    sb.Append(item.PenId.HasValue ? $",0x{item.PenId.Value:x8}" : ",");
                    stream.WriteLine(sb.ToString());
                    sb.Clear();
                }
                stream.Close();
            }
            catch (Exception ex)
            {
                _synchronizationContext.Post(o => MessageBox.Show($"Unable to load image: {ex.Message}"), null);
            }
        }

        private void RealTimeInk_PenData_Save(object sender, RoutedEventArgs e)
        {
            if (_realTimeInk_PenData.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Title = "Save PenData",
                    AddExtension = true,
                    DefaultExt = "csv",
                    Filter = "CSV (*.csv)|*.csv",
                    OverwritePrompt = true
                };

                if (saveFileDialog.ShowDialog() == true)
                {
                    Task.Run(() => RealTimeInk_SavePenData(saveFileDialog.FileName), _cancellationToken.Token);
                }
            }
        }

        private string ValueToString<T>(T? value) where T : struct
        {
            return value != null && value.HasValue ? value.ToString() : "";
        }
        private string ValueToHexString(int? value)
        {
            return value != null && value.HasValue ? $"0x{value.Value:x8}" : "";
        }

        public string RealTimeInk_Timestamp => _realTimeInk_PenData_Last?.Timestamp.ToString("O");
        public string RealTimeInk_Point => _realTimeInk_PenData_Last?.Point.ToString();
        public string RealTimeInk_Phase => _realTimeInk_PenData_Last?.Phase.ToString();
        public string RealTimeInk_Pressure => ValueToString(_realTimeInk_PenData_Last?.Pressure);
        public string RealTimeInk_PointDisplay => ValueToString(_realTimeInk_PenData_Last?.PointDisplay);
        public string RealTimeInk_PointRaw => ValueToString(_realTimeInk_PenData_Last?.PointRaw);
        public string RealTimeInk_PressureRaw => ValueToString(_realTimeInk_PenData_Last?.PressureRaw);
        public string RealTimeInk_TimestampRaw => ValueToString(_realTimeInk_PenData_Last?.TimestampRaw);
        public string RealTimeInk_Sequence => ValueToString(_realTimeInk_PenData_Last?.Sequence);
        public string RealTimeInk_Rotation => ValueToString(_realTimeInk_PenData_Last?.Rotation);
        public string RealTimeInk_Azimuth => ValueToString(_realTimeInk_PenData_Last?.Azimuth);
        public string RealTimeInk_Altitude => ValueToString(_realTimeInk_PenData_Last?.Altitude);
        public string RealTimeInk_Tilt => ValueToString(_realTimeInk_PenData_Last?.Tilt);
        public string RealTimeInk_PenId => ValueToHexString(_realTimeInk_PenData_Last?.PenId);
        #endregion
    }


}
