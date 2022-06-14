namespace PropertyManagementSystem.Domain;

public class Room
{
    public int RoomId { get; set; }
    public int RoomNumber { get; set; }
    public string RoomType { get; set; }
    public bool Occupied { get; set; }
    public bool Clean { get; set; }
}
