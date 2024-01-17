using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace GUI_Friendly_PWM_ADC_GPIO_Application
{
    public partial class GUI : Form
    {
        IntPtr[] AdcValue;
        IntPtr[] Adc;
        IntPtr PulseOut, led;
        Boolean returnValue, GPIOINIT = false, ADCINIT = false, PWMINIT = false, stopTimerstarted = false;
        gpio.uIo ledport = new gpio.uIo();

        //imp data below
        uint frequency;
        uint dutyCycle;

        //------------------------------------------------------------------------  ADC value to be printed in box

        public GUI()
        {
            InitializeComponent();
        }

        void InitGPIO(IntPtr hGpio, ref gpio.uIo releasePort, ushort pinNumber, gpio.tIoDirection dir)
        {
            hGpio = gpio_vyb.VybGpio_Init(null);
            releasePort.ColibriPin.nr = pinNumber;
            releasePort.type = (ushort)gpio.tIoType.ioColibriPin;
            gpio_vyb.VybGpio_ConfigureAsGpio(hGpio, releasePort);
            gpio_vyb.VybGpio_SetDir(hGpio, releasePort, dir);
            GPIOINIT = true;
        }

        void InitADC(int Channels)
        {
            AdcValue = new IntPtr[Channels];
            Adc = new IntPtr[Channels];

            for (int i = 0; i < Channels; i++)
            {
                AdcValue[i] = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(uint)));
                String ChName = "ADC" + (i + 1);
                Adc[i] = adc_vyb.VybAdc_Init(ChName);
                if (Adc[i] == null)
                {
                    MessageBox.Show("ADC not Initialize");
                }
                returnValue = adc_vyb.VybAdc_SetConfigInt(Adc[i], "BitResolution", 12, TdxCommon.ParamStorageType.StoreVolatile);
                returnValue = adc_vyb.VybAdc_SetConfigInt(Adc[i], "AvgSamples", 16, TdxCommon.ParamStorageType.StoreVolatile);
                returnValue = adc_vyb.VybAdc_Open(Adc[i]);
            }

            ADCINIT = true;
        }

        void DeInitADC(int Channels)
        {
            for (int i = 0; i < Channels; i++)
            {
                adc_vyb.VybAdc_Deinit(Adc[i]);
            }
            ADCINIT = false;
        }

        void InitPulseOut()
        {
            PulseOut = pwm_vyb.VybPwm_Init("PWM2");
            if (PulseOut == null)
                MessageBox.Show("Pulse Module Error....");

            pwm_vyb.VybPwm_SetConfigInt(PulseOut, "baseFreq", /*515625*/33000000, TdxCommon.ParamStorageType.StoreVolatile);  //this is returning false for now, which means error is prior this line
        }

        void StopPulse()
        {
            if (pwm_vyb.VybPwm_Open(PulseOut) == true)
                pwm_vyb.VybPwm_Close(PulseOut);
            pwm_vyb.VybPwm_Deinit(PulseOut);
            PWMINIT = false;
            freq.Hide();
            duty.Hide();
            freqChange.Hide();
            stopPWM.Hide();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            duty.Hide();
            freq.Hide();
            freqChange.Hide();
            stopPWM.Hide();
            stopADC.Hide();
            valueADC1.Hide();
            valueADC2.Hide();
        }

        private void picPWM_Click(object sender, EventArgs e)
        {
            InitPulseOut();
            pwm_vyb.VybPwm_Open(PulseOut);
            freq.Show();
            freqChange.Show();
        }

        private void duty_ValueChanged(object sender, EventArgs e)
        {
            dutyCycle = (UInt32)duty.Value;
            pwm_vyb.VybPwm_SetPwm(PulseOut, frequency, dutyCycle * 1024);
            stopPWM.Show();
            PWMINIT = true;
        }

        private void freq_ValueChanged(object sender, EventArgs e)
        {
            frequency = (UInt32)freq.Value;
            freqChange.Text = frequency.ToString() + " Hz";

            pwm_vyb.VybPwm_SetPwm(PulseOut, frequency, dutyCycle * 1024);
            duty.Show();
        }

        private void stopPWM_Click(object sender, EventArgs e)
        {
            StopPulse();
        }

        private void picADC_Click(object sender, EventArgs e)
        {
            valueADC1.Show();
            valueADC2.Show();
            stopADC.Show();

            InitADC(2);

            ADC1ON.Text = "ADC1 -> ON";
            ADC2ON.Text = "ADC2 -> ON";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            adc_vyb.VybAdc_Read(Adc[0], AdcValue[0], 4);
            valueADC1.Text = ((uint)Marshal.ReadInt32(AdcValue[0]) / 1000000.000f).ToString();

            adc_vyb.VybAdc_Read(Adc[1], AdcValue[1], 4);
            valueADC2.Text = ((uint)Marshal.ReadInt32(AdcValue[1]) / 1000000.000f).ToString();
        }

        private void stopADC_Click(object sender, EventArgs e)
        {
            ADC1ON.Text = "ADC1 -> OFF";
            ADC2ON.Text = "ADC2 -> OFF";
            valueADC1.Hide();
            valueADC2.Hide();
            DeInitADC(2);
            stopADC.Hide();
        }

        private void GUI_Closing(object sender, CancelEventArgs e)
        {
            if (PWMINIT == true)
            {
                StopPulse();
            }

            if (ADCINIT == true)
            {
                DeInitADC(2);
            }

            if (GPIOINIT == true)
            {
                gpio_vyb.VybGpio_Deinit(led);
            }
        }

        private void timerPWM_Tick(object sender, EventArgs e)
        {
            if (PWMINIT == true)
            {
                StopPulse();
                stopTimerstarted = true;
            }
        }

        private void timerstartPWM_Tick(object sender, EventArgs e)
        {
            if (stopTimerstarted == true)
            {
                InitPulseOut();
                pwm_vyb.VybPwm_Open(PulseOut);
                freq.Show();
                freqChange.Show();
                PWMINIT = true;
            }
        }
    }
}
