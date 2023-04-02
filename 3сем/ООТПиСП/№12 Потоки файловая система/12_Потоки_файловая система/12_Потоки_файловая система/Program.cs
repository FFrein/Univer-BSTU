using System;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Text;
using System.Reflection;
using System.Collections.Specialized;
using System.Diagnostics.Metrics;
using System.IO.Compression;
using System.Data.SqlTypes;

namespace LW12
{
    public class PNALog
    {
        FileStream? fstream = null;
        string FileName = "PNAlogfile.txt";
        public PNALog()
        {
            try
            {
                fstream = new FileStream("PNAlogfile.txt", FileMode.OpenOrCreate);
                // операции с fstream
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fstream?.Close();
            }
        }
        public async void FileInput(string input)
        {
            string str ="\nDate: " + DateTime.Now + "\n";
            str += "Path: " + Path.GetFullPath(FileName) + "\n";
            str += "File Name: " + FileName + "\n";
            str += input + "\nLog End\n";
            using (fstream = new FileStream(FileName, FileMode.Append))
            {
                // преобразуем строку в байты
                byte[] buffer = Encoding.Default.GetBytes(str);
                // запись массива байтов в файл
                await fstream.WriteAsync(buffer, 0, buffer.Length);
            }
        }
        public async void ReadFile()
        {
            using (fstream = File.OpenRead(FileName))
            {
                // выделяем массив для считывания данных из файла
                byte[] buffer = new byte[fstream.Length];
                // считываем данные
                await fstream.ReadAsync(buffer, 0, buffer.Length);
                // декодируем байты в строку
                string textFromFile = Encoding.Default.GetString(buffer);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }
        }
        public async void FindInfo(string substr, bool delet = false)
        {
            using (fstream = File.OpenRead(FileName))
            {
                // выделяем массив для считывания данных из файла
                byte[] buffer = new byte[fstream.Length];
                // считываем данные
                await fstream.ReadAsync(buffer, 0, buffer.Length);
                // декодируем байты в строку
                string textFromFile = Encoding.Default.GetString(buffer);
                string[] lines = textFromFile.Split(new char[] { '\n' });

                bool checker = false;
                int counter = 0;
                for (int i = 0; i < lines.Length; i++)
                {
                    if(lines[i].IndexOf("Log End") < 0 & checker == true)
                    {
                        Console.WriteLine(lines[i]);
                        continue;
                    }
                    else
                    {
                        checker = false;
                        if (delet == true)
                            lines[i] = null;
                    }
                    if (lines[i].IndexOf(substr) >= 0)
                    {
                        checker = true;
                        counter++;
                        Console.WriteLine(lines[i]);
                    }
                }
                
            }
        }
    }
    public class PNADiskInfo
    {
        DriveInfo[] allDrives = null;
        public PNADiskInfo()
        {
            allDrives = DriveInfo.GetDrives();
        }
        public string DiskInfo()
        {
            string str = "";
            foreach (DriveInfo d in allDrives)
            {
                str += "\nDisk Name: " + d.Name +
                    "\nDrive type: " + d.DriveType +
                    "\nVolume label: " + d.VolumeLabel +
                    "\nFile system: " + d.DriveFormat +
                    "\nAvailable space to current user: " + d.AvailableFreeSpace + " byte" +
                    "\nTotal available space: " + d.TotalFreeSpace + " byte" +
                    "\nTotal size of drive: " + d.TotalSize + " byte";
            }

            return str;
        }
    }
    public class PNAFileInfo
    {
        public string Adress(string FileName)
        {
            return "\n\n" + Path.GetFullPath(FileName);
        }
        public string FileInfo(string FileName)
        {
            FileInfo fileInf = new FileInfo(FileName);
            return
                "\nFile Name: " + FileName + "\n" +
                "File Lenght: " + fileInf.Length + "\n" +
                "File Extension: " + fileInf.Extension + "\n";
        }
        public string FileDate(string FileName)
        {
            FileInfo fileInf = new FileInfo(FileName);
            return
                "\nCreate Time: " + fileInf.CreationTime + "\n" +
                "Edit Time: " + fileInf.LastWriteTime + "\n";
        }
    }
    public class PNADirInfo
    {
        string dirName;
        string[] FileMassive;
        public PNADirInfo(string input)
        {
            dirName = input;
        }
        public string Amount()
        {
            int counter = 0;
            if (Directory.Exists(dirName))
            {
                FileMassive = Directory.GetFiles(dirName);
                foreach (var elem in FileMassive)
                {
                    Console.WriteLine("File: " + elem);
                    counter++;
                }
                return "\nFile Amount: " + counter.ToString() + "\n";
            }
            return Directory.Exists(dirName).ToString();
        }
        public string CreateTime()
        {
            string result = "\n";
            if (Directory.Exists(dirName))
            {
                FileMassive = Directory.GetFiles(dirName);
                foreach (var elem in FileMassive)
                {
                    FileInfo fileInf = new FileInfo(elem);
                    result += "\nFile Name: " + fileInf.Name +
                        "\nCreate Time: " + fileInf.CreationTime;
                }


                return result + "\n";
            }
            return Directory.Exists(dirName).ToString();
        }
        //subdirectories
        public string FileSubdir()
        {
            string result = "\n";
            if (Directory.Exists(dirName))
            {
                FileMassive = Directory.GetDirectories(dirName);
                foreach (var elem in FileMassive)
                {
                    result += "\nFolder Name: " + elem;
                }
                return result + "\n";
            }
            return Directory.Exists(dirName).ToString();
        }
        public string ParentDir()
        {
            if (Directory.Exists(dirName))
            {
                return "\n" + dirName;
                //return "\n" + Directory.GetCurrentDirectory(dirName).ToString();
            }
            return Directory.Exists(dirName).ToString();
        }
    }
    public class PNAFileManager
    {
        string catalog;
        public PNAFileManager(string input)
        {
            catalog = input;
        }
        public async void FileControll(string dirName)
        {
            string[] FileMassive;
            string result = "\n";
            if (Directory.Exists(dirName))
            {
                FileMassive = Directory.GetFiles(dirName);
                foreach (var elem in FileMassive)
                {
                    result += "\nFile: " + elem;
                }
                FileMassive = Directory.GetDirectories(dirName);
                foreach (var elem in FileMassive)
                {
                    result += "\nFolder Name: " + elem;
                }
                result += "\n";
            }

            string path = dirName + "\\PNAInspect";

            Directory.CreateDirectory(path);

            using (FileStream? fstream = new FileStream(path + "\\PNAdirinfo.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
                byte[] buffer = Encoding.Default.GetBytes(result);
                // запись массива байтов в файл
                await fstream.WriteAsync(buffer, 0, buffer.Length);
            }

            using (FileStream? fstream = File.OpenRead(path + "\\PNAdirinfo.txt"))
            {
                // выделяем массив для считывания данных из файла
                byte[] buffer = new byte[fstream.Length];
                // считываем данные
                await fstream.ReadAsync(buffer, 0, buffer.Length);
                // декодируем байты в строку
                string textFromFile = Encoding.Default.GetString(buffer);
                Console.WriteLine($"Текст из файла: {textFromFile}");
            }

            FileInfo fileInf = new FileInfo(path + "\\PNAdirinfo.txt");
            try
            {
                fileInf.CopyTo(path + "\\PNAdirinfo2.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nPNAFileManager Ошибка " + ex.Message);
            }
                
            fileInf.Delete();
        }

        public void CopyToFolder(string frompath, string topath, string format)
        {
            string fp = frompath + "\\PNAFilesCopyed\\";
            string tp = topath + "PNAFilesMoved";
            try
            {
                Directory.CreateDirectory(fp);

                if (Directory.Exists(frompath))
                {
                    foreach (var elem in Directory.GetFiles(frompath))
                    {
                        FileInfo FI = new FileInfo(elem);
                        if (FI.Extension == format)
                            try
                            {
                                FI.CopyTo(fp + FI.Name);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("\nCopyToFolder CopyTo Ошибка " + ex.Message);
                            }

                    }
                    Directory.Move(fp, tp); //что то не так
                }
            }    
            catch(Exception ex)
            {
                Console.WriteLine("\nCopyToFolder Ошибка " + ex.Message);
            }
        }
        public async void Raring(string sourceFolder, string zipFile, string targetFolder)
        {
            Directory.CreateDirectory(targetFolder);
            try
            {
                ZipFile.CreateFromDirectory(sourceFolder, zipFile);
                Console.WriteLine($"Папка {sourceFolder} архивирована в файл {zipFile}");
                ZipFile.ExtractToDirectory(zipFile, targetFolder);
            }
            catch(Exception ex)
            {
                Console.WriteLine("\nRaring Ошибка " + ex.Message);
            }
        }
    }
    public static class main
    {
        static void Main()
        {
            string fn = "PNAlogfile.txt";
            PNALog Log = new PNALog();
            PNADiskInfo DF = new PNADiskInfo();
            PNAFileInfo FI = new PNAFileInfo();
            PNADirInfo DI = new PNADirInfo("C:\\MyFile\\Универ\\3сем\\ООТПиСП\\№12 Потоки файловая система\\12_Потоки_файловая система\\12_Потоки_файловая система\\bin\\Debug\\net6.0");
            Log.FileInput(
                DF.DiskInfo() + FI.Adress(fn) + 
                FI.FileInfo(fn) + FI.FileDate(fn) +
                DI.Amount() + DI.CreateTime() +
                DI.FileSubdir() + DI.ParentDir()
                );
            PNAFileManager FM = new PNAFileManager("C:\\MyFile\\Универ\\3сем\\ООТПиСП\\№12 Потоки файловая система\\12_Потоки_файловая система\\12_Потоки_файловая система\\bin\\Debug\\net6.0");
            FM.FileControll("C:\\MyFile\\Универ\\3сем\\ООТПиСП\\№12 Потоки файловая система\\12_Потоки_файловая система\\12_Потоки_файловая система\\bin\\Debug\\net6.0");

            string path1 = "C:\\MyFile\\Универ\\3сем\\ООТПиСП\\№12 Потоки файловая система\\12_Потоки_файловая система\\12_Потоки_файловая система\\bin\\Debug\\net6.0";
            string path2 = "C:\\MyFile\\Универ\\3сем\\ООТПиСП\\№12 Потоки файловая система\\12_Потоки_файловая система\\12_Потоки_файловая система\\bin\\Debug\\net6.0\\PNAInspect\\";
            
            FM.CopyToFolder(path1, path2, ".txt");

            Log.FindInfo("Date: 14.11.2022 12:08:12");

            FM.Raring("PNAInspect", "PNA.zip", "UnraringFiles");
        }
    }
}
