namespace WeaponShop.Models.Response;

public class ApiResponse
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    public object Data { get; set; }


    public static ApiResponse SuccessWithData(object data)
    {
        return new ApiResponse
        {
            IsSuccess = true,
            Message = "Success",
            Data = data
        };
    }
}