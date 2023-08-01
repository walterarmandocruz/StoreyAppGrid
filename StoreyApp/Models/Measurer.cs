using StoreyApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreyApp.Models
{
    public class Measurer
    {
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public string CustomerNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Notes { get; set; }
        public MeasurerStatus Status { get; set; }
        public DateTime LastLecture { get; set; }

        public Measurer(string model, string serialNumber,
                        string customerNumber, string name,
                        string address, string city,
                        string notes, MeasurerStatus status,
                        DateTime lastLecture)
        {
            Model = model;
            SerialNumber = serialNumber;
            CustomerNumber = customerNumber;
            Name = name;
            Address = address;
            City = city;
            Notes = notes;
            Status = status;
            LastLecture = lastLecture;
        }
    }
}