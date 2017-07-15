using LockBoxAPI.Data;
using LockBoxAPI.Models;

namespace LockBoxAPI.Handlers.Interfaces
{
    public interface ILockSessionHandler
    {
        LockSessionModel GetSession(string guid);
    }
}