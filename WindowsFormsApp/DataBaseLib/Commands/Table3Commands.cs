using DataBaseLib.Access;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table3Commands : ITableEditorCommand
    {
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Select(string[] args)
        {

        }

        public void Insert(string[] args)
        {
            string query = $"INSERT INTO [жанр] " +
                    $"([Жанр книги]) " +
                    $"VALUES ('{args[1]}')";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [жанр]
                    SET [Жанр книги] = {args[1]};
                    WHERE [ID жанра] = {args[0]}";
            controller.ExecuteCommand(query);
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [жанр] " +
                   $"WHERE [ID жанра] = {args[0]}";
            controller.ExecuteCommand(query);
        }
    }
}
