using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ACS.SPiiPlusNET;

namespace ACS.Helpers
{
    internal class AcsManager : IDisposable
    {
        private static AcsManager instance = null;
        private static readonly object _lockObject = new object();

        private bool disposed = false;

        private Api acslib = new Api();

        private string lastErrStrings;

        #region back and force
        private class BackAndForceMove
        {
            public Thread threadHandle = null;

            public bool isAlive
            {
                get {
                    if (threadHandle == null)
                        return false;

                    return threadHandle.IsAlive; 
                }
            }

            public bool isRunning;

            public double targetPosA;
            public double targetPosB;
            public int dwell;

            public BackAndForceMove()
            {
                threadHandle = null;
                isRunning = false;

                targetPosA = 0;
                targetPosB = 0;
                dwell = 0;
            }
        }

        BackAndForceMove backAndForceMoveObject;
        #endregion

        #region MoveProfile Class Define
        public class MoveProfile{
            public double Velocity;
            public double Acceleration;
            public double Deceleration;
            public double killDeceleration;
            public double Jerk;

            public MoveProfile()
            {
                Velocity = 1;
                Acceleration = 1;
                Deceleration = 1;
                killDeceleration = 1;
                Jerk = 1;
            }
        }

        public MoveProfile[] moveProfile;
        #endregion

        #region AxisStatus Class Define
        public class AxisStatus
        {
            public MotorStates MotoStatesFlag;
            public double RPosition;
            public double FPosition;
            public double PE;
            public double FVelocity;
        }

        public AxisStatus[] axisStatus;
        #endregion


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

        public void Dispose()
        {
            if(!disposed)
            {
                disposed = true;
                backAndForceMoveObject.isRunning = false;
                Thread.Sleep(100);
            }
        }

