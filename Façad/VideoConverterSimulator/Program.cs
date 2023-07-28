using src;

class Program
{
    static void Main(string[] args)
    {
        VideoConverterFacade videoConverterFacade = new VideoConverterFacade();

        string videoFile = "example.mp4";
        string targetFormat = "avi";
        int bitrate = 2000; // kbps

        videoConverterFacade.ConvertVideo(videoFile, targetFormat, bitrate);
    }
}