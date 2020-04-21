using System;

namespace SlavaGu.ConsoleAppLauncher
{
    public class ConsoleOutputEventArgs : EventArgs
    {
        #region Public Constructors

        public ConsoleOutputEventArgs(string line, bool isError)
        {
            Line = line;
            IsError = isError;
        }

        #endregion Public Constructors

        #region Public Properties

        public bool IsError { get; private set; }
        public string Line { get; private set; }

        #endregion Public Properties
    }
}