        public AcsManager()
        {
            moveProfile = new MoveProfile[GlobalVar.MAX_AXES];
            for(int i=0; i<GlobalVar.MAX_AXES; i++)
            {
                moveProfile[i] = new MoveProfile();
            }

            axisStatus = new AxisStatus[GlobalVar.MAX_AXES];
            for (int i = 0; i < GlobalVar.MAX_AXES; i++)
            {
                axisStatus[i] = new AxisStatus();
            }

            backAndForceMoveObject = new BackAndForceMove();
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

        public bool Jog(int axis, bool direction, double velocity = 1)
        {
            try
            {
                int moveDir = (int)(direction ? GlobalDirection.ACSC_POSITIVE_DIRECTION : GlobalDirection.ACSC_NEGATIVE_DIRECTION);
                if (velocity < 0)
                    velocity = Math.Abs(velocity);

                if (velocity != 1)
                {
                    acslib.Jog(
                            MotionFlags.ACSC_AMF_VELOCITY,
                            (Axis)axis,
                            moveDir * velocity);
                }
                else
                {
                    acslib.Jog(
                            MotionFlags.ACSC_NONE,
                            (Axis)axis,
                            moveDir * velocity);//기본속도를 사용하여 선택된 축을 -방향으로 jog
                }
            }
            catch (Exception ex)//예외처리하기
            {
                lastErrStrings = ex.Message;
                return false;
            }
            return true;
        }

        public bool SetFPosition(int axis)
        {
            try
            {
                acslib.SetFPosition((Axis)axis, 0);
            }
            catch (Exception ex)//예외처리하기
            {
                lastErrStrings = ex.Message;
                return false;
            }

            return true;
        }

        public bool ToPoint(int axis, double targetPos, bool relativeMove = false)
        {
            try
            {
                if(relativeMove)
                {
                    acslib.ToPoint(MotionFlags.ACSC_AMF_RELATIVE, (Axis)axis, targetPos/*distance*/);
                }
                else //absolute move
                {
                    acslib.ToPoint(MotionFlags.ACSC_NONE, (Axis)axis, targetPos);
                }
            }
            catch (Exception ex) //exception
            {
                lastErrStrings = ex.Message;
                return false;
            }

            return true;
        }

        public bool Halt(int axis)
        {
            try
            {
                acslib.Halt((Axis)axis);
            }
            catch (Exception ex)//그 외 예외는 표시
            {
                lastErrStrings = ex.Message;
                return false;
            }

            return true;
        }

        public bool ReadMoveProfile(int axis)
        {
            try
            {
                moveProfile[axis].Velocity = acslib.GetVelocity((Axis)axis);
                moveProfile[axis].Acceleration = acslib.GetAcceleration((Axis)axis);
                moveProfile[axis].Deceleration = acslib.GetDeceleration((Axis)axis);
                moveProfile[axis].killDeceleration = acslib.GetKillDeceleration((Axis)axis);
                moveProfile[axis].Jerk = acslib.GetJerk((Axis)axis);
            }
            catch (Exception ex)
            {
                lastErrStrings = ex.Message;
                return false;
            }

            return true;
        }

        public bool ReadMoveProfileAll()
        {
            try
            {
                for(int i=0; i<GlobalVar.MAX_AXES; i++)
                {
                    moveProfile[i].Velocity = acslib.GetVelocity((Axis)i);
                    moveProfile[i].Acceleration = acslib.GetAcceleration((Axis)i);
                    moveProfile[i].Deceleration = acslib.GetDeceleration((Axis)i);
                    moveProfile[i].killDeceleration = acslib.GetKillDeceleration((Axis)i);
                    moveProfile[i].Jerk = acslib.GetJerk((Axis)i);
                }
            }
            catch (Exception ex)
            {
                lastErrStrings = ex.Message;
                return false;
            }

            return true;
        }

        public bool WriteMoveProfile(int axis, MoveProfile setMoveProfile)
        {
            try
            {
                acslib.SetVelocityImm((Axis)axis, setMoveProfile.Velocity);
                acslib.SetAcceleration((Axis)axis, setMoveProfile.Acceleration);
                acslib.SetDecelerationImm((Axis)axis, setMoveProfile.Deceleration);
                acslib.SetKillDeceleration((Axis)axis, setMoveProfile.killDeceleration);
                acslib.SetJerk((Axis)axis, setMoveProfile.Jerk);
            }
            catch (Exception ex)
            {
                lastErrStrings = ex.Message;
                return false;
            }

            return true;
        }

        public bool UpdateAxisStatus(int axis)
        {
            try
            {
                axisStatus[axis].MotoStatesFlag = (MotorStates)acslib.GetMotorState((Axis)axis);
                axisStatus[axis].RPosition = acslib.GetRPosition((Axis)axis);
                axisStatus[axis].FPosition = acslib.GetFPosition((Axis)axis);
                axisStatus[axis].FVelocity = acslib.GetFVelocity((Axis)axis);

                object posErr = acslib.ReadVariableAsVector("PE", SPiiPlusNET.ProgramBuffer.ACSC_NONE, axis, axis);
                axisStatus[axis].PE = ((double[])posErr)[0];
            }
            catch (Exception ex)
            {
                lastErrStrings = ex.Message;
                return false;
            }

            return true;
        }

        public bool UpdateAxisStatusAll()
        {
            try
            {
                object posErr = acslib.ReadVariableAsVector("PE", SPiiPlusNET.ProgramBuffer.ACSC_NONE, 0, GlobalVar.MAX_AXES - 1);

                for (int i=0; i<GlobalVar.MAX_AXES; i++)
                {
                    axisStatus[i].MotoStatesFlag = (MotorStates)acslib.GetMotorState((Axis)i);
                    axisStatus[i].RPosition = acslib.GetRPosition((Axis)i);
                    axisStatus[i].FPosition = acslib.GetFPosition((Axis)i);
                    axisStatus[i].FVelocity = acslib.GetFVelocity((Axis)i);
                    axisStatus[i].PE = ((double[])posErr)[i];
                }
            }
            catch (Exception ex)
            {
                lastErrStrings = ex.Message;
                return false;
            }

            return true;
        }

        public bool WaitForMotionEnd(int axis, int timeOut = 20000)
        { 
            try
            {
                acslib.WaitMotionEnd((Axis)axis, timeOut);//Maximum Wait Time 20sec
            }
            catch (Exception ex)//그 외 예외는 표시
            {
                lastErrStrings = ex.Message;
                return false;
            }
            return true;
        }
        #endregion

        #region Back and Forth Move
        public bool BackAndForthMoveStart(int axis, double targetA, double targetB, int dwell=1)
        {
            try
            {
                if (backAndForceMoveObject.threadHandle == null || !backAndForceMoveObject.isAlive)
                {
                    backAndForceMoveObject.targetPosA = targetA;
                    backAndForceMoveObject.targetPosB = targetB;
                    backAndForceMoveObject.dwell = dwell;

                    backAndForceMoveObject.threadHandle = new Thread(new ParameterizedThreadStart(BackAndForthMoveFunction));

                    backAndForceMoveObject.threadHandle.IsBackground = true;
                    backAndForceMoveObject.threadHandle.Start(axis);
                }
            }
            catch (Exception ex) //Exception
            {
                lastErrStrings = ex.Message;
                return false;
            }
            return true;
        }

        public bool BackAndForthMoveStop(int axis)
        {
            try
            {
                Halt(axis);
                backAndForceMoveObject.isRunning = false;
                backAndForceMoveObject.threadHandle?.Abort();
                backAndForceMoveObject.threadHandle = null;
            }
            catch (Exception ex) //Exception
            {
                lastErrStrings = ex.Message;
                return false;
            }
            return true;
        }

        private void BackAndForthMoveFunction(object objAxis)
        {
            int axis = (int)objAxis;
            backAndForceMoveObject.isRunning = true;

            while (backAndForceMoveObject.isRunning)
            {
                ToPoint(axis, backAndForceMoveObject.targetPosA);
                WaitForMotionEnd(axis);
                Thread.Sleep(backAndForceMoveObject.dwell); //sleep

                ToPoint(axis, backAndForceMoveObject.targetPosB);
                WaitForMotionEnd(axis);
                Thread.Sleep(backAndForceMoveObject.dwell); //sleep
            }
        }
        #endregion
    }
}
