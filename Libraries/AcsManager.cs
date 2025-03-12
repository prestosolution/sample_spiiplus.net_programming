using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ACS.SPiiPlusNET;

namespace ACS.Helpers
{
    internal class AcsManager
    {
        private static AcsManager instance = null;
        private static readonly object _lockObject = new object();

        private Api acslib = new Api();

        private string lastErrStrings;

        public static AcsManager GetInstance()
        {
            if (instance != null)
                return instance;

            lock (_lockObject)//Preventing concurrent object creation due to multi-threading
            {
                if (instance == null)
                    instance = new AcsManager();
            }
            return instance;
        }

        public string GetLastErrorString()
        {
            return lastErrStrings;
        }

        private bool CheckConnection()
        {
            if (GlobalVar.Connected == false)
            {
                lastErrStrings = "The communication connection was not established.";
                return false;
            }

            lastErrStrings = string.Empty;
            return true;
        }

        #region Communication Methods
        public bool Connect(Connect_Type type = Connect_Type.SIMULATOR, string ipAddr = "10.0.0.100", string port = "701")
        {
            try
            {
                if (type == Connect_Type.SIMULATOR)
                {
                    acslib.OpenCommSimulator();//connect with simulator
                }
                else if (type == Connect_Type.TCP)
                {
                    acslib.OpenCommEthernetTCP(               //connect with simulator
                                                ipAddr,                         //input IP address 
                                                Convert.ToInt32(port.Trim())//int port -> convert to int32
                                                );
                }
            }
            catch(Exception ex)
            {
                lastErrStrings = ex.Message;
                return false;
            }

            GlobalVar.Connected = true;
            Thread.Sleep(100);
            return true;
        }

        public bool Disconnect()
        {
            try
            {
                acslib.CloseComm();
            }
            catch(Exception ex)
            {
                lastErrStrings = ex.Message;
                return false;
            }

            GlobalVar.Connected = false;
            Thread.Sleep(10);
            return true;
        }

        public bool Transaction(string prompt, ref string result)
        {
            try
            {
                result = acslib.Transaction(prompt);
            }
            catch (Exception ex)//exception catch
            {
                lastErrStrings = ex.Message;
                result = string.Empty;
                return false;
            }

            return true;
        }
        #endregion

        #region ACSPL+ Program Management Methods
        public bool RunBuffer(ProgramBuffer bufferIndex, string label)
        {
            try
            {
                acslib.RunBuffer((SPiiPlusNET.ProgramBuffer)bufferIndex, label);
            }
            catch (Exception ex)//exception catch
            {
                lastErrStrings = ex.Message;
                return false;
            }

            return true;
        }

        public bool StopBuffer(ProgramBuffer bufferIndex)
        {
            try
            {
                acslib.StopBuffer((SPiiPlusNET.ProgramBuffer)bufferIndex);//stop buffer
            }
            catch (Exception ex)//exception catch
            {
                lastErrStrings = ex.Message;
                return false;
            }

            return true;
        }

        public bool LoadBuffer(ProgramBuffer bufferIndex, string program)
        {
            try
            {
                acslib.LoadBuffer((SPiiPlusNET.ProgramBuffer)bufferIndex, program);//Loads ACSPL+ program to user specified buffer
            }
            catch (Exception ex)//exception catch
            {
                lastErrStrings = ex.Message;
                return false;
            }

            return true;
        }

        public bool CompileBuffer(ProgramBuffer bufferIndex)
        {
            try
            {
                acslib.CompileBuffer((SPiiPlusNET.ProgramBuffer)bufferIndex);//compile buffer with selected index
            }
            catch (Exception ex)//exception catch
            {
                lastErrStrings = ex.Message;
                return false;
            }

            return true;
        }

        public bool UploadBuffer(ProgramBuffer bufferIndex, ref string result)
        {
            try
            {
                result = acslib.UploadBuffer((SPiiPlusNET.ProgramBuffer)bufferIndex);//ACSPL+ program from the specified program buffer
            }
            catch (Exception ex)//exception catch
            {
                lastErrStrings = ex.Message;
                result = string.Empty;
                return false;
            }

            return true;
        }

