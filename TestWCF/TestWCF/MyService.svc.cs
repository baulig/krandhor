﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace TestWCF
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
	// NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
	public class MyService : IMyService
	{
		public int Delay(int timespan)
		{
			Thread.Sleep(timespan);
			return 0;
		}

		public void TestByRef(ref int test, long foo)
		{
			test = -test;
		}
	}
}
