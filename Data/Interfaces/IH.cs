namespace Final_Project.Interfaces
{
    public interface IH
    {
        int? AddHobby(Hobby h);
        List<Hobby> GetAllHobbys();
        Hobby GetHobbysById(int Id);
        int? RemoveHobbysById(int id);
        int? UpdateHobbys(Hobby h);
    }
}
