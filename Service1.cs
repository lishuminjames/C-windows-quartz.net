using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Timer = System.Timers.Timer;

//using SmartTest.BLL;
//using SmartTest.Model;
using System.Data.Entity;
using Quartz;
using log4net;
using Quartz.Impl;


namespace GetBaseDataWindowsService
{
    public partial class Service1 : ServiceBase
    {
        private readonly ILog logger;
        //private readonly ILog logger = LogManager.GetLogger(typeof(TestJob));
        private IScheduler scheduler;


        public Service1()
        {
            InitializeComponent();
            logger = LogManager.GetLogger(typeof(Service1));
            ISchedulerFactory schedulerFactory = new StdSchedulerFactory();
            scheduler = schedulerFactory.GetScheduler();
        }

        protected override void OnStart(string[] args)
        {
            scheduler.Start();
            logger.Info("Quartz服务成功启动");
        }

        protected override void OnStop()
        {
            scheduler.Shutdown();
            logger.Info("Quartz服务成功终止");
        }

        protected override void OnPause()
        {
            scheduler.PauseAll();
        }

        protected override void OnContinue()
        {
            scheduler.ResumeAll();
        }

    }
    //public partial class Service1 : ServiceBase
    //{
    //    private Timer timer = new Timer();     //计时器 
    //    public Service1()
    //    {
    //        InitializeComponent();
    //    }

    //    protected override void OnStart(string[] args)
    //    {
    //        EventLog.WriteEntry("我的服务启动");
    //        Writestr("服务启动");
    //        timer = new Timer();
    //        timer.Interval = 1000;//设置计时器事件间隔执行时间
    //        timer.Elapsed += new ElapsedEventHandler(ChkSrv);
    //        timer.Enabled = true;
    //        timer.AutoReset = true;//设置是执行一次（false）还是一直执行(true)；  

    //    }

    //    protected override void OnStop()
    //    {
    //        this.timer.Enabled = false;
    //        Writestr("服务停止");
    //        EventLog.WriteEntry("我的服务停止");
    //    }

    //    /// <summary>  
    //    /// 定时检查，并执行方法  
    //    /// </summary>  
    //    /// <param name="source"></param>  
    //    /// <param name="e"></param>  
    //    public void ChkSrv(object source, System.Timers.ElapsedEventArgs e)
    //    {

    //        int intHour = e.SignalTime.Hour;
    //        int intMinute = e.SignalTime.Minute;
    //        int intSecond = e.SignalTime.Second;

    //        if (intHour == 16 && intMinute == 25 && intSecond == 00) //定时设置,判断分时秒  
    //        {
    //            try
    //            {
    //                System.Timers.Timer tt = (System.Timers.Timer)source;
    //                tt.Enabled = false;
    //                SetInnPoint();
    //                tt.Enabled = true;
    //            }
    //            catch (Exception err)
    //            {
    //                Writestr(err.Message);
    //            }
    //        }

    //    }
    //    //我的方法  
    //    public void SetInnPoint()
    //    {
    //        try
    //        {
    //            Writestr("服务运行");
    //            //这里执行你的东西  
    //            var obj = new JObject();
    //            UserInfo userInfo = new UserInfo();
    //            userInfo.id = new Guid("00400000-0000-0020-0000-000035000f00");
    //            userInfo.UserName = "lsm";
    //            userInfo.HeadImage = "lsmheadimage";
    //            userInfo.LoginTime = new DateTime(2017, 8, 18).Date;
    //            userInfo.Phone = "18365409646";
    //            userInfo.Password = "123456";
    //            // var aa = JsonConvert.SerializeObject(List<UserModel>);
    //            new UserInfoService().AddEntity(userInfo);

    //            obj.Add("message", "successs");
    //            Thread.Sleep(10000);
    //        }
    //        catch (Exception err)
    //        {
    //            Writestr(err.Message);
    //        }
    //    }
    //    /// <summary>
    //    /// 记录操作日志
    //    /// </summary>
    //    /// <param name="readme"></param>
    //    public void Writestr(string readme)
    //    {
    //        //debug==================================================  
    //        //StreamWriter dout = new StreamWriter(@"c:\" + System.DateTime.Now.ToString("yyyMMddHHmmss") + ".txt");  
    //        StreamWriter dout = new StreamWriter(@"c:\" + "WServ_InnPointLog.txt", true);
    //        dout.Write("\r\n事件：" + readme + "\r\n操作时间：" + System.DateTime.Now.ToString("yyy-MM-dd HH:mm:ss"));
    //        //debug==================================================  
    //        dout.Close();
    //    }

    //}
}

