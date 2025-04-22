using System;
using wms_android.Interfaces;

namespace wms_android.Utils
{
    /// <summary>
    /// Mock implementation of PosApiHelper to replace Com.Ctk.Sdk.PosApiHelper.
    /// This is a temporary solution to allow the project to build without the actual SDK.
    /// </summary>
    public class PosApiHelper : IPosApiHelper
    {
        private static PosApiHelper _instance;
        public static PosApiHelper Instance => _instance ??= new PosApiHelper();

        public int PrintInit(int gray, int density, int mode, int otherOptions)
        {
            Console.WriteLine("MockPosApiHelper: PrintInit called");
            return 0; // Success
        }

        public int PrintSetAlign(int align)
        {
            Console.WriteLine($"MockPosApiHelper: PrintSetAlign called with align={align}");
            return 0;
        }

        public int PrintSetFont(sbyte width, sbyte height, sbyte style)
        {
            Console.WriteLine($"MockPosApiHelper: PrintSetFont called with width={width}, height={height}, style={style}");
            return 0;
        }

        public int PrintStr(string text)
        {
            Console.WriteLine($"MockPosApiHelper: PrintStr called with text={text}");
            return 0;
        }

        public int PrintQrCode_Cut(string content, int width, int height, string format)
        {
            Console.WriteLine($"MockPosApiHelper: PrintQrCode_Cut called with content={content}, width={width}, height={height}, format={format}");
            return 0;
        }

        public int PrintFeedPaper(int lines)
        {
            Console.WriteLine($"MockPosApiHelper: PrintFeedPaper called with lines={lines}");
            return 0;
        }

        public int PrintStart()
        {
            Console.WriteLine("MockPosApiHelper: PrintStart called");
            return 0;
        }
        
        /// <summary>
        /// Checks if paper is loaded and ready for printing
        /// </summary>
        /// <returns>True if paper is ready, false otherwise</returns>
        public bool IsPaperReady()
        {
            Console.WriteLine("MockPosApiHelper: IsPaperReady called");
            return true; // Always return true in mock implementation
        }
        
        /// <summary>
        /// Gets a human-readable status message about the printer
        /// </summary>
        /// <returns>Status message</returns>
        public string GetStatusMessage()
        {
            Console.WriteLine("MockPosApiHelper: GetStatusMessage called");
            return "Mock printer ready"; // Return a default message
        }
    }
} 