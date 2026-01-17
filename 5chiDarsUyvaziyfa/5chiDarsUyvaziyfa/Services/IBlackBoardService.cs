using _5chiDarsUyvaziyfa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5chiDarsUyvaziyfa.Services;

public interface IBlackBoardService
{
    public Guid AddBlackBoard(BlackBoard blackBoard);
    public bool DeleteBlackBoard(Guid BlackBoardId);
    public bool UpdateBlackBoard(BlackBoard blackBoard);
    public BlackBoard? GetBlackBoardById(Guid BlackBoardId);
    public List<BlackBoard> GetAllBlackBoard();
}
