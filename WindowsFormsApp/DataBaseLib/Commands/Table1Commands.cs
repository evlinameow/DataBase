using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table1Commands : ITableEditorCommand
    {
        // ЕСЛИ нужна другая БД, просто меняем AccessDataBaseController
        // на нужную, например SQLiteDataBaseController
        // в следующей строке
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Select(string[] args)
        {

        }

        public void Insert(string[] args)
        {
            string query = $"INSERT INTO [издательство] " +
                    $"([Издательство]) " +
                    $"VALUES ('{args[1]}')";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [издательство]
                    SET [Издательство] = {args[1]};
                    WHERE [ID издательства] = {args[0]}";


            controller.ExecuteCommand(query);
            // дома

            /*
             string query = $"UPDATE [Категории] SET [Категория товара] = '{type}', " +
                    $"[Скидка %] = {discount} " +
                    $"WHERE [ID] = {id}"; 
             */
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [издательство] " +
                   $"WHERE [ID издательства] = {args[0]}";
            controller.ExecuteCommand(query);
            // дома

            /*
             string query = $"DELETE FROM [Категории] " +
                    $"WHERE [ID] = {id}";
             */
        }


    }
}
