using Microsoft.AspNetCore.Mvc.Rendering;

namespace Weather.ViewModel
{
    public class CityViewModel
    {
        public List<SelectListItem> CityList { get; } = new List<SelectListItem>
        {
           new SelectListItem { Text = "請選擇", Value=""},
           new SelectListItem { Text = "花蓮縣", Value = "花蓮縣" },
           new SelectListItem { Text = "臺東縣", Value = "臺東縣" },
           new SelectListItem { Text = "澎湖縣", Value = "澎湖縣" },
           new SelectListItem { Text = "金門縣", Value = "金門縣" },
           new SelectListItem { Text = "連江縣", Value = "連江縣" },
           new SelectListItem { Text = "臺北市", Value = "臺北市" },
           new SelectListItem { Text = "新北市", Value = "新北市" },
           new SelectListItem { Text = "桃園市", Value = "桃園市" },
           new SelectListItem { Text = "臺中市", Value = "臺中市" },
           new SelectListItem { Text = "臺南市", Value = "臺南市" },
           new SelectListItem { Text = "高雄市", Value = "高雄市" },
           new SelectListItem { Text = "基隆市", Value = "基隆市" },
           new SelectListItem { Text = "新竹縣", Value = "新竹縣" },
           new SelectListItem { Text = "新竹市", Value = "新竹市" },
           new SelectListItem { Text = "苗栗縣", Value = "苗栗縣" },
           new SelectListItem { Text = "彰化縣", Value = "彰化縣" },
           new SelectListItem { Text = "南投縣", Value = "南投縣" },
           new SelectListItem { Text = "雲林縣", Value = "雲林縣" },
           new SelectListItem { Text = "嘉義縣", Value = "嘉義縣" },
           new SelectListItem { Text = "嘉義市", Value = "嘉義市" },
           new SelectListItem { Text = "屏東縣", Value = "屏東縣" },
        };
    }
}
