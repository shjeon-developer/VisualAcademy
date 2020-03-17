using Microsoft.AspNetCore.Components;
using System;

namespace VisualAcademy.Pages
{
    public partial class About : ComponentBase
    {
        private string Title = "정보";

        private string SubTitle = "사이트 정보";

        protected override void OnInitialized()
        {
            SubTitle = DateTime.Now.ToShortTimeString();
        }
    }
}
