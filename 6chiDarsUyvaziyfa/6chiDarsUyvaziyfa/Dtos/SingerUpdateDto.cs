using System;
using System.Collections.Generic;
using System.Text;

namespace _6chiDarsUyvaziyfa.Dtos;

public class SingerUpdateDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Password { get; set; }
    public string SingerName { get; set; }
    public List<string> MusicNames { get; set; }
    public List<string> Genres { get; set; }
    public List<string> Awards { get; set; }
}
