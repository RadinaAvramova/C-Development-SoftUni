﻿namespace BoatRacingSimulator.UI
{
    using System.IO;
    using BoatRacingSimulator.Interfaces;

    public class FileUserInterface : IUserInterface
    {
        public FileUserInterface(string input, string output)
        {
            this.Reader = new StreamReader(File.Open(input, FileMode.Open));
            this.Writer = new StreamWriter(File.Create(output));
        }

        public StreamReader Reader { get; private set; }

        public StreamWriter Writer { get; private set; }

        public string ReadLine()
        {
            return this.Reader.ReadLine();
        }

        public void WriteLine(string message)
        {
            this.Writer.WriteLine(message);
        }

        public void Close()
        {
            this.Writer.Close();
            this.Reader.Close();
        }
    }
}
