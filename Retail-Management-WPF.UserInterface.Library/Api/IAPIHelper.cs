using Retail_Management_WPF.UserInterface.Models;
using System.Threading.Tasks;

namespace Retail_Management_WPF.UserInterface.Library.Api
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task GetLoggedInUserInfo(string token);
    }
}