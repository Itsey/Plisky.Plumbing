﻿namespace Plisky.Test {

    internal class Program {

        private static int Main(string[] args) {
           // Original();
            NewOne();
            return 5;
        }

        private static void NewOne() {
#if false
            NewBilge nb = new NewBilge("Context");
            
            nb.AddHandler(new TCPHandler("127.0.0.1", 9060));
            //nb.AddHandler(new ODSHandler());
           // nb.Error.Log("Hello");
            nb.Info.Log("ONLINE (NEW) .......");
            Console.WriteLine("This is written to the console NEW");
            Console.Error.WriteLine("this is written to the error NEW ");
           // nb.Info.Log("DONE....");
            for (int i = 0; i < 10; i++) {
                Thread.Sleep(200);
            }

            Emergency.Diags.Shutdown();
            Console.WriteLine("Hit a key");
            Console.ReadLine();
            //nb.Info.Log("REALLY ? .....");
            CommandArgumentSupport cas = new CommandArgumentSupport();
        }

      /*  private static void Original() {
            OldBilge.QueueMessages = false;
            OldBilge.Log("ONLINE.....");
            Console.WriteLine("This is written to the console");
            Console.Error.WriteLine("this is written to the error");
            OldBilge.Log("DONE....");
            Thread.Sleep(2000);
            OldBilge.Log("REAlly");
        }*/
#endif 

            }
    }
}