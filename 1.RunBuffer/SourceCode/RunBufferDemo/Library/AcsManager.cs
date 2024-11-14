
using System;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using ACS.SPiiPlusNET;

namespace ACSSimDev.SEQ
{
    class AcsManager
    {
        private static AcsManager instance = null;

        public class Cmd
        {
            public const int INIT = 100;
            public const int RUN = 200;
            public const int STOP = 300;
            public const int RESET = 400;

            public const int ERROR = 900;
        }

        public enum ConnType
        {
            SIMULATOR = 0,
            TCPIP = 1
        }

        private bool isConnected = false;

        private int lastErrorCode = 0;
        private string exceptionMessage = string.Empty;

        Api acslib = new Api();

        ACSC_CONNECTION_INFO acsConnInfo;
        
        public AcsManager()
        {
        }

        //SingleTone
        public static AcsManager GetInstance()
        {
            if (instance != null)
                return instance;

            lock (typeof(AcsManager))
            {
                if (instance == null)
                    instance = new AcsManager();
            }
            return instance;
        }


        #region Related Communication Functions
        public bool Connect(ConnType conntype = ConnType.SIMULATOR, string ipAddr = "10.0.0.100", string port = "701")
        {
            if (isConnected)
                return true;

            if (conntype == ConnType.SIMULATOR)
            {
                acslib.OpenCommSimulator();
            }
            else if (conntype == ConnType.TCPIP)
            {
                acslib.OpenCommEthernetTCP(ipAddr, Convert.ToInt32(port));
            }

            Thread.Sleep(10);

            lastErrorCode = acslib.GetLastError();
            if (lastErrorCode != 0)
                return false;

            isConnected = true;

            return true;
        }

        public void Disconnect()
        {
            if (isConnected == false)
                return;

            Thread.Sleep(10);
            acslib.CloseComm();

            isConnected = false;
        }

        public bool IsConnected()
        {
            acsConnInfo = acslib.GetConnectionInfo();

            if (acsConnInfo.Type == ACSC_CONNECTION_TYPE.ACSC_ETHERNET)
                isConnected = true;
            else
                isConnected = false;

            return isConnected;
        }

        private bool CheckApiError()
        {
            lastErrorCode = acslib.GetLastError();
            if (lastErrorCode != 0)
                return false;

            return true;
        }

        public string GetLastErrorString()
        {
            return acslib.GetErrorString(lastErrorCode);
        }
        #endregion

        #region Related Buffer Handle Functions
        public int CheckBufferError(int bufferNum)
        {
            if (acslib == null || isConnected == false)
                return 0;

            return acslib.GetProgramError((ProgramBuffer)bufferNum);
        }

        public bool LoadBuffer(int bufferNo, string programCode)
        {
            if (acslib == null || isConnected == false)
                return false;

            try
            {
                acslib.LoadBuffer((ProgramBuffer)bufferNo, programCode);

                return CheckApiError();
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception : " + e.Message);
                return false;
            }

            return true;
        }

        public bool CompileBuffer(int bufferNo, string programCode)
        {
            if (acslib == null || isConnected == false)
                return false;

            try
            {
                acslib.CompileBuffer((ProgramBuffer)bufferNo);

                return CheckApiError();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
                return false;
            }

            return true;
        }

        public bool RunBuffer(int bufferNo, string label = "")
        {
            if (acslib == null || isConnected == false)
                return false;

            try
            {
                if (string.IsNullOrEmpty(label))
                    acslib.RunBuffer((ProgramBuffer)bufferNo, null);
                else
                    acslib.RunBuffer((ProgramBuffer)bufferNo, label);

                lastErrorCode = acslib.GetLastError();
                if (lastErrorCode != 0)
                    return false;
            }
            catch (Exception e)
            {
                exceptionMessage = "Error: " + e.Message;
                return false;
            }

            return true;
        }
        #endregion

        #region Related motor control Functions
        public void MotorEnable(int axisNo)
        {
            if (acslib == null || isConnected == false)
                return;

            acslib.Enable((Axis)axisNo);
        }

        public void MotorDisable(int axisNo)
        {
            if (acslib == null || isConnected == false)
                return;

            acslib.Disable((Axis)axisNo);
        }

        public void MotorSetParam(int axisNo, double velocity, double acc, double dec, double jerk, double kdec)
        {
            if (acslib == null || isConnected == false)
                return;

            try
            {
                acslib.SetVelocityImm((Axis)axisNo, velocity);
                acslib.SetAccelerationImm((Axis)axisNo, acc);
                acslib.SetDecelerationImm((Axis)axisNo, dec);
                acslib.SetJerkImm((Axis)axisNo, jerk);
                acslib.SetKillDecelerationImm((Axis)axisNo, kdec);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        public void MotorToPoint(int axisNo, double point)
        {
            if (acslib == null || isConnected == false)
                return;

            try
            {
                acslib.ToPoint(MotionFlags.ACSC_NONE, (Axis)axisNo, point);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        public void MotorJog(int axisNo, int dir = 1)
        {
            if (acslib == null || isConnected == false)
                return;

            try
            {
                acslib.Jog(MotionFlags.ACSC_NONE, (Axis)axisNo, dir * 10);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        public void MotorStop(int axisNo)
        {
            if (acslib == null || isConnected == false)
                return;

            try
            {
                acslib.Halt((Axis)axisNo);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        public void MotorSetToZero(int axisNo)
        {
            if (acslib == null || isConnected == false)
                return;

            try
            {
                acslib.SetFPosition((Axis)axisNo, 0);
                //acslib.SetRPosition(())
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }
        #endregion
    }
}