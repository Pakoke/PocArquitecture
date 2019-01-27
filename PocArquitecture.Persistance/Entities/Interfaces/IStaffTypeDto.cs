namespace PocArquitecture.Persistance.Entities
{
    /// <summary>
    /// Defines the <see cref="IStaffTypeDto" />
    /// </summary>
    public interface IStaffTypeDto
    {
        int StaffTypeId { get; set; }

        string NameStaff { get; set; }

        string DescriptionStaff { get; set; }
    }
}
