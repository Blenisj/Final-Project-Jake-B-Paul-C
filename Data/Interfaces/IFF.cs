namespace Final_Project.Interfaces
{
    public interface IFF
    {
        int? AddFood(FavoriteFood f);
        List<FavoriteFood> GetAllFoods();
        FavoriteFood GetFoodsById(int Id);
        int? RemoveFoodsById(int id);
        int? UpdateFoods(FavoriteFood f);
    }
}
