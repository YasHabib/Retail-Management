using Retail_Management_WPF.UserInterface.Models;
using System.Threading.Tasks;

namespace Retail_Management_WPF.UserInterface.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}