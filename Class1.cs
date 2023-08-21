using System;

public class VName
{
    public int VNameId { get; set; }
    public string OwnerName { get; set; }
    public string ContactNo { get; set; }
    public string Location { get; set; }
    public DateTime CreatedOn { get; set; }

    public VName(string ownerName, string contactNo, string location)
    {
        OwnerName = ownerName;
        ContactNo = contactNo;
        Location = location;
        CreatedOn = DateTime.Now;
    }
}

public class Vehicle
{
    public int VehicleId { get; set; }
    public string VehicleNoPlate { get; set; }
    public int VNameId { get; set; }
    public string VehicleName { get; set; }
    public DateTime CreatedOn { get; set; }

    public Vehicle(string vehicleNoPlate, int vNameId, string vehicleName)
    {
        VehicleNoPlate = vehicleNoPlate;
        VNameId = vNameId;
        VehicleName = vehicleName;
        CreatedOn = DateTime.Now;
    }
}

public class ParkingTicket
{
    public int ParkingTicketId { get; set; }
    public int VehicleId { get; set; }
    public int VNameId { get; set; }
    public DateTime IssueDate { get; set; }
    public decimal Amount { get; set; }
    public DateTime CreatedOn { get; set; }

    public ParkingTicket(int vehicleId, int vNameId, DateTime issueDate, decimal amount)
    {
        VehicleId = vehicleId;
        VNameId = vNameId;
        IssueDate = issueDate;
        Amount = amount;
        CreatedOn = DateTime.Now;
    }
}
