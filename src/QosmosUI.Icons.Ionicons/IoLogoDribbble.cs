// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons;

public class IoLogoDribbble : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 512 512";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M256,32C132.33,32,32,132.33,32,256S132.33,480,256,480,480,379.78,480,256,379.67,32,256,32ZM398.22,135.25a186.36,186.36,0,0,1,44,108.38c-40.37-2.1-88.67-2.1-127.4,1.52-4.9-12.37-9.92-24.5-15.4-36.17C344.08,189.62,378.5,164.18,398.22,135.25ZM256,69.33a185.81,185.81,0,0,1,119.12,42.94c-20.3,25.66-52.15,48-91.82,64.86C261.6,137,236.63,102.47,210,75.28A187.51,187.51,0,0,1,256,69.33ZM171.53,89.75c26.95,26.83,52.27,61,74.44,101C203.85,203.62,155.55,211,104,211c-9.8,0-19.36-.35-28.81-.94A186.78,186.78,0,0,1,171.53,89.75ZM69.68,247.13c10.62.47,21.35.7,32.2.59,58.8-.7,113.52-9.92,160.54-25q6.65,13.83,12.6,28.35a115.43,115.43,0,0,0-16.69,5C194.05,283.07,143.42,326.58,116,379.2A186,186,0,0,1,69.33,256C69.33,253,69.45,250.05,69.68,247.13ZM256,442.67a185.57,185.57,0,0,1-114.45-39.32c24.85-49.23,69.18-90,125.07-115.27,5.25-2.45,12.25-4.43,20.3-6.18q10,27.64,17.85,57.4A678,678,0,0,1,322,430.42,185.06,185.06,0,0,1,256,442.67Zm100.92-29.75a672.61,672.61,0,0,0-17.39-92.05c-4-15.17-8.51-29.87-13.41-44.22,36.63-3,80.5-2.57,115.38,0A186.5,186.5,0,0,1,356.92,412.92Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
