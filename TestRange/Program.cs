// See https://aka.ms/new-console-template for more information
using ECRAndEFTPOS.Common;
using System.Text;

Console.WriteLine("Hello, World!");

var client = new ECRAndEFTPOSCommonClient(new ECRAndEFTPOSCommonCredentials("", ""), true);

var terminalsResponse = await client.GetTerminalsAsync();

Console.ReadLine();