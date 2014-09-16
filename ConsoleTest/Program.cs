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

		static void Main (string[] args)
		{
			var program = new Program ();
			program.Test ();
			program.Run ();
		}

		Program ()
		{
			client = ServiceClientHelper.CreateServiceClient ();
			asyncEvent = new AutoResetEvent (false);
			client.TestOutCompleted += TestOutCompleted;
			client.TestByRefCompleted += TestByRefCompleted;
		}

		void Test ()
		{
			foreach (var op in client.Endpoint.Contract.Operations) {
				Console.WriteLine ("OP: {0}", op.Name);
				foreach (var message in op.Messages) {
					Console.WriteLine ("MESSAGE: {0}", message.Action);
					var body = message.Body;
					foreach (var part in body.Parts) {
						Console.WriteLine ("PART: {0}", part.Name);
					}
				}
			}
		}

		void Run ()
		{
			int test = 8;
			client.TestByRefAsync(2048, test);
			client.TestOutAsync ();
			asyncEvent.WaitOne ();
		}

		void TestOutCompleted (object sender, TestOutCompletedEventArgs e)
		{
			Console.WriteLine ("TEST: {0} {1}", e.Result, e.time);
		}

		void TestByRefCompleted (object sender, TestByRefCompletedEventArgs e)
		{
			Console.WriteLine ("TEST: {0} {1}", e.test, e.time);
			asyncEvent.Set ();
		}
	}
}
