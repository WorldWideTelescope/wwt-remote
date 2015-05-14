using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace WWTRemoteControl
{
    public partial class MainForm : Form
    {
        public static bool ShowConfig = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forceClose = true;
            this.Close();
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (!ShowConfig)
            {
                this.WindowState = FormWindowState.Minimized;
            }



            //if (!Properties.Settings.Default.Master)
            //{
            //    NetControl.Start();
            //}

            netID.Text = Properties.Settings.Default.NetworkID;

            gammaValueA.Text = Properties.Settings.Default.GammaA.ToString();
            gammaValueB.Text = Properties.Settings.Default.GammaB.ToString();

            WatchDog.Checked = Properties.Settings.Default.WatchDogTimer;
            SetMasterState(Properties.Settings.Default.Master);
            MasterCheckbox.Checked = Properties.Settings.Default.Master;

            if (!Properties.Settings.Default.Master)
            {
                NetControl.Start();
            }

            string yourVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text += " " + yourVersion;
        }

        void ShowMasterState(bool isMaster)
        {
            launchAll.Enabled = isMaster;
            killAll.Enabled = isMaster;
            wakeAll.Enabled = isMaster;
            RestartAll.Enabled = isMaster;
            shutdownAll.Enabled = isMaster;
            Landscape0.Enabled = isMaster;
            Portrait270.Enabled = isMaster;
            Portrait90.Enabled = isMaster;
            UpsideDown180.Enabled = isMaster;
            gammaA.Enabled = isMaster;
            gammaB.Enabled = isMaster;
            gammaValueA.Enabled = isMaster;
            gammaValueB.Enabled = isMaster;
            runCommand.Enabled = isMaster;
            commandText.Enabled = isMaster;
            WatchDog.Enabled = !isMaster;
        }

        bool firstInit = true;

        void SetMasterState(bool newMasterState)
        {
            if (Properties.Settings.Default.Master != newMasterState)
            {
                if (Properties.Settings.Default.Master)
                {
                    Properties.Settings.Default.Master = newMasterState;
                    NetControl.Start();
                }
                else
                {
                    Properties.Settings.Default.Master = newMasterState;
                    NetControl.Abort();
                }
            }

            
            ShowMasterState(newMasterState);
        }

        bool is64BitProcess = (IntPtr.Size == 8);
        private void launchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (is64BitProcess)
            {
                Process.Start("C:\\Program Files (x86)\\Microsoft Research\\Microsoft WorldWide Telescope\\wwtexplorer.exe");
            }
            else
            {
                Process.Start("C:\\Program Files\\Microsoft Research\\Microsoft WorldWide Telescope\\wwtexplorer.exe");
            }

        }

        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process[] RunningProcesses = Process.GetProcessesByName("WWTExplorer");
            RunningProcesses[0].CloseMainWindow();
        }

        private void masterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Show();
            
        }

        private void launchAll_Click(object sender, EventArgs e)
        {
            NetControl.SendCommand("LAUNCH", "");
        }


        private void killAll_Click(object sender, EventArgs e)
        {
            NetControl.SendCommand("KILL", "");

        }

        private void runCommand_Click(object sender, EventArgs e)
        {
            NetControl.SendCommand("COMMAND", commandText.Text);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            NetControl.Abort();
            Properties.Settings.Default.Save();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!forceClose)
            {
                this.ShowInTaskbar = false;
                this.Hide();
                e.Cancel = true;
            }
        }
        bool forceClose = false;

        private void wakeAll_Click(object sender, EventArgs e)
        {
            string[] wakeList = Properties.Settings.Default.WolList.Split(new char[] { ',' });
            foreach (string node in wakeList)
            {
                NetControl.WakeFunction(node);
            }
        }

        private void nodeList_Click(object sender, EventArgs e)
        {
            NodeListEditor editor = new NodeListEditor();
            editor.ShowDialog();
        }

        private void shutdownAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to shutdown all clients?", "Shutdown all", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                NetControl.SendCommand("SHUTDOWN", "");
            }

        }

        private void RestartAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to restart all clients?", "Restart all", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                NetControl.SendCommand("RESTART", "");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Update all clients?", "Send Software Update", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                NetControl.SendCommand("UPDATE", "");
            }
        }

        private void netID_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.NetworkID = netID.Text;
        }

        private void netID_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            netID.ReadOnly = !netID.ReadOnly;
        }

        public static void Rotate(int value)
        {
            // initialize the DEVMODE structure
            DEVMODE dm = new DEVMODE();
            dm.dmDeviceName = new string(new char[32]);
            dm.dmFormName = new string(new char[32]);
            dm.dmSize = (short)Marshal.SizeOf(dm);

            if (0 != NativeMethods.EnumDisplaySettings(
            null,
            NativeMethods.ENUM_CURRENT_SETTINGS,
            ref dm))
            {
                // swap width and height
                int temp = dm.dmPelsHeight;
                dm.dmPelsHeight = dm.dmPelsWidth;
                dm.dmPelsWidth = temp;

                //// determine new orientation
                //switch (dm.dmDisplayOrientation)
                //{
                //    case NativeMethods.DMDO_DEFAULT:
                //        dm.dmDisplayOrientation = NativeMethods.DMDO_270;
                //        break;
                //    case NativeMethods.DMDO_270:
                //        dm.dmDisplayOrientation = NativeMethods.DMDO_180;
                //        break;
                //    case NativeMethods.DMDO_180:
                //        dm.dmDisplayOrientation = NativeMethods.DMDO_90;
                //        break;
                //    case NativeMethods.DMDO_90:
                //        dm.dmDisplayOrientation = NativeMethods.DMDO_DEFAULT;
                //        break;
                //    default:
                //        // unknown orientation value
                //        // add exception handling here
                //        break;
                //}

                // determine new orientation
                dm.dmDisplayOrientation = value;


                int iRet = NativeMethods.ChangeDisplaySettings(ref dm, 0);
                if (NativeMethods.DISP_CHANGE_SUCCESSFUL != iRet)
                {
                    // add exception handling here
                }
            }


        }

        private void Landscape0_Click(object sender, EventArgs e)
        {
            NetControl.SendCommand("ROTATE", "0");
        }

        private void Portrait90_Click(object sender, EventArgs e)
        {
            NetControl.SendCommand("ROTATE", "1");
        }

        private void UpsideDown180_Click(object sender, EventArgs e)
        {
            NetControl.SendCommand("ROTATE", "2");
        }

        private void Portrait270_Click(object sender, EventArgs e)
        {
            NetControl.SendCommand("ROTATE", "3");
        }

        private void gammaA_Click(object sender, EventArgs e)
        {
            NetControl.SendCommand("GAMMA", Properties.Settings.Default.GammaA.ToString());
           // SetGamma(Properties.Settings.Default.GammaA);
        }

        private void gammaB_Click(object sender, EventArgs e)
        {
            NetControl.SendCommand("GAMMA", Properties.Settings.Default.GammaB.ToString());
           // SetGamma(Properties.Settings.Default.GammaB);
        }

        private void gammaValueA_Validated(object sender, EventArgs e)
        {
            Properties.Settings.Default.GammaA = double.Parse(gammaValueA.Text);
        }

        private void gammaValueB_Validated(object sender, EventArgs e)
        {
            Properties.Settings.Default.GammaB = double.Parse(gammaValueB.Text);
        }

        private void gammaValueA_Validating(object sender, CancelEventArgs e)
        {
            double gamma = 0;

            if (double.TryParse(gammaValueA.Text, out gamma) && gamma > 0)
            {
                gammaValueA.BackColor = SystemColors.Window;
            }
            else
            {
                gammaValueA.BackColor = Color.Red;
                e.Cancel = true;
            }

        }

        private void gammaValueB_Validating(object sender, CancelEventArgs e)
        {
            double gamma = 0;

            if (double.TryParse(gammaValueB.Text, out gamma) && gamma > 0)
            {
                gammaValueB.BackColor = SystemColors.Window;
            }
            else
            {
                gammaValueB.BackColor = Color.Red;
                e.Cancel = true;
            }
        }

        [DllImport("gdi32.dll")]
        private unsafe static extern bool SetDeviceGammaRamp(Int32 hdc, void* ramp);


        public static ushort Gamma(int val, double gamma)
        {
            return (ushort)Math.Min((int)65535, (int)((65535.0 * Math.Pow(val / 255.0, 1.0 / gamma)) + 0.5));
        }

        internal static unsafe void SetGamma(double p)
        {
            ushort* gArray = stackalloc ushort[3 * 256];
            ushort* idx = gArray;

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 256; i++)
                {
                    ushort arrayVal = Gamma(i, p);
                    *idx = arrayVal;
                    idx++;
                }
            }

            //For some reason, this always returns false?
            bool retVal = SetDeviceGammaRamp(Graphics.FromHwnd(IntPtr.Zero).GetHdc().ToInt32(), gArray);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (NetControl.WWTShouldBeRunning && Properties.Settings.Default.WatchDogTimer)
            {
                Process[] RunningProcesses = Process.GetProcessesByName("WWTExplorer");


                if (RunningProcesses.Length < 1)
                {
                    if (is64BitProcess)
                    {
                        Process.Start("C:\\Program Files (x86)\\Microsoft Research\\Microsoft WorldWide Telescope\\wwtexplorer.exe", "restart");
                    }
                    else
                    {
                        Process.Start("C:\\Program Files\\Microsoft Research\\Microsoft WorldWide Telescope\\wwtexplorer.exe", "restart");
                    }
                }
            }
        }

        private void WatchDog_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.WatchDogTimer = WatchDog.Checked;
        }

        private void MasterCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            SetMasterState(MasterCheckbox.Checked);
        }
    }
    public class NativeMethods
    {
        // PInvoke declaration for EnumDisplaySettings Win32 API
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern int EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref DEVMODE lpDevMode);

        // PInvoke declaration for ChangeDisplaySettings Win32 API
        [DllImport("user32.dll", CharSet = CharSet.Ansi)]
        public static extern int ChangeDisplaySettings(ref DEVMODE lpDevMode, int dwFlags);

        // add more functions as needed …

        // constants
        public const int ENUM_CURRENT_SETTINGS = -1;
        public const int DMDO_DEFAULT = 0;
        public const int DMDO_90 = 1;
        public const int DMDO_180 = 2;
        public const int DMDO_270 = 3;
        public const int DISP_CHANGE_SUCCESSFUL = 0;

        // add more constants as needed …
    }
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    public struct DEVMODE
    {
        public static DEVMODE CreateDevmode()
        {
            DEVMODE dm = new DEVMODE();
            dm.dmDeviceName = new String(new char[32]);
            dm.dmFormName = new String(new char[32]);
            dm.dmSize = (short)Marshal.SizeOf(dm);
            return dm;
        }


        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmDeviceName;

        public short dmSpecVersion;
        public short dmDriverVersion;
        public short dmSize;
        public short dmDriverExtra;
        public int dmFields;
        public int dmPositionX;
        public int dmPositionY;
        public int dmDisplayOrientation;
        public int dmDisplayFixedOutput;
        public short dmColor;
        public short dmDuplex;
        public short dmYResolution;
        public short dmTTOption;
        public short dmCollate;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmFormName;

        public short dmLogPixels;
        public short dmBitsPerPel;
        public int dmPelsWidth;
        public int dmPelsHeight;
        public int dmDisplayFlags;
        public int dmDisplayFrequency;
        public int dmICMMethod;
        public int dmICMIntent;
        public int dmMediaType;
        public int dmDitherType;
        public int dmReserved1;
        public int dmReserved2;
        public int dmPanningWidth;
        public int dmPanningHeight;
    };





    class NetControl
    {
        static NetControl()
        {

        }
        private static Thread listenThread;

        private const int listenPort = 0;

        static UdpClient listener = null;

        public static void Abort()
        {
            running = false;
            if (listener != null)
            {
                listener.Close();
            }
            listener = null;
        }
        [DllImport("user32.dll")]
        public static extern int ExitWindowsEx(int uFlags, int dwReason);

        public static string TargetName = "";
        public static int ErrorCount = 0;

        public static bool WWTShouldBeRunning = false;
        static bool running = true;
        public static void Start()
        {
            if (listener == null)
            {
                running = true;
                listenThread = new Thread(new ThreadStart(listenerThreadFunc));
                listenThread.Start();
            }
        }
        public static string MasterAddress = "127.0.0.1";
        static bool is64BitProcess = (IntPtr.Size == 8);
        public static void listenerThreadFunc()
        {

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US", false);
            while (running)
            {
                GetClient();
                IPEndPoint destinationEP = new IPEndPoint(IPAddress.Any, 8089);
                while (running)
                {
                    try
                    {
                        byte[] bytes = listener.Receive(ref destinationEP);


                        if (bytes.Length > 2)
                        {

                            //Convert Byte to String
                            string sBuffer = Encoding.ASCII.GetString(bytes);
                            string[] values = sBuffer.Split(new char[] { ',' });

                            if (values.Length == 4)
                            {
                                if (values[0] == "WWTCONTROL2" && (values[1] == Properties.Settings.Default.NetworkID))
                                {
                                    MasterAddress = destinationEP.Address.ToString();
                                    switch (values[2])
                                    {
                                        case "LAUNCH":
                                            if (is64BitProcess)
                                            {
                                                Process.Start("C:\\Program Files (x86)\\Microsoft Research\\Microsoft WorldWide Telescope\\wwtexplorer.exe");
                                            }
                                            else
                                            {
                                                Process.Start("C:\\Program Files\\Microsoft Research\\Microsoft WorldWide Telescope\\wwtexplorer.exe");
                                            }
                                            WWTShouldBeRunning = true;
                                            break;
                                        case "KILL":
                                            Process[] RunningProcesses = Process.GetProcessesByName("WWTExplorer");
                                            RunningProcesses[0].CloseMainWindow();
                                            WWTShouldBeRunning = false;
                                            break;
                                        case "COMMAND":
                                            Process.Start(values[3]);
                                            break;
                                        case "SHUTDOWN":
                                            Process.Start("shutdown", "-s -f /t 1");
                                            break;
                                        case "RESTART":
                                            Process.Start("shutdown", "-r -f /t 1");
                                            break;
                                        case "UPDATE":
                                            UpdateSoftware();
                                            break;
                                        case "ROTATE":
                                            MainForm.Rotate(int.Parse(values[3]));
                                            break;
                                        case "GAMMA":
                                            MainForm.SetGamma(double.Parse(values[3]));
                                            break;      
                                    }
                                }
                            }
                        }

                    }
                    catch
                    {
                        if (!running)
                        {
                            return;
                        }
                    }
                }
                listener.Close();
                listener = null;
            }
        }

        public static void UpdateSoftware()
        {
            WebClient client = new WebClient();
            // Get Distortion map
            try
            {
                string url = string.Format("http://{0}:5050/Configuration/images/executable", NetControl.MasterAddress);
                string filename;
                if (is64BitProcess)
                {
                    filename = "C:\\Program Files (x86)\\Microsoft Research\\Microsoft WorldWide Telescope\\wwtexplorer.exe";
                }
                else
                {
                    filename = "C:\\Program Files\\Microsoft Research\\Microsoft WorldWide Telescope\\wwtexplorer.exe";
                }
                Byte[] data = client.DownloadData(url);
                File.WriteAllBytes(filename, data);
            }
            catch
            {
            }

        }

        private static void GetClient()
        {
            try
            {
                listener = new UdpClient(8089);
            }
            catch
            {
                listener = new UdpClient(8091);
            }
        }
        static Socket sockA = null;
        static Socket sockB = null;
        static DateTime lastMessage = DateTime.Now;

        public static void SendCommand(string command, string param)
        {
            if (sockA == null)
            {
                sockA = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
                sockA.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
                IPEndPoint bindEPA = new IPEndPoint(IPAddress.Parse(GetThisHostIP()), 8089);
                sockA.Bind(bindEPA);
            }

            EndPoint destinationEPA = (EndPoint)new IPEndPoint(IPAddress.Broadcast, 8089);

            string output = "WWTCONTROL2" + "," + Properties.Settings.Default.NetworkID + "," + command + "," + param;

            Byte[] header = Encoding.ASCII.GetBytes(output);

            sockA.SendTo(header, destinationEPA);
        }

        public static string GetThisHostIP()
        {
            string hostIp = "127.1.1.1";
            try
            {
                String strHostName = Dns.GetHostName();

                // Find host by name
                IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

                // Enumerate IP addresses
                foreach (IPAddress ipaddress in iphostentry.AddressList)
                {
                    if (ipaddress.AddressFamily == AddressFamily.InterNetwork)
                    {
                        hostIp = ipaddress.ToString();
                        break;
                    }
                }
            }
            catch
            {
            }

            return hostIp;
        }

        public static void WakeFunction(string MAC_ADDRESS)
        {
            if (MAC_ADDRESS.Length != 12)
            {
                return;
            }

            WOLClass client = new WOLClass();
            client.Connect(new
               IPAddress(0xffffffff),  //255.255.255.255  i.e broadcast
               0x2fff); // port=12287 let's use this one 
            client.SetClientToBrodcastMode();
            //set sending bites
            int counter = 0;
            //buffer to be send
            byte[] bytes = new byte[1024];   // more than enough :-)
            //first 6 bytes should be 0xFF
            for (int y = 0; y < 6; y++)
                bytes[counter++] = 0xFF;
            //now repeate MAC 16 times
            for (int y = 0; y < 16; y++)
            {
                int i = 0;
                for (int z = 0; z < 6; z++)
                {
                    bytes[counter++] =
                        byte.Parse(MAC_ADDRESS.Substring(i, 2),
                        NumberStyles.HexNumber);
                    i += 2;
                }
            }

            //now send wake up packet
            int reterned_value = client.Send(bytes, 1024);
        }
    }

    public class WOLClass : UdpClient
    {
        public WOLClass()
            : base()
        { }
        //this is needed to send broadcast packet
        public void SetClientToBrodcastMode()
        {
            if (this.Active)
                this.Client.SetSocketOption(SocketOptionLevel.Socket,
                                          SocketOptionName.Broadcast, 0);
        }
    }

}
