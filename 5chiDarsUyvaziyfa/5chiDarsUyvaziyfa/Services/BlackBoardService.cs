using _5chiDarsUyvaziyfa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5chiDarsUyvaziyfa.Services;

public class BlackBoardService : IBlackBoardService
{
    List<BlackBoard> Boards;
    public BlackBoardService()
    {
        Boards = new List<BlackBoard>();
    }
    public Guid AddBlackBoard(BlackBoard blackBoard)
    {
        Guid guid = Guid.NewGuid();
        Boards.Add(blackBoard);
        return blackBoard.BlackBoardId;
    }

    public bool DeleteBlackBoard(Guid BlackBoardId)
    {
        foreach (BlackBoard blackBoard in Boards)
        {
            if(blackBoard.BlackBoardId == BlackBoardId)
            {
                Boards.Remove(blackBoard);
                return true;
            }
        }
        return false;
    }

    public List<BlackBoard> GetAllBlackBoard()
    {
        return Boards;
    }

    public BlackBoard? GetBlackBoardById(Guid BlackBoardId)
    {
        foreach(BlackBoard blackBoard in Boards)
        {
            if(blackBoard.BlackBoardId != null)
            {
                return blackBoard;
            }
        }
        return null;
    }

    public bool UpdateBlackBoard(BlackBoard updateblackBoard)
    {
        foreach(var blackboard  in Boards)
        {
            if(blackboard.BlackBoardId == updateblackBoard .BlackBoardId)
            {
                blackboard.height = updateblackBoard.height;
                blackboard.width = updateblackBoard.width;
                blackboard.Description = updateblackBoard .Description;
                blackboard.Name = updateblackBoard .Name;

                return true;
            }


        }
        return false;
    }
}
