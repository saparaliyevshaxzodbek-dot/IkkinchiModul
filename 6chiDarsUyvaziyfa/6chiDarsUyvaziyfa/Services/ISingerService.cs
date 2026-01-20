using _6chiDarsUyvaziyfa.Dtos;

namespace _6chiDarsUyvaziyfa.Services
{
    public interface ISingerService
    {
        public Guid AddSinger(SingerCreateDto singerCreateDto);
        public SingerGetDto? GetSingerById(Guid singerId);
        public List<SingerGetDto> GetAllSingers();
        public bool DeleteSinger(Guid singerId);
        public bool UpdateSinger(Guid singerId , SingerUpdateDto singerUpdateDto);
        public SingerGetDto? GetSingerWithMaxPlays();
        public SingerGetDto? GetAllSingersWithMaxMusic();
        public SingerGetDto? GetAllSingersWithMaxAward();
        public SingerGetDto? GetSingerWithMinPlays();
        public SingerGetDto? GetAllSingersWithMinMusic();
        public SingerGetDto? GetAllSingersWithMinAward();
        public List<SingerGetDto> GetTopSingersWithMaxPlays(int count);
        public List<SingerGetDto> GetTopSingersWithMinPlays(int count);
        public List<SingerGetDto> GetSingersByGenre (string genre); 

    }
}