using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMessageSizeBug
{
    public class MainViewModel
    {
        private readonly IJSRuntime _jsRuntime;

        public List<string> Data { get; set; } = new List<string>();

        public MainViewModel(IJSRuntime jSRuntime)
        {
            _jsRuntime = jSRuntime;
            
        }

        public async Task LoadDataAsync(int itemCount)
        {
            Data = await _jsRuntime.InvokeAsync<List<string>>("getData", itemCount);
        }
    }
}
