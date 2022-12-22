using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PressureSystemInformation_Vbeta1.Test;

namespace PressureSystemInformation_Vbeta1.Report
{
    public class ReportTest
    {
        /// <summary>
        /// Fecha de prueba
        /// </summary>
        public DateTime dateOfTest { get; set; }
        /// <summary>
        /// Datos generales del reporte
        /// </summary>
        public int reportID { get; set; }
        public string reportName { get; set; }
        /// <summary>
        /// Datos del cliente
        /// </summary>
        public string clientName { get; set; }
        public string clienID { get; set; }
        /// <summary>
        /// Datos del operador
        /// </summary>
        public string operatorName { get; set; }
        public string operatorObservations { get; set; }
        /// <summary>
        /// Datos del equipo
        /// </summary>
        public string deviceName { get; set; }
        public string serialNumber { get; set; }
        public string transducerSerial { get; set; }
        public DateTime deviceExpires { get; set; }
        public string deviceDescription { get; set; }
        /// <summary>
        /// Prueba realizadad
        /// </summary>
        public LeakTest test;
        public double maxPressure { get; set; }
        public double minPressure { get; set; }
        public ReportTest(LeakTest test,
            string clientName,
            string clientID,
            string opName,
            string opObs,
            string devName,
            string devSerial,
            string tranSerial,
            string devDesc,
            DateTime devExp)
        {
            dateOfTest = DateTime.Today;
            this.test = test;

            this.clientName = clientName;
            this.clienID = clientID;
            operatorName = opName;
            operatorObservations = opObs;
            deviceName = devName;
            serialNumber = devSerial;
            transducerSerial = tranSerial;
            deviceDescription = devDesc;
            deviceExpires = devExp;

            GetID();
        }

        private void GetID() 
        {
            Random rng = new Random();
            reportID = rng.Next();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            reportName = Convert.ToString(reportID)+"-"+Convert.ToString(dateOfTest.Year)+"-";
            reportName += chars[rng.Next(0, 25)];
            reportName += chars[rng.Next(0, 25)];
            reportName += chars[rng.Next(0, 25)];

        }

    }
}
