namespace src;

public class BitrateController
{
    public void AdjustBitrate(string videoFile, int bitrate)
    {
        Console.WriteLine($"Adjusting the bitrate of video file '{videoFile}' to {bitrate} kbps.");
    }
}