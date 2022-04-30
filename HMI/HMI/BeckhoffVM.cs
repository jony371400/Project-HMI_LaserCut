using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControllerBase;
using BeckhoffControllerBase;
using TwinCAT.Ads;

namespace HMI
{
    public class BeckhoffVM
    {
        IControll Controll ;
        BeckhoffChannel Channel;
        //IVariable Test_PLC = null;

        public BeckhoffVM()
        {
            Controll = new BeckhoffController();
            Controll.LoadConfig(System.Environment.CurrentDirectory + "\\BeckhoffConfig.xml");
            Controll.Connect();
            Controll.Mapping(); //處理時程過長   

            Channel = (BeckhoffChannel)Controll.CNC.Channel[0];
            //Test_PLC = Controll
        }
    }
}