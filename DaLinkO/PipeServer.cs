using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DaLinkO
{

    public class PipeServer
    {

        DataManager activePacks;
        Form1 backwardsForm1;

        public PipeServer(DataManager b, Form1 f)
        {
            activePacks = b;
            backwardsForm1 = f;
        }

        public bool debugMods  { get; set; }

        string beansToText;

        bool running;
        Thread runningThread;
        //EventWaitHandle terminateHandle = new EventWaitHandle(false, EventResetMode.AutoReset); 
        //for some reason one of the examples online for the pipeserver used this, when it's active though it severely limits 
        //the rate at which new servers are created.
        public string PipeName { get; set; }

        void ServerLoop()
        {

            while (running)
            {
                ProcessNextClient();
                //terminateHandle.WaitOne();
            }
           

        }

        public void Run()
        {
            running = true;
            runningThread = new Thread(ServerLoop);
            runningThread.Start();

        }

        public void Stop()
        {
            running = false;
            runningThread.Abort();
        }

        public void ProcessClientThread(object o) //must pass namedpipeserverstream
        {
            
            NamedPipeServerStream pipeStream = (NamedPipeServerStream)o;
            XmlSerializer deserializer = new XmlSerializer(typeof(DR));
            
            if (debugMods == false) //if not in debugg mode then process the incoming data into Beans
            {
                DR newbeans = new DR();
            using (TextReader reader = new StreamReader(pipeStream))  
                {
                    try
                    {
                        newbeans = (DR)deserializer.Deserialize(reader);
                    }
                    catch (Exception)
                    {
                    }
                }
            activePacks.updateDataPacks(newbeans);
            }
            else  //if in debugg mode send the data as text to the debugg box
            {
                using (StreamReader reader = new StreamReader(pipeStream))  //works with StreamReader
                    {
                    beansToText = reader.ReadToEnd();
                    backwardsForm1.reportToDebugTexbox(beansToText);
                    }
            }

                pipeStream.Close();
                pipeStream.Dispose();
                //terminateHandle.Set();
            

        }

        public void ProcessNextClient()
        {
            try
            {
                NamedPipeServerStream pipeStream = new NamedPipeServerStream(PipeName, PipeDirection.InOut, -1);
                pipeStream.WaitForConnection();

                //Spawn a new thread for each request and continue waiting
                Task.Factory.StartNew(() => ProcessClientThread(pipeStream));

            }
            catch (Exception)
            {//if more than 254 in use this triggers
            }
        }


        public void CloseServer()
        {
            Stop();

        }



        public String ProvideXMLinString()
        {
            return beansToText;
        }


    }
}