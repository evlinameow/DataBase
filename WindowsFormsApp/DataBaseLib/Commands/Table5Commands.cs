using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table5Commands : ITableEditorCommand
    {
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Select(string[] args)
        {

        }

        public void Insert(string[] args)
        {
            string query = $"INSERT INTO [main] " +
                    $"([ID книги], [ID клиента], [Дата покупки], [Стоимость]) " +
                    $"VALUES ({args[1]}, {args[2]}, '{args[3]}', {args[4]})";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [main]
                    SET [ID книги] = {args[1]}, [ID клиента] = {args[2]}, [Дата покупки] = {args[3]}, [Стоимость] = {args[4]};
                    WHERE [ID] = {args[0]}";
            controller.ExecuteCommand(query);

        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [main] " +
                   $"WHERE [ID] = {args[0]}";
            controller.ExecuteCommand(query);

        }


    }
}
