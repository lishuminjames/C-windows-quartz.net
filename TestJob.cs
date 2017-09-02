using System;
using Common.Logging;
using log4net;
using Newtonsoft.Json.Linq;
using Quartz;
//using SmartTest.BLL;
//using SmartTest.Model;

namespace GetBaseDataWindowsService
{
    public sealed class TestJob : IJob
    {
       // private readonly ILog _logger = LogManager.GetLogger(typeof(TestJob));
         private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType); 
        public void Execute(IJobExecutionContext context)
        {
           _logger.InfoFormat("TestJob测试");
            //_logger.InfoFormat(AddData().ToString());
        }

        //private JObject AddData()
        //{
        //    _logger.InfoFormat("开始往数据库插入数据！");
        //    _logger.ErrorFormat("assf");
        //    var obj = new JObject();
        //    UserInfo userInfo = new UserInfo();
        //    userInfo.id = new Guid();
        //    userInfo.UserName = "lsm";
        //    userInfo.HeadImage = "lsmheadimage";
        //    userInfo.LoginTime = new DateTime(2017, 8, 18).Date;
        //    userInfo.Phone = "18365409646";
        //    userInfo.Password = "123456";
        //    var aa = JsonConvert.SerializeObject(List<UserModel>);
        //    new UserInfoService().AddEntity(userInfo);

        //    obj.Add("message", "successs");
        //    return obj;
        //}
    }
}