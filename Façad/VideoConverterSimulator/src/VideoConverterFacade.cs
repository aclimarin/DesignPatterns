namespace src;

public class VideoConverterFacade
{
    private VideoCodec videoCodec;
    private AudioCodec audioCodec;
    private FormatConverter formatConverter;
    private BitrateController bitrateController;

    public VideoConverterFacade()
    {
        videoCodec = new VideoCodec();
        audioCodec = new AudioCodec();
        formatConverter = new FormatConverter();
        bitrateController = new BitrateController();
    }

    public void ConvertVideo(string videoFile, string targetFormat, int bitrate)
    {
        videoCodec.CodecSpecificOperation(videoFile);
        audioCodec.CodecSpecificOperation(videoFile);
        formatConverter.ConvertFormat(videoFile, targetFormat);
        bitrateController.AdjustBitrate(videoFile, bitrate);
        Console.WriteLine($"Video conversion completed for '{videoFile}'!");
    }
}