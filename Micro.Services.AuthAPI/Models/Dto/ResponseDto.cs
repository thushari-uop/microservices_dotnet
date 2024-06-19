namespace Micro.Services.CouponAPI.Models.Dto;

    //for return the all api as a result
    public class ResponseDto
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "";

    }

