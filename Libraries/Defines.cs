using System;

namespace ACS.Helpers
{
    public enum Connect_Type
    {
        SIMULATOR = 0,
        TCP = 1
    }

    #region ACS definitions by-pass
    public enum ProgramBuffer
    {
        ACSC_BUFFER_ALL = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_ALL,
        ACSC_NONE = SPiiPlusNET.ProgramBuffer.ACSC_NONE,
        ACSC_BUFFER_0 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_0,
        ACSC_BUFFER_1 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_1,
        ACSC_BUFFER_2 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_2,
        ACSC_BUFFER_3 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_3,
        ACSC_BUFFER_4 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_4,
        ACSC_BUFFER_5 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_5,
        ACSC_BUFFER_6 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_6,
        ACSC_BUFFER_7 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_7,
        ACSC_BUFFER_8 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_8,
        ACSC_BUFFER_9 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_9,
        ACSC_BUFFER_10 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_10,
        ACSC_BUFFER_11 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_11,
        ACSC_BUFFER_12 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_12,
        ACSC_BUFFER_13 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_13,
        ACSC_BUFFER_14 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_14,
        ACSC_BUFFER_15 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_15,
        ACSC_BUFFER_16 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_16,
        ACSC_BUFFER_17 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_17,
        ACSC_BUFFER_18 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_18,
        ACSC_BUFFER_19 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_19,
        ACSC_BUFFER_20 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_20,
        ACSC_BUFFER_21 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_21,
        ACSC_BUFFER_22 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_22,
        ACSC_BUFFER_23 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_23,
        ACSC_BUFFER_24 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_24,
        ACSC_BUFFER_25 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_25,
        ACSC_BUFFER_26 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_26,
        ACSC_BUFFER_27 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_27,
        ACSC_BUFFER_28 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_28,
        ACSC_BUFFER_29 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_29,
        ACSC_BUFFER_30 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_30,
        ACSC_BUFFER_31 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_31,
        ACSC_BUFFER_32 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_32,
        ACSC_BUFFER_33 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_33,
        ACSC_BUFFER_34 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_34,
        ACSC_BUFFER_35 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_35,
        ACSC_BUFFER_36 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_36,
        ACSC_BUFFER_37 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_37,
        ACSC_BUFFER_38 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_38,
        ACSC_BUFFER_39 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_39,
        ACSC_BUFFER_40 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_40,
        ACSC_BUFFER_41 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_41,
        ACSC_BUFFER_42 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_42,
        ACSC_BUFFER_43 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_43,
        ACSC_BUFFER_44 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_44,
        ACSC_BUFFER_45 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_45,
        ACSC_BUFFER_46 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_46,
        ACSC_BUFFER_47 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_47,
        ACSC_BUFFER_48 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_48,
        ACSC_BUFFER_49 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_49,
        ACSC_BUFFER_50 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_50,
        ACSC_BUFFER_51 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_51,
        ACSC_BUFFER_52 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_52,
        ACSC_BUFFER_53 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_53,
        ACSC_BUFFER_54 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_54,
        ACSC_BUFFER_55 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_55,
        ACSC_BUFFER_56 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_56,
        ACSC_BUFFER_57 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_57,
        ACSC_BUFFER_58 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_58,
        ACSC_BUFFER_59 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_59,
        ACSC_BUFFER_60 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_60,
        ACSC_BUFFER_61 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_61,
        ACSC_BUFFER_62 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_62,
        ACSC_BUFFER_63 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_63,
        ACSC_BUFFER_64 = SPiiPlusNET.ProgramBuffer.ACSC_BUFFER_64
    }

    [Flags]
    public enum ProgramStates
    {
        ACSC_ALL = SPiiPlusNET.ProgramStates.ACSC_ALL,
        ACSC_NONE = SPiiPlusNET.ProgramStates.ACSC_NONE,
        ACSC_PST_COMPILED = SPiiPlusNET.ProgramStates.ACSC_PST_COMPILED,
        ACSC_PST_RUN = SPiiPlusNET.ProgramStates.ACSC_PST_RUN,
        ACSC_PST_SUSPEND = SPiiPlusNET.ProgramStates.ACSC_PST_SUSPEND,
        ACSC_PST_DEBUG = SPiiPlusNET.ProgramStates.ACSC_PST_DEBUG,
        ACSC_PST_AUTO = SPiiPlusNET.ProgramStates.ACSC_PST_AUTO
    }

    [Flags]
    public enum SafetyControlMasks : uint
    {
        ACSC_NONE = SPiiPlusNET.SafetyControlMasks.ACSC_NONE,
        ACSC_SAFETY_RL = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_RL,
        ACSC_SAFETY_LL = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_LL,
        ACSC_SAFETY_NETWORK = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_NETWORK,
        ACSC_SAFETY_HOT = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_HOT,
        ACSC_SAFETY_SRL = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_SRL,
        ACSC_SAFETY_SLL = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_SLL,
        ACSC_SAFETY_ENCNC = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_ENCNC,
        ACSC_SAFETY_ENC2NC = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_ENC2NC,
        ACSC_SAFETY_DRIVE = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_DRIVE,
        ACSC_SAFETY_ENC = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_ENC,
        ACSC_SAFETY_ENC2 = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_ENC2,
        ACSC_SAFETY_PE = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_PE,
        ACSC_SAFETY_CPE = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_CPE,
        ACSC_SAFETY_VL = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_VL,
        ACSC_SAFETY_AL = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_AL,
        ACSC_SAFETY_CL = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_CL,
        ACSC_SAFETY_SP = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_SP,
        ACSC_SAFETY_STO = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_STO,
        ACSC_SAFETY_HSSINC = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_HSSINC,
        ACSC_SAFETY_EXTNT = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_EXTNT,
        ACSC_SAFETY_TEMP = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_TEMP,
        ACSC_SAFETY_PROG = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_PROG,
        ACSC_SAFETY_MEM = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_MEM,
        ACSC_SAFETY_TIME = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_TIME,
        ACSC_SAFETY_ES = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_ES,
        ACSC_SAFETY_INT = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_INT,
        ACSC_SAFETY_INTGR = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_INTGR,
        ACSC_SAFETY_FAILURE = SPiiPlusNET.SafetyControlMasks.ACSC_SAFETY_FAILURE,
        ACSC_ALL = uint.MaxValue
    }
    #endregion
}
