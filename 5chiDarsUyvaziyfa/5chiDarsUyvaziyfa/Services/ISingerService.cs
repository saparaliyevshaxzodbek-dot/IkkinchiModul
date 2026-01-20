using _5chiDarsUyvaziyfa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5chiDarsUyvaziyfa.Services;

public interface ISingerService
{
    public Guid AddSinger(Singer singer);
    public bool DeleteSinger(Guid singerId);
    public bool UpdateSinger(Singer singer);
    public List<Singer> GetAllSinger();
    public Singer? GetSingerById(Guid singerId);
}
