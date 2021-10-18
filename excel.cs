using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Text.Encodings;



namespace Ecommercetestcase
{
    class excel
    {

        public static DataTable ExcelToDataTable(string fileName)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            //open file and returns as Stream
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            //Createopenxmlreader via ExcelReaderFactory
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream); //.xlsx

            var result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });

            //Return as DataSet
            DataSet result1 = excelReader.AsDataSet();
            //Get all the Tables
            DataTableCollection table = result1.Tables;
            //Store it in DataTable
            DataTable resultTable = table["Sheet1"];

            //return
            return resultTable;
        }
       static List<Datacollection> dataCol = new List<Datacollection>();

        public static void PopulateInCollection(string fileName)
        {
            DataTable table = ExcelToDataTable(fileName);

            //Iterate through the rows and columns of the Table
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col <= table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()
                    };
                    //Add all the details for each row
                    dataCol.Add(dtTable);
                }
            }
        }

        public static string ReadData(int rowNumber, string columnName)
        {
            try

            {
               // IWebElement SecondImg = driver.driver1.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div[1]/ul[1]/li[1]/div/div[1]/div/a[1]/img"));
               // Thread.Sleep(1000);
              //  IWebElement MoreBtn = driver.driver1.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div[1]/ul[1]/li[1]/div/div[2]/div[2]/a[1]"));
              //  Actions actions = new Actions(driver.driver1);
               // actions.MoveToElement(SecondImg).MoveToElement(MoreBtn).Click().Perform();
               // driver.driver1.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[1]/a")).Click();

                //Retriving Data using LINQ to reduce much of iterations
                string data = (from colData in dataCol
                               where colData.colName == columnName && colData.rowNumber == rowNumber
                               select colData.colValue).SingleOrDefault();

                //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }
            catch (Exception e)
            {
                return null;
            }
        }



    }

    public class Datacollection
    {
        public int rowNumber { get; set; }
        public string colName { get; set; }
        public string colValue { get; set; }
    }

}

