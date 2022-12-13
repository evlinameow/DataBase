using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table4Commands : ITableEditorCommand
    {
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Select(string[] args)
        {

        }

        public void Insert(string[] args)
        {
            string query = $"INSERT INTO [book] " +
                    $"([Название книги], [Автор], [Описание], [ID жанра], [ID издательства]) " +
                    $"VALUES ('{args[1]}', '{args[2]}', '{args[3]}', {args[4]}, {args[5]})";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [book]
                    SET [Название книги] = {args[1]}, [Автор] = {args[2]}, [Описание] = {args[3]}, [ID жанра] = {args[4]}, [ID издательства] = {args[5]};
                    WHERE [ID клиента] = {args[0]}";
            controller.ExecuteCommand(query);
            
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [book] " +
                   $"WHERE [ID книги] = {args[0]}";
            controller.ExecuteCommand(query);
            
        }


    }
}
