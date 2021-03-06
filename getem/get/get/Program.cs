﻿using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace getemail
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string line = "";
                Regex pattern = new Regex(@"(.+)(@+)(gmail+)(\.+)(com)");
                StreamReader sr = new StreamReader(args[0]);// doc file
                StreamWriter sw = new StreamWriter("result.txt");// luu file

                List<string> result = new List<string>();
                while (line != null)
                {
                    result.Add(line);
                    line = sr.ReadLine();
                }
                foreach (var item in result)
                {
                    Match match = pattern.Match(item);
                    if (match.Success)
                        sw.WriteLine(match);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }
    }
}