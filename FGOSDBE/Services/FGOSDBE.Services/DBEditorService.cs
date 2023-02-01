using FGOSDBE.Services.Interfaces;

namespace FGOSDBE.Services
{
    public class DBEditorService : IDBEditorService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
