using System;

namespace PadamBookStore.Models.ViewModels.ErrorViewModelSS
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
