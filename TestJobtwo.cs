using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Logging;
using Quartz;
using log4net;

namespace GetBaseDataWindowsService
{
    public sealed class TestJobtwo : IJob
    {
        private static readonly log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public void Execute(IJobExecutionContext context)
        {
            _logger.InfoFormat("TestJobtwo测试");
            //_logger.InfoFormat(AddData().ToString());
        }
    }
}
