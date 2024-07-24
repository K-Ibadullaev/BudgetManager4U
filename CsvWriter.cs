﻿using System.Collections.Generic;   
using System.IO;                    
using BudgetManager4U.Models;       

public static class CsvWriter
{

    /// <summary>
    ///  method to formate and write transactions into a CSV file
    /// </summary>
    /// <param name="transactions">List of TransactionClass instanses</param>
    /// <param name="filePath">string variable, containing path to the directory </param>
    /// <returns> void </returns>

    public static void WriteTransactionsToCsv(List<TransactionClass> transactions, string filePath)
    {
        using (var writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Date,Description,TransactionAmount");     

            foreach (var transaction in transactions)
            {
                
                writer.WriteLine($"{transaction.Datum:d},{transaction.Description},{transaction.TransactionAmount}"); 
            }
        }
    }
}


