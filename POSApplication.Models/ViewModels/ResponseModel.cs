namespace POSApplication.Models.ViewModels;

public class ResponseModel
{
    public int Code { get; set; }
    public string Message { get; set; } = null!;
    public dynamic Data { get; set; } = null!;
}
