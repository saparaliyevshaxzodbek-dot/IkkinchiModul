using _5chiDarsUyvaziyfa.Models;

namespace _5chiDarsUyvaziyfa.Services;

public class SingerService : ISingerService
{
    List<Singer> SingerList;
    public SingerService()
    {
        SingerList = new List<Singer>();
    }

    public bool DeleteSinger(Guid singerId)

    {
        foreach (Singer singer in SingerList)
        {
            if (singer.SingerId == singerId)
            {
                SingerList.Remove(singer);
                return true;
            }
        }
        return false;
    }

    public List<Singer> GetAllSinger()
    {
        return SingerList; 
    }



}