        public bool ClearBuffer(ProgramBuffer bufferIndex)
        {
            try
            {
                acslib.ClearBuffer((SPiiPlusNET.ProgramBuffer)bufferIndex, 1, 100000);
            }
            catch (Exception ex)//exception catch
            {
                lastErrStrings = ex.Message;
                return false;
            }

            return true;
        }

        public bool GetProgramState(ProgramBuffer bufferIndex, ref ProgramStates result)
        {
            try
            {
                result = (ProgramStates)acslib.GetProgramState((SPiiPlusNET.ProgramBuffer)bufferIndex);
            }
            catch (Exception ex)//exception catch
            {
                result = 0;
                lastErrStrings = ex.Message;
                return false;
            }

            return true;
        }

        #endregion

        #region Read and Write Variables Methods
        public bool ReadFault(ref object result)
        {
            try
            {
                result = acslib.ReadVariableAsVector(
                        "FAULT",                                //변수 : fault
                        SPiiPlusNET.ProgramBuffer.ACSC_NONE,    //특정버퍼의 fault가 아닌 전역의 fault
                        0,                                      //0부터
                        GlobalVar.MAX_AXES - 1,                 //최대 모터 축 수 까지
                        -1,                                     //ACSC_NONE
                        -1                                      //ACSC_NONE 
                        );                                      //-> fault라는 전역 변수를 2차원은 무시하고 1차원 배열만 확인하겠다.(1차원 = right, left)
            }
            catch (Exception ex)//exception catch
            {
                result = null;
                lastErrStrings = ex.Message;
                return false;
            }
            return true;
        }
        #endregion

        #region Inputs/Outputs Access Methods
        public bool GetInputPort(int portNo, ref int result)
        {
            try
            {
                result = acslib.GetInputPort(portNo);
            }
            catch (Exception ex)//exception catch
            {
                result = 0;
                lastErrStrings = ex.Message;
                return false;
            }
            return true;
        }

        public bool GetOutputPort(int portNo, ref int result)
        {
            try
            {
                result = acslib.GetOutputPort(portNo);
            }
            catch (Exception ex)//exception catch
            {
                result = 0;
                lastErrStrings = ex.Message;
                return false;
            }
            return true;
        }

        public bool SetOutputPort(int portNo, int setValue)
        {
            try
            {
                acslib.SetOutputPort(portNo, setValue);
            }
            catch (Exception ex)//exception catch
            {
                lastErrStrings = ex.Message;
                return false;
            }
            return true;
        }

        public bool SetOutputBit(int portNo, int bitNo, int setValue)
        {
            try
            {
                acslib.SetOutput(portNo, bitNo, setValue);
            }
            catch (Exception ex)//exception catch
            {
                lastErrStrings = ex.Message;
                return false;
            }
            return true;
        }
        #endregion

        #region Axis/Motor Management Methods
        public bool Enable(int axis)
        {
            try
            {
                acslib.Enable((Axis)axis);
            }
            catch (Exception ex)//exception catch
            {
                lastErrStrings = ex.Message;
                return false;
            }

            return true;
        }

        public bool Disable(int axis)
        {
            try
            {
                acslib.Disable((Axis)axis);
            }
            catch (Exception ex)//exception catch
            {
                lastErrStrings = ex.Message;
                return false;
            }

            return true;
        }

        public bool Jog(int axis, bool direction, double velocity = 1, bool useCustomSpeed = false)
        {
            try
            {
                int dir = (int)(direction ? GlobalDirection.ACSC_POSITIVE_DIRECTION : GlobalDirection.ACSC_NEGATIVE_DIRECTION);
                if (useCustomSpeed == true)
                {
                    acslib.Jog(
                            MotionFlags.ACSC_AMF_VELOCITY,
                            (Axis)axis,
                            dir * velocity);
                }
                else
                {
                    acslib.Jog(
                            MotionFlags.ACSC_NONE,
                            (Axis)axis,
                            dir * velocity);//기본속도를 사용하여 선택된 축을 -방향으로 jog
                }
            }
            catch (Exception ex)//예외처리하기
            {
                lastErrStrings = ex.Message;
                return false;
            }

            return true;
        }
        #endregion
    }
}
