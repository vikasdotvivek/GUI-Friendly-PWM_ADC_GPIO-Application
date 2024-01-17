/// @file        TdxAllLibraries.cs
/// @copyright   Copyright (c) 2015 Toradex AG
/// $Author:     Toradex $
/// $Rev:        0000 $
/// $Date:       01-06-2018 12:16:29 PM $
/// @brief       .NET wrapper for Toradex WinCE libraries.
///              It allows to use the TdxAllLibraries.dll from a managed .NET application.
///              This code is not verified. It is provided as is, without maInt32enance!
///              Still any feedback is welcome to improve this code.
/// @test        Colibri VF61 and VF50
/// @target      Colibri T30, T20, VFxx, iMX6 and Apalis T30, iMX6
/// @tested      gpio, spi, adc, pwm, update,CAN, RpMsg, SysInfo, Int, wdg, Coproc
/// @Not-Tested  Clk, MapMem, KernelCallback
/// 

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
#pragma warning disable 649 , 169

//******************************************************************************
// Imports for TdxCommon.h
class TdxCommon
{
    /// type definition for a software version (usually shown as `[Major].[Minor].[Build]`
   [StructLayout(LayoutKind.Sequential)]
    public struct tVersion
    {
        public UInt32 Major;           ///< Major Version Number                          
        public UInt32 Minor;           ///< Minor Version Number
        public UInt32 Build;           ///< Build Number
    }
    public enum ParamStorageType
    {
        StoreToRegistry = 0,    ///< Store the parameter only temporarily, until the library's DeInit() function is called.
        StoreVolatile = 1       ///< Store the value also in the registry. It will be used as new default when the library's Init() function is called.
    }
}

/// Dll Imports for adc functions 
class adc
{
    [DllImport("TdxAllLibrariesDll.dll")]
    public static extern IntPtr Adc_Init(string portName);

    [DllImport("TdxAllLibrariesDll.dll")]
    public static extern bool Adc_Deinit(IntPtr hPort);

    [DllImport("TdxAllLibrariesDll.dll")]
    public static extern bool Adc_Open(IntPtr hPort);

    [DllImport("TdxAllLibrariesDll.dll")]
    public static extern bool Adc_Close(IntPtr hPort);

    [DllImport("TdxAllLibrariesDll.dll")]
    public static extern UInt32 Adc_Read(IntPtr hPort, IntPtr microVolts, UInt32 maxBytes);

    [DllImport("TdxAllLibrariesDll.dll")]
    public static extern UInt32 Adc_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 Value);

    [DllImport("TdxAllLibrariesDll.dll")]
    public static extern bool Adc_SetConfigInt(IntPtr hPort, string paramName, UInt32 pValue, TdxCommon.ParamStorageType storageType);

    [DllImport("TdxAllLibrariesDll.dll")]
    public static extern void Adc_GetVersion(ref TdxCommon.tVersion ver);
}

/// Dll Imports for adc_imx6 functions 
class adc_imx6
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx6Adc_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Adc_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Adc_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Adc_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Adc_Read(IntPtr hPort, IntPtr microVolts, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Adc_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Adc_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx6Adc_GetVersion(ref TdxCommon.tVersion ver);   
}

