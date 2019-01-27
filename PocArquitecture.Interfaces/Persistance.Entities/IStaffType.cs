namespace PocArquitecture.Interfaces.Persistance.Entities
{
    /// <summary>
    /// Defines the <see cref="IStaffType" />
    /// </summary>
    public interface IStaffType
    {
        int StaffTypeId { get; set; }

        string NameStaff { get; set; }

        string DescriptionStaff { get; set; }
    }
}
