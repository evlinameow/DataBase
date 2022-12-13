using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table2Commands : ITableEditorCommand
    {
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Select(string[] args)
        {

        }

        public void Insert(string[] args)
        {
            string query = $"INSERT INTO [клиент] " +
                    $"([ФИО], [Телефон], [email]) " +
                    $"VALUES ('{args[1]}', '{args[2]}', '{args[3]}')";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [клиент]
                    SET [ФИО] = {args[1]}, [Телефон] = {args[2]}, [email] = {args[3]};
                    WHERE [ID клиента] = {args[0]}";
            controller.ExecuteCommand(query);
            /*
             string query = $"UPDATE [Категории] SET [Категория товара] = '{type}', " +
                    $"[Скидка %] = {discount} " +
                    $"WHERE [ID] = {id}"; 
             */
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [клиент] " +
                   $"WHERE [ID клиента] = {args[0]}";
            controller.ExecuteCommand(query);
            // дома

            /*
             string query = $"DELETE FROM [Категории] " +
                    $"WHERE [ID] = {id}";
             */
        }


    }
}
