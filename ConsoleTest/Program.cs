using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestWCF
{
	class Program
	{
		MyServiceClient client;
		AutoResetEvent asyncEvent;

		static void Main(string[] args)
		{
			var program = new Program();
			program.Run();
		}

		Program ()
		{
			client = ServiceClientHelper.CreateServiceClient();
			asyncEvent = new AutoResetEvent(false);
			client.TestByRefCompleted += TestByRefCompleted;
		}

		void Run ()
		{
			var result = new ManualResetEvent(false);
			int test = 8;
			client.TestByRefAsync(test);
			asyncEvent.WaitOne();
		}

		void TestByRefCompleted(object sender, TestByRefCompletedEventArgs e)
		{
			Console.WriteLine("TEST: {0}", e.test);
			asyncEvent.Set();
		}
	}
}
