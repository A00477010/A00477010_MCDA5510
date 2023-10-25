using System;
using CsvHelper;
using System.IO;
using CsvHelper.Configuration;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
namespace ProgAssign1

{
    class Program
    {
        private static int skipped = 0;
        private static int valid = 0;
        private static List<csvData> validRecords = new List<csvData>();
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();
            Logger log = new Logger("C:\\Users\\adity\\Desktop\\SDEV\\Assignment1\\A00477010_MCDA5510\\ProgAssign1", "logs.txt");
            string outputCsv = "C:\\Users\\adity\\Desktop\\SDEV\\Assignment1\\A00477010_MCDA5510\\ProgAssign1\\Output.csv";
            Console.WriteLine("Hello world this is a new console app for assignment 1 ");
            string rootFolder = "C:\\Users\\adity\\Desktop\\SDEV\\MCDA5510_Assignments\\Sample Data";
            string[] csvFiles = Directory.GetFiles(rootFolder, "*.csv", SearchOption.AllDirectories);
            log.Log("Process started");
            writeHeaders(outputCsv);



            List<csvData> inValidRecords = new List<csvData>();

            stopwatch.Start();
            foreach (string csvFile in csvFiles)
            {
                parseCsv(csvFile, log);


            }
            Console.WriteLine("valid " + valid + " skipped " + skipped);
            writeDataToCSV(outputCsv, validRecords, log);
            stopwatch.Stop();
            log.Log("Valid rows found and updated -> " + valid);
            log.Log("Invalid rows found ->" + skipped);
            log.Log("Elapsed time for execution " + stopwatch.ElapsedMilliseconds + " ms");
        }

        static void parseCsv(string csvPath, Logger log)
        {


            using (var reader = new StreamReader(csvPath))
                try
                {


                    using (var csvReader = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        HasHeaderRecord = false,
                        MissingFieldFound = null,


                    }))
                    {
                        var data = csvReader.GetRecords<csvData>();
                        foreach (var record in data)
                        {

                            if (IsValid(record))
                            {

                                record.Date = getDate(csvPath);
                                validRecords.Add(record);
                                valid++;



                            }
                            else
                            {
                                skipped++;


                            }


                        }

                    }
                }
                catch (IOException e)
                {
                    Console.Write($"Error in handling the file :{e.Message}");
                    log.Log($"Error in handling the file :{e.Message}");
                }
        }






        static bool IsValid(csvData record)
        {

            if (string.IsNullOrWhiteSpace(record.FirstName))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(record.LastName))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(record.Street))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(record.Province))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(record.City))
            {
                return false;
            }
            string emailRegexPattern = @"^[\w\.-]+@[\w\.-]+\.\w+$";

            if (!Regex.IsMatch(record.EmailAddress, emailRegexPattern))
            {
                return false;

            }

            string postalCodePattern = @"^[A-Z]\d[A-Z] \d[A-Z]\d$";
            if (!Regex.IsMatch(record.PostalCode, postalCodePattern))
            {
                return false;

            }
            return true;




        }
        static void writeDataToCSV(String outputCsv, List<csvData> validRecord, Logger log)
        {
            using (var write = new StreamWriter(outputCsv, true))
                try
                {


                    using (var csvWriter = new CsvWriter(write, new CsvConfiguration(CultureInfo.InvariantCulture)))
                    {
                        csvWriter.WriteRecords(validRecord);

                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine($"Error in writting output to csv file :{e.Message}");
                    log.Log($"Error in writting output to csv file :{e.Message}");


                }
        }

        static void writeHeaders(string outputCSV)
        {
            Console.WriteLine("Called the write method");
            using (var write = new StreamWriter(outputCSV, true))
            using (var csvWriter = new CsvWriter(write, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csvWriter.WriteField("First Name");
                csvWriter.WriteField("Last Name");
                csvWriter.WriteField("Street Number");
                csvWriter.WriteField("Street");
                csvWriter.WriteField("City");
                csvWriter.WriteField("Province");
                csvWriter.WriteField("Postal Code");
                csvWriter.WriteField("Country");
                csvWriter.WriteField("Phone Number");
                csvWriter.WriteField("Email Address");
                csvWriter.WriteField("Date");
                csvWriter.NextRecord();

            }


        }
        static string getDate(string csvPath)
        {
            string regexForDate = @"\b\d{4}\\\d{1,2}\\\d{1,2}\b";
            Regex regex = new Regex(regexForDate);
            Match match = regex.Match(csvPath);
            string date = match.Value.Replace("\\", "/");
            return date;


        }

    }

}