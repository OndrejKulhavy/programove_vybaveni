using System;
using System.Collections.Generic;


namespace Cviceni_31._10._2022
{
    internal class Graf
    {
        List<Point> points = new List<Point>();
        public Graf()
        {
        }
        public void AddPoint(Point point)
        {
            points.Add(point);
        }
        public string SroubyAMatice()
        {
            return "Srouby a matice";
        }
        //open url
        public void PrintMatice()
        {
            System.Diagnostics.Process myProcess = new System.Diagnostics.Process();
            try
            {
                // true is the default, but it is important not to set it to false
                myProcess.StartInfo.UseShellExecute = true;
                myProcess.StartInfo.FileName = "https://youtu.be/xzi2vbGOJ7g";
                myProcess.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}