using _6chiDarsUyvaziyfa.Dtos;
using _6chiDarsUyvaziyfa.Models;

namespace _6chiDarsUyvaziyfa.Services;

public class SingerService : ISingerService
{
    List<Singer> Singers;
    public SingerService()
    {
        Singers = new List<Singer>();
    }
    public Guid AddSinger(SingerCreateDto singerCreateDto)
    {
        var singer = new Singer()
        {
            SingerId = Guid.NewGuid(),
            FirstName = singerCreateDto.FirstName,
            LastName = singerCreateDto.LastName,
            SingerName = singerCreateDto.SingerName,
            Password = singerCreateDto.Password,
            MusicNames = singerCreateDto.MusicNames,
            Genres = singerCreateDto.Genres,
            Awards = singerCreateDto.Awards,
            TotalPlays = 0
        };

        Singers.Add(singer);
        return singer.SingerId;
    }

    public bool DeleteSinger(Guid singerId)
    {
        foreach (var singer in Singers)
        {
            if (singer.SingerId == singerId)
            {
                Singers.Remove(singer);
                return true;
            }
        }
        return false;
    }

    public List<SingerGetDto> GetAllSingers()
    {
        var singerGetDtos = ToSingerGetDtos(Singers);
        return singerGetDtos;
    }

    public SingerGetDto? GetAllSingersWithMaxAward()
    {

        if (Singers.Count == 0)
        {
            return null;
        }

        var singersWithMaxAward = Singers[0];
        foreach (var singer in Singers)
        {
            if (singersWithMaxAward.Awards.Count() < singer.Awards.Count())

            {
                singersWithMaxAward = singer;
            }
        }

        return ToSingerGetDto(singersWithMaxAward);
    }

    public SingerGetDto? GetAllSingersWithMaxMusic()
    {
        if (Singers.Count == 0)
        {
            return null;
        }

        var singersWithMaxMusic = Singers[0];
        foreach (var singer in Singers)
        {
            if (singersWithMaxMusic.MusicNames.Count() < singer.Awards.Count())

            {
                singersWithMaxMusic = singer;
            }
        }

        return ToSingerGetDto(singersWithMaxMusic);
    }

    public SingerGetDto? GetAllSingersWithMinAward()
    {
        if (Singers.Count == 0)
        {
            return null;
        }

        var singersWithMinAward = Singers[0];
        foreach (var singer in Singers)
        {
            if (singersWithMinAward.Awards.Count() > singer.Awards.Count())

            {
                singersWithMinAward = singer;
            }
        }

        return ToSingerGetDto(singersWithMinAward);
    }

    public SingerGetDto? GetAllSingersWithMinMusic()
    {
        if (Singers.Count == 0)
        {
            return null;
        }

        var singersWithMinMusic = Singers[0];
        foreach (var singer in Singers)
        {
            if (singersWithMinMusic.MusicNames.Count() > singer.Awards.Count())

            {
                singersWithMinMusic = singer;
            }
        }

        return ToSingerGetDto(singersWithMinMusic);
    }

    public SingerGetDto? GetSingerById(Guid singerId)
    {
        foreach (var singer in Singers)
        {
            if (singer.SingerId == singerId)
            {
                return ToSingerGetDto(singer);
            }
        }
        return null;
    }

    public List<SingerGetDto> GetSingersByGenre(string genre)
    {
        var singerGetDtos = new List<SingerGetDto>();
        foreach (var singer in Singers)
        {
            if (singer.Genres.Contains(genre))
            {
                singerGetDtos.Add(ToSingerGetDto(singer));
            }
        }
        return singerGetDtos;
    }

    public SingerGetDto? GetSingerWithMaxPlays()
    {
        if (Singers.Count() == 0)
        {
            return null;
        }

        var singerWithMaxPlays = Singers[0];
        foreach (var singer in Singers)
        {
            if (singerWithMaxPlays.TotalPlays < singer.TotalPlays)
            {
                {
                    singerWithMaxPlays = singer;
                }
            }

        }

        return ToSingerGetDto(singerWithMaxPlays);
    }

    public SingerGetDto? GetSingerWithMinPlays()
    {

        if (Singers.Count() == 0)
        {
            return null;
        }

        var singerWithMinPlays = Singers[0];
        foreach (var singer in Singers)
        {
            if (singerWithMinPlays.TotalPlays > singer.TotalPlays)
            {
                {
                    singerWithMinPlays = singer;
                }
            }

        }

        return ToSingerGetDto(singerWithMinPlays);

    }

    public List<SingerGetDto> GetTopSingersWithMaxPlays(int count)
    {
        var singers = Singers.OrderBy(s => s.TotalPlays).Take(count).ToList();
        return ToSingerGetDtos(singers);
    }

    public List<SingerGetDto> GetTopSingersWithMinPlays(int count)
    {
        throw new NotImplementedException();
    }

    public bool UpdateSinger(Guid singerId, SingerUpdateDto singerUpdateDto)
    {
        foreach (var singer in Singers)
        {
            if (singer.SingerId == singerId)
            {
                singer.SingerName = singerUpdateDto.SingerName;
                singer.FirstName = singerUpdateDto.FirstName;
                singer.LastName = singerUpdateDto.LastName;
                singer.Awards = singerUpdateDto.Awards;
                singer.Genres = singerUpdateDto.Genres;
                singer.Password = singerUpdateDto.Password;
                singer.MusicNames = singerUpdateDto.MusicNames;

                return true;
            }
        }

        return false;
    }

    private SingerGetDto ToSingerGetDto(Singer singer)
    {
        return new SingerGetDto()
        {
            SingerId = singer.SingerId,
            FirstName = singer.FirstName,
            LastName = singer.LastName,
            SingerName = singer.SingerName,
            MusicNames = singer.MusicNames,
            Genres = singer.Genres,
            Awards = singer.Awards,
            TotalPlays = singer.TotalPlays,
        };
    }

    private List<SingerGetDto> ToSingerGetDtos(List<Singer> singers)
    {
        var singerGetDtos = new List<SingerGetDto>();
        foreach (var singer in singers)
        {
            singerGetDtos.Add(ToSingerGetDto(singer));
        }
        return singerGetDtos;
    }
}
