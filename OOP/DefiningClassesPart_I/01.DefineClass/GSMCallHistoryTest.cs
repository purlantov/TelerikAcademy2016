using System;

namespace DefineClass
{
	public class GSMCallHistoryTest
	{
		public GSMCallHistoryTest ()
		{
		}

		public static void CallHistoryTest ()
		{
			var gsm = new GSM ("3310", "Nokia");
			gsm.AddCall (new Call (DateTime.Now.Date, DateTime.Now.ToShortTimeString (), "+3598886626262", 44));
			gsm.AddCall (new Call (DateTime.Now.Date, DateTime.Now.ToShortTimeString (), "+3598886626262", 32));
			gsm.AddCall (new Call (DateTime.Now.Date, DateTime.Now.ToShortTimeString (), "+3598886626262", 33));

			//Print history calls
			foreach (var item in gsm.CallHistory) {
				Console.WriteLine (item);
			}

			Console.WriteLine (new String ('-', 70)); // delimeter

			gsm.DeleteCall (1); //remove call

			//Print history calls
			foreach (var item in gsm.CallHistory) {
				Console.WriteLine (item);
			}

			gsm.RemoveLongestCall ();

			Console.WriteLine (new String ('-', 70)); // delimeter

			//Print history calls
			foreach (var item in gsm.CallHistory) {
				Console.WriteLine (item);
			}
		}
	}
}