/// Dll Imports for adc_imx7 functions 
class adc_imx7
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx7Adc_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Adc_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Adc_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Adc_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Adc_Read(IntPtr hPort, IntPtr microVolts, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Adc_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Adc_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx7Adc_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for adc_teg functions 
class adc_teg
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr TegAdc_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegAdc_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegAdc_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegAdc_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegAdc_Read(IntPtr hPort, IntPtr microVolts, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegAdc_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegAdc_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void TegAdc_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for adc_vyb functions 
class adc_vyb
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr VybAdc_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybAdc_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybAdc_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybAdc_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybAdc_Read(IntPtr hPort, IntPtr microVolts, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybAdc_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybAdc_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void VybAdc_GetVersion(ref TdxCommon.tVersion ver);   
}

/// Dll Imports for can functions 
class can
{
    static class CanMsgFlags
    {
        /// Identifier extension bit (IDE), used for tCanMsg.canMsgFlags\n
        /// 0 = id is in standard format (11 bits)\n
        /// 1 = id is in extended format (29 bits)
        public const UInt32 CanMsgFlags_IDE = 0x00000001;

        /// Remote transmission request (RTR), used for tCanMsg.canMsgFlags\n
        /// 0 = message is a regular data frame\n
        /// 1 = message is a remote data request frame
        public const UInt32 CanMsgFlags_RTR = 0x00000002;
    }

    const UInt32 CAN_RW_FAILURE = UInt32.MaxValue;

	public enum tCanBusStatus
	{
	    Active = 0,         
	    Passive,            
	    Off                 
	};
	
    [StructLayout(LayoutKind.Sequential) ]
	public struct tCanMsg
	{
	    public UInt32 id;                                          ///< ID for CAN Bus Message Buffer (11 or 29bits used)
	    public UInt32 canMsgFlags;                                 ///< message specific flags.Currently only 2 bits are used:\n * @ref IDE "CanMsgFlags_IDE"\n * @ref RTR "CanMsgFlags_RTR" (read only)
	    public UInt32 dataLen;                                     ///< Message Data Length (0...8). This matches the DLC field of a CAN message.
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]      
	    public Byte[] data;                                        ///< Message Data (0...8 bytes used). This matches the data field of a CAN message.
	};
	
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Can_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Can_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Can_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Can_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Can_Read(IntPtr hPort, IntPtr msg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Can_Write(IntPtr hPort, IntPtr msg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Can_WriteMultiple(IntPtr hPort, IntPtr msg, UInt32 numMsgs);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Can_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Can_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Can_GetConfigString(IntPtr hPort, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Can_SetConfigString(IntPtr hPort, string paramName, string pValue, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Can_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for can_imx6 functions 
class can_imx6
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx6Can_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Can_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Can_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Can_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Can_Read(IntPtr hPort, IntPtr msg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Can_Write(IntPtr hPort, IntPtr msg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Can_WriteMultiple(IntPtr hPort, IntPtr msg, UInt32 numMsgs);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Can_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Can_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Can_GetConfigString(IntPtr hPort, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Can_SetConfigString(IntPtr hPort, string paramName, string pValue, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx6Can_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for can_imx7 functions 
class can_imx7
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx7Can_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Can_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Can_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Can_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Can_Read(IntPtr hPort, IntPtr msg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Can_Write(IntPtr hPort, IntPtr msg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Can_WriteMultiple(IntPtr hPort, IntPtr msg, UInt32 numMsgs);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Can_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Can_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Can_GetConfigString(IntPtr hPort, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Can_SetConfigString(IntPtr hPort, string paramName, string pValue, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx7Can_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for can_teg functions 
class can_teg
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr TegCan_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegCan_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegCan_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegCan_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegCan_Read(IntPtr hPort, IntPtr msg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegCan_Write(IntPtr hPort, IntPtr msg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegCan_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegCan_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegCan_GetConfigString(IntPtr hPort, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegCan_SetConfigString(IntPtr hPort, string paramName, string pValue, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void TegCan_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for can_vyb functions 
class can_vyb
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr VybCan_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybCan_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybCan_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybCan_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybCan_Read(IntPtr hPort, IntPtr msg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybCan_Write(IntPtr hPort, IntPtr msg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybCan_WriteMultiple(IntPtr hPort, IntPtr msg, UInt32 numMsgs);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybCan_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybCan_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybCan_GetConfigString(IntPtr hPort, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybCan_SetConfigString(IntPtr hPort, string paramName, string pValue, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void VybCan_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for clk_imx6 functions 
class clk_imx6
{
	public enum tImx6GateMode
	{
	    DDK_CLOCK_GATE_MODE_DISABLED            = 0,
	    DDK_CLOCK_GATE_MODE_ENABLED_RUN         = 1,
	    DDK_CLOCK_GATE_MODE_ENABLED_ALL         = 3,
	    DDK_CLOCK_GATE_MODE_POWER_OFF           = 4          // in fact, 4 may not exsit in MX6Q
	};
	
	public enum tImx6ClkId
	{
	    DDK_CLOCK_GATE_INDEX_AIPS_TZ1                           = 0,    // CGR0[1:0]
        DDK_CLOCK_GATE_INDEX_AIPS_TZ2                           = 1,    // CGR0[3:2]
        DDK_CLOCK_GATE_INDEX_APBHDMA_HCLK                       = 2,    // CGR0[5:4]
        DDK_CLOCK_GATE_INDEX_ASRC_CLK                           = 3,    // CGR0[7:6]
        DDK_CLOCK_GATE_INDEX_CAAM_SECURE_MEM                    = 4,    // CGR0[9:8]
        DDK_CLOCK_GATE_INDEX_CAAM_WRAPPER_ACLK                  = 5,    // CGR0[11:10]
        DDK_CLOCK_GATE_INDEX_CAAM_WRAPPER_IPG                   = 6,    // CGR0[13:12]
        DDK_CLOCK_GATE_INDEX_CAN1                               = 7,    // CGR0[15:14]
        DDK_CLOCK_GATE_INDEX_CAN1_SERIAL                        = 8,    // CGR0[17:16]
        DDK_CLOCK_GATE_INDEX_CAN2                               = 9,    // CGR0[19:18]
        DDK_CLOCK_GATE_INDEX_CAN2_SERIAL                        = 10,   // CGR0[21:20]
        DDK_CLOCK_GATE_INDEX_CHEETAH_DBG                        = 11,   // CGR0[23:22]
        DDK_CLOCK_GATE_INDEX_DCIC1                              = 12,   // CGR0[25:24]
        DDK_CLOCK_GATE_INDEX_DCIC2                              = 13,   // CGR0[27:26]
        DDK_CLOCK_GATE_INDEX_DTCP_DTCP                          = 14,   // CGR0[29:28]
        DDK_CLOCK_GATE_INDEX_R1                                 = 15,   // CGR0[31:30]
        
        DDK_CLOCK_GATE_INDEX_ECSPI1                             = 16,   // CGR1[1:0]
        DDK_CLOCK_GATE_INDEX_ECSPI2                             = 17,   // CGR1[3:2]
        DDK_CLOCK_GATE_INDEX_ECSPI3                             = 18,   // CGR1[5:4]
        DDK_CLOCK_GATE_INDEX_ECSPI4                             = 19,   // CGR1[7:6]
        DDK_CLOCK_GATE_INDEX_ECSPI5_I2C4                        = 20,   // CGR1[9:8]        // it's ECSPI5 on Q/D and I2C4 on S/DL
        DDK_CLOCK_GATE_INDEX_ENET                               = 21,   // CGR1[11:10]
        DDK_CLOCK_GATE_INDEX_EPIT1                              = 22,   // CGR1[13:12]
        DDK_CLOCK_GATE_INDEX_EPIT2                              = 23,   // CGR1[15:14]
        DDK_CLOCK_GATE_INDEX_ESAI                               = 24,   // CGR1[17:16]
        DDK_CLOCK_GATE_INDEX_R2                                 = 25,   // CGR1[19:18]
        DDK_CLOCK_GATE_INDEX_GPT                                = 26,   // CGR1[21:20]
        DDK_CLOCK_GATE_INDEX_GPT_SERIAL                         = 27,   // CGR1[23:22]
        DDK_CLOCK_GATE_INDEX_GPU2D                              = 28,   // CGR1[25:24]
        DDK_CLOCK_GATE_INDEX_GPU3D                              = 29,   // CGR1[27:26]
        DDK_CLOCK_GATE_INDEX_R3                                 = 30,   // CGR1[29:28]
        DDK_CLOCK_GATE_INDEX_R4                                 = 31,   // CGR1[31:30]
        
        DDK_CLOCK_GATE_INDEX_HDMI_TX_IAHBCLK                    = 32,   // CGR2[1:0]
        DDK_CLOCK_GATE_INDEX_R5                                 = 33,   // CGR2[3:2]
        DDK_CLOCK_GATE_INDEX_HDMI_TX_ISFR                       = 34,   // CGR2[5:4]
        DDK_CLOCK_GATE_INDEX_I2C1_SERIAL                        = 35,   // CGR2[7:6]
        DDK_CLOCK_GATE_INDEX_I2C2_SERIAL                        = 36,   // CGR2[9:8]
        DDK_CLOCK_GATE_INDEX_I2C3_SERIAL                        = 37,   // CGR2[11:10]
        DDK_CLOCK_GATE_INDEX_IIM                                = 38,   // CGR2[13:12]
        DDK_CLOCK_GATE_INDEX_IOMUX_IPT                          = 39,   // CGR2[15:14]
        DDK_CLOCK_GATE_INDEX_IPMUX1                             = 40,   // CGR2[17:16]
        DDK_CLOCK_GATE_INDEX_IPMUX2                             = 41,   // CGR2[19:18]
        DDK_CLOCK_GATE_INDEX_IPMUX3                             = 42,   // CGR2[21:20]
        DDK_CLOCK_GATE_INDEX_IPSYNC_IP2APB_TZASC2_IPG_MASTER    = 43,   // CGR2[23:22]
        DDK_CLOCK_GATE_INDEX_IPSYNC_IP2APB_TZASC2_IPG           = 44,   // CGR2[25:24]
        DDK_CLOCK_GATE_INDEX_IPSYNC_VDOA_IPG_MASTER             = 45,   // CGR2[27:26]
        DDK_CLOCK_GATE_INDEX_R6                                 = 46,   // CGR2[29:28]
        DDK_CLOCK_GATE_INDEX_R7                                 = 47,   // CGR2[31:30]
        
        DDK_CLOCK_GATE_INDEX_IPU1_IPU                           = 48,   // CGR3[1:0]
        DDK_CLOCK_GATE_INDEX_IPU1_IPU_DI0                       = 49,   // CGR3[3:2]
        DDK_CLOCK_GATE_INDEX_IPU1_IPU_DI1                       = 50,   // CGR3[5:4]
        DDK_CLOCK_GATE_INDEX_IPU2_IPU                           = 51,   // CGR3[7:6]
        DDK_CLOCK_GATE_INDEX_IPU2_IPU_DI0                       = 52,   // CGR3[9:8]
        DDK_CLOCK_GATE_INDEX_IPU2_IPU_DI1                       = 53,   // CGR3[11:10]
        DDK_CLOCK_GATE_INDEX_LDB_DI0                            = 54,   // CGR3[13:12]
        DDK_CLOCK_GATE_INDEX_LDB_DI1                            = 55,   // CGR3[15:14]
        DDK_CLOCK_GATE_INDEX_MIPI_CORE_CFG                      = 56,   // CGR3[17:16]
        DDK_CLOCK_GATE_INDEX_MLB                                = 57,   // CGR3[19:18]
        DDK_CLOCK_GATE_INDEX_MMDC_CORE_ACLK_FAST_CORE_P0        = 58,   // CGR3[21:20]
        DDK_CLOCK_GATE_INDEX_MMDC_CORE_ACLK_FAST_CORE_P1        = 59,   // CGR3[23:22]
        DDK_CLOCK_GATE_INDEX_MMDC_CORE_IPG_P0                   = 60,   // CGR3[25:24]
        DDK_CLOCK_GATE_INDEX_MMDC_CORE_IPG_P1                   = 61,   // CGR3[27:26]
        DDK_CLOCK_GATE_INDEX_OCRAM                              = 62,   // CGR3[29:28]
        DDK_CLOCK_GATE_INDEX_OPENVGAXI_ROOT                     = 63,   // CGR3[31:30]
        
        DDK_CLOCK_GATE_INDEX_PCIE_ROOT                          = 64,   // CGR4[1:0]
        DDK_CLOCK_GATE_INDEX_PERFMON1_APB                       = 65,   // CGR4[3:2]
        DDK_CLOCK_GATE_INDEX_PERFMON2_APB                       = 66,   // CGR4[4:3]
        DDK_CLOCK_GATE_INDEX_PERFMON3_APB                       = 67,   // CGR4[7:6]
        DDK_CLOCK_GATE_INDEX_PL301_FAST1_S133                   = 68,   // CGR4[9:8]
        DDK_CLOCK_GATE_INDEX_R8                                 = 69,   // CGR4[11:10]
        DDK_CLOCK_GATE_INDEX_PL301_PER1_BCH                     = 70,   // CGR4[13:12]
        DDK_CLOCK_GATE_INDEX_PL301_PER2_MAIN                    = 71,   // CGR4[15:14]
        DDK_CLOCK_GATE_INDEX_PWM1                               = 72,   // CGR4[17:16]
        DDK_CLOCK_GATE_INDEX_PWM2                               = 73,   // CGR4[19:18]
        DDK_CLOCK_GATE_INDEX_PWM3                               = 74,   // CGR4[21:20]
        DDK_CLOCK_GATE_INDEX_PWM4                               = 75,   // CGR4[23:22]
        DDK_CLOCK_GATE_INDEX_RAWNAND_U_BCH_INPUT_APB            = 76,   // CGR4[25:24]
        DDK_CLOCK_GATE_INDEX_RAWNAND_U_GPMI_BCH_INPUT_BCH       = 77,   // CGR4[27:26]
        DDK_CLOCK_GATE_INDEX_RAWNAND_U_GPMI_BCH_INPUT_GPMI_IO   = 78,   // CGR4[29:28]
        DDK_CLOCK_GATE_INDEX_RAWNAND_U_GPMI_INPUT_APB           = 79,   // CGR4[31:30]
        
        DDK_CLOCK_GATE_INDEX_ROM                                = 80,   // CGR5[1:0]
        DDK_CLOCK_GATE_INDEX_R9                                 = 81,   // CGR5[3:2]
        DDK_CLOCK_GATE_INDEX_SATA                               = 82,   // CGR5[5:4]
        DDK_CLOCK_GATE_INDEX_SDMA                               = 83,   // CGR5[7:6]
        DDK_CLOCK_GATE_INDEX_R10                                = 84,   // CGR5[9:8]
        DDK_CLOCK_GATE_INDEX_R11                                = 85,   // CGR5[11:10]
        DDK_CLOCK_GATE_INDEX_SPBA                               = 86,   // CGR5[13:12]
        DDK_CLOCK_GATE_INDEX_SPDIF                              = 87,   // CGR5[15:14]
        DDK_CLOCK_GATE_INDEX_R12                                = 88,   // CGR5[17:16]
        DDK_CLOCK_GATE_INDEX_SSI1                               = 89,   // CGR5[19:18]
        DDK_CLOCK_GATE_INDEX_SSI2                               = 90,   // CGR5[21:20]
        DDK_CLOCK_GATE_INDEX_SSI3                               = 91,   // CGR5[23:22]
        DDK_CLOCK_GATE_INDEX_UART                               = 92,   // CGR5[25:24]
        DDK_CLOCK_GATE_INDEX_UART_SERIAL                        = 93,   // CGR5[27:26]
        DDK_CLOCK_GATE_INDEX_R13                                = 94,   // CGR5[29:28]
        DDK_CLOCK_GATE_INDEX_R14                                = 95,   // CGR5[31:30]
        
        DDK_CLOCK_GATE_INDEX_USBOH3                             = 96,   // CGR6[1:0]
        DDK_CLOCK_GATE_INDEX_USDHC1                             = 97,   // CGR6[3:2]
        DDK_CLOCK_GATE_INDEX_USDHC2                             = 98,   // CGR6[5:4]
        DDK_CLOCK_GATE_INDEX_USDHC3                             = 99,   // CGR6[7:6]
        DDK_CLOCK_GATE_INDEX_USDHC4                             = 100,  // CGR6[9:8]
        DDK_CLOCK_GATE_INDEX_EMI_SLOW                           = 101,  // CGR6[11:10]
        DDK_CLOCK_GATE_INDEX_VDOAXI                             = 102,  // CGR6[13:12]
        DDK_CLOCK_GATE_INDEX_VPU                                = 103,  // CGR6[15:14]
        DDK_CLOCK_GATE_INDEX_R15                                = 104,  // CGR6[17:16]
        DDK_CLOCK_GATE_INDEX_R16                                = 105,  // CGR6[19:18]
        DDK_CLOCK_GATE_INDEX_R17                                = 106,  // CGR6[21:20]
        DDK_CLOCK_GATE_INDEX_R18                                = 107,  // CGR6[23:22]
        DDK_CLOCK_GATE_INDEX_R19                                = 108,  // CGR6[25:24]
        DDK_CLOCK_GATE_INDEX_R20                                = 109,  // CGR6[27:26]
        DDK_CLOCK_GATE_INDEX_R21                                = 110,  // CGR6[29:28]
        DDK_CLOCK_GATE_INDEX_R22                                = 111,  // CGR6[31:30]
        
        DDK_CLOCK_GATE_INDEX_R23                                = 112,  // CGR7[1:0]
        DDK_CLOCK_GATE_INDEX_R24                                = 113,  // CGR7[3:2]
        DDK_CLOCK_GATE_INDEX_R25                                = 114,  // CGR7[5:4]
        DDK_CLOCK_GATE_INDEX_R26                                = 115,  // CGR7[7:6]
        DDK_CLOCK_GATE_INDEX_R27                                = 116,  // CGR7[9:8]
        DDK_CLOCK_GATE_INDEX_R28                                = 117,  // CGR7[11:10]
        DDK_CLOCK_GATE_INDEX_R29                                = 118,  // CGR7[13:12]
        DDK_CLOCK_GATE_INDEX_R30                                = 119,  // CGR7[15:14]
        DDK_CLOCK_GATE_INDEX_R31                                = 120,  // CGR7[17:16]
        DDK_CLOCK_GATE_INDEX_R32                                = 121,  // CGR7[19:18]
        DDK_CLOCK_GATE_INDEX_R33                                = 122,  // CGR7[21:20]
        DDK_CLOCK_GATE_INDEX_R34                                = 123,  // CGR7[23:22]
        DDK_CLOCK_GATE_INDEX_R35                                = 124,  // CGR7[25:24]
        DDK_CLOCK_GATE_INDEX_R36                                = 125,  // CGR7[27:26]
        DDK_CLOCK_GATE_INDEX_R37                                = 126,  // CGR7[29:28]
        DDK_CLOCK_GATE_INDEX_R38                                = 127,  // CGR7[31:30]
        
        DDK_CLOCK_GATE_INDEX_ENUM_END                           = 128
	};

	public enum tImx6SignalId
	{
	    DDK_CLOCK_SIGNAL_OSC                = 0,
        DDK_CLOCK_SIGNAL_PLL1_CPU           = 1,            // CPU
        DDK_CLOCK_SIGNAL_PLL2_BUS           = 2,            // BUS (528MHz)
        DDK_CLOCK_SIGNAL_PLL3_USBOTG        = 3,            // USB (480MHz)
        DDK_CLOCK_SIGNAL_PLL1_REF           = 4,
        DDK_CLOCK_SIGNAL_PLL4_AUDIO         = 5,            // AUDIO
        DDK_CLOCK_SIGNAL_ARM                = 6,
        DDK_CLOCK_SIGNAL_AXI                = 7,
        DDK_CLOCK_SIGNAL_PERIPH             = 8,            // This is a intermidiate signal
        DDK_CLOCK_SIGNAL_MMDC_CH0_AXI       = 9,
        DDK_CLOCK_SIGNAL_MMDC_CH1_AXI       = 10,
        DDK_CLOCK_SIGNAL_AHB                = 11,
        DDK_CLOCK_SIGNAL_IPG                = 12,
        
        DDK_CLOCK_SIGNAL_PERCLK             = 13,           
        
        DDK_CLOCK_SIGNAL_CKIL_SYNC          = 14,
        DDK_CLOCK_SIGNAL_CKIH               = 15,
        
        DDK_CLOCK_SIGNAL_IPU2_HSP           = 16,
        DDK_CLOCK_SIGNAL_IPU1_HSP           = 17,
        DDK_CLOCK_SIGNAL_PCIE_AXI           = 18,
        DDK_CLOCK_SIGNAL_VDO_AXI            = 19,
        DDK_CLOCK_SIGNAL_VPU_AXI            = 20,
        DDK_CLOCK_SIGNAL_528M_PFD2_396M     = 21,
        DDK_CLOCK_SIGNAL_USDHC1             = 22,
        DDK_CLOCK_SIGNAL_USDHC2             = 23,
        DDK_CLOCK_SIGNAL_USDHC3             = 24,
        DDK_CLOCK_SIGNAL_USDHC4             = 25,
        DDK_CLOCK_SIGNAL_SSI1               = 26,
        DDK_CLOCK_SIGNAL_SSI2               = 27,
        DDK_CLOCK_SIGNAL_SSI3               = 28,
        DDK_CLOCK_SIGNAL_CAN                = 29,
        DDK_CLOCK_SIGNAL_UART               = 30,
        DDK_CLOCK_SIGNAL_SPDIF0             = 31,
        DDK_CLOCK_SIGNAL_SPDIF1             = 32,
        DDK_CLOCK_SIGNAL_ESAI               = 33,
        DDK_CLOCK_SIGNAL_ECSPI              = 34,
        DDK_CLOCK_SIGNAL_ACLK_EIM_SLOW      = 35,
        DDK_CLOCK_SIGNAL_ACLK               = 36,
        DDK_CLOCK_SIGNAL_ENFC               = 37,
        DDK_CLOCK_SIGNAL_HSI_TX             = 38,
        DDK_CLOCK_SIGNAL_VIDEO_27M          = 39,
        
        DDK_CLOCK_SIGNAL_LDB_DI0_SERIAL     = 40,
        DDK_CLOCK_SIGNAL_LDB_DI1_SERIAL     = 41,
        DDK_CLOCK_SIGNAL_LDB_DI0_IPU        = 42,
        DDK_CLOCK_SIGNAL_LDB_DI1_IPU        = 43,
        DDK_CLOCK_SIGNAL_IPU1_DI0           = 44,
        DDK_CLOCK_SIGNAL_IPU1_DI1           = 45,
        DDK_CLOCK_SIGNAL_IPU2_DI0           = 46,
        DDK_CLOCK_SIGNAL_IPU2_DI1           = 47,
        DDK_CLOCK_SIGNAL_GPU2D_CORE         = 48,
        DDK_CLOCK_SIGNAL_GPU2D_AXI_DQ       = 49,
        DDK_CLOCK_SIGNAL_GPU3D_CORE         = 50,
        DDK_CLOCK_SIGNAL_GPU3D_AXI_DQ       = 51,
        DDK_CLOCK_SIGNAL_GPU3D_SHADER_DQ    = 52,
        DDK_CLOCK_SIGNAL_PLL5_VIDEO_BASE    = 53,           // VIDEO
        DDK_CLOCK_SIGNAL_PLL3_120M          = 54,
        DDK_CLOCK_SIGNAL_PLL3_80M           = 55,
        DDK_CLOCK_SIGNAL_PLL3_60M           = 56,
        DDK_CLOCK_SIGNAL_PLL6_MLB           = 57,           // MLB
        DDK_CLOCK_SIGNAL_PLL2_BURNIN        = 58,
        
        DDK_CLOCK_SIGNAL_IPP_DI0            = 59,
        DDK_CLOCK_SIGNAL_IPP_DI1            = 60,
        
        DDK_CLOCK_SIGNAL_PLL7_USBHOST       = 61,           // USBHOST
        DDK_CLOCK_SIGNAL_PLL8_ENET          = 62,           // ENET
        DDK_CLOCK_SIGNAL_528M_PFD3_198_153M = 63,
        DDK_CLOCK_SIGNAL_528M_PFD0_352_306M = 64,
        DDK_CLOCK_SIGNAL_480M_PFD1_540M     = 65,
        DDK_CLOCK_SIGNAL_480M_PFD0_720M     = 66,
        DDK_CLOCK_SIGNAL_528M_PFD1_594_528M = 67,
        DDK_CLOCK_SIGNAL_480M_PFD2_508M     = 68, // 508.2MHz
        DDK_CLOCK_SIGNAL_480M_PFD3_454M     = 69, // 454.7Mhz
        
	    DDK_CLOCK_SIGNAL_PLL5_VIDEO_LCD     = 70,
	    DDK_CLOCK_SIGNAL_PLL5_VIDEO_LVDS    = 71,
        
        DDK_CLOCK_SIGNAL_ENUM_END           = 72
	};
	
	public enum tImx6BaudSourceId
	{
	    DDK_CLOCK_BAUD_SOURCE_CKIL              = 0,
        DDK_CLOCK_BAUD_SOURCE_OSC               = 1,
        DDK_CLOCK_BAUD_SOURCE_PLL1_CPU          = 2,
        DDK_CLOCK_BAUD_SOURCE_PLL2_BUS          = 3,
        DDK_CLOCK_BAUD_SOURCE_528M_PFD0_352_306M= 4,
        DDK_CLOCK_BAUD_SOURCE_528M_PFD1_594_528M= 5,
        DDK_CLOCK_BAUD_SOURCE_528M_PFD2_396M    = 6,
	    DDK_CLOCK_BAUD_SOURCE_528M_PFD3_198_153M= 7,
        DDK_CLOCK_BAUD_SOURCE_PLL3_USBOTG       = 8,
        DDK_CLOCK_BAUD_SOURCE_480M_PFD0_720M    = 9,
        DDK_CLOCK_BAUD_SOURCE_480M_PFD1_540M    = 10,
        DDK_CLOCK_BAUD_SOURCE_480M_PFD2_508M    = 11,
        DDK_CLOCK_BAUD_SOURCE_480M_PFD3_454M    = 12,
        DDK_CLOCK_BAUD_SOURCE_PLL4_AUDIO        = 13,
        DDK_CLOCK_BAUD_SOURCE_PLL5_VIDEO        = 14,
        DDK_CLOCK_BAUD_SOURCE_PLL6_MLB          = 15,
        DDK_CLOCK_BAUD_SOURCE_PLL7_USBHOST      = 16,
        DDK_CLOCK_BAUD_SOURCE_PLL8_ENET         = 17,
        DDK_CLOCK_BAUD_SOURCE_IPP_DI0           = 18, // external clock sources for display
        DDK_CLOCK_BAUD_SOURCE_IPP_DI1           = 19, // external clock sources for display
        DDK_CLOCK_BAUD_SOURCE_GND               = 20, 
        DDK_CLOCK_BAUD_SOURCE_ENUM_END          = 21
	};
	
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx6Clk_Init(string registryPath);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Clk_Deinit(IntPtr hClk);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Clk_EnableClock(IntPtr hClk, clk_imx6.tImx6ClkId clockId, bool enable);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Clk_ClockEnabled(IntPtr hClk, clk_imx6.tImx6ClkId clockId);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Clk_GetFrequency(IntPtr hClk, clk_imx6.tImx6SignalId signalId);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Clk_SetFrequency(IntPtr hClk, clk_imx6.tImx6SignalId signalId, UInt32 freq);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Clk_GetBaudSourceInfo(IntPtr hClk, clk_imx6.tImx6BaudSourceId baudSourceId, ref UInt32 freq, ref UInt32 refcount);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Clk_GetSignalInfo(IntPtr hClk, clk_imx6.tImx6SignalId signalId,ref UInt32  freq, clk_imx6.tImx6BaudSourceId baudsource, clk_imx6.tImx6SignalId parent);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Clk_GetClockGateInfo(IntPtr hClk, clk_imx6.tImx6ClkId clkId, clk_imx6.tImx6SignalId signal, ref UInt32 refcount);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Clk_GetCPUFrequency(IntPtr hClk);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Clk_SetCPUFrequency(IntPtr hClk, UInt32 freq);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Clk_SetMinCPUFrequency(IntPtr hClk, UInt32 freq);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Clk_SetMaxCPUFrequency(IntPtr hClk, UInt32 freq);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx6Clk_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for clk_imx7 functions 
class clk_imx7
{
	public enum tImx7ClkId
	{
	    ARM_A7_CLK_ROOT = 0,
	    ARM_M4_CLK_ROOT = 1,
	    ARM_M0_CLK_ROOT = 2,
	    MAIN_AXI_CLK_ROOT = 16,
	    DISP_AXI_CLK_ROOT = 17,
	    ENET_AXI_CLK_ROOT = 18,
	    NAND_USDHC_BUS_CLK_ROOT = 19,
	    AHB_CLK_ROOT = 32,
		ADC_CLK_ROOT = 33,  
	    DRAM_PHYM_CLK_ROOT = 48,
	    DRAM_CLK_ROOT = 49,
	    DRAM_PHYM_ALT_CLK_ROOT = 64,
	    DRAM_ALT_CLK_ROOT = 65,
	    USB_HSIC_CLK_ROOT = 66,
	    PCIE_CTRL_CLK_ROOT = 67,
	    PCIE_PHY_CLK_ROOT = 68,
	    EPDC_PIXEL_CLK_ROOT = 69,
	    LCDIF_PIXEL_CLK_ROOT = 70,
	    MIPI_DSI_EXTSER_CLK_ROOT = 71,
	    MIPI_CSI_WARP_CLK_ROOT = 72,
	    MIPI_DPHY_REF_CLK_ROOT = 73,
	    SAI1_CLK_ROOT = 74,
	    SAI2_CLK_ROOT = 75,
	    SAI3_CLK_ROOT = 76,
	    SPDIF_CLK_ROOT = 77,
	    ENET1_REF_CLK_ROOT = 78,
	    ENET1_TIME_CLK_ROOT = 79,
	    ENET2_REF_CLK_ROOT = 80,
	    ENET2_TIME_CLK_ROOT = 81,
	    ENET_PHY_REF_CLK_ROOT = 82,
	    EIM_CLK_ROOT = 83,
	    NAND_CLK_ROOT = 84,
	    QSPI_CLK_ROOT = 85,
	    USDHC1_CLK_ROOT = 86,
	    USDHC2_CLK_ROOT = 87,
	    USDHC3_CLK_ROOT = 88,
	    CAN1_CLK_ROOT = 89,
	    CAN2_CLK_ROOT = 90,
	    I2C1_CLK_ROOT = 91,
	    I2C2_CLK_ROOT = 92,
	    I2C3_CLK_ROOT = 93,
	    I2C4_CLK_ROOT = 94,
	    UART1_CLK_ROOT = 95,
	    UART2_CLK_ROOT = 96,
	    UART3_CLK_ROOT = 97,
	    UART4_CLK_ROOT = 98,
	    UART5_CLK_ROOT = 99,
	    UART6_CLK_ROOT = 100,
	    UART7_CLK_ROOT = 101,
	    ECSPI1_CLK_ROOT = 102,
	    ECSPI2_CLK_ROOT = 103,
	    ECSPI3_CLK_ROOT = 104,
	    ECSPI4_CLK_ROOT = 105,
	    PWM1_CLK_ROOT = 106,
	    PWM2_CLK_ROOT = 107,
	    PWM3_CLK_ROOT = 108,
	    PWM4_CLK_ROOT = 109,
	    FLEXTIMER1_CLK_ROOT = 110,
	    FLEXTIMER2_CLK_ROOT = 111,
	    SIM1_CLK_ROOT = 112,
	    SIM2_CLK_ROOT = 113,
	    GPT1_CLK_ROOT = 114,
	    GPT2_CLK_ROOT = 115,
	    GPT3_CLK_ROOT = 116,
	    GPT4_CLK_ROOT = 117,
	    TRACE_CLK_ROOT = 118,
	    WDOG_CLK_ROOT = 119,
	    CSI_MCLK_CLK_ROOT = 120,
	    AUDIO_MCLK_CLK_ROOT = 121,
	    WRCLK_CLK_ROOT = 122,
	    IPP_DO_CLKO1 = 123,
	    IPP_DO_CLKO2 = 124,
	
	    CLK_ROOT_MAX,
	};
	
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx7Clk_Init(string registryPath);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Clk_Deinit(IntPtr hClk);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Clk_EnableClock(IntPtr hClk, clk_imx7.tImx7ClkId clockId, bool enable);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Clk_ClockEnabled(IntPtr hClk, clk_imx7.tImx7ClkId clockId);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx7Clk_GetVersion(ref TdxCommon.tVersion ver);
}

/// Dll Imports for clk_teg functions 
class clk_teg
{ 
    /// ClockOtimize selection for TegClk_SetClockFrequency
    public enum tClockOptimise
    {
        ClockOptimiseForPower,        ///< Optimise clock source selection for lowest power consumption
        ClockOptimiseForPrecision     ///< Optimise clock source selection to be the closest frequency
    }

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr TegClk_Init(string registryPath);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegClk_Deinit(IntPtr hClk);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegClk_Reset(IntPtr hClk, UInt32 clockId, bool state);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegClk_EnableClock(IntPtr hClk, UInt32 clockId, bool state);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegClk_SetClockFrequency(IntPtr hClk, UInt32 clockId, UInt32 targetMinimumFrequency, UInt32 targetMaximumFrequency, tClockOptimise optimiseTarget);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegClk_GetClk(IntPtr hClk, UInt32 clockId);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegClk_GetClockFrequency(IntPtr hClk, UInt32 clockId);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegClk_Waitus(IntPtr hClk, UInt32 uSec);

    [DllImport("TdxAllLibrariesDll.dll")]
    public static extern void TegClk_GetVersion(ref TdxCommon.tVersion ver);
}

/// Dll Imports for clk_vyb functions 
class clk_vyb
{
	public enum tVybClkId
	{
	    clkFlexCan0         =   0,
	    clkDmaChMux0        =   4,
	    clkDmaChMux1        =   5,
	    clkUart0            =   7,
	    clkUart1            =   8,
	    clkUart2            =   9,
	    clkUart3            =  10,
	    clkSpi0             =  12,
	    clkSpi1             =  13,
	    clkSai0             =  15,
	    clkSai1             =  16,
	    clkSai2             =  17,
	    clkSai3             =  18,
	    clkCrc              =  19,
	    clkUsbc0            =  20,
	    clkPdb              =  22,
	    clkPit              =  23,
	    clkFtm0             =  24,
	    clkFtm1             =  25,
	    clkAdc0             =  27,
	    clkTcon0            =  29,
	    clkWdogA5           =  30,
	    clkWdogM4           =  31,
	    clkLptmr            =  32,
	    clkRle              =  34,
	    clkQuadSpi0         =  36,
	    clkIomuxCntr        =  40,
	    clkPortAMuxCtrl     =  41,
	    clkPortBMuxCtrl     =  42,
	    clkPortCMuxCtrl     =  43,
	    clkPortDMuxCtrl     =  44,
	    clkPortEMuxCtrl     =  45,
	    clkAnadig           =  48,
	    clkScscm            =  50,
	    clkDcu0             =  56,
	    clkAsrc             =  64,
	    clkSpdif            =  65,
	    clkEsai             =  66,
	    clkExternalWdog     =  69,
	    clkI2c0             =  70,
	    clkI2c1             =  71,
	    clkWkup             =  74,
	    clkCcm              =  75,
	    clkGpc              =  76,
	    clkVREG_DIG         =  77,
	    clkCmu              =  79,
	    clkDmaChMux2        =  97,
	    clkDmaChMux3        =  98,
	    clkOtpCtrl          = 101,
	    clkUart4            = 105,
	    clkUart5            = 106,
	    clkSpi2             = 108,
	    clkSpi3             = 109,
	    clkDdrmc            = 110,
	    clkSdhc0            = 113,
	    clkSdhc1            = 114,
	    clkUsbc1            = 116,
	    clkFtm2             = 120,
	    clkFtm3             = 121,
	    clkAdc1             = 123,
	    clkTcon1            = 125,
	    clkSegmwntLcd       = 126,
	    clkQuadSpi1         = 132,
	    clkVideoAdc         = 135,
	    clkVideoDecoder     = 136,
	    clkViu3             = 137,
	    clkDac0             = 140,
	    clkDac1             = 141,
	    clkEMac0            = 144,
	    clkEMac1            = 145,
	    clkFlexCan1         = 148,
	    clkDcu1             = 152,
	    clkNandFlashControl = 160,
	    clkI2c2             = 166,
	    clkI2c3             = 167,
	    clkEthernetL2Switch = 168,
	    clkClockEnd         = 180
	};
	
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr VybClk_Init(string registryPath);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybClk_Deinit(IntPtr hClk);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybClk_EnableClock(IntPtr hClk, clk_vyb.tVybClkId clockId, bool enable);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybClk_ClockEnabled(IntPtr hClk, clk_vyb.tVybClkId clockId);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void VybClk_Waitus(IntPtr hClk, UInt32 uSec);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void VybClk_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for Coproc functions 
class Coproc
{
	public enum eSoc
	{
	    Soc_None     = -1,           
	    Soc_PXA270   = 0x11,         
	    Soc_PXA320   = 0x02,         
	    Soc_PXA300   = 0x08,         
	    Soc_PXA310   = 0x09,         
	    Soc_TEGRA2   = 0x411FC09,    
	    Soc_TEGRA3   = 0x412FC09,    
	    Soc_VF50     = 0x00500000,   
	    Soc_VF61     = 0x00610000,   
	    Soc_IMX6S    = 0x200,        
	    Soc_IMX6DL   = 0x201,        
	    Soc_IMX6D    = 0x202,        
	    Soc_IMX6Q    = 0x203,        
	    Soc_IMX7S    = 0x00700000,   
	    Soc_IMX7D    = 0x00710000,   
	};

	public enum eSocFamily
	{
	    SocFamily_None   = -1,    
	    SocFamily_PXA    = 1,     
	    SocFamily_Tegra  = 2,     
	    SocFamily_Vybrid = 3,     
	    SocFamily_Imx6   = 4,     
	    SocFamily_Imx7   = 5      
	};
	
	public enum eFormFactor
	{
	    FormFactor_None     = -1,    
	    FormFactor_Colibri  = 0,     
	    FormFactor_Apalis   = 1      
	};
	
	public enum eCop
	{
	    p0 = 0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15
	};

	public enum eCopReg
	{
	    c0 = 0, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15
	};
	
	[DllImport("TdxAllLibrariesDll.dll")]
    public static extern int Cop_MRC(Coproc.eCop cpNr, UInt32 opcode1, Coproc.eCopReg cRn, Coproc.eCopReg cRm, UInt32 opcode2);

	[DllImport("TdxAllLibrariesDll.dll")]
    public static extern void Cop_MCR(int value, Coproc.eCop cpNr, UInt32 opcode1, Coproc.eCopReg cRn, Coproc.eCopReg cRm, UInt32 opcode2);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Cop_GetCpuid();

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern Coproc.eSoc Cop_GetSoc();

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern Coproc.eSocFamily Cop_GetSocFamily();

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern Coproc.eFormFactor Cop_GetFormFactor();

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Cop_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for gpio functions 
class gpio
{
    /// 32 bit uIo (higher 16 bits - Type of IO, lower 16 bits - IO number)
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public struct uIo
    {
        [FieldOffset(0)]
        public UInt16 number;

        [FieldOffset(2)]
        public UInt16 type;

        [FieldOffset(0)]
        public tGpio Gpio;

        [FieldOffset(0)]
        public tColibriPin ColibriPin;

        [FieldOffset(0)]
        public tColibriExtensionPin ColibriExtensionPin;

        [FieldOffset(0)]
        public tApalisPin ApalisPin;

        [FieldOffset(0)]
        public UInt32 GenericDefinition;

        public struct tGpio
        {
            public UInt16 nr;
            public UInt16 tp;
        }

        public struct tColibriPin
        {
            public UInt16 nr;
            public UInt16 tp;
        }
        public struct tApalisPin
        {
            public UInt16 nr;
            public UInt16 tp;
        }

        public struct tColibriExtensionPin
        {
            public UInt16 nr;
            public UInt16 tp;
        }

        // Static initializer
        public uIo(UInt16 ioNum, UInt16 ioType): this()
        {
            this.number = ioNum;
            this.type = ioType;
        }
    }

	/// define possible options to specify an IO pin
    public enum tIoType
    {
        ioNone = -1,                  ///< specify that this Io is unused and ignored
        ioReserved = 0x0000,          ///< do not use this undefined usage type (could be GPIO, SODIMM, ...)
        ioGpio = 0x0010,              ///< specify a GPIO
        ioColibriPin = 0x0020,        ///< specify an SODIMM pin of a Colibri module
        ioColibriExtension = 0x0021,  ///< specify a pin on the Colibri FFC Extension connector
        ioApalisPin = 0x0030,         ///< specify an MXM3 pin of an Apalis module
        ioUserDefined  = 0x00ff       ///< specify a User Defined type. Behaviour is not defined
    }
	
	/// Struct to store two IOs.
    /// This is used to describe a multiplexed pin, i.e. two GPIOs shorted to one module pin.
    public struct tTwoIo
    {
        uIo Primary;            ///< For signals that have two SoC GPIOs shorted together, this field describes the primary IO.
                                ///< There is no fixed rule which IO is the primary or secondary, it is just a Toradex definition.\n
                                ///< For regular IOs, this is the only valid entry of the tTwoIo structure.
        uIo Secondary;          ///< For signals that have two SoC GPIOs shorted together, this field describes the secondary IO.\n
                                ///< For regular IOs, this field is invalid.
    }	

	public enum tIoAltFn
	{
	    ioAltFn0 = 0,           ///< AltFn0 (exact function depends on particular SoC and GPIO)
        ioAltFn1,               ///< AltFn1 (exact function depends on particular SoC and GPIO)
        ioAltFn2,               ///< AltFn2 (exact function depends on particular SoC and GPIO)
        ioAltFn3,               ///< AltFn3 (exact function depends on particular SoC and GPIO)
        ioAltFn4,               ///< AltFn4 (exact function depends on particular SoC and GPIO)
        ioAltFn5,               ///< AltFn5 (exact function depends on particular SoC and GPIO)
        ioAltFn6,               ///< AltFn6 (exact function depends on particular SoC and GPIO)
        ioAltFn7,               ///< AltFn7 (exact function depends on particular SoC and GPIO)
        ioAltFn8,
        ioAltFn9,
        ioAltFnGpio = -1,       ///< Generic definition for the GPIO AltFn, compatible on all modules
	    ioAltFnInvalid = -2     ///< Marker for an invalid AltFn
	} ;
	
    /// Gpio level configuration values
    public enum tIoLevel
    {
        ioLow = 0,              ///< logic low level
        ioHigh = 1,             ///< logic high level
        ioLevelInvalid = -1
    }

	/// Gpio direction configuration values
    public enum tIoDirection
    {
        ioInput = 0,            ///< direction: input
        ioOutput = 1,           ///< direction: output
        ioDirInvalid = -1
    }
	
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Gpio_Init(string registryPath);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Gpio_Deinit(IntPtr hGpio);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Gpio_Open(IntPtr hGpio);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Gpio_Close(IntPtr hGpio);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern gpio.tIoDirection Gpio_GetDir(IntPtr hGpio, gpio.uIo io);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Gpio_SetDir(IntPtr hGpio, gpio.uIo io, gpio.tIoDirection dir);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern gpio.tIoLevel Gpio_GetLevel(IntPtr hGpio, gpio.uIo io);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Gpio_SetLevel(IntPtr hGpio, gpio.uIo io, gpio.tIoLevel val);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Gpio_ConfigureAsGpio(IntPtr hGpio, gpio.uIo io);

	// The .Net calling convention for returning a struct is different of the calling convention that
    // Microsoft uses for native code. Therefore a small wrapper function is required.
    [DllImport("TdxAllLibrariesDll.dll")]
    public static extern void Gpio_NormalizeIo(ref gpio.uIo ioNormalized, IntPtr hGpio, gpio.uIo io);
    public static gpio.uIo Gpio_NormalizeIo(IntPtr hGpio, gpio.uIo io)
    {
        gpio.uIo ioTemp = new gpio.uIo();
        Gpio_NormalizeIo(ref ioTemp, hGpio, io);
        return ioTemp;
    }

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Gpio_SetConfigString(IntPtr hGpio, gpio.uIo io, string paramName2, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Gpio_GetConfigString(IntPtr hGpio, gpio.uIo io, StringBuilder paramName2, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Gpio_GetConfigInt(IntPtr hGpio, gpio.uIo io, string paramName2, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Gpio_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for gpio_imx6 functions 
class gpio_imx6
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx6Gpio_Init(string registryPath);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Gpio_Deinit(IntPtr hGpio);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Gpio_Open(IntPtr hGpio);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Gpio_Close(IntPtr hGpio);

	// The .Net calling convention for returning a struct is different of the calling convention that
    // Microsoft uses for native code. Therefore a small wrapper function is required.
    [DllImport("TdxAllLibrariesDll.dll")]
    public static extern void Imx6Gpio_NormalizeIo(ref gpio.uIo ioNormalized, IntPtr hGpio, gpio.uIo io);
    public static gpio.uIo Imx6Gpio_NormalizeIo(IntPtr hGpio, gpio.uIo io)
    {
        gpio.uIo ioTemp = new gpio.uIo();
        Imx6Gpio_NormalizeIo(ref ioTemp, hGpio, io);
        return ioTemp;
    }

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern gpio.tIoDirection Imx6Gpio_GetDir(IntPtr hGpio, gpio.uIo io);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx6Gpio_SetDir(IntPtr hGpio, gpio.uIo io, gpio.tIoDirection dir);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern gpio.tIoLevel Imx6Gpio_GetLevel(IntPtr hGpio, gpio.uIo io);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx6Gpio_SetLevel(IntPtr hGpio, gpio.uIo io, gpio.tIoLevel val);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx6Gpio_ConfigureAsGpio(IntPtr hGpio, gpio.uIo io);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Gpio_SetConfigString(IntPtr hGpio, gpio.uIo io, string reserved, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Gpio_GetConfigString(IntPtr hGpio, gpio.uIo io, string paramName2, ref string pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Gpio_GetConfigInt(IntPtr hGpio, gpio.uIo io, string paramName2, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx6Gpio_GetVersion(TdxCommon.tVersion ver);    
}

/// Dll Imports for gpio_imx7 functions 
class gpio_imx7
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx7Gpio_Init(string registryPath);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Gpio_Deinit(IntPtr hGpio);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Gpio_Open(IntPtr hGpio);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Gpio_Close(IntPtr hGpio);

	// The .Net calling convention for returning a struct is different of the calling convention that
    // Microsoft uses for native code. Therefore a small wrapper function is required.
    [DllImport("TdxAllLibrariesDll.dll")]
    public static extern void Imx7Gpio_NormalizeIo(ref gpio.uIo ioNormalized, IntPtr hGpio, gpio.uIo io);
    public static gpio.uIo Imx7Gpio_NormalizeIo(IntPtr hGpio, gpio.uIo io)
    {
        gpio.uIo ioTemp = new gpio.uIo();
        Imx7Gpio_NormalizeIo(ref ioTemp, hGpio, io);
        return ioTemp;
    }

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern gpio.tIoDirection Imx7Gpio_GetDir(IntPtr hGpio, gpio.uIo io);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx7Gpio_SetDir(IntPtr hGpio, gpio.uIo io, gpio.tIoDirection dir);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern gpio.tIoLevel Imx7Gpio_GetLevel(IntPtr hGpio, gpio.uIo io);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx7Gpio_SetLevel(IntPtr hGpio, gpio.uIo io, gpio.tIoLevel val);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx7Gpio_ConfigureAsGpio(IntPtr hGpio, gpio.uIo io);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Gpio_SetConfigString(IntPtr hGpio, gpio.uIo io, string reserved, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Gpio_GetConfigString(IntPtr hGpio, gpio.uIo io, string paramName2, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Gpio_GetConfigInt(IntPtr hGpio, gpio.uIo io, string paramName2, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx7Gpio_GetVersion(ref TdxCommon.tVersion ver);  
}

/// Dll Imports for gpio_teg functions 
class gpio_teg
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr TegGpio_Init(string registryPath);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegGpio_Deinit(IntPtr hGpio);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegGpio_Open(IntPtr hGpio);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegGpio_Close(IntPtr hGpio);

	// The .Net calling convention for returning a struct is different of the calling convention that
    // Microsoft uses for native code. Therefore a small wrapper function is required.
    [DllImport("TdxAllLibrariesDll.dll")]
    public static extern void TegGpio_NormalizeIo(ref gpio.uIo ioNormalized, IntPtr hGpio, gpio.uIo io);
    public static gpio.uIo TegGpio_NormalizeIo(IntPtr hGpio, gpio.uIo io)
    {
        gpio.uIo ioTemp = new gpio.uIo();
        TegGpio_NormalizeIo(ref ioTemp, hGpio, io);
        return ioTemp;
    }

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern gpio.tIoDirection TegGpio_GetDir(IntPtr hGpio, gpio.uIo io);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void TegGpio_SetDir(IntPtr hGpio, gpio.uIo io, gpio.tIoDirection dir);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern gpio.tIoLevel TegGpio_GetLevel(IntPtr hGpio, gpio.uIo io);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void TegGpio_SetLevel(IntPtr hGpio, gpio.uIo io, gpio.tIoLevel level);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void TegGpio_ConfigureAsGpio(IntPtr hGpio, gpio.uIo io);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegGpio_SetConfigString(IntPtr hGpio, gpio.uIo io, string paramName2, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegGpio_GetConfigString(IntPtr hGpio, gpio.uIo io, string paramName2, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegGpio_GetConfigInt(IntPtr hGpio, gpio.uIo io, string paramName2, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void TegGpio_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for gpio_vyb functions 
class gpio_vyb
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr VybGpio_Init(string registryPath);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybGpio_Deinit(IntPtr hGpio);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybGpio_Open(IntPtr hGpio);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybGpio_Close(IntPtr hGpio);

    // The .Net calling convention for returning a struct is different of the calling convention that
    // Microsoft uses for native code. Therefore a small wrapper function is required.
    [DllImport("TdxAllLibrariesDll.dll")]
    public static extern void VybGpio_NormalizeIo(ref gpio.uIo ioNormalized, IntPtr hGpio, gpio.uIo io);
    public static gpio.uIo VybGpio_NormalizeIo(IntPtr hGpio, gpio.uIo io)
    {
        gpio.uIo ioTemp = new gpio.uIo();
        VybGpio_NormalizeIo(ref ioTemp, hGpio, io);
        return ioTemp;
    }

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern gpio.tIoDirection VybGpio_GetDir(IntPtr hGpio, gpio.uIo io);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void VybGpio_SetDir(IntPtr hGpio, gpio.uIo io, gpio.tIoDirection dirOut);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern gpio.tIoLevel VybGpio_GetLevel(IntPtr hGpio, gpio.uIo io);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void VybGpio_SetLevel(IntPtr hGpio, gpio.uIo io, gpio.tIoLevel val);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void VybGpio_ConfigureAsGpio(IntPtr hGpio, gpio.uIo io);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybGpio_SetConfigString(IntPtr hGpio, gpio.uIo io, string reserved, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybGpio_GetConfigString(IntPtr hGpio, gpio.uIo io, string paramName2, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybGpio_GetConfigInt(IntPtr hGpio, gpio.uIo io, string paramName2, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void VybGpio_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for i2c functions 
class i2c
{
    const UInt32 I2C_RW_FAILURE = UInt32.MaxValue;

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr I2c_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool I2c_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool I2c_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool I2c_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 I2c_Read(IntPtr hPort, IntPtr pbuf, UInt32 numberOfBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 I2c_Write(IntPtr hPort, IntPtr pbuf, UInt32 numberOfBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool I2c_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 I2c_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void I2c_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for i2c_imx6 functions 
class i2c_imx6
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx6I2c_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6I2c_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6I2c_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6I2c_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6I2c_Read(IntPtr hPort, IntPtr pbuf, UInt32 numberOfBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6I2c_Write(IntPtr hPort, IntPtr pbuf, UInt32 numberOfBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6I2c_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6I2c_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx6I2c_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for i2c_imx7 functions 
class i2c_imx7
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx7I2c_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7I2c_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7I2c_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7I2c_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7I2c_Read(IntPtr hPort, IntPtr pbuf, UInt32 numberOfBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7I2c_Write(IntPtr hPort, IntPtr pbuf, UInt32 numberOfBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7I2c_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7I2c_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx7I2c_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for i2c_teg functions 
class i2c_teg
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr TegI2c_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegI2c_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegI2c_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegI2c_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegI2c_Read(IntPtr hPort, IntPtr pbuf, UInt32 numberOfBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegI2c_Write(IntPtr hPort, IntPtr pbuf, UInt32 numberOfBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegI2c_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegI2c_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void TegI2c_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for i2c_vyb functions 
class i2c_vyb
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr VybI2c_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybI2c_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybI2c_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybI2c_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybI2c_Read(IntPtr hPort, IntPtr pbuf, UInt32 numberOfBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybI2c_Write(IntPtr hPort, IntPtr pbuf, UInt32 numberOfBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybI2c_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybI2c_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void VybI2c_GetVersion(TdxCommon.tVersion ver);   
}

/// Dll Imports for Int32 functions 
class Int
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Int_Init();

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Int_Deinit(IntPtr hInt);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Int_LoadIntChainHandler(IntPtr hInt, string lpFilename, string lpszFunctionName, Byte bIRQ);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Int_FreeIntChainHandler(IntPtr hInt, IntPtr hInstance);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Int_InterruptInitialize(IntPtr hInt, UInt32 idInt, IntPtr hEvent, IntPtr pvData, UInt32 cbData);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Int_InterruptDisable(IntPtr hInt, UInt32 idInt);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Int_InterruptDone(IntPtr hInt, UInt32 idInt);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Int_CreateStaticMapping(IntPtr hInt, UInt32 dwPhysBase, UInt32 dwSize);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Int_KernelLibIoControl(IntPtr hInt, IntPtr hModule, UInt32 dwIoControlCode, IntPtr lpInBuf, UInt32 nInBufSize, IntPtr lpOutBuf, UInt32 nOutBufSize, IntPtr lpBytesReturned);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Int_GetCurrentProcessId(IntPtr hInt);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Int_RequestSysInterrupt(IntPtr hInt, UInt32 dwIrq);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Int_ReleaseSysIntr(IntPtr hInt, UInt32 dwSysIntr);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Int_GetVersion(ref TdxCommon.tVersion ver);   
}

/// Dll Imports for Int32_vyb functions 
class Int_vyb
{
    public const int IRQ_BASE = 16;

    /// IRQ numbers for VF50 and VF61
///
/// | IRQ       | Interrupt source           |
/// | :-------- | :------------------------- |
/// | 0 - 145   | Various Vybrid Peripherals |
/// | 146 - 153 | Timer0 - Timer7            |
/// | 154 - 255 | GPIOs. See Gpio_GetIrq()   |
/// \n
/// The constants defining each IRQ number of the VF50/VF61 SoCs are:

	public enum IRQInterruptIndex
	{
        IRQ_SGI0                     = 16-IRQ_BASE ,              ///< Software Generated Interrupt
        IRQ_SGI1                     = 17-IRQ_BASE ,              ///< Software Generated Interrupt
        IRQ_SGI2                     = 18-IRQ_BASE ,              ///< Software Generated Interrupt
        IRQ_SGI3                     = 19-IRQ_BASE ,              ///< Software Generated Interrupt
        IRQ_SGI4                     = 20-IRQ_BASE ,              ///< Software Generated Interrupt
        IRQ_SGI5                     = 21-IRQ_BASE ,              ///< Software Generated Interrupt
        IRQ_SGI6                     = 22-IRQ_BASE ,              ///< Software Generated Interrupt
        IRQ_SGI7                     = 23-IRQ_BASE ,              ///< Software Generated Interrupt
        IRQ_SGI8                     = 24-IRQ_BASE ,              ///< Software Generated Interrupt
        IRQ_SGI9                     = 25-IRQ_BASE ,              ///< Software Generated Interrupt
        IRQ_SGI10                    = 26-IRQ_BASE ,              ///< Software Generated Interrupt
        IRQ_SGI11                    = 27-IRQ_BASE ,              ///< Software Generated Interrupt
        IRQ_SGI12                    = 28-IRQ_BASE ,              ///< Software Generated Interrupt
        IRQ_SGI13                    = 29-IRQ_BASE ,              ///< Software Generated Interrupt
        IRQ_SGI14                    = 30-IRQ_BASE ,              ///< Software Generated Interrupt
        IRQ_SGI15                    = 31-IRQ_BASE ,              ///< Software Generated Interrupt
        IRQ_PPI0                     = 32-IRQ_BASE ,              ///< Private Peripheral Interrupt
        IRQ_PPI1                     = 33-IRQ_BASE ,              ///< Private Peripheral Interrupt
        IRQ_PPI2                     = 34-IRQ_BASE ,              ///< Private Peripheral Interrupt
        IRQ_PPI3                     = 35-IRQ_BASE ,              ///< Private Peripheral Interrupt
        IRQ_PPI4                     = 36-IRQ_BASE ,              ///< Private Peripheral Interrupt
        IRQ_PPI5                     = 37-IRQ_BASE ,              ///< Private Peripheral Interrupt
        IRQ_PPI6                     = 38-IRQ_BASE ,              ///< Private Peripheral Interrupt
        IRQ_PPI7                     = 39-IRQ_BASE ,              ///< Private Peripheral Interrupt
        IRQ_PPI8                     = 40-IRQ_BASE ,              ///< Private Peripheral Interrupt
        IRQ_PPI9                     = 41-IRQ_BASE ,              ///< Private Peripheral Interrupt
        IRQ_PPI10                    = 42-IRQ_BASE ,              ///< Private Peripheral Interrupt
        IRQ_GlobalTimer              = 43-IRQ_BASE ,              ///< Private Peripheral Interrupt
        IRQ_PPI12                    = 44-IRQ_BASE ,              ///< Private Peripheral Interrupt
        IRQ_CoreTimer                = 45-IRQ_BASE ,              ///< Private Peripheral Interrupt
        IRQ_CoreWatchdog             = 46-IRQ_BASE ,              ///< Private Peripheral Interrupt
        IRQ_PPI15                    = 47-IRQ_BASE ,              ///< Private Peripheral Interrupt
        IRQ_CPU_to_CPU_int0          = 48-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_CPU_to_CPU_int1          = 49-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_CPU_to_CPU_int2          = 50-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_CPU_to_CPU_int3          = 51-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_Directed_CA5_int0        = 52-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_Directed_CA5_int1        = 53-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_Directed_CA5_int2        = 54-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_Directed_CA5_int3        = 55-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_DMA0_Transfer_Complete   = 56-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_DMA0_Error               = 57-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_DMA1_Transfer_Complete   = 58-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_DMA1_Error               = 59-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_Reserved44               = 60-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_Reserved45               = 61-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_MSCM_ECC0                = 62-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_MSCM_ECC1                = 63-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_CSU_Alarm                = 64-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_Reserved49               = 65-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_MSCM_ACTZS               = 66-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_Reserved51               = 67-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_WDOG_A5                  = 68-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_WDOG_M4                  = 69-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_WDOG_SNVS                = 70-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_CP1_Boot_Fail            = 71-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_QuadSPI0                 = 72-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_QuadSPI1                 = 73-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_DRAM                     = 74-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_SDHC0                    = 75-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_SDHC1                    = 76-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_Reserved61               = 77-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_DCU0                     = 78-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_DCU1                     = 79-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_VIU                      = 80-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_Reserved65               = 81-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_GC355                    = 82-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_RLE                      = 83-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_LCD                      = 84-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_Reserved69               = 85-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_Reserved70               = 86-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_PIT                      = 87-IRQ_BASE ,              ///< PIT timer interrupt (Shared Peripheral Interrupt)
        IRQ_LPTimer0                 = 88-IRQ_BASE ,              ///< LPTimer interrupt (Shared Peripheral Interrupt)
        IRQ_Reserved73               = 89-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_FlexTimer0               = 90-IRQ_BASE ,              ///< FTM0 fault-IRQ_BASE , overflow and channels interrupt (Shared Peripheral Interrupt)
        IRQ_FlexTimer1               = 91-IRQ_BASE ,              ///< FTM1 fault-IRQ_BASE , overflow and channels interrupt (Shared Peripheral Interrupt)
        IRQ_FlexTimer2               = 92-IRQ_BASE ,              ///< FTM2 fault-IRQ_BASE , overflow and channels interrupt (Shared Peripheral Interrupt)
        IRQ_FlexTimer3               = 93-IRQ_BASE ,              ///< FTM3 fault-IRQ_BASE , overflow and channels interrupt (Shared Peripheral Interrupt)
        IRQ_Reserved78               = 94-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_Reserved79               = 95-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_Reserved80               = 96-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_Reserved81               = 97-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_USBPHY0                  = 98-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_USBPHY1                  = 99-IRQ_BASE ,              ///< Shared Peripheral Interrupt
        IRQ_Reserved84               = 100-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_ADC0                     = 101-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_ADC1                     = 102-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_DAC0                     = 103-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_DAC1                     = 104-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_Reserved89               = 105-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_FlexCAN0                 = 106-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_FlexCAN1                 = 107-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_MLB                      = 108-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_UART0                    = 109-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_UART1                    = 110-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_UART2                    = 111-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_UART3                    = 112-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_UART4                    = 113-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_UART5                    = 114-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_DSPI0                    = 115-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_DSPI1                    = 116-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_DSPI2                    = 117-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_DSPI3                    = 118-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_I2C0                     = 119-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_I2C1                     = 120-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_I2C2                     = 121-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_I2C3                     = 122-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_USB0                     = 123-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_USB1                     = 124-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_Reserved109              = 125-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_ENET_MAC0                = 126-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_ENET_MAC1                = 127-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_ENET_1588_Timer0         = 128-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_ENET_1588_Timer1         = 129-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_ENET_Switch              = 130-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_NFC                      = 131-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_SAI0                     = 132-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_SAI1                     = 133-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_SAI2                     = 134-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_SAI3                     = 135-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_ESAI_BIFIFO              = 136-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_SPDIF                    = 137-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_ASRC                     = 138-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_CMU                      = 139-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_WKPU0                    = 140-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_WKPU1                    = 141-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_CCM0                     = 142-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_CCM1                     = 143-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_SRC                      = 144-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_PDB                      = 145-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_EWM                      = 146-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_Reserved131              = 147-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_SNVS_Consolidated        = 148-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_SNVS_Security            = 149-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_CAAM                     = 150-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_Reserved135              = 151-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_Reserved136              = 152-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_Reserved137              = 153-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_Reserved138              = 154-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_PORT0                    = 155-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_PORT1                    = 156-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_PORT2                    = 157-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_PORT3                    = 158-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_PORT4                    = 159-IRQ_BASE ,             ///< Shared Peripheral Interrupt
        IRQ_Spurious1022             = 160-IRQ_BASE ,             ///< Special Interrupt
        IRQ_Spurious1023             = 161-IRQ_BASE ,             ///< Special Interrupt
        IRQ_HW_MAX                   = 162-IRQ_BASE ,             ///< Special Interrupt             
	} ;  
}

/// Dll Imports for KernelCallback functions 
class KernelCallback
{
    /// List of available Kernel Callback functions
    /// Each value is an index matching a kernel-function-pointer
	public enum eKFn
	{
	    idGetModuleHandle,
	    idGetProcAddress,
	    idAllocPhysMem,
	    idCacheRangeFlush,
	    idCacheSync,
	    idCeGetCacheInfo,
	    idCeSetMemoryAttributes,
	    idCeSetPowerOnEvent,
	    idCeVirtualSharedAlloc,
	    idCreateStaticMapping,
	    idDrWatsonClear,
	    idDrWatsonFlush,
	    idDrWatsonGetSize,
	    idDrWatsonReadData,
	    idDrWatsonWriteData,
	    idForcePageout,
	    idFreeIntChainHandler,
	    idFreePhysMem,
	    idGetCallerProcess,
	    idGetStdioPathW,
	    idGetSystemMemoryDivision,
	    idInterruptDisable,
	    idInterruptDone,
	    idInterruptInitialize,
	    idInterruptMask,
	    idKernelLibIoControl,
	    idLoadDriver,
	    idLoadIntChainHandler,
	    idLockPages,
	    idOpenWatchDogTimer,
	    idPageOutModule,
	    idProfileCaptureStatus,
	    idRefreshWatchDogTimer,
	    idSetDbgZone,
	    idSetInterruptEvent,
	    idSetJITDebuggerPath,
	    idSetStdioPathW,
	    idSetSystemMemoryDivision,
	    idUnlockPages,
	    idVirtualCopy,
	    idVirtualCopyEx,
	    idVirtualSetAttributes,
	    idCloseHandle,
	    idLastEntry
	} ;
	
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Kcb_Init();

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Kcb_Deinit(IntPtr hKcb);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Kcb_GetFunctionPoInt32er(IntPtr hKcb, UInt32 kernelFunction);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Kcb_DoKernelCallBack(IntPtr pArgs, UInt32 size);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Kcb_GetVersion(ref TdxCommon.tVersion ver);
    
}

/// Dll Imports for MapMem functions 
class MapMem
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr AllocPhysMem(UInt32 cbSize, UInt32 fdwProtect, UInt32 dwAlignmentMask, UInt32 dwFlags, IntPtr pPhysicalAddress);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool FreePhysMem(IntPtr lpvAddress);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VirtualCopy(IntPtr lpvDest, IntPtr lpvSrc, UInt32 cbSize, UInt32 fdwProtect);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VirtualSetAttributes (IntPtr lpvAddress, UInt32 cbSize, UInt32 dwNewFlags, UInt32 dwMask, IntPtr lpdwOldFlags);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr CreateStaticMapping(UInt32 dwPhysBase, UInt32 dwSize);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Map_Init();

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Map_Deinit(IntPtr hMap);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Map_VirtualCopy(IntPtr lpvDest, IntPtr lpvSrc, UInt32 cbSize, UInt32 fdwProtect);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Map_VirtualSetAttributes(IntPtr lpvAddress, UInt32 cbSize, UInt32 dwNewFlags, UInt32 dwMask, IntPtr lpdwOldFlags);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Map_LockPages(IntPtr lpvAddress, UInt32 cbSize, IntPtr pPFNs, Int32 fOptions);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Map_MapMemory(UInt32 pa, UInt32 size);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Map_UnMapMemory(IntPtr pRegs);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Map_AllocPhysMem(IntPtr hMap, UInt32 cbSize, UInt32 fdwProtect, UInt32 dwAlignmentMask, UInt32 dwFlags, IntPtr pPhysicalAddress);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Map_FreePhysMem(IntPtr lpvAddress);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr  Map_OALPAtoVA(IntPtr pa, bool cached);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Map_MemoryRead(IntPtr  pAddr, UInt32 bits);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Map_MemoryWrite(IntPtr  pAddr, UInt32 val, UInt32 bits);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Map_MemoryMask(IntPtr  pAddr, UInt32 val, UInt32 mask, UInt32 bits);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Map_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for pwm functions 
class pwm
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Pwm_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Pwm_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Pwm_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Pwm_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Pwm_GetConfigString( IntPtr hPort, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Pwm_SetConfigString(IntPtr hPort, string paramName, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Pwm_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Pwm_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Pwm_SetPwm(IntPtr hPort, UInt32 freq, UInt32 duty);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Pwm_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for pwm_imx6 functions
class pwm_imx6
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx6Pwm_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Pwm_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Pwm_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Pwm_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Pwm_GetConfigString(IntPtr hPort, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Pwm_SetConfigString(IntPtr hPort, string paramName, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Pwm_GetConfigInt( IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Pwm_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Pwm_SetPwm(IntPtr hPort, UInt32 freq, UInt32 duty);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx6Pwm_GetVersion(ref TdxCommon.tVersion ver);   
}

/// Dll Imports for pwm_imx7 functions 
class pwm_imx7
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx7Pwm_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Pwm_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Pwm_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Pwm_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Pwm_GetConfigString(IntPtr hPort, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Pwm_SetConfigString(IntPtr hPort, string paramName, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Pwm_GetConfigInt( IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Pwm_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Pwm_SetPwm(IntPtr hPort, UInt32 freq, UInt32 duty);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx7Pwm_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for pwm_teg functions 
class pwm_teg
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr TegPwm_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegPwm_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegPwm_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegPwm_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegPwm_GetConfigString(IntPtr hPort, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegPwm_SetConfigString(IntPtr hPort, string paramName, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegPwm_GetConfigInt( IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegPwm_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegPwm_SetPwm(IntPtr hPort, UInt32 freq, UInt32 duty);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void TegraPwm_GetVersion(ref TdxCommon.tVersion ver);   
}

/// Dll Imports for pwm_vyb functions 
class pwm_vyb
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr VybPwm_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybPwm_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybPwm_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybPwm_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybPwm_GetConfigString(IntPtr hPort, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybPwm_SetConfigString(IntPtr hPort, string paramName, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybPwm_GetConfigInt( IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybPwm_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybPwm_SetPwm(IntPtr hPort, UInt32 freq, UInt32 duty);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void VybPwm_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for rpmsg functions 
class rpmsg
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Rpmsg_Init(string registryPath);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Rpmsg_Deinit(IntPtr hRpmsg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Rpmsg_Open(IntPtr hRpmsg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Rpmsg_Close(IntPtr hRpmsg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Rpmsg_Write(IntPtr hRpmsg, IntPtr data, UInt32 sizeBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Rpmsg_Read(IntPtr hRpmsg, IntPtr data, UInt32 sizeBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Rpmsg_GetConfigString(IntPtr hRpmsg, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Rpmsg_SetConfigString(IntPtr hRpmsg, string paramName, string pValue, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Rpmsg_SetConfigInt(IntPtr hRpmsg, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Rpmsg_GetConfigInt(IntPtr hRpmsg, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Rpmsg_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for rpmsg_imx7 functions 
class rpmsg_imx7
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx7Rpmsg_Init(string registryPath);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Rpmsg_Deinit(IntPtr hRpmsg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Rpmsg_Open(IntPtr hRpmsg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Rpmsg_Close(IntPtr hRpmsg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Rpmsg_Write(IntPtr hRpmsg, IntPtr data, UInt32 sizeBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Rpmsg_Read(IntPtr hRpmsg, IntPtr data, UInt32 sizeBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Rpmsg_GetConfigString(IntPtr hRpmsg, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Rpmsg_SetConfigInt(IntPtr hRpmsg, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Rpmsg_GetConfigInt(IntPtr hRpmsg, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Rpmsg_SetConfigString(IntPtr hRpmsg, string paramName, string pValue, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx7Rpmsg_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for rpmsg_vyb functions 
class rpmsg_vyb
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr VybRpmsg_Init(string registryPath);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybRpmsg_Deinit(IntPtr hRpmsg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybRpmsg_Open(IntPtr hRpmsg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybRpmsg_Close(IntPtr hRpmsg);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybRpmsg_Write(IntPtr hRpmsg, IntPtr data, UInt32 sizeBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybRpmsg_Read(IntPtr hRpmsg, IntPtr data, UInt32 sizeBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybRpmsg_GetConfigString(IntPtr hRpmsg, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybRpmsg_SetConfigInt(IntPtr hRpmsg, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybRpmsg_GetConfigInt(IntPtr hRpmsg, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybRpmsg_SetConfigString(IntPtr hRpmsg, string paramName, string pValue, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void VybRpmsg_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for spi functions 
class spi
{
    public enum eSpiMasterSlave
    {
        SpiMaster,             ///< Configure as Master Device
        SpiSlave               ///< Configure as Slave Device
    }

    public enum eSpiMode
    {
        SpiMode0,              ///< Mode 0 - Polarity (CPOL) 0, Phase (CPHA) 0
        SpiMode1,              ///< Mode 1 - Polarity (CPOL) 0, Phase (CPHA) 1
        SpiMode2,              ///< Mode 2 - Polarity (CPOL) 1, Phase (CPHA) 0
        SpiMode3               ///< Mode 3 - Polarity (CPOL) 1, Phase (CPHA) 1
    }
	
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Spi_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Spi_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Spi_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Spi_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Spi_Read(IntPtr hPort, IntPtr pbuf, UInt32 numberOfFrames);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Spi_Write(IntPtr hPort, IntPtr pbuf, UInt32 numberOfFrames);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Spi_ReadWrite(IntPtr hPort, IntPtr rxBuffer, IntPtr txBuffer, UInt32 numberOfFrames);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Spi_SetConfigString(IntPtr hPort, string paramName, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Spi_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Spi_GetConfigString(IntPtr hPort, string paramName, StringBuilder value, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Spi_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Spi_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for spi_imx6 functions 
class spi_imx6
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx6Spi_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Spi_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Spi_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Spi_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Spi_ReadWrite(IntPtr hPort, IntPtr rxBuffer, IntPtr txBuffer, UInt32 numberOfFrames);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Spi_Read(IntPtr hPort, IntPtr buffer, UInt32 numberOfFrames);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Spi_Write(IntPtr hPort, IntPtr buffer, UInt32 numberOfFrames);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Spi_GetConfigString(IntPtr hPort, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Spi_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Spi_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Spi_SetConfigString(IntPtr hPort, string paramName, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx6Spi_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for spi_imx7 functions 
class spi_imx7
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx7Spi_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Spi_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Spi_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Spi_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Spi_ReadWrite(IntPtr hPort, IntPtr rxBuffer, IntPtr txBuffer, UInt32 numberOfFrames);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Spi_Read(IntPtr hPort, IntPtr buffer, UInt32 numberOfFrames);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Spi_Write(IntPtr hPort, IntPtr buffer, UInt32 numberOfFrames);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Spi_GetConfigString(IntPtr hPort, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Spi_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Spi_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Spi_SetConfigString(IntPtr hPort, string paramName, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx7Spi_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for spi_teg functions 
class spi_teg
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr TegSpi_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegSpi_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegSpi_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegSpi_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegSpi_ReadWrite(IntPtr hPort, IntPtr rxBuffer, IntPtr txBuffer, UInt32 numberOfFrames);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegSpi_Read(IntPtr hPort, IntPtr buffer, UInt32 numberOfFrames);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegSpi_Write(IntPtr hPort, IntPtr buffer, UInt32 numberOfFrames);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegSpi_GetConfigString(IntPtr hPort, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegSpi_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegSpi_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegSpi_SetConfigString(IntPtr hPort, string paramName, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void TegSpi_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for spi_vyb functions 
class spi_vyb
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr VybSpi_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybSpi_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybSpi_Open(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybSpi_Close(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybSpi_ReadWrite(IntPtr hPort, IntPtr rxBuffer, IntPtr txBuffer, UInt32 numberOfFrames);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybSpi_Read(IntPtr hPort, IntPtr buffer, UInt32 numberOfFrames);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybSpi_Write(IntPtr hPort, IntPtr buffer, UInt32 numberOfFrames);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybSpi_GetConfigString(IntPtr hPort, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybSpi_SetConfigString(IntPtr hPort, string paramName, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybSpi_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybSpi_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void VybSpi_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for Sysinfo functions 
class Sysinfo
{
    [StructLayout(LayoutKind.Explicit)]
    public struct PID
    {
        [FieldOffset(0)]
        public Byte variant;

        [FieldOffset(1)]
        public Byte minVer;

        [FieldOffset(1)]
        public Byte majVer;

        [FieldOffset(2)]
        public UInt16 prodID;

        [FieldOffset(0)]
        public UInt32 value;
    };

    [StructLayout(LayoutKind.Explicit)]
    public struct version
    {
        [FieldOffset(0)]
        public Byte BSPID;

        [FieldOffset(0)]
        public Byte FormID;

        [FieldOffset(1)]
        public Byte Beta;

        [FieldOffset(2)]
        public Byte MinVer;

        [FieldOffset(3)]
        public Byte MajVer;

        [FieldOffset(0)]
        public UInt32 value;
    };

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Sys_Init();

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Sys_Deinit(IntPtr hSys);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Sys_GetConfigString(IntPtr hSys, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Sys_GetConfigInt(IntPtr hSys, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Sys_GetVersion(ref TdxCommon.tVersion ver);   
}

/// Dll Imports for update functions 
class update
{
	//[DllImport("TdxAllLibrariesDll.dll")]
	//public static extern typedef void (Upd_Callback)(UInt32 progress);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Upd_Init(string registryPath);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Upd_Deinit(IntPtr hUpdate);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Upd_Backup(IntPtr hUpdate);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Upd_Restore(IntPtr hUpdate);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Upd_SetConfigString(IntPtr hUpdate, string paramName, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Upd_SetConfigInt(IntPtr hUpdate, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Upd_GetConfigString(IntPtr hUpdate, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Upd_GetConfigInt(IntPtr hUpdate, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Upd_RegistrySave(IntPtr hUpdate);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Upd_RegistryClear(IntPtr hUpdate);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Upd_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for update_imx6 functions 
class update_imx6
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx6Upd_Init(string registryPath);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Upd_Deinit(IntPtr hUpdate);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Upd_Backup(IntPtr hUpdate);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Upd_Restore(IntPtr hUpdate);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Upd_SetConfigString(IntPtr hUpdate, string paramName, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Upd_SetConfigInt(IntPtr hUpdate, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Upd_GetConfigString(IntPtr hUpdate, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Upd_GetConfigInt(IntPtr hUpdate, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Upd_RegistrySave(IntPtr hUpdate);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Upd_RegistryClear(IntPtr hUpdate);

    [DllImport("TdxAllLibrariesDll.dll")]
    public static extern void Imx6Upd_GetVersion(ref TdxCommon.tVersion ver);
}

/// Dll Imports for update_imx7 functions 
class update_imx7
{

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx7Upd_Init(string registryPath);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Upd_Deinit(IntPtr hUpdate);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Upd_Backup(IntPtr hUpdate);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Upd_Restore(IntPtr hUpdate);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Upd_SetConfigString(IntPtr hUpdate, string paramName, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Upd_SetConfigInt(IntPtr hUpdate, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Upd_GetConfigString(IntPtr hUpdate, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Upd_GetConfigInt(IntPtr hUpdate, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Upd_RegistrySave(IntPtr hUpdate);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Upd_RegistryClear(IntPtr hUpdate);

    [DllImport("TdxAllLibrariesDll.dll")]
    public static extern void Imx7Upd_GetVersion(ref TdxCommon.tVersion ver);
}

/// Dll Imports for update_vyb functions 
class update_vyb
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr VybUpd_Init(string registryPath);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybUpd_Deinit(IntPtr hUpdate);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybUpd_Backup(IntPtr hUpdate);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybUpd_Restore(IntPtr hUpdate);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybUpd_SetConfigString(IntPtr hUpdate, string paramName, string value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybUpd_SetConfigInt(IntPtr hUpdate, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybUpd_GetConfigString(IntPtr hUpdate, string paramName, StringBuilder pValue, UInt32 maxBytes);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybUpd_GetConfigInt(IntPtr hUpdate, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybUpd_RegistrySave(IntPtr hUpdate);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybUpd_RegistryClear(IntPtr hUpdate);

    [DllImport("TdxAllLibrariesDll.dll")]
    public static extern void VybUpd_GetVersion(ref TdxCommon.tVersion ver);
}

/// Dll Imports for wdg functions 
class wdg
{

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Wdg_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Wdg_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Wdg_Refresh(IntPtr hPort, UInt32 timeMs);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Wdg_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Wdg_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Wdg_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for wdg_imx6 functions 
class wdg_imx6
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx6Wdg_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Wdg_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Wdg_Refresh(IntPtr hPort, UInt32 timeMs);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx6Wdg_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx6Wdg_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx6Wdg_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for wdg_imx7 functions 
class wdg_imx7
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr Imx7Wdg_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Wdg_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Wdg_Refresh(IntPtr hPort, UInt32 timeMs);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 Imx7Wdg_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool Imx7Wdg_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void Imx7Wdg_GetVersion(ref TdxCommon.tVersion ver);   
}

/// Dll Imports for wdg_teg functions 
class wdg_teg
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr TegWdg_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegWdg_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegWdg_Refresh(IntPtr hPort, UInt32 timeMs);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 TegWdg_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool TegWdg_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void TegWdg_GetVersion(ref TdxCommon.tVersion ver);    
}

/// Dll Imports for wdg_vyb functions 
class wdg_vyb
{
	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern IntPtr VybWdg_Init(string portName);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybWdg_Deinit(IntPtr hPort);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybWdg_Refresh(IntPtr hPort, UInt32 timeMs);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern UInt32 VybWdg_GetConfigInt(IntPtr hPort, string paramName, ref UInt32 pValue);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern bool VybWdg_SetConfigInt(IntPtr hPort, string paramName, UInt32 value, TdxCommon.ParamStorageType storageType);

	[DllImport("TdxAllLibrariesDll.dll")]
	public static extern void VybWdg_GetVersion(ref TdxCommon.tVersion ver);    
}
