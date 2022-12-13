﻿using DataBaseLib.Access;
using DataBaseLib.Commands;
using System.Data;

namespace DataBaseLib;

/// <summary>
/// Выполнение команд пользователя
/// </summary>
public class DataBaseCommadsManager
{


    public DataTable GetDataTable(string tableName)
    {
        BaseCommands command = new BaseCommands();
        return command.GetDataTable(tableName);
    }

    public void Insert(string[] args, string tableName)
    {
        ITableEditorCommand command;
        switch (tableName)
        {
            case "издательство":
                command = new Table1Commands();
                break;
            case "клиент":
                command = new Table2Commands();
                break;
            case "жанр":
                command = new Table3Commands();
                break;
            case "book":
                command = new Table4Commands();
                break;
            case "main":
                command = new Table5Commands();
                break;
            default: throw new Exception("Ошибка!");
        }
        command.Insert(args);
    }
    public void Delete(string[] args, string tableName)
    {
        ITableEditorCommand command;
        switch (tableName)
        {
            case "издательство":
                command = new Table1Commands();
                break;
            case "клиент":
                command = new Table2Commands();
                break;
            case "жанр":
                command = new Table3Commands();
                break;
            case "book":
                command = new Table4Commands();
                break;
            case "main":
                command = new Table5Commands();
                break;
            default: throw new Exception("Ошибка!");
        }
        command.Delete(args);
    }
    public void Update(string[] args, string tableName)
    {
        ITableEditorCommand command;
        switch (tableName)
        {
            case "издательство":
                command = new Table1Commands();
                break;
            case "клиент":
                command = new Table2Commands();
                break;
            case "жанр":
                command = new Table3Commands();
                break;
            case "book":
                command = new Table4Commands();
                break;
            case "main":
                command = new Table5Commands();
                break;
            default: throw new Exception("Ошибка!");
        }
        command.Update(args);
    }
}
