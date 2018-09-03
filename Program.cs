using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace hamid
{
    class Program   { 
         private SerialPort port = new SerialPort("/dev/ttyUSB0");
         
          [STAThread]
         static void Main(string[] args)
        {
             new Program();
       }

       private void SerialPortProgram()
    {
      Console.WriteLine("Incoming Data:");

      // Attach a method to be called when there
      // is data waiting in the port's buffer
      port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
      // Begin communications
      port.Open();

      // Enter an application loop to keep this thread alive
      Application.Run();
    }
    private void port_DataReceived(object sender,SerialDataReceivedEventArgs e)
    {
      // Show all the incoming data in the port's buffer
      Console.WriteLine(port.ReadExisting());
    }

    }
}
