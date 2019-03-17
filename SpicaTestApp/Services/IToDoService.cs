using System;
using System.Threading.Tasks;
using SpicaTestApp.Contracts;

namespace SpicaTestApp.Services
{
    public interface IToDoService
    {
        Task<GetToDoItemsResponse> GetToDoItems();
    }
}
